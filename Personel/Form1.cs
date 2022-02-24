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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;

            con.Open();
            Kullanici k = new Kullanici();
            k.kullaniciadi = textBox1.Text;
            k.sifre = textBox2.Text;
            
            SqlCommand command = new SqlCommand();
            SqlDataReader dr;
           

            command.CommandText = "select * from Personel where kullaniciadi=@p1 and sifre=@p2";
            command.Parameters.AddWithValue("@p1", k.kullaniciadi);
            command.Parameters.AddWithValue("@p2", k.sifre);
            command.Connection = con;
            dr = command.ExecuteReader();
            dr.Read();
            int adminMİ = Convert.ToInt32( dr["birim"]);
            if (dr.HasRows)
            {

                Form2 form2 = new Form2(adminMİ);
                form2.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Bilgi girişi");
            }
            con.Close();



        }
    }
}
