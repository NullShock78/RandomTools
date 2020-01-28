using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
namespace EmoteWallGUI
{
    public static class ImageSplitter
    {

        class FrameInfo
        {
            public Bitmap bmp;
            public int delay;

            public FrameInfo(Bitmap bmp, int delay)
            {
                this.bmp = bmp;
                this.delay = delay;
            }
        }

        static int tilesW = 0;
        static int tilesH = 0;

        public static string SplitGif(string path, string emoteName)
        {
            string resStr = "";
            string folder = Path.GetDirectoryName(path);

            
            MagickImageCollection coll = new MagickImageCollection();

            MagickImageCollection collo = new MagickImageCollection(path);
            for (int j = 0; j < collo.Count; j += 6)
            {
                coll.Add(collo[j]);
            }
            

            var len = coll.Count;
            List<List<FrameInfo>> gifs = new List<List<FrameInfo>>();
            //List<MagickImageCollection> gifs = new List<MagickImageCollection>();

            //var b = coll[0].ToBitmap();
            //const int div = 16;
            //int w = b.Width - (b.Width % div);
            //int h = b.Height - (b.Height % div);

            //if ((w / div) * (h / div) > 50)
            //{
            //    if (h > w)
            //    {
            //        //int diff = (224 - h);
            //        float d = (float)(7 * div) / h;
            //        h = (7 * div);
            //        w = (int)(w * d);
            //    }
            //    else
            //    {
            //        float d = (float)(7 * div) / w;
            //        w = (7 * div);
            //        h = (int)(h * d);
            //    }
            //}
            //w = w - (w % div);
            //h = h - (h % div);

            //int tilesX = w / div;
            //int tilesY = h / div;
            //int div = 16;
            //var w = 5 * div;
            //var h = 4 * div;

            //int tilesX = 5;
            //int tilesY = 4;
            //int numTiles = tilesX * tilesY;

            //for (int j = 0; j < numTiles; j++)
            //{
            //    //gifs.Add(new List<FrameInfo>());
            //    //var c = new MagickImageCollection();
            //    gifs.Add(new List<FrameInfo>());
            //}


            for (int j = 0; j < len; j++)
            {

                using (MagickImage img = new MagickImage(coll[j]))
                {
                    var delay = img.AnimationDelay;
                    SliceFrame(gifs, img, delay);
                    //img.Resize(w, h);
                    //var tiles = img.CropToTiles(div, div).ToArray();
                    //for (int k = 0; k < numTiles; k++)
                    //{
                    //    //gifs[k].Add(new FrameInfo(tiles[k].ToBitmap(),);
                    //    MagickImage m = new MagickImage(tiles[k]);
                    //    m.AnimationDelay = delay;
                    //    gifs[k].Add(m);
                    //}
                }
            }
            
            string newFolder = Path.Combine(folder, emoteName.ToUpper() + "_" + Guid.NewGuid().ToString().Substring(0, 4));
            Directory.CreateDirectory(newFolder);

            QuantizeSettings settings = new QuantizeSettings();
            settings.Colors = 128;
            for (int j = 0; j < gifs.Count; j++)
            {
                //gifs[j].Quantize(settings);
                //gifs[j].Optimize();
                //gifs[j].Write(Path.Combine(newFolder, $"{emoteName}{j}.gif"));
                //Todo: write

                using (MagickImageCollection mc = new MagickImageCollection()) {
                    for (int k = 0; k < len; k++)
                    {
                        var mi = new MagickImage(gifs[j][k].bmp);
                        mi.AnimationDelay = gifs[j][k].delay;
                        mc.Add(mi);
                        gifs[j][k].bmp.Dispose();
                    }
                    mc.Quantize(settings);
                    mc.Optimize();
                    mc.Write(Path.Combine(newFolder, $"{emoteName}{j}.gif"));
                }
            }

            int iter = 0;
            for (int y = 0; y < tilesH; y++)
            {
                for (int x = 0; x < tilesW; x++)
                {
                    resStr += $":{emoteName}{iter}:";
                    iter++;
                }
                resStr += Environment.NewLine;
            }

            if (resStr.Length > 0)
            {
                resStr = resStr.Substring(0, resStr.Length - 2);
                File.WriteAllText(Path.Combine(newFolder, "pasteable.txt"), resStr);
            }

            tilesW = 0;
            tilesH = 0;
            return resStr;
            //Path.Combine(newFolder, $"{emoteName}{iter}.png")


        }


