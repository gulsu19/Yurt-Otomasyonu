using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _202503015
{
    public partial class FrmYoneticiİslemleri : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("Select * from dbo.Admin", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "dbo.Admin");
            dataGridView1.DataSource = ds.Tables["dbo.Admin"];
            con.Close();

        }
        public FrmYoneticiİslemleri()
        {
            InitializeComponent();
        }

        private void FrmYoneticiİslemleri_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            SqlCommand cmd1 = new SqlCommand("insert into Admin (yoneticiAd,yoneticiSifre) values (@p1,@p2)", con);
            con.Open();
            cmd1.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            cmd1.Parameters.AddWithValue("@p2", FrmMD5sifre.MD5sifre(TxtSifre.Text));
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yeni Yönetici Eklendi.");
            GridDoldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtKullaniciAd.Text = ad;
            TxtSifre.Text = sifre;
            TxtYoneticiID.Text = id;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            SqlCommand cmd2 = new SqlCommand("delete from Admin where yoneticiID=@p1", con);
            con.Open();
            cmd2.Parameters.AddWithValue("@p1", TxtYoneticiID.Text);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti.");
            GridDoldur();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            SqlCommand cmd3 = new SqlCommand("update Admin set yoneticiAd=@p1,yoneticiSifre=@p2 where yoneticiID=@p3", con);
            con.Open();
            cmd3.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            cmd3.Parameters.AddWithValue("@p2", TxtSifre.Text);
            cmd3.Parameters.AddWithValue("@p3", TxtYoneticiID.Text);
            cmd3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme İşlemi Tamamlandı.");
            GridDoldur();
        }
    }
}
