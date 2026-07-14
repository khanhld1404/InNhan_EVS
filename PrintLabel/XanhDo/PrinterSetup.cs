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
    public partial class PrinterSetup : Form
    {
        string pathFileSetupXD = Application.StartupPath + "\\SettingXanhDo.ini";
        public PrinterSetup()
        {
            InitializeComponent();
        }


        private void PrinterSetup_Load(object sender, EventArgs e)
        {
            load_Printer();

            string GreenPrinter = IniFile.ReadValue("Printer", "Xanh", pathFileSetupXD);
            string RedPrinter = IniFile.ReadValue("Printer", "Do", pathFileSetupXD);

            cboGreenPrinter.SelectedItem = GreenPrinter;
            cboRedPrinter.SelectedItem = RedPrinter;

        }

        // hàm load danh sách máy in trong máy tính
        private void load_Printer()
        {
            List<string> listPrinter = new List<string>();

            var list = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
            foreach (string printer in list)
            {
                listPrinter.Add(printer);
            }

            
            cboGreenPrinter.DataSource = listPrinter.ToList();

            cboRedPrinter.DataSource = listPrinter.ToList() ;
            



        }

        private void btnSavePrinter_Click(object sender, EventArgs e)
        {
            try
            {
                string greenPrint = cboGreenPrinter.SelectedItem.ToString();
                string redPrint = cboRedPrinter.SelectedItem.ToString();

                IniFile.WriteValue("Printer", "Xanh", greenPrint, pathFileSetupXD);
                IniFile.WriteValue("Printer", "Do", redPrint, pathFileSetupXD);

                MessageBox.Show("Cập nhật thông tin thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
