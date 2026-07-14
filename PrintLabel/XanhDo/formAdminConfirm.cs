using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.XanhDo
{
    public partial class formAdminConfirm : Form
    {
        public string UserName_Admin { get; set; }
        public string LyDoInLai { get; set; }

        clQuery clquery = new clQuery();
        public formAdminConfirm()
        {
            InitializeComponent();
            txtUserName.Focus();

        }

        //public formAdminConfirm(string userName_Admin)
        //{
        //    UserName_Admin = userName_Admin;
        //    InitializeComponent();
        //}

        private bool LoginAdmin()
        {
           
            bool result = false;
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {

                string pass = clQuery.GetMD5(txtPassword.Text);
                var data = db.pro_Login(txtUserName.Text, pass).ToList();
                if (data.Count > 0)
                {
                    var data2 = data.SingleOrDefault();

                     bool _Admin = data2.Admin ?? false; // xem phai quyen admin ko
                     bool _LeaderSX = data2.LeaderSX ?? false;

                    if(_Admin || _LeaderSX)
                    {
                        result = true;
                    }
                   

                }

                return result;
            }
        }

        private void ConfirmAdmin()
        {
            try
            {
                bool admin = LoginAdmin();
             
                if (admin)
                {
                    UserName_Admin = txtUserName.Text;
                    LyDoInLai = txtLyDoInLai.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    UserName_Admin = string.Empty;
                    LyDoInLai = string.Empty;
                    MessageBox.Show("Tài khoản không chính xác", "Confirm false", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message , "Confirm false", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); 
            }
        }

      

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtLyDoInLai.Text.Trim()))
            {
                ConfirmAdmin();
            }
            else
            {
                MessageBox.Show("Nhập lý do in lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserName_Admin = string.Empty;
            LyDoInLai = string.Empty;
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }
    }
}
