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
    public partial class FrmGider : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-UIVL0H1\SQLEXPRESS;Initial Catalog=202503015;Integrated Security=True";
        public FrmGider()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand("insert into Giderler(Elektrik,Su,Doğalgaz,İnternet,Gıda,Personel,Diger) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@p1", TxtElektrikk.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSu.Text);
            cmd.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
            cmd.Parameters.AddWithValue("@p4", Txtİnternet.Text);
            cmd.Parameters.AddWithValue("@p5", TxtGıda.Text);
            cmd.Parameters.AddWithValue("@p6", TxtPersonel.Text);
            cmd.Parameters.AddWithValue("@p7", TxtDiger.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {

        }
    }
}
