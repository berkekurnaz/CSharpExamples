using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // SQLite Kutuphanesi

namespace SQLiteRehberOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        /* Form Yuklendigi An Calisacak Kodlar */
        private void Form1_Load(object sender, EventArgs e)
        {
            RehberListele();
            Toplam_Kisi_Sayisi();
        }

        /* Listeleme */
        void RehberListele()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select * From TBL_REHBER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        /* Kaydet Butonu Tiklama Olaylari */
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult secim = MessageBox.Show("Yeni Kisi Eklemek Istiyor Musunuz?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    SQLiteCommand komut = new SQLiteCommand("Insert Into TBL_REHBER(ADSOYAD,TELEFON,ADRES) Values (@p1,@p2,@p3)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@p2", TxtTelefon.Text);
                    komut.Parameters.AddWithValue("@p3", TxtAdres.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Ekleme Basarili...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RehberListele();
                    Toplam_Kisi_Sayisi();
                }
                else
                {
                    RehberListele();
                }
            }
        }

        /* Guncelle Butonu Tiklama Olaylari */
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult secim = MessageBox.Show("Kisi Guncellemek Istiyor Musunuz?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    SQLiteCommand komut = new SQLiteCommand("Update TBL_REHBER set ADSOYAD=@p1,TELEFON=@p2,ADRES=@p3 where ID=@p4", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@p2", TxtTelefon.Text);
                    komut.Parameters.AddWithValue("@p3", TxtAdres.Text);
                    komut.Parameters.AddWithValue("@p4", TxtId.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Guncelleme Basarili...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RehberListele();
                }
                else
                {
                    RehberListele();
                }
            }
        }

        /* Sil Butonu Tiklama Olaylari */
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult secim = MessageBox.Show("Kisi Silmek Istiyor Musunuz?", "Soru Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secim == DialogResult.Yes)
                {
                    SQLiteCommand komut = new SQLiteCommand("Delete From TBL_REHBER Where ID=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtId.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Silme Basarili...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RehberListele();
                    Toplam_Kisi_Sayisi();
                }
                else
                {
                    RehberListele();
                }
            }
        }

        /* Kapat Butonu Tiklama Olaylari */
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Tiklayinca Verileri Alanlara Cekme Islemi */
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int number = dataGridView1.SelectedCells[0].RowIndex;

            try
            {
                TxtId.Text = dataGridView1.Rows[number].Cells[0].Value.ToString();
                TxtAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtTelefon.Text = dataGridView1.Rows[number].Cells[2].Value.ToString();
                TxtAdres.Text = dataGridView1.Rows[number].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu...", "Bilgi Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* Telefon Arama */
        private void TxtAraTelefon_TextChanged(object sender, EventArgs e)
        {
            if (TxtAraTelefon.Text == "(   )    -")
            {
                RehberListele();
            }
            else
            {
                string srg = TxtAraTelefon.Text;
                string sorgu = "Select * from TBL_REHBER where TELEFON like '%" + srg + "%'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }
        }

        /* Ad Soyad Arama */
        private void TxtAraAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (TxtAraAdSoyad.Text == "(   )    -")
            {
                RehberListele();
            }
            else
            {
                string srg = TxtAraAdSoyad.Text;
                string sorgu = "Select * from TBL_REHBER where ADSOYAD like '%" + srg + "%'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }
        }

        /* Adres Arama */
        private void TxtAraAdres_TextChanged(object sender, EventArgs e)
        {
            if (TxtAraAdres.Text == "(   )    -")
            {
                RehberListele();
            }
            else
            {
                string srg = TxtAraAdres.Text;
                string sorgu = "Select * from TBL_REHBER where ADRES like '%" + srg + "%'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
            }
        }

        /* Toplam Kisi Sayisi Gosterme */
        void Toplam_Kisi_Sayisi()
        {
            SQLiteCommand komut = new SQLiteCommand("Select Count(*) From TBL_REHBER", bgl.baglanti());
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamKisi.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

    }
}
