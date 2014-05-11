namespace Lenticuprint
{
    partial class UserNumberDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this._cancel = new System.Windows.Forms.Button();
            this._confirm = new System.Windows.Forms.Button();
            this._value = new System.Windows.Forms.NumericUpDown();
            this._caption = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._value)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._confirm);
            this.panel1.Controls.Add(this._cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 69);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(368, 28);
            this.panel1.TabIndex = 0;
            // 
            // _cancel
            // 
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this._cancel.Location = new System.Drawing.Point(293, 5);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(75, 23);
            this._cancel.TabIndex = 0;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            // 
            // _confirm
            // 
            this._confirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this._confirm.Location = new System.Drawing.Point(218, 5);
            this._confirm.Name = "_confirm";
            this._confirm.Size = new System.Drawing.Size(75, 23);
            this._confirm.TabIndex = 1;
            this._confirm.Text = "OK";
            this._confirm.UseVisualStyleBackColor = true;
            this._confirm.Click += new System.EventHandler(this._confirm_Click);
            // 
            // _value
            // 
            this._value.DecimalPlaces = 12;
            this._value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._value.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this._value.Location = new System.Drawing.Point(5, 49);
            this._value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            786432});
            this._value.Name = "_value";
            this._value.Size = new System.Drawing.Size(368, 20);
            this._value.TabIndex = 1;
            this._value.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this._value.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _caption
            // 
            this._caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this._caption.Location = new System.Drawing.Point(5, 5);
            this._caption.Name = "_caption";
            this._caption.Size = new System.Drawing.Size(368, 44);
            this._caption.TabIndex = 2;
            this._caption.Text = "Use up and down arrows or enter a numeric value";
            // 
            // UserNumberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancel;
            this.ClientSize = new System.Drawing.Size(378, 102);
            this.ControlBox = false;
            this.Controls.Add(this._caption);
            this.Controls.Add(this._value);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserNumberDialog";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select a value";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _confirm;
        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.NumericUpDown _value;
        private System.Windows.Forms.Label _caption;
    }
}