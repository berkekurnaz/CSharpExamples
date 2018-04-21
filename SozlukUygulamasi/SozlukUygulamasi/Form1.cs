using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SozlukUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngilizce_Click(object sender, EventArgs e)
        {
            FrmIngilizce frIngilizce = new FrmIngilizce();
            frIngilizce.Show();
            this.Hide();
        }

        private void BtnTurkce_Click(object sender, EventArgs e)
        {
            FrmTurkce frTurkce = new FrmTurkce();
            frTurkce.Show();
            this.Hide();
        }

        private void BtnHakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda frHakkinda = new FrmHakkinda();
            frHakkinda.Show();
            this.Hide();
        }
    }
}
