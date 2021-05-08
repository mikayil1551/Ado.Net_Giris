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

namespace AdoNet_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            //Sql Authentication ile baglanma
            //baglanti.ConnectionString = "Server=localhost;Database=Northwind;User=sa;Pwd=123";
            //Windows Authentication ile baglanma
            baglanti.ConnectionString = "Server=localhost;Database=Northwind;Integrated Security=true";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select*from Urunler";
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                string adi = rdr["UrunAdi"].ToString();
                string fiyati = rdr["BirimFiyati"].ToString();
                string stogu = rdr["HedefStokDuzeyi"].ToString();
                listUrunler.Items.Add(string.Format("{0}-{1}-{2}", adi, fiyati, stogu));
            }
            baglanti.Close();


        }

        private void BtnKategoriler_Click(object sender, EventArgs e)
        {
           
          
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KategorilerYeni ky = new KategorilerYeni();
            ky.ShowDialog();
        }
    }
}
