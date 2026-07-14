using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using ZXing;
using ZXing.Common;
using System.IO;

namespace PrintLabel
{
    public class clImageExcel
    {
        public static void AddImage(ExcelWorksheet oSheet, int rowIndex, int colIndex, string imagePath, string tenAnh, int marginLeftCell = 1, int marginTopCell = 1)
        {
            Bitmap image = new Bitmap(imagePath);

            //Image image = Image.FromFile(imagePath);

            ExcelPicture excelImage = null;
            if (image != null)
            {
                excelImage = oSheet.Drawings.AddPicture(tenAnh, imagePath);
                excelImage.From.Column = colIndex; //chèn vào từ cột nào. tính từ 0
                excelImage.From.Row = rowIndex; //chèn vào từ dòng nào, tính từ 0

                //int newWI = (int)(image.Width * 1.4);

                //excelImage.SetSize(newWI, 50); // điều chỉnh lại size ảnh trong excel. ko điểu chỉnh ở phần mềm vì nó sẽ làm vỡ điểm ảnh


                // 2x2 px space for better alignment
                //excelImage.From.ColumnOff = Pixel2MTU(5); // margin left: px
                //excelImage.From.RowOff = Pixel2MTU(10); // margin top:px

                excelImage.From.ColumnOff = Pixel2MTU(marginLeftCell); // margin left: px
                excelImage.From.RowOff = Pixel2MTU(marginTopCell); // margin top:px
            }
        }

        // hàm tính ra pixcel
        private static int Pixel2MTU(int pixels)
        {
            int mtus = pixels * 9525; // 9525 đơn vị của cái éo gì để quy đổi ra excel ấy
            return mtus;
        }

        public static Bitmap ScaleImage(Bitmap bmp, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / bmp.Width;
            var ratioY = (double)maxHeight / bmp.Height;
            var ratio = Math.Min(ratioX, ratioY);
            var newWidth = (int)(bmp.Width * ratio);
            var newHeight = (int)(bmp.Height * ratio);
            var newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);
            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.DrawImage(bmp, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

    

        /// <summary>
        /// Tạo mã vạch
        /// </summary>
        /// <param name="strCode"></param>
        /// <param name="sizeQRCode"></param>
        /// <param name="pathSaveQRCode"></param>
        public static void create_QRCode(string strCode, int sizeQRCode, string pathSaveQRCode)
        {
            try
            {
                if (!string.IsNullOrEmpty(strCode))
                {
                    var barcodeWriter = new BarcodeWriter
                    {
                        Format = BarcodeFormat.QR_CODE,
                        Options = new EncodingOptions
                        {

                            Height = 1,
                            Width = 1
                            ,
                            Margin = 0


                            //,PureBarcode = true
                        }
                        //  ,
                        //Renderer = new BitmapRenderer
                        //{
                        //    Background = backgroundQRCode
                        //    //Foreground = Color.Green  // đổi màu barcode
                        //}
                    };

                    using (var bitmap = barcodeWriter.Write(strCode)) //strBarCode
                    {
                        using (var stream = new MemoryStream())
                        {
                            var scaleBitmap = ScaleImage(bitmap, sizeQRCode, sizeQRCode); // 55, 55 // điều chỉnh lại size barcode ko có vùng quiet zone

                            scaleBitmap.Save(stream, ImageFormat.Png);


                            var image =  Image.FromStream(stream);




                            string path = string.Format("{0}\\{1}.png", pathSaveQRCode, strCode);
                           
                            image.Save(path, ImageFormat.Png);//



                        }
                    }
                }

            }
            catch 
            {

                //MessageBox.Show(ex.ToString());
            }
        }


        public static void deleteFileInFolder(string pathFolder)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(pathFolder);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
            catch 
            {                
            }
        }
    }
}
