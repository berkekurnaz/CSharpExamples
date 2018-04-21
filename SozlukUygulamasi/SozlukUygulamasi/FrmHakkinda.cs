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
    public partial class FrmHakkinda : Form
    {
        public FrmHakkinda()
        {
            InitializeComponent();
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 frAnaSayfa = new Form1();
            frAnaSayfa.Show();
            this.Hide();
        }
    }
}
