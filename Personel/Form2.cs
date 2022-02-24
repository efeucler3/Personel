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
using System.Data.Sql;
using System.Configuration;

namespace Personel
{
    public partial class Form2 : Form
    {
        public Form2(int adminMİ)
        {
            InitializeComponent();

            if (adminMİ==1)
            {
                btn_guncelle.Show();
                btn_ekle.Show();
                btn_ara.Show();
                btn_sil.Show();
            }
            else
            {
                btn_ara.Show();

            }
        }
        Kullanici k = new Kullanici();
        
        private void Form2_Load(object sender, EventArgs e)
        {
            List<Kullanici> liste = new List<Kullanici>();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;

            con.Open();
            Kullanici k = new Kullanici();
            SqlCommand command = new SqlCommand();
            SqlDataReader dr;

            


        }
    }
}
