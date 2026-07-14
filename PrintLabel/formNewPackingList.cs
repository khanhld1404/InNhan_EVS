using OfficeOpenXml;
using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Shapes;
using ZXing;
using ZXing.Common;
using PrintLabel.clObject;
using Excel = Microsoft.Office.Interop.Excel;

namespace PrintLabel
{
    public partial class formNewPackingList : Form
    {
        int idUser = 0;
        string ChungLoai;
        string DongThung;
        string MaPL;
        string MaPL_excel;
        string UserName;
        string FullName;
        int idPL_OLD;
        string MaPL_OLD;
        int idPL_BSTB;
        string lydo_BSTB;
        string LeaderConfirm_BSTB;
        static int SoLuongScan = 0;

        int MaxPackingList;
        DateTime DateTimeCreatedPL;
        clQuery clquery = new clQuery();

        List<clPackingList> LIST_PACKING = new List<clPackingList>();

        public formNewPackingList(int idUser, string _chungLoai, string _dongThung, string maPL,
            string userName, string fullName, int idPL_old, string maPL_old, string maPL_excel, int _idPL_BSTB, string _lydoBSTB, string _leaderConfirm_BSTB)
        {

            this.idUser = idUser;
            this.ChungLoai = _chungLoai;
            this.DongThung = _dongThung;
            this.MaPL = maPL;
            this.UserName = userName;
            this.FullName = fullName;
            this.idPL_OLD = idPL_old;
            this.MaPL_OLD = maPL_old;
            this.MaPL_excel = maPL_excel;
            this.idPL_BSTB = _idPL_BSTB;
            this.lydo_BSTB = _lydoBSTB;
            this.LeaderConfirm_BSTB = _leaderConfirm_BSTB;

            InitializeComponent();

        }

        public formNewPackingList()
        {
            InitializeComponent();
        }



        private void formNewPackingList_Load(object sender, EventArgs e)
        {
            DateTimeCreatedPL = DateTime.Now;

            txtChungLoai.Text = ChungLoai;
            txtThietBi.Text = DongThung;

            txtMaPackingList.Text = MaPL;
            txtTaiKhoan.Text = UserName;
            txtHoTen.Text = FullName;



            string maxPL = clquery.ReadFile(6);
            MaxPackingList = Convert.ToInt32(maxPL);

            txtScanBarcode.Focus();

            // kiểm tra xem phải trường hợp thay thế PL ko
            if (idPL_OLD > 0)
            {
                lbTitlePackingList.Text = "Tạo Packing List thay thế";
                btnPackingList_OLD.Visible = true;
                btnPackingList_OLD.Text = MaPL_OLD;
            }
            else
            {
                lbTitlePackingList.Text = "Tạo mới Packing List";
                btnPackingList_OLD.Visible = false;

                //nếu là bổ sung thiết bị cho PackingList
                if (idPL_BSTB > 0)
                {
                    lbTitlePackingList.Text = "Bổ sung thiết bị vào Packing List";

                    // Load data từ PL bổ sung (dữ liệu đã có) vào LIST_PACKING
                    using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                    {
                        var dataAdd = (from s in db.tblPackingList_Detail_02
                                       where s.IdPL == idPL_BSTB
                                       select s).ToList();

                        foreach (var item in dataAdd)
                        {
                            LIST_PACKING.Add(new clPackingList(item.WO_No, item.ID_No, item.Item_No, item.Rev_No, (DateTime)item.DateScan, (int)item.Qty, item.ThietBi_Detail, (bool)item.ResultScan, item.ErrorScan,
                                                                item.AdminConfirm, item.LyDoError, item.strFull, (bool)item.ItemNew, item.PL_OLD));
                        }

                    }


                }

            }

            Loaddata();

        }

