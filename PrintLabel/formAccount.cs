using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class formAccount : Form
    {
        public formAccount()
        {
            InitializeComponent();
        }

        bool addUser = false; //== false la Edit, == true la add user

        clExportExcel clexcel = new clExportExcel();
        private void formAccount_Load(object sender, EventArgs e)
        {
            loadDataUser();
        }

        private void loadDataUser()
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from s in db.tblUsers
                                select s).ToList();

                    gvAccount.AutoGenerateColumns = false;
                    gvAccount.DataSource = data;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            addUser = true;
            formAddEditAccount f = new formAddEditAccount(addUser, 0);

            if (f.ShowDialog() == DialogResult.OK)
            {
                btnSearch_Click(sender, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from s in db.tblUsers
                                where s.UserName.Contains(search) ||
                                      s.Code.Contains(search) ||
                                      s.FullName.Contains(search)
                                select s).ToList();
                    gvAccount.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gvAccount.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int cu = gvAccount.CurrentCell.RowIndex;
                    int idAcc = Convert.ToInt32(gvAccount.Rows[cu].Cells["IDUser"].Value.ToString());

                    addUser = false;
                    formAddEditAccount f = new formAddEditAccount(addUser, idAcc);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        btnSearch_Click(sender, null);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from a in db.tblUsers
                                join b in db.tblUser_Role on a.IDUser equals b.IDUser
                                join c in db.tblRoles on b.IDRole equals c.IDRole
                                where a.Active == true
                                select new
                                {
                                    a.UserName,
                                    a.Code,
                                    a.FullName,
                                    a.LeaderSX,
                                    a.Admin,
                                    a.Remark,
                                    a.DateChangePass,
                                    c.CodeRole,
                                    c.NameRole
                                }).ToList();

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Chọn nơi lưu file Excel";
                        saveFileDialog.FileName = "ThongTinTaiKhoan.xlsx";
                        //saveFileDialog.OverwritePrompt = true;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            await Task.Run(() => {
                                clexcel.ExportLinQ_To_Excel_EPPlus(data, filePath, "DS_TaiKhoan");
                            });

                            


                            MessageBox.Show("Xuất thông tin thành công","Xuất thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
