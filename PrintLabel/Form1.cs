using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace PrintLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _IDUser = 0;
        int _IDHistoryLogin = 0;
        string _FullName = "";
        string _UserName = "";
        bool _Admin = false;

        string pathSetupFunc = Application.StartupPath + "\\FunctionDefault.ini";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //Login();
        }

        private void Save_HistoryLogin(int idUser_, string Func)
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                tblHistoryLogin login = new tblHistoryLogin();
                login.IDUser = idUser_;
                login.DateLogin = DateTime.Now;
                login.TimeLogin = DateTime.Now;

                login.PCName = clQuery.PCName();

                login.FuncDefault = Func;


                db.tblHistoryLogins.Add(login);
                db.SaveChanges();

                _IDHistoryLogin = login.IDHistory;

            }
        }

        public static string GetMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }

            return sbHash.ToString();

        }

        private void Login()
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {

                    string pass = GetMD5(txtPassword.Text);
                    var data = db.pro_Login(txtUserName.Text, pass).ToList();
                    if (data.Count > 0)
                    {
                        var data2 = data.SingleOrDefault();
                        _IDUser = data2.IDUser;
                        _FullName = data2.FullName;
                        _UserName = data2.UserName;
                        _Admin = Convert.ToBoolean(data2.Admin); // xem phai quyen admin ko



                        // kiểm tra xem đến ngày Yêu cầu đổi password chưa
                        //DateTime dateChangePass = data2.DateChangePass == null ? DateTime.Now : Convert.ToDateTime(data2.DateChangePass);
                        DateTime dateChangePass = data2.DateChangePass ?? DateTime.Now; // viết tắt của câu trên

                        if (dateChangePass <= DateTime.Now) // YC đổi mk
                        {
                            fromChangePassword ch = new fromChangePassword(pass, _IDUser);
                            ch.ShowDialog();
                        }
                        else
                        {
                            string funcDefault = IniFile.ReadValue("Function", "func", pathSetupFunc); // Func default set theo máy

                            // kiểm tra xem user có quyền như Function default không?
                            var userCheck = (from s in db.tblUser_Role
                                             from t in db.tblRoles
                                             where s.IDRole == t.IDRole &&
                                                   s.IDUser == _IDUser &&
                                                   t.CodeRole == funcDefault
                                             select new
                                             {
                                                 t.CodeRole
                                             }).ToList().Count;

                            if (userCheck > 0)
                            {

                                // lưu lịch sử login
                                Save_HistoryLogin(_IDUser, funcDefault);
                                //this.Hide();

                                //this.Invoke((MethodInvoker)(() => this.Hide()));
                                this.Invoke((MethodInvoker)delegate
                                {
                                    this.Hide();

                                    switch (funcDefault)
                                    {
                                        case "NHAN_BARCODE_KITTING":
                                            formPrint print = new formPrint(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin, funcDefault);
                                            print.ShowDialog();
                                            break;
                                        case "NHAN_BARCODE_DONGGOI":
                                            formPrint print1 = new formPrint(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin, funcDefault);
                                            print1.ShowDialog();
                                            break;
                                        case "NHAN_QC":
                                            XanhDo.XanhDo_print xd = new XanhDo.XanhDo_print(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin);
                                            xd.ShowDialog();
                                            break;

                                        case "PACKING_LIST":
                                            formCreatePL createPL = new formCreatePL(_IDUser, _Admin, _UserName, _IDHistoryLogin, _FullName);
                                            createPL.ShowDialog();
                                            break;

                                        //case "NHAN_BARCODE_DONGGOI_TAS":
                                        //    //formPrint print1 = new formPrint(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin, funcDefault);
                                        //    //print1.ShowDialog();
                                        //    break;
                                        //case "JIGConfirm":

                                        //    XacNhanJIG.MainConfirmJIG jig = new XacNhanJIG.MainConfirmJIG(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin);
                                        //    jig.ShowDialog();
                                        //    break;
                                        default:
                                            XanhDo.SetupFuncDefault setup = new XanhDo.SetupFuncDefault(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin);
                                            setup.ShowDialog();
                                            break;
                                    }
                                });

                            }
                            else
                            {
                                MessageBox.Show("Bạn không có quyền truy cập chức năng này !", "Function", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đăng nhập không đúng hoặc tài khoản của bạn đang bị khóa \n Vui lòng liên hệ với người quản lý để được hỗ trợ", "Login false", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                backgroundWorker1.RunWorkerAsync();
                //Login();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            btnLogin.Invoke(new Action(() => { btnLogin.Enabled = false; }));
            picLoading.Invoke(new Action(() => { picLoading.Visible = true; }));

            Login();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnLogin.Invoke(new Action(() => { btnLogin.Enabled = true; }));
            picLoading.Invoke(new Action(() => { picLoading.Visible = false; }));
            //backgroundWorker1.Dispose();
            //backgroundWorker1 = null;

        }
    }
}
