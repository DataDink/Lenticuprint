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
        }

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
                var container = new GroupBox {
                    Text = fileName,
                    BackgroundImage = img,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Width = 200,
                    Height = 200,
                };
                var closeButton = new Button {
                    ForeColor = Color.Red,
                    Text = @"×",
                    Width = 20,
                    Height = 20,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Left = 180,
                };
                var rotateButton = new Button {
                    ForeColor = Color.Blue,
                    Text = @"¬",
                    Width = 20,
                    Height = 20,
                    Anchor = AnchorStyles.Right | AnchorStyles.Top,
                    Left = 160,
                };
                closeButton.Click += (s, a) => _pnlImages.Controls.Remove(container);
                rotateButton.Click += (s, a) => { container.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone); container.Refresh(); };
                container.Controls.Add(closeButton);
                container.Controls.Add(rotateButton);
                _pnlImages.Controls.Add(container);
            } catch {
                MessageBox.Show(@"Image could not be opened or read.");
            }
        }

        /// <summary>
        /// Validates the form for processing and alerts the user to any problems
        /// </summary>
        private bool AlertValidation()
        {
            if (_pnlImages.Controls.OfType<GroupBox>().Count() < 2) {
                MessageBox.Show(@"This operation requires at least 2 images to be loaded.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Clones all user loaded images from the form and rotates them for maximum printing resolution if requested.
        /// </summary>
        private Bitmap[] GetImages()
        {
            var controls = _pnlImages.Controls.OfType<GroupBox>().ToArray();
            if (!controls.Any()) return new Bitmap[0];
            var size = controls.First().BackgroundImage.Size;
            return _pnlImages.Controls.OfType<GroupBox>()
                .Select((g, i) => {
                    var image = g.BackgroundImage.ScaleTo(size).Dispose(b => b.Shift(b.Width / 100 * ((_tkbHorzShift.Value*i)%100))); 
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone); 
                    return image;
                })
                .ToArray();
        }

        /// <summary>
        /// Generates a bitmap preview of the resulting lenticulation
        /// </summary>
        private Image GenerateImage()
        {
            if (!AlertValidation()) return null;
            var images = GetImages();
            var image = new Bitmap(images.Max(i => i.Width), images.Max(i => i.Height));
            using (var gfx = Graphics.FromImage(image)) {
                gfx.Lenticulate(images, image.HorizontalResolution, image.HorizontalResolution, 0f, image.Width / image.HorizontalResolution, image.Height / image.HorizontalResolution);
            }
            images.ToList().ForEach(i => i.Dispose());
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return image;
        }

        /// <summary>
        /// Displays an image preview to the user
        /// </summary>
        private void _btnPreview_Click(object sender, EventArgs e)
        {
            var image = GenerateImage();
            if (image == null) return;

            var view = new Form {
                Text = @"Preview",
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = image,
                BackColor = Color.Black,
            };
            view.Show();
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        private void _btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Prompts the user to save the preview image to disk
        /// </summary>
        private void _btnSave_Click(object sender, EventArgs e)
        {
            var image = GenerateImage();
            if (image == null) return;

            var dlg = new SaveFileDialog {
                Title = @"Save this image",
                AddExtension = true,
                ValidateNames = true,
                Filter = @"JPEG|*.jpg;*.jpeg|Bitmap|*.bmp|Gif|*.gif|Png|*.png"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            image.Save(dlg.FileName);
        }

        /// <summary>
        /// Generates a print document and displays print dialogs to the user
        /// </summary>
        private void _btnPrint_Click(object sender, EventArgs e)
        {
            if (!AlertValidation()) return;

            using (var doc = new PrintDocument())
            using (var settings = new PrintDialog{Document = doc})
            using (var preview = new PrintPreviewDialog{Document = doc}) {
                if (settings.ShowDialog() != DialogResult.OK) return;

                var images = GetImages();
                var dpi = 100f;
                var lpi = (float) _nupLpi.Value;
                var margin = (float) _nupMargin.Value;
                var width = (float) _nupWidth.Value;
                var height = (float)_nupHeight.Value;
                doc.PrintPage += (s, a) => a.Graphics.Lenticulate(images, lpi, dpi, margin, width, height);
                preview.ShowDialog();
                images.ToList().ForEach(i => i.Dispose());
            }

        }

        /// <summary>
        /// Generates a print test to help determine the approriate lenticular settings to match your lenticular lense
        /// </summary>
        private void _btnPrintTest_Click(object sender, EventArgs e)
        {
            using (var doc = new PrintDocument())
            using (var settings = new PrintDialog { Document = doc })
            using (var preview = new PrintPreviewDialog{Document = doc}) {
                if (settings.ShowDialog() != DialogResult.OK) return;

                doc.PrintPage += (s, a) =>
                {
                    var startLpi = (float)_nupLpi.Value - 20;
                    const float lpiStep = .25f;
                    const float startCount = 2f;
                    const float groupSize = 2f;
                    const float textSize = 14f;
                    const float rowSize = 100f;
                    const float colSize = 10f;
                    const float groupHeight = textSize*groupSize + rowSize*groupSize;
                    const float rowHeight = rowSize + textSize;

                    var count = startCount;
                    for (var groupTop = 25f; groupTop + groupHeight <= 1100; groupTop += groupHeight) {
                        var group = (int) ((groupTop - 25)/groupHeight);
                        var lpi = startLpi;
                        for (var rowTop = groupTop; rowTop + rowHeight <= groupTop + groupHeight; rowTop += rowHeight) {
                            var row = (int) ((rowTop - groupTop)/rowHeight);
                            for (var colLeft = 25f; colLeft <= 825; colLeft += colSize) {
                                var col = (int)((colLeft - 25)/colSize);
                                var line = 100/lpi;
                                var pen = new Pen(Color.Black, line);
                                if (col%5 == 0) {
                                    a.Graphics.DrawString(string.Format("{0}:{1}", Math.Round(lpi, 2), count), SystemFonts.DefaultFont, Brushes.Black, colLeft, rowTop);
                                }
                                for (var y = rowTop + textSize; y <= rowTop + rowHeight; y += line * count) {
                                    a.Graphics.DrawLine(pen, colLeft, y, colLeft + colSize, y);
                                }
                                lpi += lpiStep;
                            }
                        }
                        count++;
                    }
                };
                preview.ShowDialog();
            }
        }
    }
}
