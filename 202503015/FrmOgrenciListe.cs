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
    public partial class FrmOgrenciListe : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";
        public FrmOgrenciListe()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListe_Load(object sender, EventArgs e)
        {
            VeriBaglantilarNavigasyon();
        }

        public void VeriBaglantilarNavigasyon()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            con.Close();

            bindingSource1.DataSource = ds.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;

            label13.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciID"));
            TxtOgrAd.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciAd"));
            TxtOgrSoyad.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciSoyad"));
            MskTC.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciTC"));
            MskOgrTelefon.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciTelefon"));
            MskDogum.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciDogum"));
            CmbBolum.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciBolum"));
            TxtMail.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciMail"));
            CmbOdaNo.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciOdaNo"));
            TxtVeliAdSoyad.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciVeliAdSoyad"));
            MskVeliTelefon.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciveliTelefon"));
            RchAdres.DataBindings.Add(new Binding("Text", bindingSource1, "ogrenciVeliAdres"));


        }
    }
}
