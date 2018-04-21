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
    public partial class FrmTurkce : Form
    {
        public FrmTurkce()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BAGITOD;Initial Catalog=DboSozluk;Integrated Security=True");

        private void FrmTurkce_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TOP 50 TURKCE From TBL_KELIMELER", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select INGILIZCE From TBL_KELIMELER where TURKCE=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtTurkce.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtIngilizce.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void TxtTurkce_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TURKCE From TBL_KELIMELER where TURKCE like '" + TxtTurkce.Text + "%'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
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
