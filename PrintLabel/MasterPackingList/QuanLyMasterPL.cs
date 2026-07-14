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

namespace PrintLabel.MasterPackingList
{
    public partial class QuanLyMasterPL : Form
    {
        public QuanLyMasterPL()
        {
            InitializeComponent();
        }

        private void QuanLyMasterPL_Load(object sender, EventArgs e)
        {
            loadData_ChungLoai();

            loadData_Thietbi();

            LoadData_ItemMaster();
        }

        #region CHỦNG LOẠI - Thêm mới, Xóa

        private void loadData_ChungLoai()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var data = (from s in db.tblPackingList_ChungLoai
                            where s.idParents == 0
                            select s).ToList();
                gvDataChungLoai.AutoGenerateColumns = false;
                gvDataChungLoai.DataSource = data;
            }
        }

        private void btnNewChungLoai_Click(object sender, EventArgs e)
        {
            try
            {

                formNewChungLoai newChungloai = new formNewChungLoai();
                if (newChungloai.ShowDialog() == DialogResult.OK)
                {
                    loadData_ChungLoai();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // gvcellClick - Xóa chủng loại
        private void gvDataChungLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                // Xoa du lieu bang con
                if (e.ColumnIndex == gvDataChungLoai.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa Chủng Loại này ???", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int cu = gvDataChungLoai.CurrentCell.RowIndex;
                        int idXOa = Convert.ToInt32(gvDataChungLoai.Rows[cu].Cells["idChungLoai"].Value.ToString());


                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {
                            // trước khi xóa phải kiểm tra xem có Thiết bị link tới chủng loại ko
                            var checkDele = (from s in db.tblPackingList_ChungLoai
                                             where s.idParents == idXOa
                                             select s).ToList();
                            if (checkDele.Count > 0)
                            {
                                MessageBox.Show("Lỗi xóa chủng loại, Bạn vui lòng xóa Thiết bị link tới chủng loại cần xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                var deleteCL = db.tblPackingList_ChungLoai.Where(id => id.idChungLoai == idXOa).SingleOrDefault();
                                db.tblPackingList_ChungLoai.Remove(deleteCL);
                                db.SaveChanges();

                                MessageBox.Show("Xóa chủng loại thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                loadData_ChungLoai();

                            }
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


        #region THIẾT BỊ - Thêm, sửa , xóa

        private void loadData_Thietbi()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var data = db.pro_PackingList_04_ListThietBi().ToList();

                gvData_ThietBi.AutoGenerateColumns = false;
                gvData_ThietBi.DataSource = data;
            }
        }

        private void btnNewhietBi_Click(object sender, EventArgs e)
        {
            try
            {
                formEditThietBi f = new formEditThietBi(0);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadData_Thietbi();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvData_ThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // chỉnh sửa thiết bị
                //if (e.ColumnIndex == gvData_ThietBi.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    int cu = gvData_ThietBi.CurrentCell.RowIndex;
                //    int idEdit = Convert.ToInt32(gvData_ThietBi.Rows[cu].Cells["idChungLoai2"].Value.ToString());

                //    formEditThietBi f = new formEditThietBi(idEdit);
                //    if (f.ShowDialog() == DialogResult.OK)
                //    {
                //        loadData_Thietbi();
                //    }

                //}

                // xóa thiết bị
                if (e.ColumnIndex == gvData_ThietBi.Columns["Delete2"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa thiết bị này ???", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int cu = gvData_ThietBi.CurrentCell.RowIndex;
                        int idXOa = Convert.ToInt32(gvData_ThietBi.Rows[cu].Cells["idChungLoai2"].Value.ToString());

                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {
                            // kiểm tra trước khi xóa, xem có item nào link tới thiết bị này ko
                            var checkItem = (from s in db.tblPackingList_Item
                                             where s.idChungLoai == idXOa
                                             select s).ToList();
                            if (checkItem.Count > 0)
                            {
                                MessageBox.Show("Lỗi xóa thiết bị, Bạn vui lòng xóa item master link tới thiết bị này cần xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                var xoaTB = db.tblPackingList_ChungLoai.Where(id => id.idChungLoai == idXOa).SingleOrDefault();
                                db.tblPackingList_ChungLoai.Remove(xoaTB);
                                db.SaveChanges();

                                MessageBox.Show("Xóa thiết bị thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                loadData_Thietbi();

                            }
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



        private void LoadData_ItemMaster()
        {
            try
            {

                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    int pageSize = int.Parse(cboPageSize.SelectedItem.ToString());
                    int pageNumber = Convert.ToInt32(mntxtPage.Text);

                    string contentSearch = txtSearch.Text;

                    var data = db.pro_PackingList_05_ListItemMaster(pageSize, pageNumber, contentSearch).ToList();

                    //đếm tất cả dữ liệu
                    int AllData = db.func_02_PackingList_ListTB_Search(contentSearch).ToList().Count;

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
                    if (sttEnd > AllData)
                    {
                        sttEnd = AllData;
                    }

                    mnStart_End_Data.Text = string.Format("From {0} to {1} of {2}", sttStart, sttEnd, AllData);

                    gvData_ItemMaster.AutoGenerateColumns = false;
                    gvData_ItemMaster.DataSource = data;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            mntxtPage.Text = "1";
            LoadData_ItemMaster();
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

                LoadData_ItemMaster();
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

                LoadData_ItemMaster();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // back lại page trước đó
        private void mnbtn_backPage_Click(object sender, EventArgs e)
        {
            try
            {
                int _page = Convert.ToInt32(mntxtPage.Text);

                if (_page > 1)
                {
                    mntxtPage.Text = (_page - 1).ToString();
                }

                LoadData_ItemMaster();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // chuyển tới page đầu tiên
        private void mnbtn_FirstPage_Click(object sender, EventArgs e)
        {
            try
            {
                mntxtPage.Text = "1";

                LoadData_ItemMaster();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData_ItemMaster();
        }

        private void btnNew_ItemMaster_Click(object sender, EventArgs e)
        {
            try
            {
                formNewItemMaster m = new formNewItemMaster();
                if(m.ShowDialog() == DialogResult.OK)
                {
                    LoadData_ItemMaster();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvData_ItemMaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // xóa thiết bị
                if (e.ColumnIndex == gvData_ItemMaster.Columns["DeleteTB"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa Item master này ???", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int cu = gvData_ItemMaster.CurrentCell.RowIndex;
                        int idXOa = Convert.ToInt32(gvData_ItemMaster.Rows[cu].Cells["idItem"].Value.ToString());

                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {
                            
                                var xoaItem = db.tblPackingList_Item.Where(id => id.idItem == idXOa).SingleOrDefault();
                                db.tblPackingList_Item.Remove(xoaItem);
                                db.SaveChanges();

                                MessageBox.Show("Xóa Item master thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadData_ItemMaster();

                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
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
                        var data = (from s in db.func_02_PackingList_ListTB_Search("")
                                    select new
                                    {
                                        s.STT,
                                        s.ItemCode,
                                        s.ThietBi,
                                        s.ChungLoai
                                    }).ToList();

                        DataTable dt = new DataTable();
                        dt.Columns.Add("STT", typeof(string));
                        dt.Columns.Add("ItemCode", typeof(string));
                        dt.Columns.Add("ThietBi", typeof(string));
                        dt.Columns.Add("ChungLoai", typeof(string));


                        foreach (var item in data)
                        {
                            dt.Rows.Add(item.STT, item.ItemCode, item.ThietBi, item.ChungLoai);
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
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
