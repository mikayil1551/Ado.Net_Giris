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
    public partial class KategorilerYeni : Form
    {
        public KategorilerYeni()
        {
            InitializeComponent();
        }

        private void KategorilerYeni_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Server=localhost;Database=Northwind;Integrated Security=true";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select* from Kategoriler";
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                string adi = rdr["KategoriAdi"].ToString();
                string tanimi = rdr["Tanimi"].ToString();
                listKat.Items.Add(string.Format("{0}-{1}", adi, tanimi));
            }
            baglanti.Close();
        }
    }
}
