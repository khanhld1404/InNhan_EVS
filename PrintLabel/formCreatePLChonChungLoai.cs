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
    public partial class formCreatePLChonChungLoai : Form
    {
        bool XuatLaiPL; // trường hợp xuất lại Packing list thì được phép trùng mã PL
        public formCreatePLChonChungLoai(bool _xuatLaiPL)
        {
            this.XuatLaiPL = _xuatLaiPL;
            InitializeComponent();
        }
        //public formCreatePLChonChungLoai()
        //{
        //    InitializeComponent();
        //}

        public string ChungLoai { get; set; }
        public string DongThung { get; set; }

        public string MaPL { get; set; }
        public string MaPL_Excel { get; set; }


        private void formCreatePLChonChungLoai_Load(object sender, EventArgs e)
        {
            loadData_ChungLoai();
        }

        private void loadData_ChungLoai()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                //lấy chủng loại (cha)
                var data = (from s in db.tblPackingList_ChungLoai
                            where s.idParents == 0
                            select s).ToList();

                ////data.Insert(0, new tblPackingList_ChungLoai({ idChungLoai = 0, TenChungLoai = "--Chọn chủng loại--" }));

                //cboChungLoai.Items.Insert(0, new { idChungLoai = 0, TenChungLoai = "--Chọn chủng loại--" });

                //foreach (var item in data)
                //{
                //    cboChungLoai.Items.Add(new { item.idChungLoai, item.TenChungLoai });
                //}


                cboChungLoai.DataSource = data;
                cboChungLoai.DisplayMember = "TenChungLoai"; //TenChungLoai
                cboChungLoai.ValueMember = "idChungLoai"; //idChungLoai

                //  cboChungLoai.SelectedIndex = 0;




            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ChungLoai = cboChungLoai.Text;
            DongThung = string.Join(",", clbThietBi.CheckedItems.Cast<object>().Select(item => item.ToString()));
            string _maPL1 = txtMaPL1.Text.Trim();
            string _maPL2 = txtMaPL2.Text.Trim();
            string _maPL3 = txtMaPL3.Text.Trim();
            string _maPL4 = txtMaPL4.Text.Trim();

            MaPL = string.Format("{0}-{1}-{2}/{3}", _maPL1, _maPL2, _maPL3, _maPL4);
            MaPL_Excel = string.Format("{0}-{1}-{2}.{3}", _maPL1, _maPL2, _maPL3, _maPL4);


            if (!string.IsNullOrEmpty(ChungLoai) && !string.IsNullOrEmpty(DongThung) && !string.IsNullOrEmpty(_maPL2) && !string.IsNullOrEmpty(_maPL3) && !string.IsNullOrEmpty(_maPL4))
            {
                // kiểm tra xem mã Packing list đã tồn tại chưa
                // chỉ kiểm tra ở bảng tblPackingList_02
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = (from s in db.tblPackingList_02
                                where s.MaPL == MaPL
                                select s).ToList().Count;
                    if (data > 0 && XuatLaiPL == false)
                    {
                        MessageBox.Show("Mã danh sách đóng thùng đã tồn tại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lỗi xác nhận Chủng loại, thiết bị", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // load data thiết bị từ chủng loại
        private void cboChungLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            int idChungLoai = 0;
            var selectValue = cboChungLoai.SelectedValue;
            clbThietBi.Items.Clear();
            string text_CL = cboChungLoai.Text.Substring(0, 2).ToUpper();
            string time_CL = DateTime.Now.ToString("yyMMdd");
            txtMaPL1.Text = string.Format("{0}-{1}", text_CL, time_CL);

            if (selectValue is int)
            {
                idChungLoai = Convert.ToInt32(cboChungLoai.SelectedValue.ToString());
                // load data thiết bị
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    //var data = db.pro_PackingList_01_load_QuyCachDongThungTB(idChungLoai).ToList();

                    //cboThietBi.DisplayMember = "DongThung";
                    //cboThietBi.ValueMember = "DongThung";
                    //cboThietBi.DataSource = data;


                    var dataCheckBoxList = (from s in db.tblPackingList_ChungLoai
                                            where s.idParents == idChungLoai
                                            select s).ToList();

                    if (dataCheckBoxList.Count > 0)
                    {
                        foreach (var item in dataCheckBoxList)
                        {
                            clbThietBi.Items.Add(item.TenChungLoai);
                        }

                    }
                }
            }

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string selectedItems = string.Join(",", clbThietBi.CheckedItems.Cast<object>().Select(item => item.ToString()));
        //    MessageBox.Show(selectedItems);

        //}

        #region các hàm nhập mã PL, chỉ nhập số
        // hàm chỉ cho phép textBox nhập số
        private void txt_keyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Cho phép phím điều khiển (Backspace, Delete, Ctrl+C/V...) và chữ số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự
                errorProvider1.SetError(txt, "Chỉ được nhập ký tự số");
                lbThongBao.Visible = true;

            }
            else
            {
                errorProvider1.SetError(txt, string.Empty);
                lbThongBao.Visible = false;
            }

        }


        private void txtMaPL3_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_keyPress_OnlyNumber(sender, e);
        }

        private void txtMaPL2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_keyPress_OnlyNumber(sender, e);
        }

        private void txtMaPL4_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_keyPress_OnlyNumber(sender, e);
        }

        // Hàm format thành 2 chữ số khi ròi textbox
        private void txtNumber_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            if (string.IsNullOrWhiteSpace(tb.Text))
                return;

            if (int.TryParse(tb.Text, out int value))
            {
                // Format 2 chữ số: 01, 02, 10
                tb.Text = value.ToString("D2");
            }
        }

        private void txtMaPL2_Leave(object sender, EventArgs e)
        {
            txtNumber_Leave(sender, e);
        }
        #endregion
    }
}
