namespace PhotoEditor
{
    partial class flipDialog
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
            this.overX = new System.Windows.Forms.RadioButton();
            this.overY = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // overX
            // 
            this.overX.AutoSize = true;
            this.overX.Location = new System.Drawing.Point(20, 3);
            this.overX.Name = "overX";
            this.overX.Size = new System.Drawing.Size(78, 17);
            this.overX.TabIndex = 0;
            this.overX.TabStop = true;
            this.overX.Text = "over X-Axis";
            this.overX.UseVisualStyleBackColor = true;
            // 
            // overY
            // 
            this.overY.AutoSize = true;
            this.overY.Location = new System.Drawing.Point(116, 3);
            this.overY.Name = "overY";
            this.overY.Size = new System.Drawing.Size(78, 17);
            this.overY.TabIndex = 1;
            this.overY.TabStop = true;
            this.overY.Text = "over Y-Axis";
            this.overY.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(23, 26);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(116, 27);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // flipDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 59);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.overY);
            this.Controls.Add(this.overX);
            this.Name = "flipDialog";
            this.Text = "flipDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton overX;
        private System.Windows.Forms.RadioButton overY;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
    }
}