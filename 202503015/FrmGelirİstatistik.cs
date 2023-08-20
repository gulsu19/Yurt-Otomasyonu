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
    public partial class FrmGelirİstatistik : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }

        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            // kasadaki toplam parayı gösterme
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand("select Sum (odemeMiktar) from Kasa", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblPara.Text = dr[0].ToString() + "TL";
            }
            con.Close();

            //tekrarsız olarak ayları listeleme
            SqlCommand cmd2 = new SqlCommand("select distinct (odemeAy) from Kasa ", con);
            con.Open();
            SqlDataReader dr3 = cmd2.ExecuteReader();
            while (dr3.Read())
            {
                CmbAy.Items.Add(dr3[0].ToString());
            }
            con.Close();
        }

        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select Sum (odemeMiktar) from Kasa where odemeAy=@p1", con);
            con.Open();
            cmd1.Parameters.AddWithValue("@p1", CmbAy.Text);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                LblAyKazanc.Text = dr1[0].ToString();
            }
            con.Close();
        }
    }
}
