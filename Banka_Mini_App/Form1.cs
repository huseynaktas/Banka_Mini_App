using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Mini_App
{
    public partial class btnGirisYap : Form
    {
        public btnGirisYap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3JI920O\SQLEXPRESS;Initial Catalog=DbBankaProjeTest;Integrated Security=True");

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLKISILER where HESAPNO=@p1 and SIFRE=@p2", conn);
            cmd.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.hesap = mskHesapNo.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            conn.Close();
        }
    }
}
