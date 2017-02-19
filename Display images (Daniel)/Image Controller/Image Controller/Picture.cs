using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Image_Controller
{
    class Picture
    {
        /// <summary>
        /// Instance variables
        /// </summary>
        private String date;
        private String time;
        private String second;
        private Image image;

        /// <summary>
        /// Constructor that takes in 4 arguments and sets the instance variables to the paramters value
        /// </summary>
        /// <param name="date"></param>
        /// <param name="hour"></param>
        /// <param name="second"></param>
        /// <param name="image"></param>
        public Picture(String date, String time, String second, Image image)
        {
            this.date = date;
            this.time = time;
            this.second = second;
            this.image = image;
        }

        /// <summary>
        /// Returns a variable
        /// </summary>
        /// <returns>The variable date</returns>
        public String GetDate()
        {
            return date;
        }

        /// <summary>
        /// Returns a variable
        /// </summary>
        /// <returns>The variable time</returns>
        public String GetTime()
        {
            return time;
        }

        /// <summary>
        /// Returns a variable
        /// </summary>
        /// <returns>The variable second</returns>
        public String GetSecond()
        {
            return second;
        }

        /// <summary>
        /// Returns a variable
        /// </summary>
        /// <returns>The variable image</returns>
        public Image GetImage()
        {
            return image;
        }

        /// <summary>
        /// Clears the data of the variable image
        /// </summary>
        public void ClearImage()
        {
            image = null;
        }

        /// <summary>
        /// Resize the image to the specified width and height
        /// </summary>
        /// <param name="image">The image to resize</param>
        /// <param name="width">The width to resize to</param>
        /// <param name="height">The height to resize to</param>
        /// <returns>The resized image</returns>
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
