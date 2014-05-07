namespace Lenticuprint
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this._direction = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this._lpi = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnPreview = new System.Windows.Forms.Button();
            this._btnAddImage = new System.Windows.Forms.Button();
            this._btnPrint = new System.Windows.Forms.Button();
            this._btnPrintTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnClose = new System.Windows.Forms.Button();
            this._pnlImages = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._shift = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._lpi)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._shift)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Settings";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 37);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(194, 21);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this._direction);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(55, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(139, 21);
            this.panel10.TabIndex = 1;
            // 
            // _direction
            // 
            this._direction.Dock = System.Windows.Forms.DockStyle.Fill;
            this._direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._direction.FormattingEnabled = true;
            this._direction.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this._direction.Location = new System.Drawing.Point(0, 0);
            this._direction.Name = "_direction";
            this._direction.Size = new System.Drawing.Size(139, 21);
            this._direction.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(55, 21);
            this.panel11.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Direction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 21);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this._lpi);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(55, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 21);
            this.panel5.TabIndex = 1;
            // 
            // _lpi
            // 
            this._lpi.DecimalPlaces = 5;
            this._lpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lpi.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._lpi.Location = new System.Drawing.Point(0, 0);
            this._lpi.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this._lpi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._lpi.Name = "_lpi";
            this._lpi.Size = new System.Drawing.Size(139, 20);
            this._lpi.TabIndex = 0;
            this._lpi.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this._lpi.Value = new decimal(new int[] {
            673125,
            0,
            0,
            262144});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(55, 21);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LPI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 259);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this._btnPreview);
            this.flowLayoutPanel1.Controls.Add(this._btnAddImage);
            this.flowLayoutPanel1.Controls.Add(this._btnPrint);
            this.flowLayoutPanel1.Controls.Add(this._btnPrintTest);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 169);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // _btnPreview
            // 
            this._btnPreview.Location = new System.Drawing.Point(103, 3);
            this._btnPreview.Name = "_btnPreview";
            this._btnPreview.Size = new System.Drawing.Size(94, 25);
            this._btnPreview.TabIndex = 0;
            this._btnPreview.Text = "Preview";
            this._btnPreview.UseVisualStyleBackColor = true;
            this._btnPreview.Click += new System.EventHandler(this._btnPreview_Click);
            // 
            // _btnAddImage
            // 
            this._btnAddImage.Location = new System.Drawing.Point(3, 3);
            this._btnAddImage.Name = "_btnAddImage";
            this._btnAddImage.Size = new System.Drawing.Size(94, 25);
            this._btnAddImage.TabIndex = 1;
            this._btnAddImage.Text = "Add Image";
            this._btnAddImage.UseVisualStyleBackColor = true;
            this._btnAddImage.Click += new System.EventHandler(this._btnAddImage_Click);
            // 
            // _btnPrint
            // 
            this._btnPrint.Location = new System.Drawing.Point(103, 34);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(94, 25);
            this._btnPrint.TabIndex = 2;
            this._btnPrint.Text = "Print";
            this._btnPrint.UseVisualStyleBackColor = true;
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // _btnPrintTest
            // 
            this._btnPrintTest.Location = new System.Drawing.Point(3, 34);
            this._btnPrintTest.Name = "_btnPrintTest";
            this._btnPrintTest.Size = new System.Drawing.Size(94, 25);
            this._btnPrintTest.TabIndex = 3;
            this._btnPrintTest.Text = "Print Test";
            this._btnPrintTest.UseVisualStyleBackColor = true;
            this._btnPrintTest.Click += new System.EventHandler(this._btnPrintTest_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 24);
            this.panel2.TabIndex = 2;
            // 
            // _btnClose
            // 
            this._btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this._btnClose.Location = new System.Drawing.Point(125, 0);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 24);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _pnlImages
            // 
            this._pnlImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlImages.Location = new System.Drawing.Point(200, 0);
            this._pnlImages.Name = "_pnlImages";
            this._pnlImages.Size = new System.Drawing.Size(629, 227);
            this._pnlImages.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._shift);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(200, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 32);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horizontal Shift";
            // 
            // _shift
            // 
            this._shift.Dock = System.Windows.Forms.DockStyle.Fill;
            this._shift.Location = new System.Drawing.Point(3, 16);
            this._shift.Maximum = 100;
            this._shift.Minimum = -100;
            this._shift.Name = "_shift";
            this._shift.Size = new System.Drawing.Size(623, 13);
            this._shift.TabIndex = 0;
            this._shift.TickFrequency = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 259);
            this.Controls.Add(this._pnlImages);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lenticuprint";
            this.groupBox1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._lpi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._shift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _btnPreview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnAddImage;
        private System.Windows.Forms.Button _btnPrint;
        private System.Windows.Forms.FlowLayoutPanel _pnlImages;
        private System.Windows.Forms.Button _btnPrintTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar _shift;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown _lpi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _direction;
    }
}

