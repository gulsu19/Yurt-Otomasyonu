namespace _202503015
{
    partial class FrmGelirİstatistik
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
            this.LblAyKazanc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbAy = new System.Windows.Forms.ComboBox();
            this.LblPara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAyKazanc
            // 
            this.LblAyKazanc.AutoSize = true;
            this.LblAyKazanc.BackColor = System.Drawing.Color.SeaShell;
            this.LblAyKazanc.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAyKazanc.Location = new System.Drawing.Point(549, 74);
            this.LblAyKazanc.Name = "LblAyKazanc";
            this.LblAyKazanc.Size = new System.Drawing.Size(20, 20);
            this.LblAyKazanc.TabIndex = 11;
            this.LblAyKazanc.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(411, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seçilen Ay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ay Seçin:";
            // 
            // CmbAy
            // 
            this.CmbAy.BackColor = System.Drawing.Color.SeaShell;
            this.CmbAy.FormattingEnabled = true;
            this.CmbAy.Location = new System.Drawing.Point(138, 38);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Size = new System.Drawing.Size(203, 24);
            this.CmbAy.TabIndex = 8;
            this.CmbAy.SelectedIndexChanged += new System.EventHandler(this.CmbAy_SelectedIndexChanged);
            // 
            // LblPara
            // 
            this.LblPara.AutoSize = true;
            this.LblPara.BackColor = System.Drawing.Color.SeaShell;
            this.LblPara.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPara.Location = new System.Drawing.Point(549, 38);
            this.LblPara.Name = "LblPara";
            this.LblPara.Size = new System.Drawing.Size(20, 20);
            this.LblPara.TabIndex = 7;
            this.LblPara.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(377, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kasadaki Para:";
            // 
            // FrmGelirİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(696, 168);
            this.Controls.Add(this.LblAyKazanc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbAy);
            this.Controls.Add(this.LblPara);
            this.Controls.Add(this.label1);
            this.Name = "FrmGelirİstatistik";
            this.Text = "FrmGelirİstatistik";
            this.Load += new System.EventHandler(this.FrmGelirİstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAyKazanc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbAy;
        private System.Windows.Forms.Label LblPara;
        private System.Windows.Forms.Label label1;
    }
}