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
    public partial class ItemMasterXD : Form
    {
        int _IDUser;
        public ItemMasterXD()
        {
            InitializeComponent();
        }

        public ItemMasterXD(int IDUser)
        {
            _IDUser = IDUser;
            InitializeComponent();
        }

        private void Load_ItemMaster()
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    int pageSize = int.Parse(cboPageSize.SelectedItem.ToString());
                    int pageNumber = Convert.ToInt32(mntxtPage.Text);

                    string contentSearch = txtSearch.Text;

                    var CountALLData = db.pro_XD_04_Itemcheck_XD_CoutRecord(contentSearch).FirstOrDefault().Value;

                    //đếm tất cả dữ liệu
                    int AllData = Convert.ToInt32(CountALLData);

                    ///// tính toán số Page khi phân trang
                    int pageTotal = (int)(AllData / pageSize); // chia lấy phần nguyên

                    int soDuPage = (AllData % pageSize); // chia lấy dư
                    if (soDuPage > 0)
                    {
                        pageTotal = pageTotal + 1;
                    }

                    mnPageTotal.Text = pageTotal.ToString();
                    ////
                   
                    int sttStart = pageSize * (pageNumber - 1) + 1;  //// số thứ tự bắt đầu dữ liệu
                    int sttEnd = pageSize * pageNumber;//// số thứ tự kết thúc dữ liệu (kết thúc page)
                    if(sttEnd > AllData)
                    {
                        sttEnd = AllData;
                    }

                    mnStart_End_Data.Text = string.Format("From {0} to {1} of {2}", sttStart, sttEnd, AllData);




                    string sql = string.Format("exec pro_XD_05_Itemcheck_XD_Search {0},{1},'{2}'", pageSize, pageNumber, contentSearch);

                    DataTable dt = clQuerySQL.getData(sql);

                    gvData.AutoGenerateColumns = false;
                    gvData.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ItemMasterXD_Load(object sender, EventArgs e)
        {
            Load_ItemMaster();
        }

        // thay đổi pageSize
        private void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            mntxtPage.Text = "1";
            Load_ItemMaster();
        }

        #region các hàm điều hướng chuyển page
        // next tới page tiếp theo
        private void mnbtn_NextPage_Click(object sender, EventArgs e)
        {
            try
            {
                int _page = Convert.ToInt32(mntxtPage.Text);
                int _totalPage = Convert.ToInt32(mnPageTotal.Text);

                if (_page < _totalPage)
                {
                    mntxtPage.Text = (_page + 1).ToString();
                }

                Load_ItemMaster();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // next tới page cuối cùng
        private void mnbtn_LastPage_Click(object sender, EventArgs e)
        {
            try
            {
                mntxtPage.Text = mnPageTotal.Text;

                Load_ItemMaster();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // back page trước đó
        private void mnbtn_backPage_Click(object sender, EventArgs e)
        {
            try
            {
                int _page = Convert.ToInt32(mntxtPage.Text);

                if (_page > 1)
                {
                    mntxtPage.Text = (_page - 1).ToString();
                }

                Load_ItemMaster();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // back lại page đầu tiên
        private void mnbtn_FirstPage_Click(object sender, EventArgs e)
        {
            try
            {
                mntxtPage.Text = "1";

                Load_ItemMaster();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        // Tìm kiếm
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_ItemMaster();
        }

        #region sự kiện cellClick - Sửa xóa Item master
        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == gvData.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    int cu = gvData.CurrentCell.RowIndex;
                    int IDItem = Convert.ToInt32(gvData.Rows[cu].Cells["IDItem"].Value.ToString());

                    UpdateItemMaster update = new UpdateItemMaster(_IDUser, IDItem);
                    if(update.ShowDialog() == DialogResult.OK)
                    {
                        Load_ItemMaster();
                    }

                 
                }

                if (e.ColumnIndex == gvData.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    int cu = gvData.CurrentCell.RowIndex;
                    int IDItem = Convert.ToInt32(gvData.Rows[cu].Cells["IDItem"].Value.ToString());
                    string ItemNo = gvData.Rows[cu].Cells["ItemNo"].Value.ToString();
                    if (MessageBox.Show("Bạn muốn xóa master "+ ItemNo,"Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {
                            tblItemCheck_XD item = new tblItemCheck_XD();
                            item = db.tblItemCheck_XD.Where(id => id.IDItem == IDItem).Single();

                            db.tblItemCheck_XD.Remove(item);
                            db.SaveChanges();

                            Load_ItemMaster();



                            MessageBox.Show("Xóa master thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region xuất excel
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
                    var data = (from s in db.tblItemCheck_XD
                                select new {
                                    s.ItemNo,
                                    s.intFrom,
                                    s.intTo
                                }).ToList();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ItemNo",typeof(string));
                    dt.Columns.Add("From",typeof(int));
                    dt.Columns.Add("To",typeof(int));

                 
                    foreach(var item in data)
                    {
                        dt.Rows.Add(item.ItemNo,item.intFrom,item.intTo);
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

        #endregion

        private void btnNew_ItemMaster_Click(object sender, EventArgs e)
        {
            UpdateItemMaster update = new UpdateItemMaster(_IDUser, -1); // thêm mới
            if(update.ShowDialog() == DialogResult.OK)
            {
                Load_ItemMaster();
            }
        }
    }
}
