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
    public partial class Setting_Printer_TAS : Form
    {
        public Setting_Printer_TAS()
        {
            InitializeComponent();
        }
          
        clQuery cl = new clQuery();

        // Thông tin đường dẫn đến chỗ độc dữ liệu master đầu vào chương trình
        string file_route = Application.StartupPath + "\\SettingDongGoi.ini";
        // Hàm dùng để lấy thông tin cho file ini
        // Lấy tên
        private string Get_Ini_Name(string SectionName)
        {
            return IniFile.ReadValue(SectionName, "name", file_route);
        }
        //Lấy tọa độ x
        private string Get_Ini_X(string SectionName)
        {
            string value = IniFile.ReadValue(SectionName, "x", file_route).Trim();

            return value;
        }
        //Lấy tọa độ y
        private string Get_Ini_Y(string SectionName)
        {
            string value = IniFile.ReadValue(SectionName, "y", file_route).Trim();

            return value;
        }

        // Hàm dùng để lưu thông tin vị trí, tên của từng thành phần trong mã vào file
        private void Save_TT(string Sectionname, bool getname = false)
        {
            // Đưa ra tên textboxx
            TextBox txt_x = Barcode_Setting.Controls[Sectionname + "_x"] as TextBox;
            TextBox txt_y = Barcode_Setting.Controls[Sectionname + "_y"] as TextBox;

            string x = txt_x.Text.Trim();
            string y = txt_y.Text.Trim();

            IniFile.WriteValue(Sectionname, "x", x, file_route);
            IniFile.WriteValue(Sectionname, "y", y, file_route);
            if(getname)
            {
                TextBox txt_name = Barcode_Setting.Controls[Sectionname + "_name"] as TextBox;
                string name = txt_name.Text.Trim();
                IniFile.WriteValue(Sectionname, "name", name, file_route);
            }
        }
        private void Setting_Printer_TAS_Load(object sender, EventArgs e)
        {
            //Xét các giá trị của máy in
            txtPrintName.Text = IniFile.ReadValue("DongGoi_TAS", "Printer", file_route).Trim();
            txtCopies.Text = IniFile.ReadValue("DongGoi_TAS", "Copies", file_route).Trim();

            // Xét các tông thong trong mã in ra
            lab1_name.Text = Get_Ini_Name("lab1");
            lab1_x.Text = Get_Ini_X("lab1");
            lab1_y.Text = Get_Ini_Y("lab1");

            value1_x.Text = Get_Ini_X("value1");
            value1_y.Text = Get_Ini_Y("value1");

            barcode1_x.Text = Get_Ini_X("barcode1");
            barcode1_y.Text = Get_Ini_Y("barcode1");

            lab3_name.Text = Get_Ini_Name("lab3");
            lab3_x.Text = Get_Ini_X("lab3");
            lab3_y.Text = Get_Ini_Y("lab3");

            value3_x.Text = Get_Ini_X("value3");
            value3_y.Text = Get_Ini_Y("value3");

            barcode2_x.Text = Get_Ini_X("barcode2");
            barcode2_y.Text = Get_Ini_Y("barcode2");

            lab2_name.Text = Get_Ini_Name("lab2");
            lab2_x.Text = Get_Ini_X("lab2");
            lab2_y.Text = Get_Ini_Y("lab2");

            value2_x.Text = Get_Ini_X("value2");
            value2_y.Text = Get_Ini_Y("value2");

            lab4_name.Text = Get_Ini_Name("lab4");
            lab4_x.Text = Get_Ini_X("lab4");
            lab4_y.Text = Get_Ini_Y("lab4");

            value4_x.Text = Get_Ini_X("value4");
            value4_y.Text = Get_Ini_Y("value4");

            lab5_name.Text = Get_Ini_Name("lab5");
            lab5_x.Text = Get_Ini_X("lab5");
            lab5_y.Text = Get_Ini_Y("lab5");

            lab6_name.Text = Get_Ini_Name("lab6");
            lab6_x.Text = Get_Ini_X("lab6");
            lab6_y.Text = Get_Ini_Y("lab6");

            lab7_name.Text = Get_Ini_Name("lab7");
            lab7_x.Text = Get_Ini_X("lab7");
            lab7_y.Text = Get_Ini_Y("lab7");

            value5_x.Text = Get_Ini_X("value5");
            value5_y.Text = Get_Ini_Y("value5");

            lab8_name.Text = Get_Ini_Name("lab8");
            lab8_x.Text = Get_Ini_X("lab8");
            lab8_y.Text = Get_Ini_Y("lab8");

            value6_name.Text = Get_Ini_Name("value6");
            value6_x.Text = Get_Ini_X("value6");
            value6_y.Text = Get_Ini_Y("value6");

            lab9_name.Text = Get_Ini_Name("lab9");
            lab9_x.Text = Get_Ini_X("lab9");
            lab9_y.Text = Get_Ini_Y("lab9");

            lab10_name.Text = Get_Ini_Name("lab10");
            lab10_x.Text = Get_Ini_X("lab10");
            lab10_y.Text = Get_Ini_Y("lab10");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrintName.Text) && !string.IsNullOrEmpty(txtCopies.Text))
            {
                // Lấy tất cả các giá trị máy in được nhập trên giao diện
                string printer_name = txtPrintName.Text;
                string printer_copies = txtCopies.Text;

                //Viết giá trị máy in vào file lưu tt
                IniFile.WriteValue("DongGoi_TAS", "Printer",printer_name, file_route);
                IniFile.WriteValue("DongGoi_TAS", "Copies", printer_copies,file_route);

                // Lưu thông tin mã vào file
                Save_TT("lab1",true);

                Save_TT("value1");

                Save_TT("barcode1");

                Save_TT("lab3", true);

                Save_TT("value3");

                Save_TT("barcode2");

                Save_TT("lab2",true);

                Save_TT("value2");

                Save_TT("lab4",true);

                Save_TT("value4");

                Save_TT("lab5", true);
                Save_TT("lab6", true);
                Save_TT("lab7", true);

                Save_TT("value5");

                Save_TT("lab8", true);
                Save_TT("value6", true);
                Save_TT("lab9", true);

                Save_TT("lab10", true);

                MessageBox.Show("Save thành công.\n Đăng xuất phần mềm và bật lại để lưu thay đổi cài đặt");
                //Thoát ra ngoài
                this.Close();

            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không đầy đủ", "Setting False", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
    }
}
