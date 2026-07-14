using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class fromChangePassword : Form
    {
        string MD5_OLD_PASS;
        int idUser;

        public fromChangePassword(string mD5_OLD_PASS, int idUser)
        {
            MD5_OLD_PASS = mD5_OLD_PASS;
            this.idUser = idUser;
            InitializeComponent();
        }

        public fromChangePassword()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            ////Application.Exit();
            //Application.Restart();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                string _oldPass = txtOldPass.Text.Trim();
                string _newPass = txtNewPass.Text.Trim();
                string _newPassConfirm = txtNewPassConfirm.Text.Trim();

                string _md5_OldPass = clQuery.GetMD5(_oldPass);
                string _md5_NewPass = clQuery.GetMD5(_newPass);
                // string _md5_NewPass_Confirm = clQuery.GetMD5(_newPassConfirm);

                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    // kiểm tra xem mk cũ có đúng không
                    if (_md5_OldPass == MD5_OLD_PASS)
                    {
                        // kiểm tra xem mật khẩu mới có khớp không và không được trùng mật khẩu cũ
                        if (_newPass == _newPassConfirm && _newPass != _oldPass)
                        {
                            // check rule mật khẩu ít nhất 8 ký tự, bao gồm 1 ký tự đặc biệt
                            if (clQuery.IsValidPassword(_newPass))
                            {
                                // cập nhật pass
                                var user = db.tblUsers.Where(id => id.IDUser == idUser).SingleOrDefault();

                                //DateTime Curr_DateChangePass = user.DateChangePass == null ? DateTime.Now : Convert.ToDateTime(user.DateChangePass);
                                //DateTime Curr_DateChangePass = user.DateChangePass ?? DateTime.Now ;

                                user.Password = _md5_NewPass;
                                user.DateChangePass = DateTime.Now.AddMonths(3); // Ngày cập nhật + thêm 3 tháng

                                db.SaveChanges();

                                MessageBox.Show("Cập nhật mật mẩu mới thành công","Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                btnExit_Click(sender, null);
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự và chứa ít nhất 1 ký tự đặc biệt", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu mới phải khớp nhau và không được trùng với mật khẩu cũ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
