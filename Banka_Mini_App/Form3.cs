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

namespace Banka_Mini_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3JI920O\SQLEXPRESS;Initial Catalog=DbBankaProjeTest;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskTC.Text);
            cmd.Parameters.AddWithValue("@p4", mskTel.Text);
            cmd.Parameters.AddWithValue("@p5", mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p6", txtSifre.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Müşteri Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi = random.Next(100000, 1000000);
            mskHesapNo.Text = sayi.ToString();
        }
    }
}
