using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _202503015
{
    public partial class FrmMD5sifre : Form
    {
        public FrmMD5sifre()
        {
            InitializeComponent();
        }

        private void FrmMD5sifre_Load(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            if (TxtSifre.Text != "")
            {
                richTextBox1.Text = MD5sifre(TxtSifre.Text);
                label3.Text = richTextBox1.Text.Length.ToString();
            }
        }

        public static string MD5sifre(string sifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);

            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
                sb.Append(item.ToString("x2").ToLower());
            return sb.ToString();

        }
    }
}
