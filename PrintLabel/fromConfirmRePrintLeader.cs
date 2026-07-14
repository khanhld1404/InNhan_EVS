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
    public partial class fromConfirmRePrintLeader : Form
    {
        public string UserName_Admin { get; set; }
        public short Copies { get; set; }
        public string LyDoInLai { get; set; }

        public fromConfirmRePrintLeader()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnInLai_Click(object sender, EventArgs e)
        {
            try
            {
                int EmptyTextBox = clQuery.countBlankTextbox(this);

                if (EmptyTextBox > 0)
                {
                    MessageBox.Show("Nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool admin = LoginAdmin();
                    if (admin) 
                    {
                        UserName_Admin = txtUserName.Text;
                        Copies = (short)numericCopy.Value;
                        LyDoInLai = txtLyDoInLai.Text;

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không chính xác", "Confirm false", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool LoginAdmin()
        {
            bool Result  = false;
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {

                string pass = clQuery.GetMD5(txtPassword.Text);
                var data = db.pro_Login(txtUserName.Text, pass).ToList();
                if (data.Count > 0)
                {
                    var data2 = data.SingleOrDefault();

                    bool _Admin = data2.Admin?? false; // xem phai quyen admin ko
                    bool _LeaderSX = data2.LeaderSX ?? false;

                    if(_Admin || _LeaderSX)
                    {
                        Result = true;
                    }

                }

                return Result;
            }
        }
    }
}
