using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lenticuprint
{
    public partial class UserNumberDialog : Form
    {
        public UserNumberDialog()
        {
            InitializeComponent();
        }

        public string Title { get { return Text; } set { Text = value; } }
        public string Caption { get { return _caption.Text; } set { _caption.Text = value; } }
        public float Value { get { return (float)_value.Value; } set { _value.Value = (Decimal)value; } }

        private void _confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
