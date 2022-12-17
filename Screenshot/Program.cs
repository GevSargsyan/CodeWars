using System;
using System.Drawing;
using System.Drawing.Imaging;
namespace Screenshot
{
    internal class Program : Form
    {
        public static void Capture(string CapturedFilePath)
        {
            Bitmap bitmap = new Bitmap
          (Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image);
            graphics.CopyFromScreen(25, 25, 25, 25, bitmap.Size);

            bitmap.Save(CapturedFilePath, ImageFormat.Bmp);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
