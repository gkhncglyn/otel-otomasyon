using System;
using System.Windows.Forms;

namespace otel_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            YeniKayit yeni = new YeniKayit();
            yeni.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            YeniKayit yeni = new YeniKayit();
            yeni.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            YeniKayit yeni = new YeniKayit();
            yeni.ShowDialog();
        }
    }
}

        
