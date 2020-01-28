using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoteWallCreator
{
    public static class ImageSplitter
    {

        public static string SplitImage(string path, string emoteName)
        {
            string resStr = "";
            string folder = Path.GetDirectoryName(path);
            Bitmap b = new Bitmap(path);
            int w = b.Width - (b.Width % 32);
            int h = b.Height - (b.Height % 32);
            

            b = ResizeImage(b, w, h);
            int iter = 0;
            for (int y = 0; y < b.Height/32; y++)
            {
                for (int x = 0; x < b.Width / 32; x++)
                {
                    Bitmap nb = new Bitmap(32, 32);
                    Rectangle dr = new Rectangle(0, 0, 32, 32);
                    Rectangle sr = new Rectangle(x*32, y*32, 32, 32);
                    CopyRegionIntoImage(b, sr, ref nb, dr);
                    
                    nb.Save(Path.Combine(folder, $"{emoteName}{iter}.png"));
                    resStr += $":{emoteName}{iter}:";
                    iter++;
                    if (iter >= 50) return resStr;
                }
                resStr += "\r\n";
            }
            resStr = resStr.Substring(0, resStr.Length - 2);
            return resStr;
        }

        public static void CopyRegionIntoImage(Bitmap srcBitmap, Rectangle srcRegion, ref Bitmap destBitmap, Rectangle destRegion)
        {
            using (Graphics grD = Graphics.FromImage(destBitmap))
            {
                grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


    }
}
