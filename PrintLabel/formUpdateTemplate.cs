using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class formUpdateTemplate : Form
    {
        public formUpdateTemplate()
        {
            InitializeComponent();
        }
        string nameFile = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    txtDuongdan.Text = file.FileName;
                    nameFile = Path.GetFileName(txtDuongdan.Text);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string fromFile = txtDuongdan.Text;
                if (nameFile != "JCQ10-EVS025-4.xlsx")
                {
                    MessageBox.Show("Tên file không chính xác \n Để cập nhật Template cho Packing List, vui lòng cập nhật tên file là 'JCQ10-EVS025-4' ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    FileInfo f = new FileInfo("JCQ10-EVS025-4.xlsx");
                    string toFile = f.FullName;

                    File.Copy(fromFile, toFile, true);

                    MessageBox.Show("Cập nhật Template thành công ");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
