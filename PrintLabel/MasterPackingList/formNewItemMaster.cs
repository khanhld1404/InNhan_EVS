using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.MasterPackingList
{
    public partial class formNewItemMaster : Form
    {
        public formNewItemMaster()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void formNewItemMaster_Load(object sender, EventArgs e)
        {
            loadData_cbChungLoai();
        }
        private void loadData_cbChungLoai()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var data = db.func_01_PackingList_ListTB().ToList();

                cbChungLoaiThietBi.DataSource = data;
                cbChungLoaiThietBi.DisplayMember = "ChungLoai_ThietBi";
                cbChungLoaiThietBi.ValueMember = "idChungLoai";


            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string newItemMaster = txtItemMaster.Text.Trim();
                if (!string.IsNullOrEmpty(newItemMaster))
                {
                    // kiểm tra xem Item master đã tồn tại chưa
                    using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                    {
                        // kiêm tra xem item master đã tồn tại chưa
                        var dataCheck = (from s in db.tblPackingList_Item
                                         where s.ItemCode == newItemMaster
                                         select s).ToList();
                        if (dataCheck.Count > 0)
                        {
                            MessageBox.Show("Mã ItemCode đã tồn tại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tblPackingList_Item item = new tblPackingList_Item();
                            item.idChungLoai = Convert.ToInt32(cbChungLoaiThietBi.SelectedValue.ToString());
                            item.ItemCode = newItemMaster;
                            db.tblPackingList_Item.Add(item);
                            db.SaveChanges();

                            MessageBox.Show("Thêm mới thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                     
                    }
                    
                }
                else
                {
                    MessageBox.Show("Nhập mã Item !" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
