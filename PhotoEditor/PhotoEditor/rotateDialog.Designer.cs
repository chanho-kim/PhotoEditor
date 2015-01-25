namespace PhotoEditor
{
    partial class rotateDialog
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
            this.ninetyDeg = new System.Windows.Forms.RadioButton();
            this.oneEightyDegree = new System.Windows.Forms.RadioButton();
            this.twoSeventyDegree = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ninetyDeg
            // 
            this.ninetyDeg.AutoSize = true;
            this.ninetyDeg.Location = new System.Drawing.Point(19, 12);
            this.ninetyDeg.Name = "ninetyDeg";
            this.ninetyDeg.Size = new System.Drawing.Size(80, 17);
            this.ninetyDeg.TabIndex = 0;
            this.ninetyDeg.TabStop = true;
            this.ninetyDeg.Text = "90 Degrees";
            this.ninetyDeg.UseVisualStyleBackColor = true;
            // 
            // oneEightyDegree
            // 
            this.oneEightyDegree.AutoSize = true;
            this.oneEightyDegree.Location = new System.Drawing.Point(19, 35);
            this.oneEightyDegree.Name = "oneEightyDegree";
            this.oneEightyDegree.Size = new System.Drawing.Size(86, 17);
            this.oneEightyDegree.TabIndex = 1;
            this.oneEightyDegree.TabStop = true;
            this.oneEightyDegree.Text = "180 Degrees";
            this.oneEightyDegree.UseVisualStyleBackColor = true;
            // 
            // twoSeventyDegree
            // 
            this.twoSeventyDegree.AutoSize = true;
            this.twoSeventyDegree.Location = new System.Drawing.Point(19, 58);
            this.twoSeventyDegree.Name = "twoSeventyDegree";
            this.twoSeventyDegree.Size = new System.Drawing.Size(86, 17);
            this.twoSeventyDegree.TabIndex = 2;
            this.twoSeventyDegree.TabStop = true;
            this.twoSeventyDegree.Text = "270 Degrees";
            this.twoSeventyDegree.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(19, 91);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(80, 23);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(19, 120);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // rotateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(121, 151);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.twoSeventyDegree);
            this.Controls.Add(this.oneEightyDegree);
            this.Controls.Add(this.ninetyDeg);
            this.Name = "rotateDialog";
            this.Text = "rotateDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ninetyDeg;
        private System.Windows.Forms.RadioButton oneEightyDegree;
        private System.Windows.Forms.RadioButton twoSeventyDegree;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
    }
}