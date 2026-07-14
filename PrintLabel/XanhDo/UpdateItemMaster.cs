using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.XanhDo
{
    public partial class UpdateItemMaster : Form
    {
        public int IDUser;

        // IDItem = -1 -> thêm mới
        //IDItem > 0 cập nhật Item master

        public int IDItem;

        public UpdateItemMaster()
        {
            InitializeComponent();
        }

        public UpdateItemMaster(int iDUser, int iDItem)
        {
            IDUser = iDUser;
            IDItem = iDItem;
            InitializeComponent();
        }



        private void UpdateItemMaster_Load(object sender, EventArgs e)
        {
            load_ItemMaster();
        }

        private void load_ItemMaster()
        {
            if (IDItem > 0) // Cập nhật master
            {
                lbHeaderForm.Text = "Cập nhật master";

                txtItemNo.ReadOnly = true; // -> không cho cập nhật item master -> sai-> xóa -> thêm mới master

                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from s in db.tblItemCheck_XD
                                where s.IDItem == IDItem
                                select s).FirstOrDefault();
                    if (data != null)
                    {
                        txtItemNo.Text = data.ItemNo;
                        numericFrom.Value = (int)data.intFrom;
                        numericTo.Value = (int)data.intTo;
                    }
                }
            }
            else
            {
                lbHeaderForm.Text = "Thêm mới master";
                txtItemNo.ReadOnly = false;

                txtItemNo.Text = string.Empty;
                numericFrom.Value = 0;
                numericTo.Value = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ItemNo = txtItemNo.Text.Trim();
                if (!string.IsNullOrEmpty(ItemNo))
                {
                    int _from = int.Parse(numericFrom.Value.ToString());
                    int _to = int.Parse(numericTo.Value.ToString());

                    if (_from > _to)
                    {
                        MessageBox.Show("Nhập sai chiều dài sản phẩm !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (IDItem > 0) // Cập nhật master
                        {
                            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                            {
                                tblItemCheck_XD item = new tblItemCheck_XD();
                                item = db.tblItemCheck_XD.Where(id => id.IDItem == IDItem).Single();
                                item.intFrom = _from;
                                item.intTo = _to;

                                db.SaveChanges();

                                MessageBox.Show("Cập nhật thông tin thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.DialogResult = DialogResult.OK;
                            }
                          
                        }
                        else // Thêm mới master
                        {
                            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                            {
                                // kiểm tra xem itemNo đã tồn tại chưa

                                var dataCheck = (from s in db.tblItemCheck_XD
                                                 where s.ItemNo == ItemNo
                                                 select s).ToList();
                                if (dataCheck.Count > 0)
                                {
                                    MessageBox.Show("Mã ItemNo đã tồn tại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    tblItemCheck_XD item = new tblItemCheck_XD();
                                    item.ItemNo = txtItemNo.Text;
                                    item.intFrom = _from;
                                    item.intTo = _to;
                                    db.tblItemCheck_XD.Add(item);
                                    db.SaveChanges();

                                    MessageBox.Show("Thêm mới master thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.DialogResult = DialogResult.OK;
                                }

                              
                            }
                        }

                      
                    }

                    
                }
                else
                {
                    MessageBox.Show("ItemNo không được phép bỏ trống !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

          


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
