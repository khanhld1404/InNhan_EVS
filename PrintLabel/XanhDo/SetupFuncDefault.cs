using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PrintLabel.XanhDo
{
    public partial class SetupFuncDefault : Form
    {
        #region khai báo biến
        int _IDUser;
        int _IDHistoryLogin;
        string _FullName;
        string _UserName;
        bool _Admin;
        string pathStupFunc = Application.StartupPath + "\\FunctionDefault.ini";
        #endregion

        public SetupFuncDefault()
        {
            InitializeComponent();
        }

        public SetupFuncDefault(int IDUser, int IDHistoryLogin, string FullName, string UserName, bool Admin)
        {
            _IDUser = IDUser;
            _IDHistoryLogin = IDHistoryLogin;
            _FullName = FullName;
            _UserName = UserName;
            _Admin = Admin;
            InitializeComponent();
        }

        private void btnInNhanTrang_Click(object sender, EventArgs e) // in nhãn kitting
        {
            //this.Close();
            formPrint print = new formPrint(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin, "NHAN_BARCODE_KITTING");
            print.ShowDialog();
        }

        private void SetupFuncDefault_Load(object sender, EventArgs e)
        {
            lbTenMay.Text = Environment.MachineName;

            string FuncDefault = IniFile.ReadValue("Function", "func", pathStupFunc);
            cboFunc.SelectedItem = FuncDefault;
        }

        private void btnInNhanXanhDo_Click(object sender, EventArgs e)
        {
            //this.Close();
            XanhDo_print xd = new XanhDo_print(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin);
            xd.ShowDialog();
        }


        private void btnSaveSetup_Click(object sender, EventArgs e)
        {
            string setFuncDefault = cboFunc.SelectedItem.ToString();

            IniFile.WriteValue("Function", "func", setFuncDefault, pathStupFunc);

            MessageBox.Show("Cập nhật thông tin thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {

            //Application.Restart();

            this.BeginInvoke(new Action(() =>
            {
                Application.Restart();
                Application.ExitThread(); // Đảm bảo thoát luồng hiện tại
            }));

        }

        private void btnConfirmJIG_Click(object sender, EventArgs e)
        {
            XacNhanJIG.MainConfirmJIG jig = new XacNhanJIG.MainConfirmJIG(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin);
            jig.ShowDialog();
        }

        private void btnInNhan_DongGoi_Click(object sender, EventArgs e)
        {
            formPrint print = new formPrint(_IDUser, _IDHistoryLogin, _FullName, _UserName, _Admin, "NHAN_BARCODE_DONGGOI");
            print.ShowDialog();
        }

        private void btnPakingList_Click(object sender, EventArgs e)
        {
            formCreatePL createPL = new formCreatePL(_IDUser, _Admin, _UserName, _IDHistoryLogin, _FullName);
            createPL.ShowDialog();
            
        }
    }
}
