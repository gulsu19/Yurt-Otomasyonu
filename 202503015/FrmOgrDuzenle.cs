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
    public partial class FrmOgrDuzenle : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ogrenci");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            GridDoldur();
            /* Bölümleri ekliyorum*/
            con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select bolumAd from Bolumler", con);
            SqlDataReader dr2 = cmd3.ExecuteReader();
            while (dr2.Read())
            {
                CmbBolum.Items.Add(dr2[0].ToString());
            }
            con.Close();

            /* Oda noları ekliyorum*/
            con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select odaNo from Odalar", con);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                CmbOdaNo.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci bilgilerini kaydetme.
            con = new SqlConnection(SqlCon);
            con.Open();
            cmd = new SqlCommand("insert into Ogrenci (ogrenciAd,ogrenciSoyad,ogrenciTC,ogrenciTelefon,ogrenciDogum,ogrenciBolum,ogrenciMail,ogrenciOdaNo,ogrenciVeliAdSoyad,ogrenciVeliTelefon,ogrenciVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", con);
            cmd.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", MskTC.Text);
            cmd.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
            cmd.Parameters.AddWithValue("@p5", MskDogum.Text);
            cmd.Parameters.AddWithValue("@p6", CmbBolum.Text);
            cmd.Parameters.AddWithValue("@p7", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
            cmd.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
            cmd.Parameters.AddWithValue("@p11", RchAdres.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşti.");

            GridDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            SqlCommand cmd1 = new SqlCommand("delete from Ogrenci where ogrenciID=@k1", con);
            con.Open();
            cmd1.Parameters.AddWithValue("@k1", TxtOgrId.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Silindi.");

            GridDoldur();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand("update Ogrenci set ogrenciAd=@p2,ogrenciSoyad=@p3,ogrenciTC=@p4,ogrenciTelefon=@p5,ogrenciDogum=@p6,ogrenciBolum=@p7,ogrenciMail=@p8,ogrenciOdaNo=@p9,ogrenciVeliAdSoyad=@p10,ogrenciVeliTelefon=@p11,ogrenciVeliAdres=@p12 where ogrenciID=@p1", con);
            con.Open();
            cmd.Parameters.AddWithValue("@p1", TxtOgrId.Text);
            cmd.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
            cmd.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
            cmd.Parameters.AddWithValue("@p4", MskTC.Text);
            cmd.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
            cmd.Parameters.AddWithValue("@p6", MskDogum.Text);
            cmd.Parameters.AddWithValue("@p7", CmbBolum.Text);
            cmd.Parameters.AddWithValue("@p8", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
            cmd.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
            cmd.Parameters.AddWithValue("@p12", RchAdres.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme gerçekleşti.");

            GridDoldur();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TxtOgrId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtOgrAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtOgrSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MskTC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MskOgrTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            MskDogum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            CmbBolum.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TxtMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            CmbOdaNo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            TxtVeliAdSoyad.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            MskVeliTelefon.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            RchAdres.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void BtnYeniKayıt_Click(object sender, EventArgs e)
        {
            TxtOgrId.Clear();
            TxtOgrAd.Clear();
            TxtOgrSoyad.Clear();
            MskTC.Clear();
            MskOgrTelefon.Clear();
            MskDogum.Clear();
            TxtMail.Clear();
            TxtVeliAdSoyad.Clear();
            MskVeliTelefon.Clear();
            RchAdres.Clear();
        }
    }
}
