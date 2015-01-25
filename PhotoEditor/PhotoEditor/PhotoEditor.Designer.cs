namespace PhotoEditor
{
    partial class PhotoEditor
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
            this.menuContainer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bBar = new System.Windows.Forms.TrackBar();
            this.gBar = new System.Windows.Forms.TrackBar();
            this.rBar = new System.Windows.Forms.TrackBar();
            this.sepia = new System.Windows.Forms.Button();
            this.grayscale = new System.Windows.Forms.Button();
            this.original = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gammaBar = new System.Windows.Forms.TrackBar();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.imageContainer = new System.Windows.Forms.Panel();
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.crop = new System.Windows.Forms.Button();
            this.flip = new System.Windows.Forms.Button();
            this.rotate = new System.Windows.Forms.Button();
            this.invert = new System.Windows.Forms.Button();
            this.menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            this.imageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuContainer.Controls.Add(this.invert);
            this.menuContainer.Controls.Add(this.rotate);
            this.menuContainer.Controls.Add(this.flip);
            this.menuContainer.Controls.Add(this.crop);
            this.menuContainer.Controls.Add(this.label4);
            this.menuContainer.Controls.Add(this.label5);
            this.menuContainer.Controls.Add(this.label6);
            this.menuContainer.Controls.Add(this.bBar);
            this.menuContainer.Controls.Add(this.gBar);
            this.menuContainer.Controls.Add(this.rBar);
            this.menuContainer.Controls.Add(this.sepia);
            this.menuContainer.Controls.Add(this.grayscale);
            this.menuContainer.Controls.Add(this.original);
            this.menuContainer.Controls.Add(this.label3);
            this.menuContainer.Controls.Add(this.label2);
            this.menuContainer.Controls.Add(this.label1);
            this.menuContainer.Controls.Add(this.gammaBar);
            this.menuContainer.Controls.Add(this.contrastBar);
            this.menuContainer.Controls.Add(this.brightnessBar);
            this.menuContainer.Controls.Add(this.save);
            this.menuContainer.Controls.Add(this.open);
            this.menuContainer.Location = new System.Drawing.Point(-2, 0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(1185, 80);
            this.menuContainer.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1076, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Blue";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(968, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Green";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(868, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Red";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bBar
            // 
            this.bBar.Location = new System.Drawing.Point(1072, 35);
            this.bBar.Margin = new System.Windows.Forms.Padding(0);
            this.bBar.Maximum = 8;
            this.bBar.Name = "bBar";
            this.bBar.Size = new System.Drawing.Size(104, 45);
            this.bBar.TabIndex = 15;
            this.bBar.TickFrequency = 0;
            this.bBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bBar.Value = 4;
            this.bBar.Scroll += new System.EventHandler(this.bBar_Scroll);
            // 
            // gBar
            // 
            this.gBar.Location = new System.Drawing.Point(968, 35);
            this.gBar.Margin = new System.Windows.Forms.Padding(0);
            this.gBar.Maximum = 8;
            this.gBar.Name = "gBar";
            this.gBar.Size = new System.Drawing.Size(104, 45);
            this.gBar.TabIndex = 14;
            this.gBar.TickFrequency = 0;
            this.gBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gBar.Value = 4;
            this.gBar.Scroll += new System.EventHandler(this.gBar_Scroll);
            // 
            // rBar
            // 
            this.rBar.Location = new System.Drawing.Point(864, 35);
            this.rBar.Margin = new System.Windows.Forms.Padding(0);
            this.rBar.Maximum = 8;
            this.rBar.Name = "rBar";
            this.rBar.Size = new System.Drawing.Size(104, 45);
            this.rBar.TabIndex = 13;
            this.rBar.TickFrequency = 0;
            this.rBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rBar.Value = 4;
            this.rBar.Scroll += new System.EventHandler(this.rBar_Scroll);
            // 
            // sepia
            // 
            this.sepia.Location = new System.Drawing.Point(328, 35);
            this.sepia.Name = "sepia";
            this.sepia.Size = new System.Drawing.Size(75, 23);
            this.sepia.TabIndex = 12;
            this.sepia.Text = "Sepia";
            this.sepia.UseVisualStyleBackColor = true;
            this.sepia.Click += new System.EventHandler(this.sepia_Click);
            // 
            // grayscale
            // 
            this.grayscale.Location = new System.Drawing.Point(247, 35);
            this.grayscale.Name = "grayscale";
            this.grayscale.Size = new System.Drawing.Size(75, 23);
            this.grayscale.TabIndex = 11;
            this.grayscale.Text = "Grayscale";
            this.grayscale.UseVisualStyleBackColor = true;
            this.grayscale.Click += new System.EventHandler(this.grayscale_Click);
            // 
            // original
            // 
            this.original.Location = new System.Drawing.Point(166, 35);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(75, 23);
            this.original.TabIndex = 10;
            this.original.Text = "Original";
            this.original.UseVisualStyleBackColor = true;
            this.original.Click += new System.EventHandler(this.original_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(738, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gamma Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(630, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contrast";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(530, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Brightness";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gammaBar
            // 
            this.gammaBar.Location = new System.Drawing.Point(734, 35);
            this.gammaBar.Margin = new System.Windows.Forms.Padding(0);
            this.gammaBar.Maximum = 8;
            this.gammaBar.Name = "gammaBar";
            this.gammaBar.Size = new System.Drawing.Size(104, 45);
            this.gammaBar.TabIndex = 6;
            this.gammaBar.TickFrequency = 0;
            this.gammaBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gammaBar.Value = 4;
            this.gammaBar.Scroll += new System.EventHandler(this.gammaBar_Scroll);
            // 
            // contrastBar
            // 
            this.contrastBar.Location = new System.Drawing.Point(630, 35);
            this.contrastBar.Margin = new System.Windows.Forms.Padding(0);
            this.contrastBar.Maximum = 8;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(104, 45);
            this.contrastBar.TabIndex = 5;
            this.contrastBar.TickFrequency = 0;
            this.contrastBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.contrastBar.Value = 4;
            this.contrastBar.Scroll += new System.EventHandler(this.contrastBar_Scroll);
            // 
            // brightnessBar
            // 
            this.brightnessBar.Location = new System.Drawing.Point(526, 35);
            this.brightnessBar.Margin = new System.Windows.Forms.Padding(0);
            this.brightnessBar.Maximum = 8;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(104, 45);
            this.brightnessBar.TabIndex = 4;
            this.brightnessBar.TickFrequency = 0;
            this.brightnessBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brightnessBar.Value = 4;
            this.brightnessBar.Scroll += new System.EventHandler(this.brightnessBar_Scroll);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(85, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(4, 4);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // imageContainer
            // 
            this.imageContainer.AutoScroll = true;
            this.imageContainer.Controls.Add(this.mainImage);
            this.imageContainer.Location = new System.Drawing.Point(0, 85);
            this.imageContainer.Margin = new System.Windows.Forms.Padding(0);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(1185, 675);
            this.imageContainer.TabIndex = 2;
            // 
            // mainImage
            // 
            this.mainImage.Location = new System.Drawing.Point(5, 0);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(434, 336);
            this.mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainImage.TabIndex = 0;
            this.mainImage.TabStop = false;
            this.mainImage.Paint += new System.Windows.Forms.PaintEventHandler(this.mainImage_Paint);
            this.mainImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainImage_MouseDown);
            this.mainImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainImage_MouseMove);
            this.mainImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainImage_MouseUp);
            // 
            // crop
            // 
            this.crop.Location = new System.Drawing.Point(409, 6);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(75, 23);
            this.crop.TabIndex = 19;
            this.crop.Text = "Crop";
            this.crop.UseVisualStyleBackColor = true;
            this.crop.Click += new System.EventHandler(this.crop_Click);
            // 
            // flip
            // 
            this.flip.Location = new System.Drawing.Point(247, 6);
            this.flip.Name = "flip";
            this.flip.Size = new System.Drawing.Size(75, 23);
            this.flip.TabIndex = 20;
            this.flip.Text = "Flip";
            this.flip.UseVisualStyleBackColor = true;
            this.flip.Click += new System.EventHandler(this.flip_Click);
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(328, 6);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 23);
            this.rotate.TabIndex = 21;
            this.rotate.Text = "Rotate";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // invert
            // 
            this.invert.Location = new System.Drawing.Point(409, 35);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(75, 23);
            this.invert.TabIndex = 22;
            this.invert.Text = "Invert";
            this.invert.UseVisualStyleBackColor = true;
            this.invert.Click += new System.EventHandler(this.invert_Click);
            // 
            // PhotoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.menuContainer);
            this.Controls.Add(this.imageContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PhotoEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoEditor";
            this.Resize += new System.EventHandler(this.PhotoEditor_Resize);
            this.menuContainer.ResumeLayout(false);
            this.menuContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            this.imageContainer.ResumeLayout(false);
            this.imageContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Panel imageContainer;
        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar gammaBar;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.Button sepia;
        private System.Windows.Forms.Button grayscale;
        private System.Windows.Forms.Button original;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar bBar;
        private System.Windows.Forms.TrackBar gBar;
        private System.Windows.Forms.TrackBar rBar;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Button flip;
    }
}

