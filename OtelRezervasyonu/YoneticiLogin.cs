using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonu
{
    public partial class YoneticiLogin : Form
    {
      
        public YoneticiLogin()
        {
            InitializeComponent();
        }

        private void yonGiris_Click(object sender, EventArgs e)
        {
            YoneticiAnaSayfa giris = new YoneticiAnaSayfa();
            if (textBoxkullAd.Text == "admin" || textBoxyonesifre.Text == "admin")
            {
                giris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullancıı Adı veya şifre yanlış");
            }
        }
    }
}
