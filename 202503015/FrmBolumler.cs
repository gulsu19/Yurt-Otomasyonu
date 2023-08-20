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
    public partial class FrmBolumler : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("Select * from dbo.Bolumler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "dbo.Bolumler");
            dataGridView1.DataSource = ds.Tables["dbo.Bolumler"];
            con.Close();
        }
        public FrmBolumler()
        {
            InitializeComponent();
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", con);
                cmd1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bölüm Eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA OLUŞTU!Lütfen Yeniden Deneyin.");
            }
            GridDoldur();
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("delete from Bolumler where bolumID=@p1", con);
                cmd2.Parameters.AddWithValue("@p1", TxtBolumID.Text);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!İşlem Gerçekleşmedi.");
            }
            GridDoldur();
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("update Bolumler Set bolumAd =@p1 where bolumID =@p2", con);
            cmd3.Parameters.AddWithValue("@p2", TxtBolumID.Text);
            cmd3.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
            cmd3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme Gerçekleşti.");
            GridDoldur();

        }

        int selected;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID, bolumAd;
            selected = dataGridView1.SelectedCells[0].RowIndex;
            ID = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            bolumAd = dataGridView1.Rows[selected].Cells[1].Value.ToString();

            TxtBolumID.Text = ID;
            TxtBolumAd.Text = bolumAd;
        }
    }
}
