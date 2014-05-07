using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;

namespace Lenticuprint
{
    public static class ImageExtensions
    {

        /// <summary>
        /// Scales the image to fit the new dimensions and returns the resulting image
        /// </summary>
        public static Bitmap ScaleTo(this Image image, Size size)
        {
            var scale = Math.Min((float) size.Width/image.Width, (float) size.Height/image.Height);
            var width = image.Width*scale;
            var height = image.Height*scale;
            var left = (size.Width - width) / 2;
            var top = (size.Height - height) / 2;
            var target = new Bitmap(size.Width, size.Height);
            using (var gfx = Graphics.FromImage(target)) {
                gfx.DrawImage(image, left, top, width, height);
            }
            return target;
        }

        /// <summary>
        /// Shifts the image the specified number of pixels horizontally
        /// </summary>
        public static Bitmap Shift(this Image image, int pixels)
        {
            var target = new Bitmap(image);
            using (var gfx = Graphics.FromImage(target)) {
                gfx.DrawImage(image, pixels, 0);
                pixels = pixels < 0 ? pixels + image.Width : pixels - image.Width;
                gfx.DrawImage(image, pixels, 0);
            }
            return target;
        }
    }
}
