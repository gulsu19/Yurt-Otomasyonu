using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202503015
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciListe frm = new FrmOgrenciListe();
            frm.ShowDialog();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrDuzenle frm = new FrmOgrDuzenle();
            frm.ShowDialog();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm = new FrmBolumler();
            frm.ShowDialog();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler frm = new FrmOdemeler();
            frm.ShowDialog();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider frm = new FrmGider();
            frm.ShowDialog();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi frm = new FrmGiderListesi();
            frm.ShowDialog();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirİstatistik frm = new FrmGelirİstatistik();
            frm.ShowDialog();
        }

        private void yöneticiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiİslemleri frm = new FrmYoneticiİslemleri();
            frm.ShowDialog();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.ShowDialog();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
