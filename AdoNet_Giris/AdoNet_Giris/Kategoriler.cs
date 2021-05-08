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

namespace AdoNet_Giris
{
    public partial class Kategoriler : Form
    {
 

        private void Kategoriler_Load_1(object sender, EventArgs e)
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
                listKategoriler.Items.Add(string.Format("{0}-{1}", adi, tanimi));
            }
            baglanti.Close();
        }
    }
}
