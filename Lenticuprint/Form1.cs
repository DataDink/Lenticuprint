using System;
using System.Configuration;
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
            _lpi.Value = GetSavedLpi();
            _lpi.ValueChanged += (s, e) => SaveLpi();
        }

        private decimal GetSavedLpi()
        {
            var config = GetConfiguration();
            if (!config.Settings.AllKeys.Contains("Lpi")) config = SaveLpi();
            var value = Convert.ToDecimal(config.Settings["Lpi"].Value);
            return value;
        }

        private AppSettingsSection SaveLpi()
        {
            var config = GetConfiguration();
            if (!config.Settings.AllKeys.Contains("Lpi")) config.Settings.Add("Lpi", "0");
            config.Settings["Lpi"].Value = _lpi.Value.ToString("0.############");
            config.CurrentConfiguration.Save();
            return config;
        }

        private AppSettingsSection GetConfiguration()
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            AppSettingsSection section;
            if ((section = configuration.Sections["AppSettings"] as AppSettingsSection) == null)
            {
                section = new AppSettingsSection();
                section.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToLocalUser;
                configuration.Sections.Add("AppSettings", section);
                configuration.Save();
            }
            return section;
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
            var images = _pnlImages.Controls.OfType<ImageItem>().Select(c => (Bitmap)c.Image.Clone()).ToArray();
            if (!images.Any()) return images;

            var count = images.Length;
            var shiftMax = _shift.Maximum*count;
            var shift = _shift.Value;

            var width = images.Max(i => i.Width);
            var height = images.Max(i => i.Height);
            var size = new Size(width, height);
            images = images.Select(i => i.ScaleTo(size))
                           .Select((image, index) => image.Shift((int) (width/(double) (shiftMax*count)*(shift*index))))
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
            var dlg = new UserNumberDialog {
                Title = "Configure Test",
                Caption = "Set the range around the selected LPI you would like to see:",
                Value = 1
            };
            if (dlg.ShowDialog() != DialogResult.OK) { return; }

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
                    var blockCount = (float)Math.Truncate(page.PrintBounds.Height / blockSize);
                    var startLpi = (float)_lpi.Value - dlg.Value;
                    var endLpi = (float)_lpi.Value + dlg.Value;
                    var lpiRange = endLpi - startLpi;
                    var lpiStep = lpiRange/blockCount;

                    for (var i = 0; i < blockCount; i++) {
                        page.Lpi = startLpi + lpiStep * i;
                        var top = page.PrintBounds.Top + blockSize*i;
                        page.Render(images,
                            page.PrintBounds.Left,
                            top,
                            page.PrintBounds.Right,
                            page.PrintBounds.Bottom);
                        context.Graphics.DrawString(page.Lpi.ToString("0.##############"), SystemFonts.DefaultFont, Brushes.White, page.PrintBounds.Left, top);
                    }

                    images.ToList().ForEach(i => i.Dispose());
                };
                document.Print();
            }
        }
    }
}
