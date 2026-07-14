using PrintLabel.clObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel.MasterPackingList
{
    public partial class formSetupPathSavePL : Form
    {
        string pathSetupExport = Application.StartupPath + "\\SettingExport.ini";
        public formSetupPathSavePL()
        {
            InitializeComponent();
        }

        private void formSetupPathSavePL_Load(object sender, EventArgs e)
        {
            

            txtPathExcel.Text = IniFile.ReadValue("PackingList", "PathSaveExcel", pathSetupExport);
            txtPathPDF.Text = IniFile.ReadValue("PackingList", "PathSavePDF", pathSetupExport);
        }

        private void btnPathExcel_Click(object sender, EventArgs e)
        {
            SelectPath(txtPathExcel);
        }

        private void btnPathPDF_Click(object sender, EventArgs e)
        {
            SelectPath(txtPathPDF);
        }

        private void SelectPath(TextBox txt)
        {
            
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Chọn thư mục để lưu file";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txt.Text =  folderDialog.SelectedPath;
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                IniFile.WriteValue("PackingList", "PathSaveExcel", txtPathExcel.Text, pathSetupExport);
                IniFile.WriteValue("PackingList", "PathSavePDF", txtPathPDF.Text, pathSetupExport);

                MessageBox.Show("Cập nhật thông tin thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
