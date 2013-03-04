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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this._nupMargin = new System.Windows.Forms.NumericUpDown();
            this._nupHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._nupLpi = new System.Windows.Forms.NumericUpDown();
            this._nupWidth = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnPreview = new System.Windows.Forms.Button();
            this._btnAddImage = new System.Windows.Forms.Button();
            this._btnPrint = new System.Windows.Forms.Button();
            this._btnPrintTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this._pnlImages = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._tkbHorzShift = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nupMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nupHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nupLpi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nupWidth)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tkbHorzShift)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._nupMargin, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._nupHeight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._nupLpi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._nupWidth, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Margin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _nupMargin
            // 
            this._nupMargin.DecimalPlaces = 2;
            this._nupMargin.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nupMargin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this._nupMargin.Location = new System.Drawing.Point(67, 75);
            this._nupMargin.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nupMargin.Name = "_nupMargin";
            this._nupMargin.Size = new System.Drawing.Size(124, 20);
            this._nupMargin.TabIndex = 5;
            this._nupMargin.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // _nupHeight
            // 
            this._nupHeight.DecimalPlaces = 2;
            this._nupHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nupHeight.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this._nupHeight.Location = new System.Drawing.Point(67, 51);
            this._nupHeight.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this._nupHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._nupHeight.Name = "_nupHeight";
            this._nupHeight.Size = new System.Drawing.Size(124, 20);
            this._nupHeight.TabIndex = 4;
            this._nupHeight.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LPI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _nupLpi
            // 
            this._nupLpi.DecimalPlaces = 2;
            this._nupLpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nupLpi.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this._nupLpi.Location = new System.Drawing.Point(67, 3);
            this._nupLpi.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this._nupLpi.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._nupLpi.Name = "_nupLpi";
            this._nupLpi.Size = new System.Drawing.Size(124, 20);
            this._nupLpi.TabIndex = 1;
            this._nupLpi.Value = new decimal(new int[] {
            20200,
            0,
            0,
            131072});
            // 
            // _nupWidth
            // 
            this._nupWidth.DecimalPlaces = 2;
            this._nupWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nupWidth.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this._nupWidth.Location = new System.Drawing.Point(67, 27);
            this._nupWidth.Maximum = new decimal(new int[] {
            85,
            0,
            0,
            65536});
            this._nupWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._nupWidth.Name = "_nupWidth";
            this._nupWidth.Size = new System.Drawing.Size(124, 20);
            this._nupWidth.TabIndex = 3;
            this._nupWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 117);
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
            this.panel2.Controls.Add(this._btnSave);
            this.panel2.Controls.Add(this._btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 24);
            this.panel2.TabIndex = 2;
            // 
            // _btnSave
            // 
            this._btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this._btnSave.Location = new System.Drawing.Point(50, 0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 24);
            this._btnSave.TabIndex = 1;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
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
            this.groupBox2.Controls.Add(this._tkbHorzShift);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(200, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 32);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horizontal Shift";
            // 
            // _tkbHorzShift
            // 
            this._tkbHorzShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tkbHorzShift.Location = new System.Drawing.Point(3, 16);
            this._tkbHorzShift.Maximum = 100;
            this._tkbHorzShift.Minimum = -100;
            this._tkbHorzShift.Name = "_tkbHorzShift";
            this._tkbHorzShift.Size = new System.Drawing.Size(623, 13);
            this._tkbHorzShift.TabIndex = 0;
            this._tkbHorzShift.TickFrequency = 5;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._nupMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nupHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nupLpi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nupWidth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tkbHorzShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown _nupHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _nupLpi;
        private System.Windows.Forms.NumericUpDown _nupWidth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _btnPreview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnAddImage;
        private System.Windows.Forms.Button _btnPrint;
        private System.Windows.Forms.FlowLayoutPanel _pnlImages;
        private System.Windows.Forms.Button _btnPrintTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _nupMargin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar _tkbHorzShift;
    }
}

