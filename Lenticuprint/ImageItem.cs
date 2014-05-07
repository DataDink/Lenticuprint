using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lenticuprint
{
    public partial class ImageItem : UserControl
    {
        public ImageItem()
        {
            InitializeComponent();
            _close.Click += (s, e) => { if (Delete != null) Delete(this, null); };
            _rotate.Click += (s, e) => Rotate();
        }

        public string Title { get { return _title.Text; } set { _title.Text = value; } }

        public Image Image { get { return _image.Image; } set { _image.Image = value; } }

        public event EventHandler Delete;

        private void Rotate()
        {
            if (Image == null) return;
            Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            _image.Refresh();
        }

    }
}
