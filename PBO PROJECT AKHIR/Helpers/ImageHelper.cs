using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace PBO_PROJECT_AKHIR.Helpers
{
    public static class ImageHelper
    {
        public static byte[] ImageToBinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image BinaryToImage(byte[] data)
        {
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    return Image.FromStream(ms);
            //}

            if (data == null || data.Length == 0)
                return null; // boleh kasih fallback juga

            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }
    }
}
