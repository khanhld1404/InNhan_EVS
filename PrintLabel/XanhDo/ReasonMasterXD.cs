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

namespace PrintLabel.XanhDo
{
    public partial class ReasonMasterXD : Form
    {
        int IDUser;
        public ReasonMasterXD()
        {
            InitializeComponent();
        }

        public ReasonMasterXD(int iDUser)
        {
            IDUser = iDUser;
            InitializeComponent();
        }

        private void ReasonMasterXD_Load(object sender, EventArgs e)
        {
            Load_Reason();
        }

        private void Load_Reason()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                string contentSearch = txtSearch.Text.Trim();
                var data = db.pro_XD_06_ReasonXD_search(contentSearch).ToList();

                gvData.AutoGenerateColumns = false;
                gvData.DataSource = data;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_Reason();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
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

                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from s in db.tblReason_XD
                                where s.ActiveReason == true
                                select new
                                {
                                    s.Description
                                }).ToList();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Reason", typeof(string));



                    foreach (var item in data)
                    {
                        dt.Rows.Add(item.Description);
                    }

                    clExportExcel.Data_ExportExcel(dt, outputDir);

                    MessageBox.Show("Xuất file thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gvData.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int cu = gvData.CurrentCell.RowIndex;
                    int IDReason = Convert.ToInt32(gvData.Rows[cu].Cells["ID"].Value.ToString());

                    UpdateReason update = new UpdateReason(IDUser, IDReason);
                    if(update.ShowDialog() == DialogResult.OK)
                    {
                        Load_Reason();
                    }

                }

                if (e.ColumnIndex == gvData.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int cu = gvData.CurrentCell.RowIndex;
                    int IDReason = Convert.ToInt32(gvData.Rows[cu].Cells["ID"].Value.ToString());

                    string reason = gvData.Rows[cu].Cells["Description"].Value.ToString();

                    if (MessageBox.Show("Bạn muốn xóa Reason " + reason, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {

                            tblReason_XD rea = new tblReason_XD();
                            rea = db.tblReason_XD.Where(id => id.ID == IDReason).Single();

                            db.tblReason_XD.Remove(rea);
                            db.SaveChanges();

                            Load_Reason();

                            MessageBox.Show("Xóa reason thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Reason_Click(object sender, EventArgs e)
        {
            UpdateReason update = new UpdateReason(IDUser, -1); // thêm mới
            if (update.ShowDialog() == DialogResult.OK)
            {
                Load_Reason();
            }
        }
    }
}
