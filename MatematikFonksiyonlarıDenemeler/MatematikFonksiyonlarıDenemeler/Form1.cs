using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikFonksiyonlarıDenemeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Mutlak Deger Alma
        private void BtnMutlakDeger_Click(object sender, EventArgs e)
        {
            try
            {
                int deger = Convert.ToInt32(textBox1.Text);
                int pozitif = Math.Abs(deger);
                LblSonuc.Text = pozitif.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...Lütfen Tekrar Deneyiniz...");
            }
        }

        //En Yakın Üst Sayıya Yuvarlama
        private void BtnUstYuvarla_Click(object sender, EventArgs e)
        {
            try
            {
                double deger = Convert.ToDouble(textBox1.Text);
                double yuvarla = Math.Ceiling(deger);
                LblSonuc.Text = yuvarla.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...Lütfen Tekrar Deneyiniz...");
            }

        }
        //En Yakın Alt Sayıya Yuvarlama
        private void BtnAltYuvarla_Click(object sender, EventArgs e)
        {
            try
            {
                double deger = Convert.ToDouble(textBox1.Text);
                double yuvarla = Math.Floor(deger);
                LblSonuc.Text = yuvarla.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...Lütfen Tekrar Deneyiniz...");
            }
        }

        //Üs Alma
        private void BtnUsAl_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox2.Text);
                int sayi2 = Convert.ToInt32(textBox3.Text);
                double deger = Math.Pow(sayi1, sayi2);
                label6.Text = deger.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...Lütfen Tekrar Deneyiniz...");
            }
        }

        //Kök Alma
        private void BtnKokAl_Click(object sender, EventArgs e)
        {
            try
            {
                int deger = Convert.ToInt32(textBox1.Text);
                double kok = Math.Sqrt(deger);
                LblSonuc.Text = kok.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...Lütfen Tekrar Deneyiniz...");
            }
        }

        //Pi sayısını ekrana yazdır
        private void BtnPi_Click(object sender, EventArgs e)
        {
            double deger = Math.PI;
            label7.Text = deger.ToString();
        }

        //Sinüs Hesaplama
        private void BtnSinus_Click(object sender, EventArgs e)
        {
            try
            {
                double deger = Convert.ToDouble(textBox4.Text);
                double sin = Math.Sin(deger);
                label8.Text = sin.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...Lütfen Tekrar Deneyiniz...");
            }
        }

        //Cosinus Hesaplama
        private void BtnCosinus_Click(object sender, EventArgs e)
        {
            try
            {
                double deger = Convert.ToDouble(textBox4.Text);
                double sin = Math.Cos(deger);
                label8.Text = sin.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...Lütfen Tekrar Deneyiniz...");
            }
        }

        //Tanjant Hesaplama
        private void BtnTanjat_Click(object sender, EventArgs e)
        {
            try
            {
                double deger = Convert.ToDouble(textBox4.Text);
                double sin = Math.Tan(deger);
                label8.Text = sin.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...Lütfen Tekrar Deneyiniz...");
            }
        }
    }
}
