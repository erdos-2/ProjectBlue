using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectBlue
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new SignupForm());
            Application.Run(new CustomerMainForm());
        }

        public static byte[] ConvertImageToByteArr(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image ConvertByteArrToImage(byte[] byteArr)
        {
            using (MemoryStream ms = new MemoryStream(byteArr))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
