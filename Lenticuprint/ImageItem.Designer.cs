namespace Lenticuprint
{
    partial class ImageItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this._close = new System.Windows.Forms.Button();
            this._rotate = new System.Windows.Forms.Button();
            this._title = new System.Windows.Forms.Label();
            this._image = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._title);
            this.panel1.Controls.Add(this._rotate);
            this.panel1.Controls.Add(this._close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 24);
            this.panel1.TabIndex = 0;
            // 
            // _close
            // 
            this._close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this._close.Dock = System.Windows.Forms.DockStyle.Right;
            this._close.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._close.ForeColor = System.Drawing.Color.Red;
            this._close.Location = new System.Drawing.Point(122, 0);
            this._close.Margin = new System.Windows.Forms.Padding(0);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(24, 22);
            this._close.TabIndex = 0;
            this._close.Text = "x";
            this._close.UseVisualStyleBackColor = false;
            // 
            // _rotate
            // 
            this._rotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._rotate.Dock = System.Windows.Forms.DockStyle.Right;
            this._rotate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rotate.ForeColor = System.Drawing.Color.White;
            this._rotate.Location = new System.Drawing.Point(98, 0);
            this._rotate.Margin = new System.Windows.Forms.Padding(0);
            this._rotate.Name = "_rotate";
            this._rotate.Size = new System.Drawing.Size(24, 22);
            this._rotate.TabIndex = 1;
            this._rotate.Text = "¤";
            this._rotate.UseVisualStyleBackColor = false;
            // 
            // _title
            // 
            this._title.BackColor = System.Drawing.Color.Transparent;
            this._title.Dock = System.Windows.Forms.DockStyle.Fill;
            this._title.ForeColor = System.Drawing.Color.White;
            this._title.Location = new System.Drawing.Point(0, 0);
            this._title.Name = "_title";
            this._title.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._title.Size = new System.Drawing.Size(98, 22);
            this._title.TabIndex = 2;
            this._title.Text = "...";
            this._title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _image
            // 
            this._image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._image.Dock = System.Windows.Forms.DockStyle.Fill;
            this._image.Location = new System.Drawing.Point(0, 24);
            this._image.Name = "_image";
            this._image.Padding = new System.Windows.Forms.Padding(3);
            this._image.Size = new System.Drawing.Size(148, 124);
            this._image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._image.TabIndex = 1;
            this._image.TabStop = false;
            // 
            // ImageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._image);
            this.Controls.Add(this.panel1);
            this.Name = "ImageItem";
            this.Size = new System.Drawing.Size(148, 148);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Button _rotate;
        private System.Windows.Forms.Button _close;
        private System.Windows.Forms.PictureBox _image;
    }
}
