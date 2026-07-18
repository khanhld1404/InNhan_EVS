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
    public partial class Setting_Printer_TAS : Form
    {
        public Setting_Printer_TAS()
        {
            InitializeComponent();
        }
          
        clQuery cl = new clQuery();

        //string strShowSetting = "0";

        private void Setting_Printer_TAS_Load(object sender, EventArgs e)
        {
            txtPrintName.Text = cl.ReadFileTAS(0, "Setting_TAS.txt"); // Đọc dòng đầu tiên
            txtCopies.Text = cl.ReadFileTAS(1, "Setting_TAS.txt"); // Đọc dòng thứ 2
            txtHeSoBarcode.Text = cl.ReadFileTAS(2, "Setting_TAS.txt");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrintName.Text) && !string.IsNullOrEmpty(txtCopies.Text))
            {
                cl.WriteFileTAS(txtPrintName.Text, txtCopies.Text, txtHeSoBarcode.Text, "Setting_TAS.txt");
                MessageBox.Show("Save thành công.\n Đăng xuất phần mềm và bật lại để lưu thay đổi cài đặt");
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không đầy đủ", "Setting False", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
    }
}
