using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PrjTreino.Utils
{
    public class Conversions
    {
        public static BitmapImage dataReaderToBitmapImage(SqlDataReader drb)
        {
            BitmapImage image = new BitmapImage();
            byte[] ima = null;
            ima = (byte[])drb["foto_func"];
            MemoryStream ms = new MemoryStream(ima);
            image.BeginInit();
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
    }
}
