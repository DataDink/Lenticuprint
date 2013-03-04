using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace Lenticuprint
{
    public static class ImageExtensions
    {
        /// <summary>
        /// Takes a collection of images and interlaces them together using the specified Lines Per Inch (lpi)
        /// </summary>
        public static void Lenticulate(this Graphics output, IEnumerable<Image> source, float lpi, float dpi, float margin, float width, float height)
        {
            var lineSize = dpi/lpi;
            var top = margin*dpi;
            var right = (width - margin) * dpi;
            var bottom = (height - margin) * dpi;
            var left = margin * dpi;
            var offset = 0f;

            var brushImages = source.Select(i => {
                var target = new Bitmap((int)((width + margin * 2) * dpi), (int)((height + margin * 2) * dpi));
                var image = i.ScaleTo(new Size((int)(width * dpi), (int)(height * dpi)));
                using (var bgfx = Graphics.FromImage(target)) {
                    bgfx.PageUnit = GraphicsUnit.Inch;
                    target.SetResolution(dpi, dpi);
                    bgfx.DrawImage(image, margin, margin, width, height);
                }
                return target;
            }).ToList();

            foreach (var brushImage in brushImages) {
                using (var brush = new TextureBrush(brushImage, WrapMode.Clamp))
                using (var pen = new Pen(brush, lineSize)) {
                    for (var y = top + offset; y < bottom; y += lineSize*brushImages.Count) {
                        output.DrawLine(pen, left, y, right, y);
                    }
                    offset += lineSize;
                }
            }
        }

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

        /// <summary>
        /// Performs the given process and then disposes this image
        /// </summary>
        public static Bitmap Dispose(this Image image, Func<Image, Bitmap> process)
        {
            var clone = process(image);
            image.Dispose();
            return clone;
        }
    }
}