        private void Loaddata()
        {
            try
            {
                var data = (from s in LIST_PACKING
                            where s.ResultScan == true
                            select s).ToList();

                SoLuongScan = data.Count; // deems so luong thiet bi da cos trong packing list

                lbTotal.Text = SoLuongScan.ToString();
                gvData.AutoGenerateColumns = false;
                gvData.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void insertDataScan()
        {
            try
            {
                string WONo;
                string IDNo;
                string ItemNo;
                string RevNo;

                string[] listQuyCachDongThung = txtThietBi.Text.Trim().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                string[] Chuoi = txtScanBarcode.Text.Split('%');

                //09/04/2026 c Hạnh bão yc, scan được cả WO theo cấu trúc cũ
                // Điều kiện: Chuoi[1] có độ dài > 10 thì sử dụng theo WO cũ

                if (Chuoi[1].ToString().Length > 10)// sử dụng WO cũ
                {
                    WONo = Chuoi[0].ToString();
                    IDNo = Chuoi[1].Substring(0, 8);
                    ItemNo = Chuoi[1].Remove(0, 8); // Xóa 8 chuỗi đầu đi, lấy các ký tự còn lại
                    RevNo = Chuoi[2].ToString();
                }
                else
                {
                    WONo = Chuoi[0].ToString();
                    IDNo = Chuoi[1].ToString();
                    ItemNo = Chuoi[2].ToString();
                    RevNo = Chuoi[3].ToString();
                }

                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {

                    if (SoLuongScan == MaxPackingList)
                    {
                        MessageBox.Show("Số lượng sản phẩm đã vượt quá " + MaxPackingList + ". Bạn không thể tiếp tục Scan Barcode", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // kiểm tra xem wo này đã được scan chưa
                        var check_exists = (from s in LIST_PACKING
                                            where s.WO_No == WONo &&
                                                  s.ID_No == IDNo &&
                                                  s.Item_No == ItemNo &&
                                                  s.ResultScan == true
                                            select s).ToList().Count;
                        if (check_exists > 0)
                        {
                            MessageBox.Show("WO = " + WONo + " đã được Scan Barcode để tạo Packing List. Bạn không thể thêm WO này vào Packing List", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            clPackingList pac = new clPackingList();
                            pac.WO_No = WONo;
                            pac.ID_No = IDNo;
                            pac.Item_No = ItemNo;
                            pac.Rev_No = RevNo;
                            pac.Qty = 1;
                            pac.DateScan = DateTime.Now;
                            pac.ItemNew = false; // Sử dụng để kiểm tra xem có phải thiết bị được bổ sung thêm không. Áp dụng từ 04/26.

                            if (idPL_BSTB > 0) // nếu là TBBS 
                            {
                                pac.ItemNew = true;
                                pac.AdminConfirm = LeaderConfirm_BSTB;
                                pac.LyDoError = lydo_BSTB;

                            }


                            // kiểm tra xem Item scan có thuộc thiết bị đóng thùng ko
                            var ChungLoaiItem = db.pro_PackingList_02_getChungLoai_Item(ItemNo).ToList();
                            string thietbi_Item = ""; // chủng loại của ItemNo
                            if (ChungLoaiItem.Count > 0)
                            {
                                // thietbi_Item = ChungLoaiItem.FirstOrDefault().TenChungLoai;
                                thietbi_Item = ChungLoaiItem.FirstOrDefault();

                                //kiểm tra xem thiết bị Item này có nằm trong quy cách đóng thùng ko
                                var checkItem = listQuyCachDongThung.Where(s => s.Contains(thietbi_Item)).ToList();

                                if (checkItem.Count > 0) // ok
                                {
                                    pac.ThietBi_Detail = thietbi_Item;
                                    pac.ResultScan = true;


                                    // kiểm tra xem item này đã được scan ở Packing list nào chưa, Nếu scan rồi thì phải cảnh báo
                                    var check_itemPL_OLD = (from s in db.tblPackingList_Detail_02
                                                            where s.WO_No == WONo &&
                                                                  s.ID_No == IDNo &&
                                                                  s.Item_No == ItemNo
                                                            orderby s.IdPL descending
                                                            select s).ToList();

                                    if (check_itemPL_OLD.Count > 0)
                                    {
                                        // lấy mã Packing list cũ, chỉ lấy 1 cái mới nhất
                                        int _idPL_OLD = (int)check_itemPL_OLD.FirstOrDefault().IdPL;
                                        var _MaPL_OLD = (from s in db.tblPackingList_02
                                                         where s.idPL == _idPL_OLD
                                                         select s.MaPL).FirstOrDefault();

                                        string maPL_OLD = _MaPL_OLD ?? ""; // nếu _MaPL == null thì trả về giá trị ""

                                        string tb = string.Format("Thiết bị đã được scan cho Packing list khác ({0}). \n BẠN VẪN MUỐN LƯU THÔNG TIN THIẾT BỊ VÀO PAKING LIST NÀY?", maPL_OLD);
                                        if (MessageBox.Show(tb, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                        {
                                            string err = "Đã Scan thiết bị trong PL: " + maPL_OLD + " - XÁC NHẬN LƯU";
                                            formCreatePLConfirmLeader confirm = new formCreatePLConfirmLeader(WONo, IDNo, ItemNo, RevNo, thietbi_Item, txtChungLoai.Text, txtThietBi.Text, err);
                                            if (confirm.ShowDialog() == DialogResult.OK)
                                            {
                                                pac.ResultScan = true;
                                                pac.ErrorScan = err;
                                                pac.AdminConfirm = confirm.userAdmin;
                                                pac.PL_OLD = maPL_OLD;

                                            }
                                        }
                                        else
                                        {
                                            string err = "Đã Scan thiết bị trong PL: " + maPL_OLD + " - XÁC NHẬN KHÔNG LƯU";
                                            formCreatePLConfirmLeader confirm = new formCreatePLConfirmLeader(WONo, IDNo, ItemNo, RevNo, thietbi_Item, txtChungLoai.Text, txtThietBi.Text, err);
                                            if (confirm.ShowDialog() == DialogResult.OK)
                                            {
                                                pac.ResultScan = false;
                                                pac.ErrorScan = err;
                                                pac.AdminConfirm = confirm.userAdmin;
                                                pac.PL_OLD = maPL_OLD;
                                            }
                                        }
                                    }
                                }
                                else // scan nhầm chủng loại
                                {
                                    //MessageBox.Show("Nhầm con mịa chủng loại rồi", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    formCreatePLConfirmLeader confirm = new formCreatePLConfirmLeader(WONo, IDNo, ItemNo, RevNo, thietbi_Item, txtChungLoai.Text, txtThietBi.Text, "Nhầm chủng loại");
                                    if (confirm.ShowDialog() == DialogResult.OK)
                                    {
                                        pac.ResultScan = false;
                                        pac.ErrorScan = "Nhầm chủng loại";
                                        pac.AdminConfirm = confirm.userAdmin;
                                    }
                                }

                            }
                            else // chưa đăng ký master
                            {
                                // MessageBox.Show("Item Code chưa đăng ký master", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                formCreatePLConfirmLeader confirm = new formCreatePLConfirmLeader(WONo, IDNo, ItemNo, RevNo, thietbi_Item, txtChungLoai.Text, txtThietBi.Text, "Chưa đăng ký master");
                                if (confirm.ShowDialog() == DialogResult.OK)
                                {
                                    pac.ResultScan = false;
                                    pac.ErrorScan = "Chưa đăng ký master";
                                    pac.AdminConfirm = confirm.userAdmin;
                                }
                            }

                            pac.strFull = txtScanBarcode.Text;

                            // lưu thông tin
                            LIST_PACKING.Add(pac);


                        }

                    }
                    Loaddata();

                    txtScanBarcode.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Barcode không đúng định dạng, Vui lòng scan Barcode trên Chỉ thị sản xuất (Work Order) | " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtScanBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insertDataScan();
            }


        }

        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Xoa du lieu bang con
                if (e.ColumnIndex == gvData.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ???", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int cu = gvData.CurrentCell.RowIndex;
                        string _woNo = gvData.Rows[cu].Cells["Wo_No"].Value.ToString();
                        string _idNo = gvData.Rows[cu].Cells["ID_No"].Value.ToString();
                        string _itemNo = gvData.Rows[cu].Cells["Item_No"].Value.ToString();


                        var pac = LIST_PACKING.Where(id => id.WO_No == _woNo &&
                                                            id.ID_No == _idNo &&
                                                            id.Item_No == _itemNo).SingleOrDefault();

                        LIST_PACKING.Remove(pac);

                        Loaddata();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        string PrinterName = "";
        private void PrintPackingList(string Filepath)
        {
            try
            {
                #region cách này cũng chậm -> phải điền chính xác tên checksheet

                //Excel.Application xlApp = new Excel.Application();
                //Excel.Workbook wb = xlApp.Workbooks.Open(Filepath);

                //// lấy tên check sheet, truyền index = 0 thì bị lỗi
                //Excel.Worksheet ws1 = wb.Worksheets["JCQ10-AN025-4"];

                //PrintDialog printDialog1 = new PrintDialog();


                //// hiện dialog print

                //DialogResult rs = printDialog1.ShowDialog();
                //if (rs == DialogResult.OK)
                //{

                //    PrinterName = printDialog1.PrinterSettings.PrinterName;
                //    printDialog1.PrinterSettings.PrinterName = PrinterName;
                //    printDialog1.PrinterSettings.Copies = 1;
                //    printDialog1.PrinterSettings.PrintToFile = false;


                //    ws1.PrintOutEx(Type.Missing, // fROM
                //                   Type.Missing, // to
                //                   printDialog1.PrinterSettings.Copies, // Copies
                //                   Type.Missing, // Preview
                //                   printDialog1.PrinterSettings.PrinterName, // PrinterName
                //                   printDialog1.PrinterSettings.PrintToFile, //PrintToFile
                //                   printDialog1.PrinterSettings.Collate, //Collate
                //                   Type.Missing //IgnorePrintAreas
                //                   );



                //}


                //wb.Save();
                //wb.Close();
                //xlApp.Quit();

                #endregion


                #region hàm in cũ, in chậm

                using (PrintDialog Dialog = new PrintDialog())
                {
                    //Dialog.ShowDialog();
                    // In voi may in dat mac dinh
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        //để in được file excel theo chọn máy in, thì phải thay đổi máy in mặc định, VÌ code chỉ in được với máy in được set là default 
                        PrinterName = Dialog.PrinterSettings.PrinterName;
                        myPrinters.SetDefaultPrinter(PrinterName);
                        ////////////////////////////
                        ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                        {
                            Verb = "Print",
                            CreateNoWindow = true,
                            FileName = Filepath,
                            WindowStyle = ProcessWindowStyle.Hidden

                        };

                        Process printProcess = new Process();
                        printProcess.StartInfo = printProcessInfo;
                        printProcess.Start();

                        printProcess.WaitForInputIdle();

                        //Thread.Sleep(3000);

                        //if (false == printProcess.CloseMainWindow())
                        //{
                        //    printProcess.Kill();
                        //}
                    }
                }



                #endregion


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }




        private void XuatPackingList()
        {

            try
            {

                int idPL = 0;
                if (gvData.Rows.Count > 0)
                {
                    string outputDirectory = clquery.ReadFile(10);

                    // lưu thông tin vào db
                    using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                    {

                        //// cập nhật PL old là bị thay thế: ThayThePL = true
                        //if (idPL_OLD > 0)
                        //{
                        //    var upPL = db.tblPackingList_02.Where(id => id.idPL == idPL_OLD).SingleOrDefault();
                        //    upPL.ThayThePL = true;
                        //}


                        if (idPL_BSTB > 0)
                        {
                            idPL = idPL_BSTB;

                            // xóa data  tblPackingList_Detail_02 -> để lưu lại từ LIST_PACKING
                            var data_dele = (from s in db.tblPackingList_Detail_02
                                             where s.IdPL == idPL_BSTB
                                             select s).ToList();
                            db.tblPackingList_Detail_02.RemoveRange(data_dele);
                            db.SaveChanges();

                        }
                        else
                        {
                            // lưu thông tin vào bảng tblPackingList_02
                            idPL = Convert.ToInt32(db.pro_PackingList_06_InsertPL(idUser, UserName, FullName, DateTimeCreatedPL, MaPL, ChungLoai, txtThietBi.Text, MaPL_OLD, idPL_OLD, false).FirstOrDefault().Value);
                        }



                        // lưu thông tin vào bảng tblPackingList_Detail02
                        var dataInsert = LIST_PACKING.Select(item => MaptoEntity(item, idPL)).ToList();
                        db.tblPackingList_Detail_02.AddRange(dataInsert);



                        db.SaveChanges();

                    }



                    string output = clExportExcel.ExportExcel_PackingList(new FileInfo("JCQ10-EVS025-4.xlsx"), idPL, MaPL_excel);







                }
                else
                {
                    MessageBox.Show("Dữ liệu trống, bạn không thể in Packing List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        // hàm mapping từ LIST_PACKING sang tblPackingList_Detail_02
        public tblPackingList_Detail_02 MaptoEntity(clPackingList item, int idPL)
        {
            return new tblPackingList_Detail_02
            {
                IdPL = idPL,
                WO_No = item.WO_No,
                ID_No = item.ID_No,
                Item_No = item.Item_No,
                Rev_No = item.Rev_No,
                DateScan = item.DateScan,
                Qty = item.Qty,
                ThietBi_Detail = item.ThietBi_Detail,
                ResultScan = item.ResultScan,
                ErrorScan = item.ErrorScan,
                AdminConfirm = item.AdminConfirm,
                LyDoError = item.LyDoError,
                PCName = Environment.MachineName,
                strFull = item.strFull,
                ItemNew = item.ItemNew,
                PL_OLD = item.PL_OLD

            };
        }




        private void btnXuatPackingList_Click(object sender, EventArgs e)
        {
            try
            {
                if (SoLuongScan < MaxPackingList)
                {
                    string tb = string.Format("Số lượng trong Packing List chưa đủ {0} thiết bị, Bạn vẫn muốn xuất Packing List? ", MaxPackingList);
                    if (MessageBox.Show(tb, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        backgroundWorker1.RunWorkerAsync();
                        //XuatPackingList();
                    }
                }
                else
                {
                    backgroundWorker1.RunWorkerAsync();
                    //XuatPackingList();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            btnXuatPackingList.Invoke(new Action(() => { btnXuatPackingList.Enabled = false; }));
            btnExit.Invoke(new Action(() => { btnExit.Enabled = false; }));
            picLoading.Invoke(new Action(() => { picLoading.Visible = true; }));
            lbLoading.Invoke(new Action(() => { lbLoading.Visible = true; }));
            XuatPackingList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LIST_PACKING.Clear();
            MessageBox.Show("XUẤT PACKING LIST THÀNH CÔNG !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DỮ LIỆU SẼ KHÔNG ĐƯỢC LƯU KHI BẠN THOÁT CHƯƠNG TRÌNH ! \n Bạn vẫn muốn thoát chương trình? ", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LIST_PACKING.Clear();
                this.Dispose();
                this.Close();
            }
        }

        private void btnPackingList_OLD_Click(object sender, EventArgs e)
        {
            //MasterPackingList.form_DetailPackingList de = new MasterPackingList.form_DetailPackingList(idPL_OLD);
            //de.ShowDialog();
        }
    }
    // Viet class moi o day

    public static class myPrinters
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);

    }
}
