using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.XacNhanJIG
{
    public partial class ConfirmLeader : Form
    {
        int idCheckJIG;
        string JIgMaster;
        string JigPicking;

        public ConfirmLeader(int _idCheck, string jIgMaster, string jigPicking)
        {
            idCheckJIG = _idCheck;
            JIgMaster = jIgMaster;
            JigPicking = jigPicking;
            InitializeComponent();
        }

        public ConfirmLeader()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string ReasonNG = txtReasonNG.Text.Trim();
            if (!string.IsNullOrEmpty(ReasonNG))
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    string pass = clQuery.GetMD5(txtPassword.Text);
                    var data = db.pro_Login(txtUserNameLerder.Text, pass).Where(s=>s.Admin == true).ToList();

                    if (data.Count > 0)
                    {
                        var data2 = data.SingleOrDefault();

                        string _UserNameAdmin = data2.UserName;
                        string _FullNameAdmin = data2.FullName;
                        
                        // cập nhật Reason
                        string strReasonNG = string.Format("{0} ({1} Xác nhận: {2}-{3})", ReasonNG, JigPicking, _UserNameAdmin, _FullNameAdmin);
                        // Cập nhật kết quả NG
                        db.pro_JIG_10_Update_resultPickingJIG_NG(idCheckJIG, strReasonNG,_UserNameAdmin);

                        this.DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản xác nhận không chính xác ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                  
            }
            else
            {
                MessageBox.Show("Nhập lý do NG ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       

        private void ConfirmLeader_Load(object sender, EventArgs e)
        {
            txtJigMaster.Text = JIgMaster;
            txtJigPicking.Text = JigPicking;
            txtReasonNG.Focus();
        }
    }
}
