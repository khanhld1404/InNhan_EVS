using Microsoft.Office.Interop.Excel;
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
    public partial class formCreatePL : Form
    {
        clQuery clquery = new clQuery();
        int idUser = 0;
        bool Admin;
        string UserName;
        int IDHistotyLogin = 0;
        string _FullName;

        bool LeaderSX = false;

        #region ẩn button close
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion
        public formCreatePL(int idUser, bool admin, string userName, int idHisLogin, string _fullName)
        {
            this.idUser = idUser;
            this.Admin = admin;
            this.UserName = userName;
            this.IDHistotyLogin = idHisLogin;
            this._FullName = _fullName;

            InitializeComponent();

        }

        public formCreatePL()
        {
            InitializeComponent();
        }

        private void formCreatePL_Load(object sender, EventArgs e)
        {
            menuAccount.Text = string.Format("{0} ({1})", _FullName, UserName);

            LeaderSX = clquery.check_Leader_User(idUser);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from s in db.tblPackingList_02
                                where s.ThayThePL == false // không load ra những thằng đã bị thay thế
                                orderby s.DateTimeCreated descending
                                select s).Take(100).ToList();
                    gvData.AutoGenerateColumns = false;
                    gvData.DataSource = data;
                    //gvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //gvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCreatePL_Click(object sender, EventArgs e)
        {
            try
            {

                formCreatePLChonChungLoai chon = new formCreatePLChonChungLoai(false);
                if (chon.ShowDialog() == DialogResult.OK)
                {
                    string ChungLoai = chon.ChungLoai;
                    string DongThung = chon.DongThung;
                    string MaPL = chon.MaPL;
                    string MaPL_excel = chon.MaPL_Excel;

                    formNewPackingList newPL = new formNewPackingList(idUser, ChungLoai, DongThung, MaPL, UserName, _FullName,0,null, MaPL_excel, 0,null,null);
                    newPL.ShowDialog();


                }
                else // cancel
                {
                    //MessageBox.Show("Cancel");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                
                if (e.ColumnIndex == gvData.Columns["ViewDetail"].Index && e.RowIndex >= 0)
                {
                    int cu = gvData.CurrentCell.RowIndex;
                    int idPL = Convert.ToInt32(gvData.Rows[cu].Cells["IdPL"].Value.ToString());

                    MasterPackingList.form_DetailPackingList de = new MasterPackingList.form_DetailPackingList(idPL,idUser);
                    de.ShowDialog();
                }

                if (e.ColumnIndex == gvData.Columns["ReCreatePackingList"].Index && e.RowIndex >= 0)
                {
                    int cu2 = gvData.CurrentCell.RowIndex;
                    int idPL_OLD = Convert.ToInt32(gvData.Rows[cu2].Cells["IdPL"].Value.ToString());
                    string maPL_OLD = gvData.Rows[cu2].Cells["MaPL"].FormattedValue.ToString();

                    // chỗ này cho chọn lại chủng loại -> vì có thể bất thường chủng loại
                    formCreatePLChonChungLoai chon = new formCreatePLChonChungLoai(true);
                    if (chon.ShowDialog() == DialogResult.OK)
                    {
                        string ChungLoai = chon.ChungLoai;
                        string DongThung = chon.DongThung;
                        string MaPL = chon.MaPL;
                        string MaPL_excel = chon.MaPL_Excel;

                        formNewPackingList rePL = new formNewPackingList(idUser, ChungLoai, DongThung, MaPL, UserName, _FullName, idPL_OLD, maPL_OLD, MaPL_excel,0, null, null);
                        rePL.ShowDialog();

                    }


                }

                //if (e.ColumnIndex == gvData.Columns["MaPL_OLD"].Index && e.RowIndex >= 0)
                //{
                //    //int cu3 = gvData.CurrentCell.RowIndex;
                //    //int idPL_OLD = Convert.ToInt32(gvData.Rows[cu3].Cells["idPL_OLD"].Value.ToString());

                //    //if (idPL_OLD > 0)
                //    //{
                //    //    MasterPackingList.form_DetailPackingList de = new MasterPackingList.form_DetailPackingList(idPL_OLD);
                //    //    de.ShowDialog();
                //    //}

                    
                //}




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #region Link menu 

        private void mnMasterPackingList_Click(object sender, EventArgs e)
        {
            if (Admin)
            {
                MasterPackingList.QuanLyMasterPL ql = new MasterPackingList.QuanLyMasterPL();
                ql.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnUpdateMasterPackingList_Click(object sender, EventArgs e)
        {
            if (Admin)
            {
                formUpdateTemplate formUpdate = new formUpdateTemplate();
                formUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void menuDefaultFunc_Click(object sender, EventArgs e)
        {
            if (Admin)
            {
                XanhDo.SetupFuncDefault se = new XanhDo.SetupFuncDefault(idUser, IDHistotyLogin, _FullName, UserName, Admin);
                se.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                clquery.User_ChangePassword(idUser);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuThongTin_Click(object sender, EventArgs e)
        {
            formAbout about = new formAbout();
            about.ShowDialog();
        }

        private void menuHistory_Click(object sender, EventArgs e)
        {

        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            // Lưu thời gian logOut
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                tblHistoryLogin lo = new tblHistoryLogin();
                lo = db.tblHistoryLogins.Where(id => id.IDHistory == IDHistotyLogin).Single();
                lo.DateLogout = DateTime.Now;
                lo.TimeLogout = DateTime.Now;
                db.SaveChanges();
            }

            this.Dispose();
            this.Close();
            //Application.Exit();
            System.Windows.Forms.Application.Restart();
        }

        
        // menu cài đặt đường dẫn file packing list
        private void menuPathSaveFile_Click(object sender, EventArgs e)
        {
            if (Admin || LeaderSX)
            {
                MasterPackingList.formSetupPathSavePL se = new MasterPackingList.formSetupPathSavePL();
                se.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    string search = txtSearch.Text.Trim();
                    var data = db.pro_PackingList_07_SearchPL(search).ToList();

                    gvData.AutoGenerateColumns = false;
                   
                    gvData.DataSource = data;
                    //gvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void menuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (Admin || LeaderSX)
            {
                formAccount acc = new formAccount();
                acc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
