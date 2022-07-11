using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyon
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Gokhan" && textBox2.Text =="123321")
            {
                YeniKayit yeni = new YeniKayit();
                Hide();
                yeni.Show();
                
                
            }
        }
    }
}
