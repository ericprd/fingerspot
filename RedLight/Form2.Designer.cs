namespace RedLight
{
    partial class Details
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
            this.fingerBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fingerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fingerBox
            // 
            this.fingerBox.Location = new System.Drawing.Point(87, 38);
            this.fingerBox.Name = "fingerBox";
            this.fingerBox.Size = new System.Drawing.Size(357, 480);
            this.fingerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fingerBox.TabIndex = 2;
            this.fingerBox.TabStop = false;
            this.fingerBox.Click += new System.EventHandler(this.fingerBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(104, 548);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 83);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Username:";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(197, 652);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(149, 44);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 708);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fingerBox);
            this.Name = "Details";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fingerBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button closeBtn;
    }
}