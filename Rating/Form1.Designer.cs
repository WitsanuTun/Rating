namespace Rating
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
            this.RG = new System.Windows.Forms.RadioButton();
            this.RDM = new System.Windows.Forms.RadioButton();
            this.RD = new System.Windows.Forms.RadioButton();
            this.RYY = new System.Windows.Forms.RadioButton();
            this.RY = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RG
            // 
            this.RG.AutoSize = true;
            this.RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG.Location = new System.Drawing.Point(58, 134);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(143, 41);
            this.RG.TabIndex = 0;
            this.RG.TabStop = true;
            this.RG.Text = "ยอดเยี่ยม";
            this.RG.UseVisualStyleBackColor = true;
            this.RG.CheckedChanged += new System.EventHandler(this.RG_CheckedChanged);
            // 
            // RDM
            // 
            this.RDM.AutoSize = true;
            this.RDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDM.Location = new System.Drawing.Point(58, 181);
            this.RDM.Name = "RDM";
            this.RDM.Size = new System.Drawing.Size(99, 41);
            this.RDM.TabIndex = 1;
            this.RDM.TabStop = true;
            this.RDM.Text = "ดีมาก";
            this.RDM.UseVisualStyleBackColor = true;
            this.RDM.CheckedChanged += new System.EventHandler(this.RDM_CheckedChanged);
            // 
            // RD
            // 
            this.RD.AutoSize = true;
            this.RD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD.Location = new System.Drawing.Point(58, 228);
            this.RD.Name = "RD";
            this.RD.Size = new System.Drawing.Size(52, 41);
            this.RD.TabIndex = 2;
            this.RD.TabStop = true;
            this.RD.Text = "ดี";
            this.RD.UseVisualStyleBackColor = true;
            this.RD.CheckedChanged += new System.EventHandler(this.RD_CheckedChanged);
            // 
            // RYY
            // 
            this.RYY.AutoSize = true;
            this.RYY.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RYY.Location = new System.Drawing.Point(56, 322);
            this.RYY.Name = "RYY";
            this.RYY.Size = new System.Drawing.Size(118, 41);
            this.RYY.TabIndex = 3;
            this.RYY.TabStop = true;
            this.RYY.Text = "ยอดแย่";
            this.RYY.UseVisualStyleBackColor = true;
            this.RYY.CheckedChanged += new System.EventHandler(this.RYY_CheckedChanged);
            // 
            // RY
            // 
            this.RY.AutoSize = true;
            this.RY.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RY.Location = new System.Drawing.Point(56, 275);
            this.RY.Name = "RY";
            this.RY.Size = new System.Drawing.Size(69, 41);
            this.RY.TabIndex = 4;
            this.RY.TabStop = true;
            this.RY.Text = "แย่";
            this.RY.UseVisualStyleBackColor = true;
            this.RY.CheckedChanged += new System.EventHandler(this.RY_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "ให้Canonความพึงพอใจ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rating.Properties.Resources.ยอดเยี่ยม;
            this.pictureBox1.Location = new System.Drawing.Point(272, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RY);
            this.Controls.Add(this.RYY);
            this.Controls.Add(this.RD);
            this.Controls.Add(this.RDM);
            this.Controls.Add(this.RG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RG;
        private System.Windows.Forms.RadioButton RDM;
        private System.Windows.Forms.RadioButton RD;
        private System.Windows.Forms.RadioButton RYY;
        private System.Windows.Forms.RadioButton RY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

