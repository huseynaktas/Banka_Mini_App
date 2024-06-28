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

            SqlCommand cmd = new SqlCommand("Select * from TBLKISILER where HESAPNO=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTC.Text = dr[3].ToString();
                lblTel.Text = dr[4].ToString();
            }
        }
    }
}
