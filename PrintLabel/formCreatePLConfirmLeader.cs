using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class formCreatePLConfirmLeader : Form
    {
        public string WONo, IDNo, ItemNo, RevNo, ItemChungLoai, ChungLoai, ChungLoai_TBi, ErrorConfirm;
        public string userAdmin { get; set; }
        public formCreatePLConfirmLeader(string wONo, string iDNo, string itemNo, string revNo, string itemChungLoai, string chungLoai, string chungLoai_TBi, string errorConfirm)
        {
            WONo = wONo;
            IDNo = iDNo;
            ItemNo = itemNo;
            RevNo = revNo;
            ItemChungLoai = itemChungLoai;
            ChungLoai = chungLoai;
            ChungLoai_TBi = chungLoai_TBi;
            ErrorConfirm = errorConfirm;
            InitializeComponent();
        }

        public formCreatePLConfirmLeader()
        {
            InitializeComponent();
        }

        private void formCreatePLConfirmLeader_Load(object sender, EventArgs e)
        {
            txtUserAdmin.Focus();

            txtWO.Text = WONo;
            txtIDNo.Text = IDNo;
            txtItemNo.Text = ItemNo;
            txtItem_ChungLoai.Text = ItemChungLoai;
            txtRevNo.Text = RevNo;
            txtChungLoai.Text = ChungLoai;
            txtChungLoai_TBi.Text = ChungLoai_TBi;
            txtErrorConfirm.Text = ErrorConfirm;


        }

        private void btnConfirm_Click(object sender, EventArgs e)
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
    }
}
