using Microsoft.Office.Interop.Excel;
using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel
{
    public partial class formAddEditAccount : Form
    {
        public bool _addUser; //== false la Edit, == true la add user
        int idUser;
        clQuery clquery = new clQuery();
        public formAddEditAccount()
        {
            InitializeComponent();
        }

        public formAddEditAccount(bool addUser, int iduser)
        {
            _addUser = addUser;
            idUser = iduser;
            InitializeComponent();
        }

        private void formAddEditAccount_Load(object sender, EventArgs e)
        {
            if (_addUser == true)
            {
                lbTitle.Text = "Thêm mới tài khoản";
                txtUserName.Enabled = true;
                grChucNang.Visible = false;
            }
            else
            {
                lbTitle.Text = "Cập nhật thông tin tài khoản";
                txtUserName.Enabled = false;
                grChucNang.Visible = true;

                LoadData_Edit();
            }

            // load phân quyền chức năng và danh sách chức năng
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var dsChucNang = (from s in db.tblRoles
                                  select s).ToList();

                cbChucNang.DisplayMember = "CodeRole";
                cbChucNang.ValueMember = "IDRole";
                cbChucNang.DataSource = dsChucNang;

                load_Role_ChucNang();

            }

        }


        /// <summary>
        /// Hàm load Role chức năng theo người dùng
        /// </summary>
        /// <param name="_idUser"></param>
        private void load_Role_ChucNang()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                // load người dùng + phân quyền chức năng, sử dụng left join
                //var dt_User_cn = (from t1 in db.tblUsers
                //                  join t2 in db.tblUser_Role on t1.IDUser equals t2.IDUser into t2Join
                //                  from t2 in t2Join.DefaultIfEmpty() // LEFT JOIN
                //                  join t3 in db.tblRoles on t2.IDRole equals t3.IDRole into t3Join
                //                  from t3 in t3Join.DefaultIfEmpty() // LEFT JOIN
                //                  where t1.IDUser == idUser
                //                  select new
                //                  {
                //                      t1.UserName,
                //                      t1.Code,
                //                      t1.FullName,
                //                      t3.CodeRole,
                //                      t3.NameRole
                //                  }).ToList();
                var dt_User_cn = (from t1 in db.tblUser_Role
                                  join t2 in db.tblRoles on t1.IDRole equals t2.IDRole into t2Join
                                  from t2 in t2Join.DefaultIfEmpty() // LEFT JOIN
                                  where t1.IDUser == idUser
                                  select new
                                  {
                                      t2.IDRole,
                                      t2.CodeRole,
                                      t2.NameRole
                                  }).ToList();

                gvChucNang.AutoGenerateColumns = false;
                gvChucNang.DataSource = dt_User_cn;
            }
        }


        private void LoadData_Edit()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var data = (from s in db.tblUsers
                            where s.IDUser == idUser
                            select s).FirstOrDefault();
                txtUserName.Text = data.UserName;
                txtCode.Text = data.Code;
                txtFullName.Text = data.FullName;
                txtRemark.Text = data.Remark;
              
                //if (data.Active == true)
                //{
                //    ckActive.Checked = true;
                //}
                //else
                //{
                //    ckActive.Checked = false;
                //}

                //if (data.Admin == true)
                //{
                //    ckAdmin.Checked = true;
                //}
                //else
                //{
                //    ckAdmin.Checked = false;
                //}

                ckActive.Checked = data.Active ?? false;
                ckAdmin.Checked = data.Admin ?? false;
                ckLeaderSX.Checked = data.LeaderSX ?? false;

            }
        }
        private bool checkUserName_Code(string username, string code)
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from s in db.tblUsers
                                where s.UserName == username || s.Code == code
                                select s).ToList();
                    if (data.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return true;
            }
        }

        #region hàm lưu thông tin user: sửa + thêm mới
        private void brnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = txtPassword.Text.Trim();

                if (_addUser == true) // add User
                {
                    if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtFullName.Text))
                    {
                        MessageBox.Show("Vui lòng nhập Username, CodeUser và FullName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (checkUserName_Code(txtUserName.Text, txtCode.Text) == true) // đã tồn tại UserName hoặc COde user 
                        {
                            MessageBox.Show("UserName hoặc Code đã tồn tại. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                            {
                                tblUser user = new tblUser();
                                user.UserName = txtUserName.Text;

                                if (!clQuery.IsValidPassword(pass))
                                {
                                    MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự và chứa ít nhất 1 ký tự đặc biệt !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    user.Password = clQuery.GetMD5(pass);
                                    user.Code = txtCode.Text;
                                    user.FullName = txtFullName.Text;
                                    user.Active = true;

                                    user.Admin = ckAdmin.Checked;
                                    user.LeaderSX = ckLeaderSX.Checked;

                                    user.Register = DateTime.Now;
                                    user.DateChangePass = DateTime.Now; //DateTime.Now.AddMonths(3); // yc thay đổi mk sau khi tạo

                                    user.Remark = txtRemark.Text;
                                    db.tblUsers.Add(user);
                                    db.SaveChanges();

                                    MessageBox.Show("Thêm tài khoản thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // chỗ này là load lại form chuyển sang chế độ chỉnh sửa user để thêm quyền

                                    idUser = user.IDUser;
                                    _addUser = false;
                                    formAddEditAccount_Load(sender,null); // gọi lại hàm load form
                                    txtPassword.Text = string.Empty;
                                    

                                }

                            }
                        }

                    }
                }
                else //Edit
                {

                    using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                    {
                        tblUser user = new tblUser();

                        user = db.tblUsers.Where(id => id.IDUser == idUser).Single();

                        if (!string.IsNullOrEmpty(pass)) // Neu la reset mat khau
                        {
                            if (!clQuery.IsValidPassword(pass))
                            {
                                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự và chứa ít nhất 1 ký tự đặc biệt !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                user.Password = clQuery.GetMD5(txtPassword.Text);
                                user.DateChangePass = DateTime.Now; // DateTime.Now.AddMonths(3); // yc ng dùng thay đổi mk sau khi thay đổi
                            }
                        }



                        user.Code = txtCode.Text;
                        user.FullName = txtFullName.Text;

                        user.Active = ckActive.Checked;
                        user.Admin = ckAdmin.Checked;
                        user.LeaderSX = ckLeaderSX.Checked;

                        user.Remark = txtRemark.Text;
                        db.SaveChanges();

                        MessageBox.Show("Cập nhật tài khoản thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                    }

                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.DialogResult = DialogResult.OK;
        }

        #region hàm thêm quyền chức năng cho user
        private void btnThemChucNang_Click(object sender, EventArgs e)
        {
            try
            {

                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    int idRole = Convert.ToInt32(cbChucNang.SelectedValue.ToString());

                    // kiểm tra xem đã có quyền này chưa
                    var dtcheck = (from s in db.tblUser_Role
                                   where s.IDUser == idUser &&
                                         s.IDRole == idRole
                                   select s).ToList().Count;
                    if (dtcheck > 0)
                    {
                        MessageBox.Show("Quyền chức năng đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        tblUser_Role ur = new tblUser_Role();
                        ur.IDUser = idUser;
                        ur.IDRole = idRole;

                        db.tblUser_Role.Add(ur);
                        db.SaveChanges();

                        load_Role_ChucNang();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        #endregion



        private void gvChucNang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gvChucNang.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Bạn muốn xóa quyền chức năng ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int cu = gvChucNang.CurrentCell.RowIndex;
                        int idRole = Convert.ToInt32(gvChucNang.Rows[cu].Cells["IDRole"].Value.ToString());

                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {
                            var del = db.tblUser_Role.Where(id => id.IDUser == idUser && id.IDRole == idRole).SingleOrDefault();

                            db.tblUser_Role.Remove(del);
                            db.SaveChanges();

                            load_Role_ChucNang();

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
