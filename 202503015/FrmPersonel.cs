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
    public partial class FrmPersonel : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";
        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from dbo.Personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "dbo.Personel");
            dataGridView1.DataSource = ds.Tables["dbo.Personel"];
            con.Close();
        }
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand("insert into Personel (personelAdSoyad,personelDepartman) values (@p1,@p2)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kaydetme İşlemi Gerçekleşti.");
            GridDoldur();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand("delete from Personel where personelID=@p1", con);
            con.Open();
            cmd.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Silme İşleme Gerçekleşti.");
            GridDoldur();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand("update Personel set personelAdSoyad=@p1,personelDepartman=@p2 where personelID=@p3", con);
            con.Open();
            cmd.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            cmd.Parameters.AddWithValue("@p3", TxtPersonelID.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
            GridDoldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtPersonelAd.Text = ad;
            TxtPersonelGorev.Text = gorev;
            TxtPersonelID.Text = id;
        }
    }
}
