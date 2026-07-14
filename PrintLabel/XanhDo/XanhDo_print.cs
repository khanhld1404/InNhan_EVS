using OfficeOpenXml;
using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;


namespace PrintLabel.XanhDo
{
    public partial class XanhDo_print : Form
    {
        #region khai báo biến
        int _IDUser;
        int _IDHistoryLogin;
        string _FullName;
        string _UserName;
        bool _Admin;

        string strQRCode = "";
        //int intFrom;
        //int intTo;
        string PCName = Environment.MachineName;

        string folder_temp = Application.StartupPath + "\\" + "folder_temp";

        string pathFileSetupXD = Application.StartupPath + "\\SettingXanhDo.ini";
        string AdminConfirm = "";
        string LyDoInLai = "";

        bool LeaderSX = false;

        clQuery cl = new clQuery();
        #endregion



        public XanhDo_print()
        {
            InitializeComponent();
        }

        public XanhDo_print(int IDUser, int IDHistoryLogin, string FullName, string UserName, bool Admin)
        {
            _IDUser = IDUser;
            _IDHistoryLogin = IDHistoryLogin;
            _FullName = FullName;
            _UserName = UserName;
            _Admin = Admin;
            InitializeComponent();
        }

        private void XanhDo_print_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void XanhDo_print_Load(object sender, EventArgs e)
        {
            menuUserName.Text = string.Format("{0} ({1})", _FullName, _UserName);

            lbDate_lb.Text = DateTime.Now.ToString("dd/MM/yyyy");



            txtScanBarcode.Focus();

            // load lý do - nhãn đỏ
            load_RadioButtonList_Reason();

            pnAll_Reason.Enabled = false;

            LeaderSX = cl.check_Leader_User(_IDUser);

            #region các lb trong nhãn xanh đỏ
            lbWO_lb.Text = string.Empty;
            lbIDNo_lb.Text = string.Empty;
            lbItemNo_lb.Text = string.Empty;
            lbQty_lb.Text = string.Empty;
            lbRev_lb.Text = string.Empty;
            lbComment_lb.Text = string.Empty;


            lbPartNo.Text = IniFile.ReadValue("Template", "PartNo", pathFileSetupXD);

            #endregion

            // load thông số điều chỉnh in mặc định
            btnRefreshDieuChinh_Click(sender, e);

            if (LeaderSX || _Admin)
            {
                btnInNhanTest.Visible = true;
            }





        }

        #region hàm load data Radiobutton list

        private void load_RadioButtonList_Reason()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var data = (from s in db.tblReason_XD
                            where s.ActiveReason == true
                            select s).ToList();
                rdoList_Reason.DataSource = data;
                rdoList_Reason.DisplayMember = "Description";
                rdoList_Reason.ValueMember = "Description";

