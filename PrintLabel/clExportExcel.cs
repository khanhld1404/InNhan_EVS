using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using PrintLabel.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PrintLabel
{
    public class clExportExcel
    {

        public static string ExportExcel_HistoryPrint(FileInfo templace, DirectoryInfo outputdir, DateTime fromDate, DateTime toDate, string WO, string ID, string Item)
        {
            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                #region GAN DU LIEU VAO EXCEL
                using (ExcelPackage p = new ExcelPackage(templace, true))
                {
                    var data = db.pro_HistoryPrint_All(fromDate, toDate, WO, ID, Item).ToList();

                    if (data.Count > 0)
                    {
                        ExcelWorksheet ws = p.Workbook.Worksheets[1];

                        ws.Cells["B2"].Value = fromDate;
                        ws.Cells["D2"].Value = toDate;
                        ws.Cells["B3"].Value = WO;
                        ws.Cells["D3"].Value = ID;
                        ws.Cells["F3"].Value = Item;

                        int row = 8;

                        foreach (var item in data)
                        {
                            string WONo = "A" + row.ToString();
                            string IDNo = "B" + row.ToString();
                            string ItemNo = "C" + row.ToString();
                            string RevNo = "D" + row.ToString();
                            string Barcode = "E" + row.ToString();
                            string TimePrint = "F" + row.ToString();
                            string Code = "G" + row.ToString();
                            string FullName = "H" + row.ToString();


                            ws.Cells[WONo].Value = item.WO_No;
                            ws.Cells[IDNo].Value = item.ID_No;
                            ws.Cells[ItemNo].Value = item.Item_No;
                            ws.Cells[RevNo].Value = item.Rev_No;
                            ws.Cells[Barcode].Value = item.strFull;
                            ws.Cells[TimePrint].Value = item.TimePrint;
                            ws.Cells[Code].Value = item.Code;
                            ws.Cells[FullName].Value = item.FullName;


                            row++;
                        }
                    }

                    string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
                    //////////////////////////////////////////////////////

                    Byte[] bin = p.GetAsByteArray();

                    string file = outputdir + "\\HistoryPrint_" + time + ".xlsx"; // Ten file
                    File.WriteAllBytes(file, bin);
                    return file;

                    #endregion
                }


            }
        }



        public static string ExportExcel_PackingList(FileInfo templace, int idPL, string MaPL)
        {
            string pathSetupExport = Application.StartupPath + "\\SettingExport.ini";

            #region thông số QRCode

            string pathSaveQRCode = Application.StartupPath + "\\" + "folder_temp"; //packingListTemp

            string strSizeQRCode = IniFile.ReadValue("PackingList", "SizeQRCode", pathSetupExport);
            string strMaginLeftCellQR = IniFile.ReadValue("PackingList", "marginLeftCellQR", pathSetupExport);
            string strMaginTopCellQR = IniFile.ReadValue("PackingList", "marginTopCellQR", pathSetupExport);
            string strHeightCellQR = IniFile.ReadValue("PackingList", "HeightCellQR", pathSetupExport);
            string strColumnInsertQR = IniFile.ReadValue("PackingList", "ColumnInsertQR", pathSetupExport);
            string outputDirectory_Excel = IniFile.ReadValue("PackingList", "PathSaveExcel", pathSetupExport);
            string outputDirectory_PDF = IniFile.ReadValue("PackingList", "PathSavePDF", pathSetupExport);
            int SizeQRCode = Convert.ToInt32(strSizeQRCode); // kích thước của QRCode
            int MarginLeftCellQR = Convert.ToInt32(strMaginLeftCellQR); // margin left cell QRCode
            int MarginTopCellQR = Convert.ToInt32(strMaginTopCellQR); // margin Top cell QRCode
            double HeightCellQR = Convert.ToDouble(strHeightCellQR); // Chiều cao của dòng
            int ColumnInsertQR = Convert.ToInt32(strColumnInsertQR); //Cột chèn QRCOde ( tính từ 0 trong file template)


            DirectoryInfo outputDir_Excel = new DirectoryInfo(outputDirectory_Excel);
            DirectoryInfo outputDir_PDF = new DirectoryInfo(outputDirectory_PDF);
            #endregion


            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                #region GAN DU LIEU VAO EXCEL
                using (ExcelPackage p = new ExcelPackage(templace, true))
                {
                    var data = (from s in db.tblPackingList_Detail_02
                                where s.IdPL == idPL && s.ResultScan == true
                                select s).ToList();

                    if (data.Count > 0)
                    {
                        ExcelWorksheet ws = p.Workbook.Worksheets[0];

                        clQuery clquery = new clQuery();

                        string _DongStart = clquery.ReadFile(2);
                        int DongStart = Convert.ToInt32(_DongStart);
                        string CotWO = clquery.ReadFile(3);
                        string CotID = clquery.ReadFile(4);
                        string CotItem = clquery.ReadFile(5);
                        string CotRev = clquery.ReadFile(9);

                        //ws.Cells["C2"].Value = TypeDevice;
                        //ws.Cells["D3"].Value = PackingNumber;


                        int row = DongStart;

                        foreach (var item in data)
                        {

                            string WONo = CotWO + row.ToString();
                            string IDNo = CotID + row.ToString();
                            string ItemNo = CotItem + row.ToString();
                            string RevNo = CotRev + row.ToString();
                            string Qty = "E" + row.ToString();



                            ws.Cells[WONo].Value = item.WO_No;
                            ws.Cells[IDNo].Value = item.ID_No;
                            ws.Cells[ItemNo].Value = item.Item_No;
                            ws.Cells[RevNo].Value = item.Rev_No;
                            ws.Cells[Qty].Value = item.Qty;

                            #region  Tạo QRCode và chèn ảnh vào excel -> chưa dùng đến đoạn này
                            //  tạo QRCode
                            /*
                            string strCode = string.Format("{0}%{1}{2}%{3}", item.WO_No, item.ID_No, item.Item_No, item.Rev_No);


                            clImageExcel.create_QRCode(strCode, SizeQRCode, pathSaveQRCode);

                            //điều chỉnh độ rộng của dòng
                            ws.Row(row).Height = HeightCellQR;



                            // chèn ảnh vào excel
                            // đường dẫn của ảnh
                            string pathImage = string.Format("{0}\\{1}.png", pathSaveQRCode, strCode);
                            int RowInserQR = row - 1; // tính từ 0
                            clImageExcel.AddImage(ws, RowInserQR, ColumnInsertQR, pathImage, strCode, MarginLeftCellQR, MarginTopCellQR);

                            */

                            #endregion


                            row++;
                        }
                    }

                    string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
                    //////////////////////////////////////////////////////

                    //Byte[] bin = p.GetAsByteArray();
                    string fileName = string.Format("\\{0}_{1}.xlsx", MaPL, time);
                    string file_excel = outputDir_Excel + fileName; //"\\JCQ10_EVS025_" + time + ".xlsx"; // Ten file
                    //File.WriteAllBytes(file, bin);
                    p.SaveAs(file_excel);

                    // xoas file QRCode
                    //clImageExcel.deleteFileInFolder(pathSaveQRCode);


                    // chuyển file từ Excel sang pdf
                    string fileName_PDF = string.Format("\\{0}_{1}.pdf", MaPL, time);
                    string path_pdf = outputDir_PDF + fileName_PDF;
                    ConvertExcelToPDF(file_excel, path_pdf);






                    return path_pdf;

                    #endregion
                }


            }
        }

        /// <summary>
        /// hàm chuyển file từ excel sang PDF
        /// </summary>
        /// <param name="excelFilePath"></param>
        /// <param name="pdfFilePath"></param>
        private static void ConvertExcelToPDF(string excelFilePath, string pdfFilePath)
        {
            // Mở Excel và tệp Excel 
            var excelApp = new Excel.Application();
            var workbooks = excelApp.Workbooks;
            var workbook = workbooks.Open(excelFilePath);
            // Chuyển đổi tệp Excel sang PDF 
            workbook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, pdfFilePath);
            // Đóng tệp và thoát khỏi ứng dụng Excel 
            workbook.Close(false);
            excelApp.Quit();
        }

        /// <summary>
        /// Xuất excel cho picking jig
        /// </summary>
        /// <param name="outputdir"></param>
        /// <param name="WONo"></param>
        /// <returns></returns>
        public static string ExportExcel_PickingJIG(DirectoryInfo outputdir, string WONo)
        {
            string pathSetupExport = Application.StartupPath + "\\SettingExport.ini";

            #region thông số xuất file


            string template = IniFile.ReadValue("PickingJIG", "Template", pathSetupExport);
            string cellChungLoai = IniFile.ReadValue("PickingJIG", "CellChungLoai", pathSetupExport);
            string cellItemNo = IniFile.ReadValue("PickingJIG", "CellItemNo", pathSetupExport);
            string cellWONo = IniFile.ReadValue("PickingJIG", "CellWoNo", pathSetupExport);
            string cellIDNo = IniFile.ReadValue("PickingJIG", "CellIDNo", pathSetupExport);
            string cellRevNo = IniFile.ReadValue("PickingJIG", "CellRevNo", pathSetupExport);

            string strRowStartInsert = IniFile.ReadValue("PickingJIG", "RowStartInsert", pathSetupExport);

            string _cellCongDoan = IniFile.ReadValue("PickingJIG", "CellCongDoan", pathSetupExport);
            string _cellBuocSD = IniFile.ReadValue("PickingJIG", "CellBuocSD", pathSetupExport);
            string _cellMaJIG = IniFile.ReadValue("PickingJIG", "CellMaJIG", pathSetupExport);
            string _cellTenJIG = IniFile.ReadValue("PickingJIG", "CellTenJIG", pathSetupExport);
            string _cellSoLuong = IniFile.ReadValue("PickingJIG", "CellSoLuong", pathSetupExport);
            string _cellKetQua = IniFile.ReadValue("PickingJIG", "CellKetQua", pathSetupExport);

            int RowStartInsert = Convert.ToInt32(strRowStartInsert); // dòng bắt đầu chèn dữ liệu


            #endregion


            using (DBPrintLabel_ver02Entities db = new DBPrintLabel_ver02Entities(clConnection.connectEntity))
            {
                #region GAN DU LIEU VAO EXCEL
                FileInfo temp = new FileInfo(template);
                using (ExcelPackage p = new ExcelPackage(temp, true))
                {
                    var data = db.pro_JIG_01_loadPickingJIg_Wo(WONo).ToList();
                    int CountData = data.Count;
                    if (CountData > 0)
                    {
                        ExcelWorksheet ws = p.Workbook.Worksheets[0];

                        // thêm dòng vào excel theo số countData
                        int rowStartInsert = Convert.ToInt32(strRowStartInsert);
                        int rowInsert = CountData - 1; // trừ 1 dòng vì trong template có sẵn 1 dòng rồi
                        // thêm dòng theo số dữ liệu
                        ws.InsertRow(RowStartInsert, rowInsert, rowStartInsert);



                        var data2 = data.First(); //lấy dữ liệu dòng đầu tiên để lấy thông tin như: WONo,ItemNo,IDNo, RevNo
                        ws.Cells[cellChungLoai].Value = data2.ItemName;
                        ws.Cells[cellItemNo].Value = data2.ItemNo;
                        ws.Cells[cellWONo].Value = data2.WONo;
                        ws.Cells[cellIDNo].Value = data2.IDNo;
                        ws.Cells[cellRevNo].Value = data2.RevNo;




                        int row = rowStartInsert;
                        foreach (var item in data)
                        {

                            string cellCongDoan = _cellCongDoan + row.ToString();
                            string cellBuocSD = _cellBuocSD + row.ToString();
                            string cellMaJig = _cellMaJIG + row.ToString();
                            string cellTenJig = _cellTenJIG + row.ToString();
                            string cellSoLuong = _cellSoLuong + row.ToString();
                            string cellKQ = _cellKetQua + row.ToString();



                            ws.Cells[cellCongDoan].Value = item.TenCD;
                            ws.Cells[cellBuocSD].Value = item.Step;
                            ws.Cells[cellMaJig].Value = item.JIGPicking;
                            ws.Cells[cellTenJig].Value = item.JIGName;
                            ws.Cells[cellSoLuong].Value = item.QtyPickActual;

                            bool manualPicking = (bool)item.ManualPicking;

                            if (manualPicking == false) // những jig điền tay thì bỏ trống cell KetQua
                            {
                                if (item.Result != null)
                                {
                                    bool _resultCheck = (bool)item.Result;
                                    if (_resultCheck == true)
                                    {
                                        ws.Cells[cellKQ].Value = "OK";
                                    }
                                    else
                                    {
                                        ws.Cells[cellKQ].Value = "NG";
                                    }
                                }
                            }



                            row++;
                        }
                    }

                    string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
                    //////////////////////////////////////////////////////

                    //Byte[] bin = p.GetAsByteArray();

                    string file = outputdir + "\\JIG_" + time + ".xlsx"; // Ten file
                    //File.WriteAllBytes(file, bin);
                    p.SaveAs(file);

                    return file;

                    #endregion
                }


            }
        }


        /// <summary>
        /// Hàm xuất data ra excel từ dataGridview
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="outputdir"></param>
        public static void Data_ExportExcel(DataGridView gv, DirectoryInfo outputdir)
        {
            // creating Excel Application  
            Excel._Application app = new Excel.Application();
            // creating new WorkBook within Excel application  
            Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Export Data";
            // storing header part in Excel  
            for (int i = 1; i <= gv.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = gv.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i <= gv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < gv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = gv.Rows[i].Cells[j].Value.ToString();
                }
            }
            string time = DateTime.Now.ToString("ddMMyyyy_hhmmss");
            string file = string.Format("{0}\\Data_{1}.xls", outputdir, time); // Ten file
            // save the application  
            workbook.SaveAs(file, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // Exit from the application
            // comment 2 dòng này nếu muốn excel mở luôn
            workbook.Close(true, Type.Missing, Type.Missing);
            app.Quit();

            releaseObject(worksheet);
            releaseObject(workbook);
            releaseObject(app);
        }

        public static void Data_ExportExcel(DataTable dt, DirectoryInfo outputdir)
        {
            // creating Excel Application  
            Excel._Application app = new Excel.Application();
            // creating new WorkBook within Excel application  
            Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Export Data";
            // storing header part in Excel  
            for (int i = 1; i <= dt.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dt.Columns[i - 1].ColumnName;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                }
            }
            string time = DateTime.Now.ToString("ddMMyyyy_hhmmss");
            string file = string.Format("{0}\\Data_{1}.xls", outputdir, time); // Ten file
            // save the application  
            workbook.SaveAs(file, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // Exit from the application
            // comment 2 dòng này nếu muốn excel mở luôn
            workbook.Close(true, Type.Missing, Type.Missing);
            app.Quit();

            releaseObject(worksheet);
            releaseObject(workbook);
            releaseObject(app);
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
                //MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }


        /// <summary>
        /// Hàm xuất data từ gridview ra excel sử dụng EPPlus
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="filePath"></param>
        public void ExportDataGridViewToExcel_EPPlus(DataGridView dgv, string filePath)
        {
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Ghi tiêu đề cột
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dgv.Columns[col].HeaderText;
                    worksheet.Cells[1, col + 1].Style.Font.Bold = true;
                    worksheet.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                }

                // Ghi dữ liệu từng dòng
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dgv.Rows[row].Cells[col].Value?.ToString();
                    }
                }

                // Tự động điều chỉnh độ rộng cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Lưu file
                FileInfo fi = new FileInfo(filePath);
                package.SaveAs(fi);
            }

            MessageBox.Show("Xuất Excel thành công !!!");
        }

       

        /// <summary>
        /// Hàm export data từ Linq to Excel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        /// <param name="sheetName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void ExportLinQ_To_Excel_EPPlus<T>(IEnumerable<T> data, string filePath, string sheetName = "Data")
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentNullException(nameof(filePath));
            if (string.IsNullOrWhiteSpace(sheetName)) sheetName = "Data";

            // Đảm bảo thư mục tồn tại
            var dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using (var package = new ExcelPackage())
            {
                // Tạo worksheet
                var ws = package.Workbook.Worksheets.Add(sheetName);

                // Ghi dữ liệu bắt đầu từ A1. Tham số thứ 2 = true để in header theo tên property
                ws.Cells["A1"].LoadFromCollection(data, true);

                // Thêm Table để có filter và style đẹp
                var totalRows = ws.Dimension.End.Row;
                var totalCols = ws.Dimension.End.Column;
                var tblRange = ws.Cells[1, 1, totalRows, totalCols];
                var table = ws.Tables.Add(tblRange, "Tbl_" + Guid.NewGuid().ToString("N"));
                table.TableStyle = TableStyles.Medium14;

                // Format header đậm + căn giữa
                using (var header = ws.Cells[1, 1, 1, totalCols])
                {
                    header.Style.Font.Bold = true;
                    header.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    header.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }

                // Tự động fit cột
                ws.Cells[ws.Dimension.Address].AutoFitColumns();

                // Gợi ý định dạng ngày/tháng (tùy thuộc dữ liệu)
                // Nếu muốn, có thể duyệt cột và set format cho DateTime:
                // for (int c = 1; c <= totalCols; c++)
                // {
                //     var colType = data.FirstOrDefault()?.GetType().GetProperties()[c-1].PropertyType;
                //     if (colType == typeof(DateTime) || colType == typeof(DateTime?))
                //         ws.Column(c).Style.Numberformat.Format = "yyyy-mm-dd hh:mm";
                // }

                // Lưu file
                package.SaveAs(new FileInfo(filePath));
            }
        }


    }
}


