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
    public partial class FrmAdminGiris : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";

        int sonuc = 0;

        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hocam forma girmek isterseniz kullanıcı=GK,şifre=1910 yazmanız lazım.");
            captchaOlustur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from dbo.Admin where yoneticiAd=@p1 and yoneticiSifre=@p2";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            cmd.Parameters.AddWithValue("@p2", FrmMD5sifre.MD5sifre(TxtSifre.Text));
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                FrmAnaForm frm = new FrmAnaForm();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATA!Tekrardan Deneyiniz.");
                TxtKullaniciAd.Clear();
                TxtSifre.Clear();
                TxtKullaniciAd.Focus();
            }
            con.Close();



        }

        public void captchaOlustur()
        {
            Random r = new Random();
            int ilk = r.Next(0, 50);
            int ikinci = r.Next(0, 50);
            sonuc = ilk + ikinci;

            LblCaptcha.Text = ilk.ToString() + "+" + ikinci.ToString() + "=";

            TxtCaptcha.Clear();
        }

    }
}
