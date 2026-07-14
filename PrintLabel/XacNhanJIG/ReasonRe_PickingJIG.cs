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
    public partial class ReasonRe_PickingJIG : Form
    {
        public string JigMaster { get; set; }
        public string ReasonRePicking { get; set; }

        public ReasonRe_PickingJIG(string jigMaster)
        {
            JigMaster = jigMaster;
            InitializeComponent();
        }

        public ReasonRe_PickingJIG()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string reason = txtReason.Text;
            if (!string.IsNullOrEmpty(reason))
            {
                ReasonRePicking = txtReason.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập lý do xuất lại Jig ! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ReasonRe_PickingJIG_Load(object sender, EventArgs e)
        {
            txtJIGMaster.Text = JigMaster;
            txtReason.Focus();
        }
    }
}
