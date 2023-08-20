namespace _202503015
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.TxtBolumID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PcbBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.PcbBolumSil = new System.Windows.Forms.PictureBox();
            this.PcbBolumEkle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(362, 235);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bölüm Ad:";
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Location = new System.Drawing.Point(223, 229);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(250, 22);
            this.TxtBolumAd.TabIndex = 11;
            // 
            // TxtBolumID
            // 
            this.TxtBolumID.Location = new System.Drawing.Point(223, 175);
            this.TxtBolumID.Name = "TxtBolumID";
            this.TxtBolumID.Size = new System.Drawing.Size(250, 22);
            this.TxtBolumID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bölüm ID:";
            // 
            // PcbBolumDuzenle
            // 
            this.PcbBolumDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumDuzenle.Image")));
            this.PcbBolumDuzenle.Location = new System.Drawing.Point(422, 12);
            this.PcbBolumDuzenle.Name = "PcbBolumDuzenle";
            this.PcbBolumDuzenle.Size = new System.Drawing.Size(141, 126);
            this.PcbBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumDuzenle.TabIndex = 12;
            this.PcbBolumDuzenle.TabStop = false;
            this.PcbBolumDuzenle.Click += new System.EventHandler(this.PcbBolumDuzenle_Click);
            // 
            // PcbBolumSil
            // 
            this.PcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumSil.Image")));
            this.PcbBolumSil.Location = new System.Drawing.Point(223, 12);
            this.PcbBolumSil.Name = "PcbBolumSil";
            this.PcbBolumSil.Size = new System.Drawing.Size(141, 126);
            this.PcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumSil.TabIndex = 10;
            this.PcbBolumSil.TabStop = false;
            this.PcbBolumSil.Click += new System.EventHandler(this.PcbBolumSil_Click);
            // 
            // PcbBolumEkle
            // 
            this.PcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumEkle.Image")));
            this.PcbBolumEkle.Location = new System.Drawing.Point(23, 12);
            this.PcbBolumEkle.Name = "PcbBolumEkle";
            this.PcbBolumEkle.Size = new System.Drawing.Size(141, 126);
            this.PcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumEkle.TabIndex = 8;
            this.PcbBolumEkle.TabStop = false;
            this.PcbBolumEkle.Click += new System.EventHandler(this.PcbBolumEkle_Click);
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(615, 604);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.TxtBolumID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbBolumDuzenle);
            this.Controls.Add(this.PcbBolumSil);
            this.Controls.Add(this.PcbBolumEkle);
            this.Name = "FrmBolumler";
            this.Text = "FrmBolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.TextBox TxtBolumID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PcbBolumDuzenle;
        private System.Windows.Forms.PictureBox PcbBolumSil;
        private System.Windows.Forms.PictureBox PcbBolumEkle;
    }
}