        static void SliceFrame(List<List<FrameInfo>> coll, MagickImage img, int delay)
        {
            Bitmap b = img.ToBitmap();
           
            const int div = 64;
            int w = b.Width - (b.Width % div);
            int h = b.Height - (b.Height % div);

            if ((w / div) * (h / div) > 50)
            {
                if (h > w)
                {
                    //int diff = (224 - h);
                    float d = (float)(7 * div) / h;
                    h = (7 * div);
                    w = (int)(w * d);
                }
                else
                {
                    float d = (float)(7 * div) / w;
                    w = (7 * div);
                    h = (int)(h * d);
                }
            }
            w = w - (w % div);
            h = h - (h % div);
            if(tilesW == 0)
            {
                tilesW = w / div;
            }
            if (tilesH == 0)
            {
                tilesH = h / div;
            }

            b = ResizeImage(b, w, h);
            int iter = 0;

            Bitmap nb = new Bitmap(div, div);
            Rectangle dr = new Rectangle(0, 0, div, div);

            for (int y = 0; y < b.Height / div; y++)
            {
                for (int x = 0; x < b.Width / div; x++)
                {

                    Rectangle sr = new Rectangle(x * div, y * div, div, div);
                    CopyRegionIntoImage(b, sr, ref nb, dr);


                    if (coll.Count <= iter)
                    {
                        coll.Add(new List<FrameInfo>());
                    }
                    coll[iter].Add(new FrameInfo(new Bitmap(nb), delay));
                    iter++;
                }
            }
            b.Dispose();
            
        }




        public static string SplitImage(string path, string emoteName)
        {
            string resStr = "";
            string folder = Path.GetDirectoryName(path);
            Bitmap b = new Bitmap(path);

            const int div = 64;
            int w = b.Width - (b.Width % div);
            int h = b.Height - (b.Height % div);

            if ((w / div) * (h / div) > 50)
            {
                if (h > w)
                {
                    //int diff = (224 - h);
                    float d = (float)(7*div) / h;
                    h = (7 * div);
                    w = (int)(w * d);
                }
                else
                {
                    float d = (float)(7 * div) / w;
                    w = (7 * div);
                    h = (int)(h * d);
                }
            }
            w = w - (w % div);
            h = h - (h % div);

            b = ResizeImage(b, w, h);
            int iter = 0;

            Bitmap nb = new Bitmap(div, div);
            Rectangle dr = new Rectangle(0, 0, div, div);
            string newFolder = Path.Combine(folder, emoteName.ToUpper()+"_" + Guid.NewGuid().ToString().Substring(0, 4));
            Directory.CreateDirectory(newFolder);
            for (int y = 0; y < b.Height / div; y++)
            {
                for (int x = 0; x < b.Width / div; x++)
                {

                    Rectangle sr = new Rectangle(x * div, y * div, div, div);
                    CopyRegionIntoImage(b, sr, ref nb, dr);

                    nb.Save(Path.Combine(newFolder, $"{emoteName}{iter}.png"));


                    resStr += $":{emoteName}{iter}:";
                    iter++;
                    if (iter >= 50) return resStr;
                }
                resStr += "\r\n";
            }
            if (resStr.Length > 0)
            {
                resStr = resStr.Substring(0, resStr.Length - 2);
                File.WriteAllText(Path.Combine(newFolder, "pasteable.txt"), resStr);
            }
            nb.Dispose();
            b.Dispose();
            return resStr;
        }

        static void CopyRegionIntoImage(Bitmap srcBitmap, Rectangle srcRegion, ref Bitmap destBitmap, Rectangle destRegion)
        {
            using (Graphics grD = Graphics.FromImage(destBitmap))
            {
                grD.Clear(Color.Transparent);
                grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);
            }
        }

        static Bitmap ResizeImage(Image image, int width, int height)
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
