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
    public partial class formConfirmLeader_BoSungTB_PL : Form
    {
        public string MaPL, NguoiTao, ChungLoai, ThietBi;

        public string userAdmin { get; set; }
        public string LyDoXN { get; set; }
        
        public formConfirmLeader_BoSungTB_PL()
        {
            InitializeComponent();
        }

        public formConfirmLeader_BoSungTB_PL(string maPL, string nguoiTao, string chungLoai, string thietBi)
        {
            MaPL = maPL;
            NguoiTao = nguoiTao;
            ChungLoai = chungLoai;
            ThietBi = thietBi;
            InitializeComponent();
        }

        private void formConfirmLeader_BoSungTB_PL_Load(object sender, EventArgs e)
        {
            txtLyDo.Focus();
            txtMaPL.Text = MaPL;
            txtNguoiTao.Text = NguoiTao;
            txtChungLoai.Text = ChungLoai;
            txtThietBi.Text = ThietBi;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LyDoXN = txtLyDo.Text.Trim();

            if (!string.IsNullOrEmpty(LyDoXN))
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    string pass = clQuery.GetMD5(txtPasswordAdmin.Text);
                    var data = db.pro_Login(txtUserAdmin.Text, pass).Where(s => s.Admin == true || s.LeaderSX == true).ToList();

                    if (data.Count > 0)
                    {
                        var data2 = data.SingleOrDefault();

                        string _UserNameAdmin = data2.UserName;
                        string _FullNameAdmin = data2.FullName;

                        userAdmin = string.Format("{0}-{1}", _UserNameAdmin, _FullNameAdmin);
                        
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
                MessageBox.Show("Nhập lý do","Lý do", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
