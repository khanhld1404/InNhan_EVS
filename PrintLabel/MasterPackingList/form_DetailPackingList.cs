using OfficeOpenXml.FormulaParsing.Excel.Functions.Engineering;
using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PrintLabel.MasterPackingList
{
    public partial class form_DetailPackingList : Form
    {
        int idPac;
        int idUser;
        clQuery clquery = new clQuery();
        public form_DetailPackingList(int _idPac, int _idUser)
        {
            this.idPac = _idPac;
            this.idUser = _idUser;
            InitializeComponent();
        }

        private void form_DetailPackingList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var data = (from s in db.tblPackingList_02
                            where s.idPL == idPac
                            select s).FirstOrDefault();
                var data_detail = (from s in db.tblPackingList_Detail_02
                                   where s.IdPL == idPac && s.ResultScan == true
                                   select s).ToList();

                txtMaPackingList.Text = data.MaPL;
                txtUser.Text = string.Format("{0}({1})", data.FullName, data.UserName);
                txtChungLoai.Text = data.ChungLoai;
                txtThietBi.Text = data.ThietBi;
                //txtDateCreate.Text = data.DateTimeCreated != null ? data.DateTimeCreated.Value.ToString("dd/MM/yyyy HH:mm") : string.Empty;
                txtDateCreate.Text = data.DateTimeCreated != null ? data.DateTimeCreated.Value.ToString("dd/MM/yyyy") : string.Empty;

                gvData.AutoGenerateColumns = false;
                gvData.DataSource = data_detail;

                int idUserTaoPL = (int)data.IDUser;

                int TongTB = gvData.Rows.Count;
                lbTongTB.Text = TongTB.ToString();

                string _timeNow = DateTime.Now.ToString("dd/MM/yyyy");

                string maxPL = clquery.ReadFile(6);
                int MaxPackingList = Convert.ToInt32(maxPL);

                // nếu Tổng số thiết bị < 48 và thời gian tạo = thời gian hiện hành và Chỉ có người tạo PL  thì mới được phép bổ sung thêm thiết bị 
                if (TongTB < MaxPackingList && _timeNow == txtDateCreate.Text && idUser == idUserTaoPL)
                {
                    btnBoSungTB.Visible = true;
                }
            }
        }

        private async void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPL_Excel = txtMaPackingList.Text.Replace('/', '.');

               

                string question = "Chọn 'Yes' để xuất lại PACKING LIST vào thư mục đã được cài đặt \n Chọn 'No' để chỉ xuất thông tin Packing list ";

                var confirm = MessageBox.Show(question, "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes) // chỉ xuất lại Packing list
                {
                    // xuất lại file , theo yc của c Hạnh bão ngày 06/05/2026.
                    string output = clExportExcel.ExportExcel_PackingList(new FileInfo("JCQ10-EVS025-4.xlsx"), idPac, MaPL_Excel);

                    MessageBox.Show("Xuất lại Packing list thành công", "Xuất Packing List", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (confirm == DialogResult.No) // Chỉ xuất thông tin Packing list
                {
                    using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                    {
                        var data = (from a in db.tblPackingList_02
                                    join b in db.tblPackingList_Detail_02 on a.idPL equals b.IdPL
                                    where a.idPL == idPac &&
                                          b.ResultScan == true
                                    select new
                                    {
                                        a.MaPL,
                                        a.ChungLoai,
                                        a.ThietBi,
                                        a.UserName,
                                        a.FullName,
                                        a.DateTimeCreated,
                                        b.WO_No,
                                        b.ID_No,
                                        b.Item_No,
                                        b.Rev_No,
                                        b.PL_OLD
                                    }).ToList();
                        clExportExcel cl = new clExportExcel();

                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "Excel Files|*.xlsx";
                            saveFileDialog.Title = "Chọn nơi lưu file Excel";
                            saveFileDialog.FileName = $"{MaPL_Excel}.xlsx";
                            //saveFileDialog.OverwritePrompt = true;

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = saveFileDialog.FileName;

                                await Task.Run(() =>
                                {
                                    cl.ExportLinQ_To_Excel_EPPlus(data, filePath);
                                });

                                MessageBox.Show("Xuất thông tin thành công", "Xuất thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnBoSungTB_Click(object sender, EventArgs e)
        {
            string MaPL = txtMaPackingList.Text;
            string MaPL_excel = MaPL.Replace('/', '.');
            string UserCreate = txtUser.Text;
            string ChungLoai = txtChungLoai.Text;
            string ThietBi = txtThietBi.Text;

            formConfirmLeader_BoSungTB_PL confirm = new formConfirmLeader_BoSungTB_PL(MaPL, UserCreate, ChungLoai, ThietBi);
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                string adminConfirm = confirm.userAdmin;
                string LyDoXN = confirm.LyDoXN;

                // bổ sung thiết bị -> lấy theo idUser đã tạo, nên chỗ này ko cần idUser nữa
                formNewPackingList newPL = new formNewPackingList(0, ChungLoai, ThietBi, MaPL, UserCreate, "", 0, null, MaPL_excel, idPac, LyDoXN, adminConfirm);
                newPL.ShowDialog();

            }
        }
    }
}
