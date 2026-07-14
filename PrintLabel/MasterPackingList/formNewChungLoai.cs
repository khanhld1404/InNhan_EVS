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
    public partial class formNewChungLoai : Form
    {
       
        public formNewChungLoai()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string TenChungLoaiMoi = txtTenChungLoai.Text.Trim();
            if (!string.IsNullOrEmpty(TenChungLoaiMoi))
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    
                    // thêm chủng loại mới

                    // kiểm tra xem tên chủng loại đã có chưa
                    var checkCL = (from s in db.tblPackingList_ChungLoai
                                   where s.TenChungLoai.ToLower() == TenChungLoaiMoi.ToLower() &&
                                         s.idParents == 0
                                   select s).ToList();
                    if (checkCL.Count > 0)
                    {
                        MessageBox.Show("Tên chủng loại đã tồn tại trong hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        tblPackingList_ChungLoai cl = new tblPackingList_ChungLoai();
                        cl.idParents = 0;
                        cl.TenChungLoai = TenChungLoaiMoi;
                        db.tblPackingList_ChungLoai.Add(cl);
                        db.SaveChanges();

                        MessageBox.Show("Thêm chủng loại mới thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                    }
                }



                   
            }
            else
            {
                MessageBox.Show("Nhập tên chủng loại", "Nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
