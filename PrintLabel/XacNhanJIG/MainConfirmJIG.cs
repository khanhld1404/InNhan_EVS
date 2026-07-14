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

namespace PrintLabel.XacNhanJIG
{
    public partial class MainConfirmJIG : Form
    {
        #region khai báo biến
        int _IDUser;
        int _IDHistoryLogin;
        string _FullName;
        string _UserName;
        bool _Admin;

        bool scanWO = true; // phân biệt là quét mã của WO hay mã của JIG

        #endregion
        public MainConfirmJIG()
        {
            InitializeComponent();
        }

        public MainConfirmJIG(int IDUser, int IDHistoryLogin, string FullName, string UserName, bool Admin)
        {
            _IDUser = IDUser;
            _IDHistoryLogin = IDHistoryLogin;
            _FullName = FullName;
            _UserName = UserName;
            _Admin = Admin;
            InitializeComponent();
        }

        private void MainConfirmJIG_Load(object sender, EventArgs e)
        {
            txtScanBarcode.Focus();
            toolStripUser.Text = string.Format("{0} ({1})", _FullName, _UserName);
        }

        private void MainConfirmJIG_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtScanBarcodeWO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckJig();
            }
        }

        private void CheckJig()
        {
            try
            {
                if (scanWO == true) // quets mã vạch trên WO
                {
                    string strBarcodeWO = txtScanBarcode.Text.Trim();
                    if (!string.IsNullOrEmpty(strBarcodeWO))
                    {


                        string[] Chuoi = txtScanBarcode.Text.Trim().Split('%');

                        string _strWO = Chuoi[0].ToString();
                        string _strIDNo = Chuoi[1].Substring(0, 8);
                        string _strItemNo = Chuoi[1].Remove(0, 8); // Xóa 8 chuỗi đầu đi, lấy các ký tự còn lại

                        string _strRev = Chuoi[2].ToString();

                        if (_strWO.Length < 8 || _strWO.Length > 8)
                        {
                            MessageBox.Show("Mã vạch không đúng định dạng ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txtWO_info.Text = _strWO;
                            txtIDNo_info.Text = _strIDNo;
                            txtItemNo_info.Text = _strItemNo;
                            txtRevNo_Info.Text = _strRev;

                            // Kiểm ra xem WO đã được picking jig chưa
                            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                            {
                                var checkWO = (from s in db.tblJIG_CheckJIG
                                               where s.WONo == _strWO
                                               select s).ToList();
                                if (checkWO.Count > 0)
                                {
                                    // load dữ liệu picking jig, bước tiếp theo,....
                                    loadData_PickingJig_NextStep(_strWO);

                                    scanWO = false;
                                    lbScan.Text = "Quét mã vạch trên JIG";

                                }
                                else
                                {
                                    // insert dữ liệu picking jig theo master
                                    bool insertMasterJigPicking = (bool)db.pro_JIG_03_Insert_dataMaster_PickingJIG(_strWO, _strIDNo, _strItemNo, _strRev).FirstOrDefault().Value;

                                    if (insertMasterJigPicking) // insert thành công
                                    {
                                        // load dữ liệu picking jig, load bước tiếp theo,....
                                        loadData_PickingJig_NextStep(_strWO);

                                        scanWO = false;
                                        lbScan.Text = "Quét mã vạch trên JIG";

                                    }
                                    else
                                    {
                                        string noti = string.Format("Mã {0} chưa được đăng ký master", _strItemNo);
                                        MessageBox.Show(noti, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        txtScanBarcode.Text = string.Empty;
                                        txtScanBarcode.Focus();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("HÃY SCAN MÃ VẠCH TRÊN WO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Quét QRCode trên JIG
                {
                    string strBarcodeJIG = txtScanBarcode.Text.Trim();
                    if (!string.IsNullOrEmpty(strBarcodeJIG))
                    {

                        string Jig_master = txtJigMaster_nextStep.Text.Trim();

                        int lengthJIGMaster = Jig_master.Length;
                        int lengthJIGPicking = strBarcodeJIG.Length;
                        int idCheckJIG = Convert.ToInt32(txtIDCheck_nextStep.Text);

                        // nếu length jigpicking > length jig master thì mới cắt chuối theo leng jig master, nếu ko nhầm jig cmnr
                        if (lengthJIGPicking >= lengthJIGMaster)
                        {
                            // cắt chuỗi mã jig ban đầu để so sánh với jig master
                            string Jig_ss = strBarcodeJIG.Substring(0, lengthJIGMaster);

                            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                            {
                                //kiểm tra jig picking có nằm trong danh sách jig master hay ko
                                int checkJIG_detailMaster = (int)db.pro_JIG_05_CheckJiG_detail_master(strBarcodeJIG).FirstOrDefault().Value;

                                if (Jig_ss == Jig_master && checkJIG_detailMaster > 0)
                                {
                                    // Kiểm tra xem có bị lấy trùng jig ko
                                    bool DaPickingJig = (bool)db.pro_JIG_08_CheckJIG_DaPickingChua(txtWO_info.Text, Jig_master, strBarcodeJIG, txtCongDoan_nextStep.Text).FirstOrDefault().Value;
                                    if (DaPickingJig == true)
                                    {
                                        string noti = string.Format("MÃ JIG {0} ĐÃ ĐƯỢC XUẤT ", strBarcodeJIG);
                                        MessageBox.Show(noti, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        // cập nhật kết quả picking là OK
                                        db.pro_JIG_04_Update_resultPickingJIG_OK(idCheckJIG, strBarcodeJIG, _UserName);

                                        loadData_PickingJig_NextStep(txtWO_info.Text.Trim());
                                    }



                                    txtScanBarcode.Text = string.Empty;
                                    txtScanBarcode.Focus();

                                }
                                else
                                {
                                    ConfirmLeader confirm = new ConfirmLeader(idCheckJIG, Jig_master, strBarcodeJIG);
                                    if (confirm.ShowDialog() == DialogResult.OK)
                                    {
                                        loadData_PickingJig_NextStep(txtWO_info.Text.Trim());
                                    }


                                }
                            }

                        }
                        else
                        {
                            ConfirmLeader confirm = new ConfirmLeader(idCheckJIG, Jig_master, strBarcodeJIG);
                            if (confirm.ShowDialog() == DialogResult.OK)
                            {
                                loadData_PickingJig_NextStep(txtWO_info.Text.Trim());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("HÃY SCAN MÃ VẠCH TRÊN JIG", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message == "Index was outside the bounds of the array.")
                {
                    MessageBox.Show("Mã vạch không đúng định dạng. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtScanBarcode.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }


        private void loadData_PickingJig_NextStep(string WoNo)
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var dataPickingJIg = db.pro_JIG_01_loadPickingJIg_Wo(WoNo).ToList();

                gvData.AutoGenerateColumns = false;
                gvData.DataSource = dataPickingJIg;

                // đổi màu gvdata
                foreach (DataGridViewRow row in gvData.Rows)
                {
                    //int idCheckJIG = Convert.ToInt32(row.Cells["IDCheck"].Value.ToString());

                    string strResultCheck = row.Cells["Result"].FormattedValue.ToString();

                    //int QtyPickActual = Convert.ToInt32(row.Cells["QtyPickActual"].FormattedValue.ToString());
                    //int QtyPickMaster = Convert.ToInt32(row.Cells["QtyPickMaster"].FormattedValue.ToString());

                    //string strItemName = row.Cells["ItemName"].FormattedValue.ToString();




                    bool bool_ManualPicking = Convert.ToBoolean(row.Cells["ManualPicking"].Value.ToString());


                    // kiêm tra xem có phải là picking lại jig ko
                    bool bool_RePicking = false;
                    var re_picking = row.Cells["Re_Picking"].Value;
                    if (re_picking != null)
                    {
                        bool_RePicking = Convert.ToBoolean(re_picking);
                    }



                    switch (strResultCheck)
                    {
                        case "True":
                            //if (QtyPickActual == QtyPickMaster)
                            //{
                            row.DefaultCellStyle.BackColor = Color.PaleGreen;
                            //}
                            //else 
                            //{
                            //    row.DefaultCellStyle.BackColor = Color.Yellow;
                            //}


                            row.Cells["XuatLai"].Value = Properties.Resources.synchronize_16x16;
                            break;
                        case "False":
                            row.DefaultCellStyle.BackColor = Color.Red;

                            row.Cells["XuatLai"].Value = new Bitmap(1, 1); // ẩn hình ảnh


                            break;
                        default:
                            row.Cells["XuatLai"].Value = new Bitmap(1, 1);

                            break;
                    }

                    // đổi dòng mầu vàng nếu JIG là ghi tay
                    if (bool_ManualPicking)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;

                        // ẩn button xóa JIG
                        row.Cells["XoaJig"].Value = new Bitmap(1, 1);
                    }

                    // ẩn hiện immage Xóa jig xuất lại.
                    // chỉ xóa được JIG khi jig này là jig xuất lại và chưa được scanbarcode (result khác true)

                    if (bool_RePicking == true && strResultCheck != "True" && strResultCheck != "False")
                    {
                        row.Cells["XoaJig"].Value = Properties.Resources.cancel_16x16;
                    }
                    else
                    {
                        row.Cells["XoaJig"].Value = new Bitmap(1, 1);
                    }

                }



                // load bước tiếp theo
                var dataNexstep = db.pro_JIG_02_load_NextStep(WoNo).ToList();

                if (dataNexstep.Count > 0)
                {
                    var dataStep = dataNexstep.FirstOrDefault();

                    string itemName = dataStep.ItemName;
                    int step = (int)dataStep.Step;
                    int QtyMaster_next = (int)dataStep.QtyPickMaster;
                    int idCheck = dataStep.IDCheck;
                    bool _manualPicking = (bool)dataStep.ManualPicking;

                    txtCongDoan_nextStep.Text = dataStep.TenCD;
                    txtStep_nextStep.Text = step.ToString();
                    txtJigMaster_nextStep.Text = dataStep.JIGMaster;
                    txtNameJig_nextStep.Text = dataStep.JIGName;

                    txtIDCheck_nextStep.Text = idCheck.ToString(); // lấy ID





                    // nếu QtyMaster_next > 1 cần chèn thêm dòng  vào bảng tblJIG_CHeckJIG (chèn thêm 1 jig cần lấy)

                    if (QtyMaster_next > 1)
                    {
                        for (int i = 1; i < QtyMaster_next; i++)
                        {
                            db.pro_JIG_06_Insert_tblJIG_CheckJIG(txtWO_info.Text, txtIDNo_info.Text, txtItemNo_info.Text, txtRevNo_Info.Text,
                                                                 itemName, txtCongDoan_nextStep.Text, step, txtJigMaster_nextStep.Text, txtNameJig_nextStep.Text, _manualPicking);
                        }

                        // Cập nhật lại QtyMaster_next = 1, 
                        db.pro_JIG_07_Update_QtyMasterJIG(idCheck, 1);

                    }

                    txtQtyMaster_nextStep.Text = dataStep.QtyPickMaster.ToString();




                    txtScanBarcode.Focus();
                    txtScanBarcode.Text = string.Empty;

                    // nếu là lấy JIG bằng ghi tay, thì cần cập nhật jig này có result = true và bỏ trống JIGDetail
                    if (_manualPicking)
                    {
                        //cập nhật kết quả result = true và nhảy bước
                        db.pro_JIG_09_Update_result_JIGManualPicking(idCheck);

                        loadData_PickingJig_NextStep(WoNo); // đệ quy
                    }


                    btnExportFile.Visible = false;
                }
                else // đã hoàn thành xuất jig cho WO
                {
                    txtCongDoan_nextStep.Text = string.Empty;
                    txtStep_nextStep.Text = string.Empty;
                    txtJigMaster_nextStep.Text = string.Empty;
                    txtNameJig_nextStep.Text = string.Empty;
                    txtQtyMaster_nextStep.Text = string.Empty;
                    txtIDCheck_nextStep.Text = string.Empty;

                   

                    MessageBox.Show("Hoàn thành xuất JIG cho WO: " + WoNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtScanBarcode.Text = string.Empty;
                    txtScanBarcode.Focus();

                    btnExportFile.Visible = true;

                }

            }
        }

        #region sự kiện cell content click gv data : xuất lại JIG và xóa JIG xuất lại
        private void gvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gvData.Columns["XuatLai"].Index && e.RowIndex >= 0)
                {
                    // chỉ được xuất lại khi result = true
                    int cu = gvData.CurrentCell.RowIndex;
                    //int idCheck = Convert.ToInt32(gvData.Rows[cu].Cells["IDCheck"].Value.ToString());

                    string ResultCheck = gvData.Rows[cu].Cells["Result"].FormattedValue.ToString();

                    string jigMaster = gvData.Rows[cu].Cells["JIGMaster"].FormattedValue.ToString();

                    if (ResultCheck == "True")
                    {
                       
                        ReasonRe_PickingJIG re = new ReasonRe_PickingJIG(jigMaster);
                        if (re.ShowDialog() == DialogResult.OK)
                        {
                            string reasonRePicking = re.ReasonRePicking;
                            // thêm dòng mới
                            string ItemName = gvData.Rows[cu].Cells["ItemName"].FormattedValue.ToString();
                            string tenCD = gvData.Rows[cu].Cells["TenCD"].FormattedValue.ToString();
                            int step = (int)gvData.Rows[cu].Cells["Step"].Value;
                            string jigName = gvData.Rows[cu].Cells["JIGName"].FormattedValue.ToString();
                            bool manualPicking = (bool)gvData.Rows[cu].Cells["ManualPicking"].Value;

                            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                            {
                                db.pro_JIG_11_Insert_tblJIG_CheckJIG_XuatLai(txtWO_info.Text, txtIDNo_info.Text, txtItemNo_info.Text, txtRevNo_Info.Text,
                                    ItemName, tenCD, step, jigMaster, jigName, manualPicking,reasonRePicking);

                                loadData_PickingJig_NextStep(txtWO_info.Text);
                            }


                        }
                    }

                }


                // xóa jig picking lại
                if (e.ColumnIndex == gvData.Columns["XoaJig"].Index && e.RowIndex >= 0)
                {

                    // chỉ xóa được JIG khi jig này là jig xuất lại và chưa được scanbarcode (result khác true)

                    int cu = gvData.CurrentCell.RowIndex;
                    int idCheck = Convert.ToInt32(gvData.Rows[cu].Cells["IDCheck"].Value.ToString());

                    string jigMaster = gvData.Rows[cu].Cells["JIGMaster"].FormattedValue.ToString();

                    string ResultCheck = gvData.Rows[cu].Cells["Result"].FormattedValue.ToString();

                    bool bool_RePicking = false;

                    var re_picking = gvData.Rows[cu].Cells["Re_Picking"].Value;
                    if (re_picking != null)
                    {
                        bool_RePicking = Convert.ToBoolean(re_picking);
                    }



                    if (bool_RePicking == true && ResultCheck != "True" && ResultCheck != "False")
                    {
                        string question = string.Format("Bạn muốn xóa JIG : {0}", jigMaster);
                        if (MessageBox.Show(question, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                            {
                                db.pro_JIG_12_delete_tblJIG_CheckJig_idCheck(idCheck);

                                loadData_PickingJig_NextStep(txtWO_info.Text);
                            }
                        }
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // thay đổi WO
        private void btnChangeWO_Click(object sender, EventArgs e)
        {
            scanWO = true;
            lbScan.Text = "Quét mã vạch trên WO";
            gvData.DataSource = null;

            txtWO_info.Text = string.Empty;
            txtIDNo_info.Text = string.Empty;
            txtItemNo_info.Text = string.Empty;
            txtRevNo_Info.Text = string.Empty;

            txtCongDoan_nextStep.Text = string.Empty;
            txtStep_nextStep.Text = string.Empty;
            txtJigMaster_nextStep.Text = string.Empty;
            txtNameJig_nextStep.Text = string.Empty;
            txtQtyMaster_nextStep.Text = string.Empty;
            txtIDCheck_nextStep.Text = string.Empty;

            txtScanBarcode.Text = string.Empty;
            txtScanBarcode.Focus();
        }

        #region xuất file excel
        private void btnExportFile_Click(object sender, EventArgs e)
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
                if (gvData.Rows.Count > 0)
                {

                    DirectoryInfo outputDir = new DirectoryInfo(outputDirectory);
                    string output = clExportExcel.ExportExcel_PickingJIG(outputDir,txtWO_info.Text);


                    MessageBox.Show("Xuất file thành công ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Dữ liệu trống, bạn không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
    }
}
