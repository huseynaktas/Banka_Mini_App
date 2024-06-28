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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3JI920O\SQLEXPRESS;Initial Catalog=DbBankaProjeTest;Integrated Security=True");

        public string hesap;

        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesap;

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLKISILER where HESAPNO=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTC.Text = dr[3].ToString();
                lblTel.Text = dr[4].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from TBLHESAP where HESAPNO=@p1", conn);
            cmd2.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblBakiye.Text = dr2[1].ToString();
            }
            conn.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı
            conn.Open();
            SqlCommand cmd = new SqlCommand("update TBLHESAP set BAKIYE = BAKIYE + @p1 where HESAPNO = @p2", conn);
            cmd.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@p2", mskHesapNo2.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            //Gönderen Hesabın Para Azalışı
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("update TBLHESAP set BAKIYE = BAKIYE - @k1 where HESAPNO = @k2", conn);
            cmd2.Parameters.AddWithValue("@k1", decimal.Parse(txtTutar.Text));
            cmd2.Parameters.AddWithValue("@k2", hesap);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("İşlem Başarıyla Gerçekleşti");



        }
    }
}
