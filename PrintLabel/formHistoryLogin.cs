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
    public partial class formHistoryLogin : Form
    {
        public formHistoryLogin()
        {
            InitializeComponent();
        }
        clExportExcel clexcel = new clExportExcel();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    DateTime fromDate = dtFrom.Value;
                    DateTime toDate = dtTo.Value;

                    var data = db.pro_HistoryLogin_v3(fromDate, toDate, txtStrKey.Text);
                    gvDataSearch.AutoGenerateColumns = false;
                    gvDataSearch.DataSource = data;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Chọn nơi lưu file Excel";
                    saveFileDialog.FileName = "LichSuDangNhap.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                       clexcel.ExportDataGridViewToExcel_EPPlus(gvDataSearch, filePath);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
