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

namespace SozlukUygulamasi
{
    public partial class FrmIngilizce : Form
    {
        public FrmIngilizce()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BAGITOD;Initial Catalog=DboSozluk;Integrated Security=True");

        private void FrmIngilizce_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TOP 50 INGILIZCE From TBL_KELIMELER", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TURKCE From TBL_KELIMELER where INGILIZCE=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtIngilizce.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                TxtTurkce.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void TxtIngilizce_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select INGILIZCE From TBL_KELIMELER where INGILIZCE like '" + TxtIngilizce.Text + "%'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                listBox1.Items.Add(dr[0]);
            }
            baglanti.Close();
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 frAnaSayfa = new Form1();
            frAnaSayfa.Show();
            this.Hide();
        }
    }
}
