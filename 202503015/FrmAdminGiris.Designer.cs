namespace _202503015
{
    partial class FrmAdminGiris
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
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LblCaptcha = new System.Windows.Forms.Label();
            this.TxtCaptcha = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Location = new System.Drawing.Point(542, 183);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(196, 22);
            this.TxtKullaniciAd.TabIndex = 0;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(542, 262);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(196, 22);
            this.TxtSifre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(622, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblCaptcha
            // 
            this.LblCaptcha.AutoSize = true;
            this.LblCaptcha.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCaptcha.Location = new System.Drawing.Point(500, 329);
            this.LblCaptcha.Name = "LblCaptcha";
            this.LblCaptcha.Size = new System.Drawing.Size(122, 23);
            this.LblCaptcha.TabIndex = 3;
            this.LblCaptcha.Text = "LblCaptcha";
            // 
            // TxtCaptcha
            // 
            this.TxtCaptcha.Location = new System.Drawing.Point(606, 329);
            this.TxtCaptcha.Name = "TxtCaptcha";
            this.TxtCaptcha.Size = new System.Drawing.Size(116, 22);
            this.TxtCaptcha.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(184, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "İSTE KIZ YURDU ADMİN GİRİŞİ";
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_202503015.Properties.Resources._156;
            this.ClientSize = new System.Drawing.Size(815, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCaptcha);
            this.Controls.Add(this.LblCaptcha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.button2);
            this.Name = "FrmAdminGiris";
            this.Text = "FrmAdminGiris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblCaptcha;
        private System.Windows.Forms.TextBox TxtCaptcha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

