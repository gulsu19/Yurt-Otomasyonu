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
    public partial class FrmOdemeler : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select ogrenciID,ogrenciAd,ogrenciSoyad,ogrenciKalanBorc from Borclar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "dbo.Borclar");
            dataGridView1.DataSource = ds.Tables["dbo.Borclar"];
            con.Close();
        }

        public FrmOdemeler()
        {
            InitializeComponent();
        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected;
            string ID, ad, soyad, kalan;
            selected = dataGridView1.SelectedCells[0].RowIndex;
            ID = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[selected].Cells[3].Value.ToString();

            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            TxtKalan.Text = kalan;
            TxtOgrId.Text = ID;
        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            //yeni tutarı veri tabanına kaydetme
            con.Open();
            SqlCommand cmd1 = new SqlCommand("update Borclar set ogrenciKalanBorc=@p1 where ogrenciID=@p2 ", con);
            cmd1.Parameters.AddWithValue("@p2", TxtOgrId.Text);
            cmd1.Parameters.AddWithValue("@p1", TxtKalan.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Borç Ödendi.");

            // Kasa tablosuna ekleme yapma
            SqlCommand cmd2 = new SqlCommand("insert into Kasa (odemeAy,odemeMiktar) values (@k1,@k2)", con);
            con.Open();
            cmd2.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            cmd2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            cmd2.ExecuteNonQuery();
            con.Close();

            GridDoldur();
        }
    }
}
