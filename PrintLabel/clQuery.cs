using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel
{
    public class clQuery
    {
        public static string GetMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }

            return sbHash.ToString();

        }
        public string ReadFile(int STT_Dong)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"Setting.txt");
                // Ngăn chặn việc có khoảng trằng dẫn đến lỗi
                string _output = lines[STT_Dong].Trim();
                return _output;

            }
            catch
            {
                return "";
            }
        }
        // Đọc thông tin TAS

        //public string ReadFileTAS(int STT_Dong, string file)
        //{
        //    try
        //    {
        //        string[] lines = File.ReadAllLines(file);
        //        // Ngăn chặn việc có khoảng trằng dẫn đến lỗi
        //        string _output = lines[STT_Dong].Trim();
        //        return _output;

        //    }
        //    catch
        //    {
        //        return "";
        //    }
        //}

        public void WriteFile(string PrintName, string Copies, string Dong, string cotWO, string cotID, string cotItem, string MaxPackingList, string showSetting, string HesoBarcode, string cotRev, string PathSavePL)
        {
            try
            {

                string[] lines = { PrintName, Copies, Dong, cotWO, cotID, cotItem, MaxPackingList, showSetting, HesoBarcode, cotRev, PathSavePL };

                // Set a variable to the Documents path.

                //string docPath =
                //  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter("Setting.txt"))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Viết thông tin vào file TAS
        //public void WriteFileTAS(string file, string PrintName, string Copies,string HesoBarcode)
        //{
        //    try
        //    {

        //        string[] lines = { PrintName, Copies, HesoBarcode };

        //        // Set a variable to the Documents path.

        //        //string docPath =
        //        //  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //        // Write the string array to a new file named "WriteLines.txt".
        //        using (StreamWriter outputFile = new StreamWriter(file))
        //        {
        //            foreach (string line in lines)
        //                outputFile.WriteLine(line);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}



        public bool check_Exist_Scan_CreatePackingList(int idUser, int idPL, string WO, string ID, string Item, string Rev)
        {
            try
            {
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    var data = db.pro_Check_ScanPackingList(idUser, idPL, WO, ID, Item, Rev).ToList();
                    if (data.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {

                return true;
            }

        }

        /// <summary>
        /// Hàm kiểm tra mật khẩu, có ýt nhất 8 ký tự và chứa ýt nhất 1 ký tự đặc biệt
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsValidPassword(string password)
        {
            // Kiểm tra độ dài
            if (password.Length < 8)
                return false;

            // Kiểm tra ký tự đặc biệt (không phải chữ cái hoặc số)
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            return hasSpecialChar;
        }

        /// <summary>
        /// Hàm lấy tên máy tính
        /// </summary>
        /// <returns></returns>
        public static string PCName()
        {
            return Environment.MachineName;
        }

        /// <summary>
        /// check cac TextBox, Combobox đang trống
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int countBlankTextbox(Control c)
        {
            int dem = 0;
            foreach (Control c1 in c.Controls)
            {
                if (c1 is TextBox || c1 is ComboBox)
                {
                    if (c1.Text == "" || string.IsNullOrEmpty(c1.Text))
                    {
                        c1.BackColor = Color.Pink;
                        dem++;
                    }
                    else
                    {
                        c1.BackColor = Color.White;
                    }
                }
            }
            return dem;
        }


        /// <summary>
        /// hàm User yêu cầu đổi pass
        /// </summary>
        /// <param name="idUser"></param>
        public void User_ChangePassword(int idUser)
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                // lấy password cũ
                var old_pass = (from s in db.tblUsers
                                where s.IDUser == idUser
                                select s.Password).FirstOrDefault();
                if (old_pass != null)
                {
                    fromChangePassword ch = new fromChangePassword(old_pass, idUser);
                    ch.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lỗi, không tìm thấy tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Hàm update thời gian logout
        /// </summary>
        /// <param name="idHis"></param>
        public void UpdateTimeLogout( int idHis)
        {
            try
            {
                // Lưu thời gian logOut
                using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
                {
                    tblHistoryLogin lo = new tblHistoryLogin();
                    lo = db.tblHistoryLogins.Where(id => id.IDHistory == idHis).Single();
                    lo.DateLogout = DateTime.Now;
                    lo.TimeLogout = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Check xem user có quyền leaderSX ko. quyền leader sx sẽ xem đc lịch sử + truy cập quản lý Account
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public bool check_Leader_User(int idUser)
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                var check = (from s in db.tblUsers
                             where s.IDUser == idUser
                             select s).FirstOrDefault();

                return check.LeaderSX ?? false;
            }
        }

    }
}
