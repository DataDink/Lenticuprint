using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace Lenticuprint
{
    public class PageContext
    {
        private readonly PrintPageEventArgs _context;
        public PageContext(PrintPageEventArgs printerContext)
        {
            _context = printerContext;
            Lpi = 1;
            Horizontal = true;
            PrintBounds = new Rectangle(
                (int)_context.PageSettings.HardMarginX,
                (int)_context.PageSettings.HardMarginY,
                _context.PageBounds.Width - (int)_context.PageSettings.HardMarginX,
                _context.PageBounds.Height - (int)_context.PageSettings.HardMarginY);
        }

        public float Dpi { get { return 100f; } }

        public float Lpi { get; set; }

        public bool Horizontal { get; set; }

        public Rectangle PrintBounds { get; private set; }

        public void RenderLine(Graphics target, Pen pen, float position, float start, float end)
        {
            if (Horizontal) {
                target.DrawLine(pen, start, position, end, position);
            } else {
                target.DrawLine(pen, position, start, position, end);
            }
        }

        public void Render(Bitmap[] images)
        {
            Render(images, PrintBounds.Left, PrintBounds.Top, PrintBounds.Right, PrintBounds.Bottom);
        }

        public void Render(Bitmap[] images, float left, float top, float right, float bottom)
        {
            images = (images ?? new Bitmap[0]).Select(i => i.ScaleTo(PrintBounds.Size)).ToArray();
            if (!images.Any()) return;

            var scanStart = Horizontal ? top : left;
            var scanEnd = Horizontal ? bottom : right;
            var lineStart = Horizontal ? left : top;
            var lineEnd = Horizontal ? right : bottom;

            var scanSize = Dpi/Lpi;
            var scanStep = scanSize/images.Length;
            var pens = images.Select(i => new Pen(new TextureBrush(i), scanStep)).ToArray();

            for (var position = scanStart; position < scanEnd; position += scanStep * pens.Length)
            for (var index = 0; index < pens.Length; index++) {
                var pen = pens[index];
                var offset = scanStep*index;
                RenderLine(_context.Graphics, pen, position + offset, lineStart, lineEnd);
            }

            pens.ToList().ForEach(p => p.Dispose());
            images.ToList().ForEach(i => i.Dispose());
        }
    }
}
