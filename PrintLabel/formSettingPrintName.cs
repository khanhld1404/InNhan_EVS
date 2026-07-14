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
    public partial class formSettingPrintName : Form
    {
        public formSettingPrintName()
        {
            InitializeComponent();
        }

        clQuery cl = new clQuery();

        //string strShowSetting = "0";

        private void formSettingPrintName_Load(object sender, EventArgs e)
        {
            txtPrintName.Text = cl.ReadFile(0); // Đọc dòng đầu tiên
            txtCopies.Text = cl.ReadFile(1); // Đọc dòng thứ 2
            txtDong.Text = cl.ReadFile(2);
            txtWO.Text = cl.ReadFile(3);
            txtID.Text = cl.ReadFile(4);
            txtItem.Text = cl.ReadFile(5);
            txtMaxPackingList.Text = cl.ReadFile(6);
            txtShowSetting.Text = cl.ReadFile(7);
            txtHeSoBarcode.Text = cl.ReadFile(8);
            txtRevision.Text = cl.ReadFile(9);
            txtPathSavePackingList.Text = cl.ReadFile(10);

            // show cac setting khac
            showSetting();
        }






        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrintName.Text) && !string.IsNullOrEmpty(txtCopies.Text))
            {
                cl.WriteFile(txtPrintName.Text, txtCopies.Text, txtDong.Text, txtWO.Text, txtID.Text, txtItem.Text,txtMaxPackingList.Text,txtShowSetting.Text,txtHeSoBarcode.Text,txtRevision.Text,txtPathSavePackingList.Text);
                MessageBox.Show("Save thành công.\n Đăng xuất phần mềm và bật lại để lưu thay đổi cài đặt");
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không đầy đủ", "Setting False", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void showSetting()
        {
            try
            {
                if(txtShowSetting.Text == "1")
                {
                    grSetting.Visible = true;
                }
                else
                {
                    grSetting.Visible = false;
                }
            }
            catch (Exception ex)
            {
                grSetting.Visible = false;
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
