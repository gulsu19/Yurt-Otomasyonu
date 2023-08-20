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
    public partial class FrmGiderListesi : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            VeriBaglantilarNavigasyon();
        }

        public void VeriBaglantilarNavigasyon()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Giderler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            con.Close();

            bindingSource1.DataSource = ds.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;

            label8.DataBindings.Add(new Binding("Text", bindingSource1, "odemeID"));
            TxtElektrik.DataBindings.Add(new Binding("Text", bindingSource1, "Elektrik"));
            TxtSu.DataBindings.Add(new Binding("Text", bindingSource1, "Su"));
            TxtDogalgaz.DataBindings.Add(new Binding("Text", bindingSource1, "Doğalgaz"));
            Txtİnternet.DataBindings.Add(new Binding("Text", bindingSource1, "İnternet"));
            TxtGıda.DataBindings.Add(new Binding("Text", bindingSource1, "Gıda"));
            TxtPersonel.DataBindings.Add(new Binding("Text", bindingSource1, "Personel"));
            TxtDiger.DataBindings.Add(new Binding("Text", bindingSource1, "Diger"));

        }
    }
}
