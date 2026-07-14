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
    public partial class formEditThietBi : Form
    {
        public int _idChungLoaiEdit;


        public formEditThietBi(int idChungLoai)
        {
            this._idChungLoaiEdit = idChungLoai;


            InitializeComponent();
        }

        public formEditThietBi()
        {
            InitializeComponent();
        }

        private void formEditThietBi_Load(object sender, EventArgs e)
        {
            loadData_ChungLoai();

            if (_idChungLoaiEdit > 0) // Cập nhật data
            {
                txtTenThietBi.Enabled = false;
                cboChungLoai.Enabled = false;
                lbHeader.Text = "Chỉnh sửa thiết bị";
                LoadData_ChinhSua();
            }
            else
            {
                txtTenThietBi.Enabled = true;
                cboChungLoai.Enabled = true;
                lbHeader.Text = "Thêm mới thiết bị";
            }
        }

        private void loadData_ChungLoai()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var dada = (from s in db.tblPackingList_ChungLoai
                            where s.idParents == 0
                            select s).ToList();
                cboChungLoai.DataSource = dada;
                cboChungLoai.DisplayMember = "TenChungLoai";
                cboChungLoai.ValueMember = "idChungLoai";
            }
        }

        private bool check_TenThietBi_TonTai(string tenTB, int idParents)
        {
            bool result = true;

            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                // kiểm tra xem thiết bị đã tồn tại chưa
                var checkTB = (from s in db.tblPackingList_ChungLoai
                               where s.TenChungLoai == tenTB &&
                                     s.idParents == idParents
                               select s).ToList();

                if (checkTB.Count > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                return result;

            }
        }


        private void LoadData_ChinhSua()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var data = (from s in db.tblPackingList_ChungLoai
                            where s.idChungLoai == _idChungLoaiEdit
                            select s).FirstOrDefault();

                cboChungLoai.SelectedValue = data.idParents;
                txtTenThietBi.Text = data.TenChungLoai;
              

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ThietBiMoi = txtTenThietBi.Text.Trim();
                int _idParents = Convert.ToInt32(cboChungLoai.SelectedValue.ToString());

                if (_idChungLoaiEdit == 0) // Thêm mới thiết bị
                {

                    if (!string.IsNullOrEmpty(ThietBiMoi))
                    {
                        using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                        {
                            // kiểm tra xem thiết bị đã tồn tại chưa
                            //var checkTB = (from s in db.tblPackingList_ChungLoais
                            //               where s.TenChungLoai == ThietBiMoi &&
                            //                     s.idParents == _idParents
                            //               select s).ToList();
                            bool checkTB = check_TenThietBi_TonTai(ThietBiMoi, _idParents);
                            if (checkTB == true)
                            {
                                MessageBox.Show("Tên thiết bị đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                tblPackingList_ChungLoai tb = new tblPackingList_ChungLoai();
                                tb.idParents = _idParents;
                                tb.TenChungLoai = ThietBiMoi;
                               

                                db.tblPackingList_ChungLoai.Add(tb);
                                db.SaveChanges();
                                MessageBox.Show("Thêm mới thiết bị thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập tên thiết bị", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Chỉnh sửa thiết bị
                {

                    using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                    {
                        var cs = db.tblPackingList_ChungLoai.Where(id => id.idChungLoai == _idChungLoaiEdit).SingleOrDefault();

                        db.SaveChanges();
                        MessageBox.Show("Chỉnh sửa thiết bị thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
