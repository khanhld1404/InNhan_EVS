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

namespace PrintLabel.XanhDo
{
    public partial class HistoryPrintXD : Form
    {
        clExportExcel clexcel = new clExportExcel();
        public HistoryPrintXD()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    DateTime fromDate = dtFrom.Value.Date; // lấy theo ngày, để giờ bắt đầu 00h00
                    DateTime toDate = dtTo.Value.AddDays(1);
                    string keySearch = txtStrKey.Text.Trim();

                    var data = (from s in db.tblHisPrint_XD
                                where (s.DatePrint < toDate && s.DatePrint >= fromDate) &&
                                       (s.strFull.Contains(keySearch) ||
                                        s.UserPrint.Contains(keySearch) ||
                                        s.PCName.Contains(keySearch))
                                select s).ToList();

                    gvDataSearch.AutoGenerateColumns = false;
                    gvDataSearch.DataSource = data;
                    


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Chọn nơi lưu file Excel";
                    saveFileDialog.FileName = "LichSuInNhanQC.xlsx";

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
