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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace PrintLabel.DongGoi_TAS
{
    public partial class formPrintDG_TAS : Form
    {
        // Khai báo các biến truyền từ form mẹ vào
        int _IDUser;
        int _IDHistoryLogin;
        string _FullName;
        string _UserName;
        bool _Admin;
        string _PrintName;
        string _MaChucNang;

        // Khai báo các biến để hiển thị dữ liệu trên formm con
        string strWONo = "";
        string strIDNo = "";
        string strItemNo = "";
        string strRev = "";
        string strDes = "";


        private const int LINE_FONT_SIZE = 10;
        private const string STANDARD_FONT_NAME = "Verdana";

        private PrintDocument pdoc = null;

        clQuery cl = new clQuery();

        // Thông tin đường dẫn đến chỗ độc dữ liệu master đầu vào chương trình
        string file_route = Application.StartupPath + "\\SettingDongGoi.ini";

        public formPrintDG_TAS(int IDUser, int IDHistoryLogin, string FullName, string UserName, bool admin, string machucnang)
        {
            _IDUser = IDUser;
            _IDHistoryLogin = IDHistoryLogin;
            _FullName = FullName;
            _UserName = UserName;
            _Admin = admin;
            _MaChucNang = machucnang;
            InitializeComponent();
        }

        private void formPrintDG_TAS_Load(object sender, EventArgs e)
        {
            lbFullName.Text = _FullName;
            MenuAccount.Text = string.Format("{0} ({1})", _FullName, _UserName);

            _PrintName = IniFile.ReadValue("DongGoi_TAS", "Printer", file_route); // Đọc dòng đầu tiên
            string _copies = IniFile.ReadValue("DongGoi_TAS", "Copies", file_route); // Đọc dòng thứ 2// Thay đổi, số bản in người dùng tự nhập
            numericCopy.Value = short.Parse(_copies);

            // lấy thông tin tên máy
            lbTenMay.Text = clQuery.PCName();
            lbMaChucNang.Text = _MaChucNang;
        }
        // Hàm dùng để lấy thông tin cho file ini
        // Lấy tên
        private string Get_Ini_Name(string SectionName)
        {
            return IniFile.ReadValue(SectionName, "name", file_route);
        }
        //Lấy tọa độ x
        private int Get_Ini_X(string SectionName)
        {
            string value = IniFile.ReadValue(SectionName, "x", file_route).Trim();

            return short.Parse(value);
        }
        //Lấy tọa độ y
        private int Get_Ini_Y(string SectionName)
        {
            string value = IniFile.ReadValue(SectionName, "y", file_route).Trim();

            return short.Parse(value);
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            //MessageBox.Show(
            //    $"{e.PageBounds.Width} x {e.PageBounds.Height}");
            // Cấu hình Barcode
            BarcodeWriter batchWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 25,
                    Width = 120,
                    Margin = 0,
                    PureBarcode = true
                }
            };

            Graphics g = e.Graphics;

            Font fontNormal = new Font("Arial", 10, FontStyle.Bold);
            Font fontTitle = new Font("Arial", 11, FontStyle.Bold);

            //--------------------------------------------------
            // MATERIAL
            //--------------------------------------------------
            g.DrawString(Get_Ini_Name("lab1"), fontNormal, Brushes.Black, Get_Ini_X("lab1"), Get_Ini_Y("lab1"));
            g.DrawString(strItemNo, fontNormal, Brushes.Black, Get_Ini_X("value1"), Get_Ini_Y("value1"));

            //--------------------------------------------------
            // MATERIAL BARCODE
            //--------------------------------------------------

            using (Bitmap materialBarcode = batchWriter.Write(strItemNo))
            {
                g.DrawImage(
                    materialBarcode,
                    Get_Ini_X("barcode1"),
                    Get_Ini_Y("barcode1"));
            }

            //--------------------------------------------------
            // DESCRIPTION
            //--------------------------------------------------

            g.DrawString(Get_Ini_Name("lab2"), fontNormal, Brushes.Black, Get_Ini_X("lab2"), Get_Ini_Y("lab2"));

            RectangleF rectDes = new RectangleF(
                Get_Ini_X("value2"),  // X
                Get_Ini_Y("value2"),  // Y
                250,  // Width
                60    // Height
            );

            g.DrawString(
                strDes,
                fontNormal,
                Brushes.Black,
                rectDes);


            //--------------------------------------------------
            // BATCH
            //--------------------------------------------------

            g.DrawString(Get_Ini_Name("lab3"), fontNormal, Brushes.Black, Get_Ini_X("lab3"), Get_Ini_Y("lab3"));

            g.DrawString(
                strIDNo,
                fontNormal,
                Brushes.Black,
                Get_Ini_X("value3"),
                Get_Ini_Y("value3"));

            //--------------------------------------------------
            // BATCH BARCODE
            //--------------------------------------------------

            using (Bitmap batchBarcode = batchWriter.Write(strIDNo))
            {
                g.DrawImage(
                    batchBarcode,
                    Get_Ini_X("barcode2"),
                    Get_Ini_Y("barcode2"));
            }

            //--------------------------------------------------
            // VENDOR BATCH
            //--------------------------------------------------

            g.DrawString(
                Get_Ini_Name("lab4"),
                fontNormal,
                Brushes.Black,
                Get_Ini_X("lab4"),
                Get_Ini_Y("lab4"));

            g.DrawString(
                strIDNo,
                fontNormal,
                Brushes.Black,
                Get_Ini_X("value4"),
                Get_Ini_Y("value4"));
            //--------------------------------------------------
            // HEADER
            //--------------------------------------------------

            g.DrawString(Get_Ini_Name("lab5"), fontTitle, Brushes.Black, Get_Ini_X("lab5"), Get_Ini_Y("lab5"));
            g.DrawString(Get_Ini_Name("lab6"), fontNormal, Brushes.Black, Get_Ini_X("lab6"), Get_Ini_Y("lab6"));

            //--------------------------------------------------
            // RIGHT SIDE
            //--------------------------------------------------

            g.DrawString(
                Get_Ini_Name("lab7"),
                fontNormal,
                Brushes.Black,
                Get_Ini_X("lab7"),
                Get_Ini_Y("lab7"));

            g.DrawString(
                strRev,
                fontNormal,
                Brushes.Black,
                Get_Ini_X("value5"),
                Get_Ini_Y("value5"));

            g.DrawString(
                Get_Ini_Name("lab8"),
                fontNormal,
                Brushes.Black,
                Get_Ini_X("lab8"),
                Get_Ini_Y("lab8"));

            g.DrawString(
                Get_Ini_Name("value6"),
                fontNormal,
                Brushes.Black,
                Get_Ini_X("value6"),
                Get_Ini_Y("value6"));

            g.DrawString(
                Get_Ini_Name("lab9"),
                fontNormal,
                Brushes.Black,
                Get_Ini_X("lab9"),
                Get_Ini_Y("lab9"));

            g.DrawString(
                Get_Ini_Name("lab10"),
                new Font("Arial", 9, FontStyle.Bold),
                Brushes.Black,
                Get_Ini_X("lab10"),
                Get_Ini_Y("lab10"));
        }


        // Hàm in 
        public void print(short _copies)
        {
            try
            {

                #region Code đã chỉnh sửa
                //// Chọn máy in
                //code to send printdocument to the printer

                PrintDialog pd = new PrintDialog();
                string strDefaultPrinter = _PrintName;//Code to get default printer name  



                pdoc = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();

                //   Font font = new Font("Courier New", 15);//set default font for page
                //PaperSize psize = new PaperSize("Custom", 350, 120);//set paper size sing code
                pd.Document = pdoc;

                //pd.Document.DefaultPageSettings.PaperSize = psize;
                pdoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);


                //*************************Code to set Default Printer*************************************

                ps.PrinterName = _PrintName;//Code to set default printer name
                pd.PrinterSettings.PrinterName = _PrintName;//Code to set default printer name 

                //PaperSize paper =
                //    new PaperSize("Custom", 400, 290);

                //pdoc.DefaultPageSettings.PaperSize = paper;

                pdoc.PrinterSettings.Copies = _copies; //(short)numericCopy.Value;


                //************************************End**************************************************
                //DialogResult result = pd.ShowDialog();
                //if (result == DialogResult.OK)
                //{
                pdoc.Print();

                //}


                #endregion Code đã chỉnh sửa

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        // hàm lưu lịch sử in
        private void SaveHis_Print(int copies, bool prePrint, string reason = null, string leaderConfirm = null, DateTime? TimeConfirm = null)
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                tblHistoryPrint prin = new tblHistoryPrint();
                prin.IDUser = _IDUser;
                prin.DatePrint = DateTime.Now;
                prin.TimePrint = DateTime.Now;
                prin.WO_No = strWONo;
                prin.ID_No = strIDNo;
                prin.Item_No = strItemNo;
                prin.Rev_No = strRev;
                //prin.Remark = numericCopy.Value.ToString(); // Số bản in/1 lần in
                prin.strFull = txtScanBarcode.Text;
                prin.Remark = "TAS";
                prin.Copies = copies;
                prin.PrePrint = prePrint;
                prin.FuncCode = lbMaChucNang.Text;
                prin.Reason = reason;
                prin.LeaderConfirm = leaderConfirm;
                prin.TimeConfirm = TimeConfirm;
                prin.Col1 = lbTenMay.Text;  // Lưu tên máy tính

                db.tblHistoryPrints.Add(prin);
                db.SaveChanges();

            }
        }

        private void Reset_text()
        {
            //strWONo = "";
            //strIDNo = "";
            //strItemNo = "";
            txtScanBarcode.Text = "";
            //lb_WONo.Text = "";
            //lbIDNo.Text = "";
            //lbItemNo.Text = "";
            //picBarcode.Image = null;

        }
        // Hàm dùng để lấy tt Description
        private string Get_Description(string Item)
        {
            using(DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                string description = db.tblItemCheck_XD
                                    .Where(x => x.ItemNo == Item)
                                    .Select(x => x.Description)
                                    .FirstOrDefault();
                return description;
            }
        }
        // Hàm dùng để chuyển từ dạng chữ sang dạng barcode
        private void Convert_Barcode(string barcode, PictureBox mv)
        {
            // Tạo BarCode
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 30, 
                    Margin = 0,
                    PureBarcode = true

                }
            };
            //string content = txtScanBarcode.Text;

            using (var bitmap = barcodeWriter.Write(barcode)) //strBarCode
            {
                using (var stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Png);
                    var image = Image.FromStream(stream);

                    mv.Image = image;
                }
            }
        }
        private void txtScanBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtScanBarcode.Text))
                    {
                        MessageBox.Show("Vui lòng quét mã vạch trên chỉ thị", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string[] Chuoi = txtScanBarcode.Text.Split('%');
                    string _WO = Chuoi[0].ToString();
                    string _ID = Chuoi[1].ToString();
                    string _Item = Chuoi[2].ToString();
                    string _Rev = Chuoi[3].ToString();

                    // Lấy thông tin Description dựa trên Item
                    strDes = Get_Description(_Item);
                    Description.Text = strDes;

                    // Truyền thông tin vào form
                    Material.Text = _Item;
                    Batch.Text = _ID;
                    Vendor_Batch.Text = _ID;
                    Rev.Text = _Rev;

                    strWONo = _WO;
                    strIDNo = _ID;
                    strItemNo = _Item;
                    strRev = _Rev;

                    // Dịch thông tin ra các đoạn barcode
                    Convert_Barcode(_Item, Material_Barcode);
                    Convert_Barcode(_ID, Batch_Barcode);

                    // Kiểm tra xem có phải in lại không?
                    // nếu đúng là in lại + vị trí là Đóng gói thì phải có leader xác nhận
                    using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                    {

                        var checkRePrint = (from s in db.tblHistoryPrints
                                            where s.WO_No == strWONo &&
                                                  s.ID_No == strIDNo &&
                                                  s.Item_No == strItemNo &&
                                                  s.FuncCode == _MaChucNang
                                            select s).ToList().Count;


                        if (checkRePrint > 0) // in lại
                        {
                            fromConfirmRePrintLeader re = new fromConfirmRePrintLeader();
                            if (re.ShowDialog() == DialogResult.OK)
                            {
                                string leaderConfirm = re.UserName_Admin;
                                short copies = re.Copies;
                                string lyDoInLai = re.LyDoInLai;
                                DateTime reTime = DateTime.Now;

                                SaveHis_Print(copies, true, lyDoInLai, leaderConfirm, reTime);
                                // Hàm print ở đây nhé
                                print(copies);

                            }
                        }
                        else // in mới
                        {
                            //  Lưu lịch sử scan, Ai scan, vào lúc nào, scan cái gì
                            SaveHis_Print((int)numericCopy.Value, false);
                            // Hàm print ở đây nhé
                            print((short)numericCopy.Value);
                        }

                        Reset_text();

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Set_Printer_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có phải leader không
            bool check_leader =  cl.check_Leader_User(_IDUser);
            if(_Admin && check_leader)
            {
                Setting_Printer_TAS f = new Setting_Printer_TAS();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào chức năng này!");
            }
        }
    }
}
