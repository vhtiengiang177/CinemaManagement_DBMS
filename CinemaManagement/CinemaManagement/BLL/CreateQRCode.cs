using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace CinemaManagement.BLL
{
    public static class CreateQRCode
    {
        public static int strlen = 6;
        static int Graphic = 10;
        static int i = 0;
        //   static int 
        public static string passCode;
        //    public static string passCodetemp;
        public static PictureBox createQRCode(string passCode)
        {
            //   passCode = createCode();
            //  passCodetemp = passCode;
            PictureBox ptr = new PictureBox();
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var data = qr.CreateQrCode(passCode, QRCoder.QRCodeGenerator.ECCLevel.L);
            var code = new QRCoder.QRCode(data);
            ptr.Image = code.GetGraphic(Graphic);
            savePicture(ptr);
            return ptr;
        }

        //public IActionResult Index(string qrText)
        //{
        //    QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
        //    QRCode qrCode = new QRCode(qrCodeData);
        //    Bitmap qrCodeImage = qrCode.GetGraphic(20);
        //    return View(BitmapToBytes(qrCodeImage));
        //}


        public static string createCode()
        {
            string s = "";
            Random rand = new Random();
            for (int i = 0; i < strlen; i++)
                s += (char)rand.Next(65, 90);
            //  passCode = s;
            return s;
        }

        public static void savePicture(PictureBox ptr)
        {
            try
            {
                ptr.Image.Save(@"#");
                i++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
