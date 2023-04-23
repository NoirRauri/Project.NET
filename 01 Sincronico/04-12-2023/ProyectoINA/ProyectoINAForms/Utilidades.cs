using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoINAForms
{
    public static class Utilidades
    {
        public static byte[] convertImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image convertByteToImage(byte[] imageByte)
        {
            MemoryStream ms = new MemoryStream(imageByte);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
