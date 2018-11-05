using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDB_Kitaplik_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("DbBooks");
        static IMongoCollection<Books> collection = db.GetCollection<Books>("books");

        private void Form1_Load(object sender, EventArgs e)
        {
            showDocuments();
        }

        /* Verileri Datagridview'de Listeleme Islemi */
        public void showDocuments()
        {
            List<Books> list = collection.AsQueryable().ToList<Books>();
            dgvKitaplar.DataSource = list;

            var count = dgvKitaplar.RowCount;
            lblKayitliKisiSayisi.Text = "Toplam Kayıtlı Kitap Sayısı : " + count;
        }

        /* Veri Kaydetme Islemi */
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Books book = new Books(txtKitapAdi.Text, txtYazari.Text, txtTuru.Text, int.Parse(txtSayfa.Value.ToString()), int.Parse(txtPuan.Value.ToString()), txtAciklama.Text);
            collection.InsertOne(book);
            showDocuments();
        }

        /* Datagridview'e Tiklandigi Zaman Verileri Araclara Tasima*/
        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvKitaplar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKitapAdi.Text = dgvKitaplar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtYazari.Text = dgvKitaplar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTuru.Text = dgvKitaplar.Rows[e.RowIndex].Cells[3].Value.ToString();
            string sayfa = dgvKitaplar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSayfa.Value = int.Parse(sayfa.ToString());
            string puan = dgvKitaplar.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPuan.Value = int.Parse(puan.ToString());
            txtAciklama.Text = dgvKitaplar.Rows[e.RowIndex].Cells[6].Value.ToString();    
        }

        /* Veri Guncelleme Islemi */
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<Books>.Update.Set("bookname", txtKitapAdi.Text).Set("author", txtYazari.Text).Set("type", txtTuru.Text).Set("pages", int.Parse(txtSayfa.Value.ToString())).Set("point", int.Parse(txtPuan.Value.ToString())).Set("description", txtAciklama.Text);
            collection.UpdateOne(x => x.Id == ObjectId.Parse(txtId.Text), updateDef);
            showDocuments();
        }

        /* Veri Silme Islemi */
        private void btnSil_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(x => x.Id == ObjectId.Parse(txtId.Text));
            showDocuments();
        }
    }
}