                // không chọn thằng nào khi mới load
                rdoList_Reason.SetSelected(0, false);
            }
        }

        #endregion

        #region 2 sự kiện click vào rdo_NhanXanh và rdo_NhanDo


        private void rdoNhanXanh_Click(object sender, EventArgs e)
        {
            rdoNhanDo.Checked = false;

            rdoNhanXanh.ForeColor = Color.White;
            rdoNhanDo.ForeColor = Color.Black;


            //if (intFrom > 0)
            //{
            //    pn_ChieuDai.Visible = true;
            //}
            //else
            //{
            //    txtChieuDai.Text = string.Empty;
            //    pn_ChieuDai.Visible = false;
            //}

            txtReason_Other.Text = string.Empty;
            txtChieuDai.Text = "N/A";

            pn_ChieuDai.Enabled = true;


            pn_detail_Reason.Enabled = false;

            lblbHeader.Text = "QC ACCEPTED";
            pnDesignLabel.BackgroundImage = Properties.Resources.label_green_2;

            // tạo barcode
            create_QRCode_22(strQRCode, Color.Green);



        }

        private void rdoNhanDo_Click(object sender, EventArgs e)
        {
            rdoNhanXanh.Checked = false;

            rdoNhanXanh.ForeColor = Color.Black;
            rdoNhanDo.ForeColor = Color.White;

            txtChieuDai.Text = string.Empty;
            pn_ChieuDai.Enabled = false;


            pn_detail_Reason.Enabled = true;

            lblbHeader.Text = "QC REJECTED";
            pnDesignLabel.BackgroundImage = Properties.Resources.label_red_2;

            // tạo barcode
            create_QRCode_22(strQRCode, Color.Red);

        }

        #endregion

        // xóa ItemCode
        private void btnDelete_Scan_Click(object sender, EventArgs e)
        {
            txtScanBarcode.Focus();

            pnAll_Reason.Enabled = false;

            strQRCode = string.Empty;
            picQRCode.Image = null;

            nmQty.Value = 1;

            lblbHeader.Text = "QC ACCEPTED";
            pnDesignLabel.BackgroundImage = Properties.Resources.label_default_2_2_3;

            // refresh các textbox
            foreach (Control ctr in pn_readBarcode.Controls)
            {
                if (ctr is System.Windows.Forms.TextBox)
                {
                    ctr.Text = string.Empty;
                }
            }

            #region các lb trong nhãn xanh đỏ
            lbWO_lb.Text = string.Empty;
            lbIDNo_lb.Text = string.Empty;
            lbItemNo_lb.Text = string.Empty;
            lbQty_lb.Text = string.Empty;
            lbRev_lb.Text = string.Empty;
            lbComment_lb.Text = string.Empty;




            #endregion

            //
            //intFrom = 0;
            //intTo = 0;

            txtChieuDai.Text = string.Empty;
            txtReason_Other.Text = string.Empty;


        }

        #region hàm đọc barcode, tạo QRCode

        /// <summary>
        /// Hàm đọc mã vạch
        /// </summary>
        private void Read_ScanBarcode()
        {
            try
            {

                strQRCode = txtScanBarcode.Text.Trim();

                if (string.IsNullOrEmpty(strQRCode))
                {
                    MessageBox.Show("Vui lòng quét mã vạch tại chỉ thị sản xuất",
                        "Scan Barcode");
                    return;
                }



                string[] Chuoi = txtScanBarcode.Text.Trim().Split('%');
                string _strWO = Chuoi[0].ToString();
                string _strIDNo = Chuoi[1].ToString();
                string _strItemNo = Chuoi[2].ToString();
                string _strRev = Chuoi[3].ToString();

                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    // kiểm tra xem WO đã được in chưa, nếu đã in rồi, muốn in lại cần nhập tk admin
                    var checkPrint = (from s in db.tblHisPrint_XD
                                      where s.WONo == _strWO &&
                                            s.IDNo == _strIDNo &&
                                            s.ItemNo == _strItemNo
                                      select s).ToList().Count;
                    if (checkPrint > 0)
                    {
                        if (MessageBox.Show("WO đã được in nhãn, Bạn có muốn in lại ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            formAdminConfirm ad = new formAdminConfirm();
                            if (ad.ShowDialog() == DialogResult.OK)
                            {
                                AdminConfirm = ad.UserName_Admin;
                                LyDoInLai = ad.LyDoInLai;

                                DOCMAVACH();
                            }
                            else
                            {
                                AdminConfirm = string.Empty;
                                LyDoInLai = string.Empty;
                                btnDelete_Scan_Click(Type.Missing, null);
                            }
                        }
                        else
                        {
                            AdminConfirm = string.Empty;
                            LyDoInLai = string.Empty;
                            btnDelete_Scan_Click(Type.Missing, null);
                        }

                    }
                    else
                    {
                        AdminConfirm = string.Empty;
                        LyDoInLai = string.Empty;

                        DOCMAVACH();
                    }

                    void DOCMAVACH()
                    {
                        // kiểm tra xem Item đã được đăng ký master chưa
                        var dataMaster = (from s in db.tblItemCheck_XD
                                          where s.ItemNo == _strItemNo
                                          select s).ToList();
                        if (dataMaster.Count > 0)
                        {

                            txtWorkOder.Text = _strWO;
                            txtWorkOrderID.Text = _strIDNo;
                            txtItemNo.Text = _strItemNo;
                            txtRev.Text = _strRev;

                            #region các lb trong nhãn xanh đỏ

                            lbWO_lb.Text = _strWO;
                            lbIDNo_lb.Text = _strIDNo;
                            lbItemNo_lb.Text = _strItemNo;
                            lbQty_lb.Text = string.Format(" {0}", nmQty.Value.ToString());

                            if (!string.IsNullOrEmpty(_strRev))
                            {
                                lbRev_lb.Text = string.Format("Rev : {0}", _strRev);

                            }
                            else
                            {
                                lbRev_lb.Text = string.Empty;
                            }


                            //

                            lbComment_lb.Text = string.Empty;


                            #endregion

                            pnAll_Reason.Enabled = true;

                            rdoNhanXanh.Focus();




                        }
                        else
                        {
                            MessageBox.Show("Chủng loại chưa được đăng ký master", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }




                txtScanBarcode.Text = string.Empty;




            }
            catch (Exception ex)
            {

                MessageBox.Show("Mã vạch không đúng định dạng " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #region Hàm tạo mã vạch



        // hàm tạo mã vạch
        private void create_QRCode_22(string strCode, Color backgroundQRCode, bool saveQRCode = false)
        {
            //11/07/25: tạm thời comment lại đoạn code tạo QR cho nhãn xanh đỏ, vì sx chưa dùng đến

            /*
            try
            {
                if (!string.IsNullOrEmpty(strCode))
                {
                    var barcodeWriter = new BarcodeWriter
                    {
                        Format = BarcodeFormat.QR_CODE,
                        Options = new EncodingOptions
                        {

                            Height = 1,
                            Width = 1
                            ,
                            Margin = 0


                            //,PureBarcode = true
                        }
                          ,
                        Renderer = new BitmapRenderer
                        {
                            Background = backgroundQRCode
                            //Foreground = Color.Green  // đổi màu barcode
                        }
                    };

                    using (var bitmap = barcodeWriter.Write(strCode)) //strBarCode
                    {
                        using (var stream = new MemoryStream())
                        {
                            var scaleBitmap = clImageExcel.ScaleImage(bitmap, (int)nmSizeQRCode.Value, (int)nmSizeQRCode.Value); // 55, 55 // điều chỉnh lại size barcode ko có vùng quiet zone

                            scaleBitmap.Save(stream, ImageFormat.Png);

                            var image = Image.FromStream(stream);

                            // lưu ảnh thì ko hiển thị QRcode ra màn hình
                            if (saveQRCode == true)
                            {
                                string path = string.Format("{0}\\{1}.png", folder_temp, strCode);
                                image.Save(path, ImageFormat.Png);
                            }
                            else
                            {
                                picQRCode.Image = image;
                            }
                        }
                    }
                }
                else
                {
                    picQRCode.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            */

        }
        #endregion

        #endregion


        private void txtScanBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Read_ScanBarcode();
            }
        }




        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtItemNo.Text))
                {
                    string GreenPrinter = IniFile.ReadValue("Printer", "Xanh", pathFileSetupXD);
                    string RedPrinter = IniFile.ReadValue("Printer", "Do", pathFileSetupXD);

                    // IN nhãn xanh
                    if (rdoNhanXanh.Checked)
                    {
                        string GreenComment = txtChieuDai.Text.Trim();
                        int lenght_GreenComment = GreenComment.Length;
                        if (!string.IsNullOrEmpty(GreenComment) && lenght_GreenComment < 31) // cho nhập tối đa 30 ký tự thôi
                        {
                            //lbComment_lb.Text = string.Empty;
                            Ham_In_Nhan(GreenPrinter, "GREEN");
                        }
                        else
                        {
                            MessageBox.Show("Ghi chú nhãn xanh tối đa 30 ký tự và không được bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (rdoNhanDo.Checked) // in nhãn đỏ
                    {
                        #region code code cũ, check xem chọn lý do lỗi chưa
                        /*
                        if (rdoList_Reason.SelectedValue != null)
                        {
                            string Reason = rdoList_Reason.SelectedValue.ToString();
                            switch (Reason)
                            {
                                case "Other":
                                    if (!string.IsNullOrEmpty(txtReason_Other.Text))
                                    {
                                        lbComment_lb.Text = txtReason_Other.Text;
                                        Ham_In_Nhan(RedPrinter, "RED");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nhập lý do lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                default:
                                    lbComment_lb.Text = Reason;
                                    Ham_In_Nhan(RedPrinter, "RED");
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập lý do lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        */
                        #endregion

                        string RedComment = txtReason_Other.Text.Trim();
                        int lenght_RedComment = RedComment.Length;
                        if (!string.IsNullOrEmpty(RedComment) && lenght_RedComment < 31)
                        {
                            // in nhãn đỏ, 
                            Ham_In_Nhan(RedPrinter, "RED");
                        }
                        else
                        {
                            MessageBox.Show("Ghi chú nhãn đỏ tối đa 30 ký tự và không được bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Chủng loại không xác định", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            txtScanBarcode.Focus();
        }


        private void Ham_In_Nhan(string printerName, string status, bool luuLichSu = true)
        {
            // lưu QRCode
            create_QRCode_22(strQRCode, Color.Transparent, true);

            //đọc dữ liệu cài đặt từ file setting Ini
            string ini_template = IniFile.ReadValue("Template", "NameFile", pathFileSetupXD);
            string ini_cellWO = IniFile.ReadValue("Template", "CellWO", pathFileSetupXD);
            string ini_cellIDNo = IniFile.ReadValue("Template", "CellIDNo", pathFileSetupXD);
            string ini_cellQty = IniFile.ReadValue("Template", "CellQty", pathFileSetupXD);
            string ini_cellItemNo = IniFile.ReadValue("Template", "CellItemNo", pathFileSetupXD);
            string ini_cellRev = IniFile.ReadValue("Template", "CellRev", pathFileSetupXD);
            string ini_cellComment = IniFile.ReadValue("Template", "CellComment", pathFileSetupXD);
            string ini_cellDate = IniFile.ReadValue("Template", "CellDate", pathFileSetupXD);
            string ini_rowInsertQR = IniFile.ReadValue("Template", "RowInsertQR", pathFileSetupXD);
            string ini_colInsertQR = IniFile.ReadValue("Template", "ColInsertQR", pathFileSetupXD);
            string ini_deleteFile = IniFile.ReadValue("Template", "DeleteFile", pathFileSetupXD);

            FileInfo template = new FileInfo(ini_template); //"tempXanhDo_ZD420_XanhDo.xlsx"

            string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string fileExport = string.Format("{0}\\{1}.xlsx", folder_temp, time); // Ten file export

            using (ExcelPackage p = new ExcelPackage(template, true))
            {
                ExcelWorksheet ws = p.Workbook.Worksheets[0];

                //ĐIều chỉnh độ rộng (cao) của excel -> chỉ độ cao thôi, độ ngang đơn vị khác
                // để tính ra pixcel thì cần nhân với 0.75
                // 0.75 đơn vị của excel = 1 px

                // điều chỉnh chiều cao của dòng đầu tiên
                double marginTop = (0.75 * (int)nmMarginTop_lb.Value);
                ws.Row(1).Height = marginTop;

                // điều chỉnh độ ngang excel
                // 0.08 đơn vị excel = 1 px
                // điều chỉnh chiều ngang của cột đầu tiên
                double marginLeft = (0.08 * (int)nmMarginLeft_lb.Value);
                ws.Column(1).Width = marginLeft;


                //Wo
                ws.Cells[ini_cellWO].Value = txtWorkOder.Text; //F3

                //ID
                ws.Cells[ini_cellIDNo].Value = txtWorkOrderID.Text; // F4

                //Qty
                ws.Cells[ini_cellQty].Value = nmQty.Value.ToString();// string.Format(": {0}", nmQty.Value); // I5

                //ItemNo
                ws.Cells[ini_cellItemNo].Value = txtItemNo.Text; //B7

                //Rev
                if (!string.IsNullOrEmpty(txtRev.Text))
                {
                    ws.Cells[ini_cellRev].Value = string.Format("Rev : {0}", txtRev.Text); //H7
                }
                else
                {
                    ws.Cells[ini_cellRev].Value = ""; //H7
                }

                // comment
                ws.Cells[ini_cellComment].Value = lbComment_lb.Text;//B11

                // ngày tháng
                ws.Cells[ini_cellDate].Value = DateTime.Now.ToString("dd/MM/yyyy"); //H15


                #region 11/07/25: comment lại đoạn code insert ảnh QRcode vào template để in
                /*
                // đường dẫn ảnh
                string pathImage = string.Format("{0}\\{1}.png", folder_temp, strQRCode);

                int rowInserQR = int.Parse(ini_rowInsertQR);
                int colInserQR = int.Parse(ini_colInsertQR);
                clImageExcel.AddImage(ws, rowInserQR, colInserQR, pathImage, "hung"); // dòng 8, cột 7. tính từ 0
                */
                #endregion



                //string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
                //string file = string.Format("{0}\\{1}.xlsx", folder_temp, time); // Ten file export

                //p.SaveAs(new FileInfo(file));
                p.SaveAs(fileExport);





                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook wb = xlApp.Workbooks.Open(fileExport);
                Excel.Worksheet ws1 = wb.Worksheets["Sheet1"];

                PrintDialog printDialog1 = new PrintDialog();


                // hiện dialog print

                //DialogResult rs = printDialog1.ShowDialog();
                //if (rs == DialogResult.OK)
                //{


                printDialog1.PrinterSettings.PrinterName = printerName; //"ZDesigner ZD420-300dpi ZPL";
                printDialog1.PrinterSettings.Copies = 1;
                printDialog1.PrinterSettings.PrintToFile = false;


                ws1.PrintOutEx(Type.Missing, // fROM
                               Type.Missing, // to
                               printDialog1.PrinterSettings.Copies, // Copies
                               Type.Missing, // Preview
                               printDialog1.PrinterSettings.PrinterName, // PrinterName
                               printDialog1.PrinterSettings.PrintToFile, //PrintToFile
                               printDialog1.PrinterSettings.Collate, //Collate
                               Type.Missing //IgnorePrintAreas
                               );



                //}


                wb.Save();
                wb.Close();
                xlApp.Quit();

            }

            // in nhãn test thì ko lưu lịch sử
            if (luuLichSu)
            {
                // lưu lịch sử in
                Save_HisPrint(status);
            }
        



            ////// xóa file excel 
            if (ini_deleteFile == "True")
            {
                //// xóa file barcode (ảnh .png)
                try
                {
                    string file_QRCode = string.Format("{0}\\{1}.png", folder_temp, strQRCode);
                    if (File.Exists(file_QRCode))
                    {
                        File.Delete(file_QRCode);
                    }
                }
                catch { }


                try
                {
                    if (File.Exists(fileExport))
                    {
                        File.Delete(fileExport);
                    }
                }
                catch { }




            }

            #region refresh sau khi in xong

            btnDelete_Scan_Click(Type.Missing, null);

            #endregion


        }


        // hàm lưu lịch sử in nhãn
        private void Save_HisPrint(string status)
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                tblHisPrint_XD his = new tblHisPrint_XD();
                his.WONo = txtWorkOder.Text;
                his.IDNo = txtWorkOrderID.Text;
                his.ItemNo = txtItemNo.Text;
                his.RevNo = txtRev.Text;
                his.DatePrint = DateTime.Now;
                his.Status = status;
                his.Reason = lbComment_lb.Text.Trim();
                his.UserPrint = _UserName;
                his.AdminConfirm = AdminConfirm;
                his.PCName = PCName;
                his.TimesPrint = (int)nmQty.Value;
                his.IDUser = _IDUser;
                his.LyDoInLai = LyDoInLai;
                his.strFull = strQRCode;
                // thời gian Admin confirm chính là thời gian in nhãn

                db.tblHisPrint_XD.Add(his);
                db.SaveChanges();


            }
        }

        #region các hàm thay đổi size QRCode, lựa chọn lý do, textChanged txtReason_Other, textChanged txtChieuDai
        //Thay đổi size barcode thì hiển thị nhãn trên màn hình, ko lưu ảnh QRCode 
        private void nmSizeQRCode_ValueChanged(object sender, EventArgs e)
        {
            Color colorBgQRCode = Color.Green;
            if (rdoNhanXanh.Checked)
            {
                colorBgQRCode = Color.Green;
            }
            else if (rdoNhanDo.Checked)
            {
                colorBgQRCode = Color.Red;
            }

            picQRCode.Width = (int)nmSizeQRCode.Value;
            picQRCode.Height = (int)nmSizeQRCode.Value;

            create_QRCode_22(strQRCode, colorBgQRCode);
        }


        // lựa chọn lý do thì hiển thị lên label mẫu
        private void rdoList_Reason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdoList_Reason.SelectedValue != null)
            {
                string reason = rdoList_Reason.SelectedValue.ToString();
                switch (reason)
                {
                    case "Other":
                        //txtReason_Other.Enabled = true;
                        lbComment_lb.Text = txtReason_Other.Text;
                        break;
                    default:
                        lbComment_lb.Text = reason;
                        //txtReason_Other.Enabled = false;
                        break;
                }
            }

        }

        private void txtReason_Other_TextChanged(object sender, EventArgs e)
        {
            lbComment_lb.Text = txtReason_Other.Text;
            lbKyTu_Do.Text = txtReason_Other.Text.Length.ToString();
        }

        private void txtChieuDai_TextChanged(object sender, EventArgs e)
        {
            //lbComment_lb.Text = string.Format("F/L : {0} mm", txtChieuDai.Text);
            lbComment_lb.Text = txtChieuDai.Text;
            lbKyTu_Xanh.Text = txtChieuDai.Text.Length.ToString();
        }

        #endregion

        #region hàm refresh, lưu điều chỉnh in
        //Hàm load điều chỉnh in mặc định
        private void btnRefreshDieuChinh_Click(object sender, EventArgs e)
        {
            try
            {
                string ini_QRcode = IniFile.ReadValue("DieuChinhIn", "QRCode", pathFileSetupXD);
                string ini_MarginTop = IniFile.ReadValue("DieuChinhIn", "MarginTop", pathFileSetupXD);
                string ini_MarginLeft = IniFile.ReadValue("DieuChinhIn", "MarginLeft", pathFileSetupXD);

                nmSizeQRCode.Value = int.Parse(ini_QRcode);
                nmMarginTop_lb.Value = int.Parse(ini_MarginTop);
                nmMarginLeft_lb.Value = int.Parse(ini_MarginLeft);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm lưu điều chỉnh in nhãn
        private void btnSaveDieuChinh_Click(object sender, EventArgs e)
        {
            string QRCodeSize = nmSizeQRCode.Value.ToString();
            string MarginTop = nmMarginTop_lb.Value.ToString();
            string MarginLeft = nmMarginLeft_lb.Value.ToString();

            IniFile.WriteValue("DieuChinhIn", "QRCode", QRCodeSize, pathFileSetupXD);
            IniFile.WriteValue("DieuChinhIn", "MarginTop", MarginTop, pathFileSetupXD);
            IniFile.WriteValue("DieuChinhIn", "MarginLeft", MarginLeft, pathFileSetupXD);

            MessageBox.Show("Lưu thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region quản lý Item master, các hàm điều hường menu

        // Quản lý Item master
        private void mnSettingItemMaster_Click(object sender, EventArgs e)
        {
            if (_Admin)
            {
                ItemMasterXD item = new ItemMasterXD(_IDUser);
                item.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // master reason
        private void mnSettingReason_Click(object sender, EventArgs e)
        {
            if (_Admin)
            {
                ReasonMasterXD re = new ReasonMasterXD(_IDUser);
                if (re.ShowDialog() == DialogResult.OK)
                {
                    load_RadioButtonList_Reason();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void mnAbout_Click(object sender, EventArgs e)
        {
            formAbout f = new formAbout();
            f.ShowDialog();
        }


        private void mnFunctionSetup_Click(object sender, EventArgs e)
        {
            if (_Admin)
            {
                SetupFuncDefault se = new SetupFuncDefault(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin);
                se.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void mnAccount_Click(object sender, EventArgs e)
        {
            if (_Admin || LeaderSX)
            {
                formAccount acc = new formAccount();
                acc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region hàm cài đặt máy in
        // Hàm cài đặt máy in

        private void menuSetupPrinter_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Admin == true)
                {
                    PrinterSetup setup = new PrinterSetup();
                    setup.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void menuLogout_Click(object sender, EventArgs e)
        {

            cl.UpdateTimeLogout(_IDHistoryLogin);

            this.Dispose();
            this.Close();
            //Application.Exit();
            Application.Restart();
        }

        private void menuChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                cl.User_ChangePassword(_IDUser);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuHisLogin_Click(object sender, EventArgs e)
        {
            if (_Admin || LeaderSX)
            {
                formHistoryLogin his = new formHistoryLogin();
                his.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuHisInNhan_Click(object sender, EventArgs e)
        {
            if (_Admin || LeaderSX)
            {
                HistoryPrintXD his = new HistoryPrintXD();
                his.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void nmQty_ValueChanged(object sender, EventArgs e)
        {
            lbQty_lb.Text = nmQty.Value.ToString();
        }

        #region hàm in nhãn test, ko lưu lịch sử, ko check mã nhãn đã in
        private void btnInNhanTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtItemNo.Text))
                {
                    string GreenPrinter = IniFile.ReadValue("Printer", "Xanh", pathFileSetupXD);
                    string RedPrinter = IniFile.ReadValue("Printer", "Do", pathFileSetupXD);

                    // IN nhãn xanh
                    if (rdoNhanXanh.Checked)
                    {
                        Ham_In_Nhan(GreenPrinter, "GREEN", false);
                    }
                    else if (rdoNhanDo.Checked) // in nhãn đỏ
                    {
                        // in nhãn đỏ, 
                        Ham_In_Nhan(RedPrinter, "RED", false);
                    }
                }
                else
                {
                    MessageBox.Show("Chủng loại không xác định", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            txtScanBarcode.Focus();
        }
        #endregion
    }
}
