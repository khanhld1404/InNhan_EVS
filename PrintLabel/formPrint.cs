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
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace PrintLabel
{
    public partial class formPrint : Form
    {
        int _IDUser;
        int _IDHistoryLogin;
        string _FullName;
        string _UserName;
        bool _Admin;
        string _PrintName;
        string _MaChucNang;
        //short Copies;
        string showhistory = "0";


        private const int LINE_FONT_SIZE = 10;
        private const string STANDARD_FONT_NAME = "Verdana";
        private Font STANDARD_FONT = new Font(STANDARD_FONT_NAME, LINE_FONT_SIZE);
        private PrintDocument pdoc = null;

        string strWONo = "";
        string strIDNo = "";
        string strItemNo = "";
        string strRev = "";
        string strBarCode = "";
        int Wi = 0;

        bool LeaderSX = false;

        clQuery cl = new clQuery();

        // Chuoi test: 01110051%11297610OLB34DEVICE
        // Chuoi test: 19040362%19150362EV068-D013t01
        // Chuoi test: 19040362%19150362EV068-D013t01KHIU7T


        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public formPrint(int IDUser, int IDHistoryLogin, string FullName, string UserName, bool admin, string machucnang)
        {
            _IDUser = IDUser;
            _IDHistoryLogin = IDHistoryLogin;
            _FullName = FullName;
            _UserName = UserName;
            _Admin = admin;
            _MaChucNang = machucnang;
            InitializeComponent();
        }

        public formPrint()
        {
            InitializeComponent();
        }

        private void showMenuHistory()
        {
            try
            {
                //if (showhistory == "1")
                //{
                //    menuStripHistory.Visible = true;
                //}
                //else
                //{
                //    menuStripHistory.Visible = false;
                //}
                menuStripHistory.Visible = (showhistory == "1");
            }
            catch (Exception ex)
            {
                menuStripHistory.Visible = false;
                MessageBox.Show(ex.ToString());
            }
        }

        private void formPrint_Load(object sender, EventArgs e)
        {
            lbFullName.Text = _FullName;
            MenuAccount.Text = string.Format("{0} ({1})", _FullName, _UserName);

            _PrintName = cl.ReadFile(0); // Đọc dòng đầu tiên
            string _copies = cl.ReadFile(1); // Đọc dòng thứ 2// Thay đổi, số bản in người dùng tự nhập
            numericCopy.Value = short.Parse(_copies);

            showhistory = cl.ReadFile(7);
            // Show menutrip History
            showMenuHistory();

            // lấy thông tin tên máy
            lbTenMay.Text = clQuery.PCName();
            lbMaChucNang.Text = _MaChucNang;

            LeaderSX = cl.check_Leader_User(_IDUser);

            //lbTitle.Text = _MaChucNang == "NHAN_BARCODE_KITTING" ? "In nhãn Barcode - Kitting" : "In nhãn Barcode - Đóng Gói";
            if (_MaChucNang == "NHAN_BARCODE_KITTING")
            {
                lbTitle.Text = "In nhãn Barcode - Kitting";
                numericCopy.Enabled = true;
                btnInNhanDG_TAS.Visible = false;
                //numericCopy.Focus();

                // Trì hoãn focus để đảm bảo control đã sẵn sàng
                this.BeginInvoke(new Action(() => numericCopy.Focus()));

            }
            else
            {
                lbTitle.Text = "In nhãn Barcode - Đóng Gói";
                numericCopy.Enabled = false;
                btnInNhanDG_TAS.Visible = true;
                //txtScanBarcode.Focus();
                this.BeginInvoke(new Action(() => txtScanBarcode.Focus()));
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CreateBarcode_Print();
        }


        private void CreateBarcode_Print()
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

                //if (_chuoi1.Length < 8 || _chuoi1.Length > 8)
                //{
                //    MessageBox.Show("Mã vạch không đúng định dạng", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                //}
                //else
                //{
                lb_WONo.Text = _WO;
                lbIDNo.Text = _ID;
                lbItemNo.Text = _Item;
                lbRevNo.Text = _Rev;

                strWONo = _WO;
                strIDNo = _ID;
                strItemNo = _Item;
                strRev = _Rev;

                //strBarCode = txtScanBarcode.Text;

                //strBarCode = Chuoi[0] + "%" + Chuoi[1]; // Bỏ revision bản vẽ, không thêm trường này vào barcode
                strBarCode = string.Format("(10){0}(240){1}", _ID, _Item); 

                //int sokytu = (int)(strBarCode.Length);
                //Wi = (int)((11 * sokytu) * 0.662); // Coong thức là lấy w=240 là chuẩn. W = 11* sokytuBarcode * 0.662. Cong thuc cua Hung


                // Tạo BarCode
                var barcodeWriter = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new EncodingOptions
                    {
                        //Height = 20, // cu = 16, 20
                        //Width = Wi,  // 240, // cu = 230
                        //Margin = 0,
                        //PureBarcode = true

                        Height = 14, // cu = 16, 20
                                     //Width = Wi,  // 240, // cu = 230
                        Margin = 0,
                        PureBarcode = true

                    }
                };
                //string content = txtScanBarcode.Text;

                using (var bitmap = barcodeWriter.Write(strBarCode)) //strBarCode
                {
                    using (var stream = new MemoryStream())
                    {
                        bitmap.Save(stream, ImageFormat.Png);
                        var image = Image.FromStream(stream);

                        picBarcode.Image = image;

                        string strHeSoBarcode = cl.ReadFile(8); // Lấy hệ số nhãn barcode trong file setting

                        double HeSoBarcode = double.Parse(strHeSoBarcode);

                        Wi = (int)(image.Width * HeSoBarcode); //HeSoBarcode
                                                               //int He = image.Height;
                    }
                }


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
                        if (_MaChucNang == "NHAN_BARCODE_KITTING")
                        {
                            //  Lưu lịch sử scan, Ai scan, vào lúc nào, scan cái gì
                            SaveHis_Print((int)numericCopy.Value, true);
                            // Hàm print ở đây nhé
                            print((short)numericCopy.Value);
                        }
                        else // Công đoạn đóng gói cần xác nhận của Leader
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
                //}

            }
            catch
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Barcode không đúng định dạng", "False Barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void PrintLine(int intLineNo, string strFixed, string strVar, string strWidthToSameAs, short intInitialFontSize, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    float intFixedLen;
        //    float intVariableLen;
        //    float intTextFontSize;
        //    float yPos = 0;

        //    intTextFontSize = intInitialFontSize;

        //    Font fixedFont = new Font(STANDARD_FONT_NAME, intInitialFontSize, FontStyle.Bold);
        //    Font varFont = new Font(STANDARD_FONT_NAME, intInitialFontSize, FontStyle.Bold);

        //    yPos = (intLineNo * fixedFont.GetHeight(e.Graphics)) - 10;

        //    SizeF StringSize = new SizeF();
        //    StringSize = e.Graphics.MeasureString(strWidthToSameAs, fixedFont);

        //    intFixedLen = StringSize.Width + 5; // Get width of fixed part of string + a bit extra
        //    Debug.Print(strFixed + " " + intFixedLen);

        //    StringSize = e.Graphics.MeasureString(strVar, varFont);
        //    intVariableLen = StringSize.Width;
        //    while ((intVariableLen + intFixedLen) > e.PageBounds.Width)
        //    {
        //        intTextFontSize += -1;
        //        varFont = new Font("Arial", intTextFontSize - 1, FontStyle.Bold);
        //        StringSize = e.Graphics.MeasureString(strVar, varFont);
        //        intVariableLen = StringSize.Width;
        //    }

        //    e.Graphics.DrawString(strFixed, fixedFont, Brushes.Black, 10, yPos, new StringFormat());
        //    e.Graphics.DrawString(strVar, varFont, Brushes.Black, intFixedLen, yPos, new StringFormat());
        //}


        private void PrintLine(int intLineNo, string strFixed, string strVar, string strWidthToSameAs, short intInitialFontSize, System.Drawing.Printing.PrintPageEventArgs e)
        {
            short intFixedLen;
            short intVariableLen;
            short intTextFontSize;
            short yPos = 0;

            intTextFontSize = intInitialFontSize;

            Font fixedFont = new Font(STANDARD_FONT_NAME, intInitialFontSize, FontStyle.Bold);
            Font varFont = new Font(STANDARD_FONT_NAME, intInitialFontSize, FontStyle.Bold);

            yPos = (short)((intLineNo * fixedFont.GetHeight(e.Graphics)) - 10);

            SizeF StringSize = new SizeF();
            StringSize = e.Graphics.MeasureString(strWidthToSameAs, fixedFont);

            intFixedLen = (short)(StringSize.Width + 5); // Get width of fixed part of string + a bit extra
            Debug.Print(strFixed + " " + intFixedLen);

            StringSize = e.Graphics.MeasureString(strVar, varFont);
            intVariableLen = (short)(StringSize.Width);
            while ((intVariableLen + intFixedLen) > e.PageBounds.Width)
            {
                intTextFontSize += -1;
                varFont = new Font("Arial", intTextFontSize - 1, FontStyle.Bold);
                StringSize = e.Graphics.MeasureString(strVar, varFont);
                intVariableLen = (short)(StringSize.Width);
            }

            //e.Graphics.DrawString(strFixed, fixedFont, Brushes.Black, 0, yPos - 8, new StringFormat());
            //e.Graphics.DrawString(strVar, varFont, Brushes.Black, intFixedLen - 12, yPos - 8, new StringFormat());

            e.Graphics.DrawString(strFixed, fixedFont, Brushes.Black, 10, yPos, new StringFormat());
            e.Graphics.DrawString(strVar, varFont, Brushes.Black, intFixedLen, yPos, new StringFormat());

            //e.Graphics.DrawString(strFixed, fixedFont, Brushes.Black, 0, yPos - 8, new StringFormat());
            //e.Graphics.DrawString(strVar, varFont, Brushes.Black, intFixedLen - 12, yPos - 8, new StringFormat());
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            //PrintLine(1, "W/O No.  -", " " + strWONo, "W/O No.  -", 10, e);
            //PrintLine(2, "ID No.   -", " " + strIDNo, "W/O No.  -", 10, e);
            //PrintLine(3, "Item No. -", " " + strItemNo, "W/O No. -", 10, e);
            //PrintLine(4, "Rev No. -", " " + strRev, "W/O No. -", 10, e);

            PrintLine(1, "W/O No. ", "   " + strWONo, "W/O No. ", 10, e);
            PrintLine(2, "ID No.  ", "   " + strIDNo, "W/O No.  ", 10, e);
            PrintLine(3, "Item No.", "   " + strItemNo, "W/O No.", 10, e);
            PrintLine(4, "Rev No. ", "   " + strRev, "W/O No. ", 10, e);


            //pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            e.Graphics.DrawImage(picBarcode.Image, 5, 78, Wi, 14); // NEW - ADD REVISION DRAWING

           

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

        private void menuStripLogout_Click(object sender, EventArgs e)
        {

            // Lưu thời gian logOut
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                tblHistoryLogin lo = new tblHistoryLogin();
                lo = db.tblHistoryLogins.Where(id => id.IDHistory == _IDHistoryLogin).Single();
                lo.DateLogout = DateTime.Now;
                lo.TimeLogout = DateTime.Now;
                db.SaveChanges();
            }

            this.Dispose();
            this.Close();
            //Application.Exit();
            Application.Restart();
        }

        private void menuStripNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void menuStripHisPrint_Click(object sender, EventArgs e)
        {
            if (_Admin || LeaderSX)
            {
                formHistoryPrint his = new formHistoryPrint();
                his.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void menuStripHisLogin_Click(object sender, EventArgs e)
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

        private void txtScanBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateBarcode_Print();
            }
        }

        private void menuStripSetting_Click(object sender, EventArgs e)
        {

            if (_Admin == true)
            {
                formSettingPrintName print = new formSettingPrintName();
                print.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void menuStripAbout_Click(object sender, EventArgs e)
        {
            formAbout about = new formAbout();
            about.ShowDialog();
        }

        private void menuStripControl_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void menuCreatePackingList_Click(object sender, EventArgs e)
        {

        }

        private void menuUpdateTemp_Click(object sender, EventArgs e)
        {


        }



        private void mnFuncDefault_Click(object sender, EventArgs e)
        {
            if (_Admin)
            {
                XanhDo.SetupFuncDefault se = new XanhDo.SetupFuncDefault(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin);
                se.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnInNhanDG_TAS_Click(object sender, EventArgs e)
        {
            DongGoi_TAS.formPrintDG_TAS tas = new DongGoi_TAS.formPrintDG_TAS(_IDUser,_IDHistoryLogin,_FullName,_UserName,_Admin,_MaChucNang);
            tas.ShowDialog();
        }
    }
}
