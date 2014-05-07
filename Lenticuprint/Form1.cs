using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lenticuprint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _direction.SelectedIndex = 0;
        }

        public bool Horizontal { get { return _direction.Text == "Horizontal"; } }

        /// <summary>
        /// Prompts the user to select an image and adds it to the form
        /// </summary>
        private void _btnAddImage_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog {
                Title = @"Select an image file...",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"JPEG files|*.jpg;*.jpeg|Bitmap files|*.bmp|GIF Files|*.gif|Portable Network Graphic|*.png",
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            try {
                var path = dlg.FileName;
                var fileName = Path.GetFileName(path);
                var img = Image.FromFile(path);
                var control = new ImageItem {
                    Image = img,
                    Title = fileName,
                };
                control.Delete += (s, empty) => _pnlImages.Controls.Remove((Control) s);
                _pnlImages.Controls.Add(control);
            } catch {
                MessageBox.Show(@"Image could not be opened or read.");
            }
        }

        /// <summary>
        /// Validates the form for processing and alerts the user to any problems
        /// </summary>
        private bool AlertValidation()
        {
            if (_pnlImages.Controls.OfType<ImageItem>().Count() < 2) {
                MessageBox.Show(@"This operation requires at least 2 images to be loaded.");
                return false;
            }
            return true;
        }

        private Bitmap[] GetImages()
        {
            var images = _pnlImages.Controls.OfType<ImageItem>().Select(c => (Bitmap)c.Image).ToArray();
            if (!images.Any()) return images;
            var width = images.Max(i => i.Width);
            var height = images.Max(i => i.Height);
            var size = new Size(width, height);
            images = images.Select(
                    (image, index) => image
                        .ScaleTo(size))
                      .ToArray();
            return images;
        }

        private PageContext CreateContext(PrintPageEventArgs document)
        {
            return new PageContext(document) {
                Horizontal = Horizontal,
                Lpi = (float) _lpi.Value,
            };
        }

        private void RenderDocument(PrintPageEventArgs document)
        {
            var images = GetImages();
            var context = CreateContext(document);
            context.Render(images);
            images.ToList().ForEach(i => i.Dispose());
        }

        /// <summary>
        /// Displays an image preview to the user
        /// </summary>
        private void _btnPreview_Click(object sender, EventArgs e)
        {
            if (!AlertValidation()) return;
            using (var document = new PrintDocument())
            using (var preview = new PrintPreviewDialog {Document = document}) {
                document.PrintPage += (s, context) => RenderDocument(context);
                preview.ShowDialog();
            }
        }

        /// <summary>
        /// Generates a print document and displays print dialogs to the user
        /// </summary>
        private void _btnPrint_Click(object sender, EventArgs e)
        {
            if (!AlertValidation()) return;
            using (var document = new PrintDocument())
            using (var settings = new PrintDialog { Document = document })
            {
                if (settings.ShowDialog() != DialogResult.OK) return;

                document.PrintPage += (s, context) => RenderDocument(context);
                document.Print();
            }

        }

        /// <summary>
        /// Closes the application
        /// </summary>
        private void _btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Generates a print test to help determine the approriate lenticular settings to match your lenticular lense
        /// </summary>
        private void _btnPrintTest_Click(object sender, EventArgs e)
        {
            using (var document = new PrintDocument())
            using (var settings = new PrintDialog {Document = document}) {
                if (settings.ShowDialog() != DialogResult.OK) return;

                document.PrintPage += (s, context) => {
                    var page = CreateContext(context);
                    var blue = new Bitmap(page.PrintBounds.Width, page.PrintBounds.Height);
                    using (var gfx = Graphics.FromImage(blue)) gfx.Clear(Color.Blue);
                    var red = new Bitmap(page.PrintBounds.Width, page.PrintBounds.Height);
                    using (var gfx = Graphics.FromImage(red)) gfx.Clear(Color.Red);
                    var images = new[] {red, blue};

                    var blockSize = page.Dpi/2;
                    var hblockCount = (float)Math.Truncate(page.PrintBounds.Width/blockSize);
                    var vblockCount = (float)Math.Truncate(page.PrintBounds.Height / blockSize);
                    var blockCount = hblockCount*vblockCount;

                    var lpiStart = 100f;
                    var lpiEnd = 600f;
                    var lpiStep = (lpiEnd - lpiStart)/blockCount;

                    page.Lpi = lpiStart;
                    for (var h = 0; h < hblockCount; h++) {
                        for (var v = 0; v < vblockCount; v++) {
                            var left = h*blockSize;
                            var top = v*blockSize;
                            var right = left + blockSize;
                            var bottom = top + blockSize;
                            page.Lpi += lpiStep;
                            page.Render(images, left, top, right, bottom);
                        }
                    }
                    images.ToList().ForEach(i => i.Dispose());
                };
                document.Print();
            }
        }
    }
}
