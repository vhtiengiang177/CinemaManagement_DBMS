using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace CinemaManagement.BLL
{
    public static class BSImage
    {
        public static Image convertToImage(byte[] arrByte)
        {
            using (MemoryStream mStream = new MemoryStream(arrByte))
            {
                return Image.FromStream(mStream);
            }
        }
    }
}
