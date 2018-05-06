using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SezarSifrelemeYontemi
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


        /* Kelime Sifrele Butonu Tiklama Olaylari */
        private void BtnKelimeSifrele_Click(object sender, EventArgs e)
        {
            if (TxtSifrelenecekKelime.Text == "")
            {
                MessageBox.Show("Lutfen Bos Alanlari Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TxtSifrelenmisKelime.Text = "";
                string kelime = "";
                kelime = TxtSifrelenecekKelime.Text;
                char[] kelimeDizisi = kelime.ToCharArray();
                foreach (char kelimeler in kelimeDizisi)
                {
                    TxtSifrelenmisKelime.Text += Convert.ToChar(kelimeler + 3).ToString();
                }
            }
        }


        /* Sifre Coz Butonu Tiklama Olaylari */
        private void BtnSifreCoz_Click(object sender, EventArgs e)
        {
            if (TxtSifrelenmisKelime2.Text == "")
            {
                MessageBox.Show("Lutfen Bos Alanlari Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TxtCozulmusKelime.Text = "";
                string sifre = "";
                sifre = TxtSifrelenmisKelime2.Text;
                char[] sifreDizisi = sifre.ToCharArray();
                foreach (char sifreler in sifreDizisi)
                {
                    TxtCozulmusKelime.Text += Convert.ToChar(sifreler - 3).ToString();
                }
            }
        }

    }
}
