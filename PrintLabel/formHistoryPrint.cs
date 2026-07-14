using PrintLabel.Database;
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
    public partial class formHistoryPrint : Form
    {

        clExportExcel clexcel = new clExportExcel();
        public formHistoryPrint()
        {
            InitializeComponent();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    DateTime fromDate = dtFrom.Value;
                    DateTime toDate = dtTo.Value;
                    string keySearch = txtStrKey.Text.Trim();

                    var data = db.pro_HistoryPrint_Barcode_v3(fromDate, toDate, keySearch);
                    gvDataSearch.AutoGenerateColumns = false;
                    gvDataSearch.DataSource = data;


                    gvDataSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    //gvDataSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    // gvDataSearch.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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
                #region code cũ
                /*
                DateTime fromDate = dtFrom.Value;
                DateTime toDate = dtTo.Value;
                string WO_No = txtWO_No.Text;
                string ID_No = txtID_No.Text;
                string Item_No = txtItem_No.Text;

               


                string outputDirectory = "C:\\";
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Select URL for Save file";
                    dialog.SelectedPath = outputDirectory;
                    dialog.ShowNewFolderButton = true; //Cho phép tạo folder mới

                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        outputDirectory = dialog.SelectedPath;
                    }
                    else
                    {
                        return;
                    }
                }
                DirectoryInfo outputDir = new DirectoryInfo(outputDirectory);
                string output = clExportExcel.ExportExcel_HistoryPrint(new FileInfo("HistoryPrintTemplate.xlsx"), outputDir, fromDate, toDate, WO_No, ID_No, Item_No);
                MessageBox.Show("Export Complete");

                //if(MessageBox.Show("Bạn có muốn xóa dữ liệu sau khi xuất ra file ???", "Question", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                //{
                //    HamXoaData_SauKhiXuatFile();
                //    btnSearch_Click(sender, e);
                //}
                */
                #endregion

                try
                {

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Chọn nơi lưu file Excel";
                        saveFileDialog.FileName = "LichSuInNhan.xlsx";

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void delete_his(int idHis)
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                tblHistoryPrint tblhis = new tblHistoryPrint();
                tblhis = db.tblHistoryPrints.Where(id => id.IDHisPrint == idHis).Single();

                db.tblHistoryPrints.Add(tblhis);
                db.SaveChanges();
            }
        }
        private void HamXoaData_SauKhiXuatFile()
        {
            foreach (DataGridViewRow row in gvDataSearch.Rows)
            {
                int idHis = Convert.ToInt32(row.Cells["IDHisPrint"].FormattedValue.ToString());

                delete_his(idHis);
            }
            MessageBox.Show("Xóa dữ liệu thành công");

        }


    }
}
