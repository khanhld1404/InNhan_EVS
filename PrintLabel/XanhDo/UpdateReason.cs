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
    public partial class UpdateReason : Form
    {
        public int idUser;
        public int IDReason;

        public UpdateReason()
        {
            InitializeComponent();
        }

        public UpdateReason(int idUser, int iDReason)
        {
            this.idUser = idUser;
            IDReason = iDReason;
            InitializeComponent();
        }

        private void load_DataReason()
        {
            if (IDReason > 0) // Cập nhật reason
            {
                lbHeaderForm.Text = "Cập nhật Reason";
                txtReason.ReadOnly = true; // không cho cập nhật nội dung reason vì nó liên quan đến cái code : other

                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from s in db.tblReason_XD
                                where s.ID == IDReason
                                select s).FirstOrDefault();
                    if (data != null)
                    {
                        txtReason.Text = data.Description;
                        ckActiveReason.Checked = (bool)data.ActiveReason;
                    }

                }
            }
            else // thêm mới lý do
            {
                lbHeaderForm.Text = "Thêm mới Reason";
                txtReason.ReadOnly = false;
                txtReason.Text = string.Empty;
                ckActiveReason.Checked = false;
            }
        }
        private void UpdateReason_Load(object sender, EventArgs e)
        {
            load_DataReason();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Reason = txtReason.Text.Trim();
                if (!string.IsNullOrEmpty(Reason))
                {
                    if (IDReason > 0) // Cập nhật
                    {
                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {
                            // kiểm tra xem Reason đã tồn tại chưa

                            //var dataCheck = (from s in db.tblReason_XDs
                            //                 where s.Description == Reason
                            //                 select s).ToList();
                            //if (dataCheck.Count > 0)
                            //{
                            //    MessageBox.Show("Reason đã tồn tại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                            //else
                            //{
                            tblReason_XD rea = new tblReason_XD();
                            rea = db.tblReason_XD.Where(id => id.ID == IDReason).Single();
                            rea.Description = Reason;
                            rea.ActiveReason = ckActiveReason.Checked;

                            db.SaveChanges();

                            MessageBox.Show("Cập nhật thông tin thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                            //}

                        }
                    }
                    else // Thêm mới
                    {
                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {
                            // kiểm tra xem Reason đã tồn tại chưa

                            var dataCheck = (from s in db.tblReason_XD
                                             where s.Description == Reason
                                             select s).ToList();
                            if (dataCheck.Count > 0)
                            {
                                MessageBox.Show("Reason đã tồn tại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                tblReason_XD rea = new tblReason_XD();
                                rea.Description = Reason;
                                rea.ActiveReason = ckActiveReason.Checked;
                                db.tblReason_XD.Add(rea);
                                db.SaveChanges();

                                MessageBox.Show("Thêm mới reason thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.DialogResult = DialogResult.OK;
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Reason không được phép bỏ trống !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
