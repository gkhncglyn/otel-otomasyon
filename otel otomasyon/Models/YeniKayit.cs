using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml;

namespace otel_otomasyon
{
    public partial class YeniKayit : Form
    {

        public YeniKayit()
        {
            InitializeComponent();

        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Otel.mdb");
        double odaucreti, dolar, euro, gun;
        double toplam = 0;

        public void Genelliste()
        {
 
            listView1.Items.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from yenikayit", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for (int i = 1; i <= 16; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }               
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        public void kalanlarlistesi()
        {
            kalanliste.Items.Clear();
            conn.Open();
            OleDbCommand cmd2 = new OleDbCommand(@"select *from kalan", conn);
            OleDbDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem a = new ListViewItem();
                a.Text = dr["Odano"].ToString();
                a.SubItems.Add(dr["ad"].ToString());
                a.SubItems.Add(dr["soyad"].ToString());
                a.SubItems.Add(dr["telefon"].ToString());
                a.SubItems.Add(dr["giris"].ToString());
                a.SubItems.Add(dr["cikis"].ToString());
                a.SubItems.Add(dr["odaucret"].ToString());
                a.SubItems.Add(dr["toplam"].ToString());
                kalanliste.Items.Add(a);
            }
            conn.Close();
        }

        public void odalarlistesi()
        {
            odaliste.Items.Clear();
            CBODANO.Items.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from odalar", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem i = new ListViewItem();
                i.Text = reader["odano"].ToString();
                i.SubItems.Add(reader["yataksayisi"].ToString());
                i.SubItems.Add(reader["kat"].ToString());
                i.SubItems.Add(reader["ucret"].ToString());
                i.SubItems.Add(reader["durumu"].ToString());
                odaliste.Items.Add(i);

                if (reader["durumu"].ToString() == "BOS")
                {
                    CBODANO.Items.Add(reader["odano"].ToString());
                }
            }
            conn.Close();
        }

        public void cikanlar()
        {
            cikanlistesi.Items.Clear();
            conn.Open();
            OleDbCommand cmd2 = new OleDbCommand(@"select *from cikan", conn);
            OleDbDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem a = new ListViewItem();
                a.Text = dr["odano"].ToString();
                a.SubItems.Add(dr["ad"].ToString());
                a.SubItems.Add(dr["soyad"].ToString());
                a.SubItems.Add(dr["giris"].ToString());
                a.SubItems.Add(dr["cikis"].ToString());
                a.SubItems.Add(dr["ucret"].ToString());
                a.SubItems.Add(dr["toplam"].ToString());
                cikanlistesi.Items.Add(a);
            }
            conn.Close();
        }

        public void sehir()
        {
            cbsehir.Items.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from sehirler", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbsehir.Items.Add(dr["sehirler"].ToString());
            }
            conn.Close();
        }
        public void sil()
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox)
                {
                    groupBox1.Controls[i].Text = "";
                }
                for (int j = 0; j < groupBox1.Controls.Count; j++)
                {
                    if (groupBox1.Controls[j] is ComboBox)
                    {
                        groupBox1.Controls[j].Text = "";
                    }
                }
            }
        }

        public void kalan()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into kalan(Odano,ad,soyad,telefon,giris,cikis,odaucret,toplam)values" +
                "('" + CBODANO.Text +
                "','" + TBAD.Text +
                "','" + TBSOYAD.Text +
                "','" + TBTELEFON.Text +
                "','" + TBGTARIH.Text +
                "','" + TBCTARIH.Text +
                "','" + TBODAUCRET.Text +
                "','" + tbtoplam.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void genelkayit()
        {

            listView1.Items.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into yenikayit(odano,ad,soyad,tc,anaadi,babaadi,telefon,uyruk,dogumtarihi,giristarihi,cikistarihi,odaucret,sehir,ilce,mahalle,adres,email,pk)values(@odasi,@adi,@soyadi,@tcsi,@ana,@baba,@tlfn,@uyruku,@dogum,@girdi,@cikti,@ucret,@sehiri,@ilcesi,@mah,@adresi,@mail,@pksi)", conn);
            cmd.Parameters.AddWithValue("@odasi", CBODANO.Text);
            cmd.Parameters.AddWithValue("@adi", TBAD.Text);
            cmd.Parameters.AddWithValue("@soyadi", TBSOYAD.Text);
            cmd.Parameters.AddWithValue("@tcsi", TBTC.Text);
            cmd.Parameters.AddWithValue("@ana", TBANAAD.Text);
            cmd.Parameters.AddWithValue("@baba", TBBABAAD.Text);
            cmd.Parameters.AddWithValue("@tlfn", TBTELEFON.Text);
            cmd.Parameters.AddWithValue("@uyruku", TBUYRUK.Text);
            cmd.Parameters.AddWithValue("@dogum", TBDOGUM.Text);
            cmd.Parameters.AddWithValue("@girdi", TBGTARIH.Text);
            cmd.Parameters.AddWithValue("@cikti", TBCTARIH.Text);
            cmd.Parameters.AddWithValue("@ucret", TBODAUCRET.Text);
            cmd.Parameters.AddWithValue("@sehiri", cbsehir.Text);
            cmd.Parameters.AddWithValue("@ilcesi", cbilce.Text);
            cmd.Parameters.AddWithValue("@mah", cbmahalle.Text);
            cmd.Parameters.AddWithValue("@adresi", tbadres.Text);
            cmd.Parameters.AddWithValue("@mail", tbemail.Text);
            cmd.Parameters.AddWithValue("@pksi", tbposta.Text);
            cmd.ExecuteNonQuery();
            OleDbCommand CMD2 = new OleDbCommand("update odalar set durumu='DOLU' where odano='" + CBODANO.Text + "'", conn);
            CMD2.ExecuteNonQuery();

            conn.Close();

        }

        private void TBCTARIH_ValueChanged(object sender, EventArgs e)
        {
            DateTime girdi = TBGTARIH.Value;
            DateTime cikti = TBCTARIH.Value;
            System.TimeSpan hesap;
            hesap = cikti.Subtract(girdi);
            int toplamgun = Convert.ToInt32(hesap.TotalDays);
            tbgun.Text = toplamgun.ToString();
        }
        private void öıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.ShowDialog();
        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar();
            odalar.ShowDialog();
        }

        private void tümMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            butunmusteriler btnmst = new butunmusteriler();
            btnmst.ShowDialog();
        }

        private void kalanMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kalanmusteriler klnmst = new kalanmusteriler();
            klnmst.ShowDialog();
        }

        private void öıkışYapanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cikanmusteriler cknmst = new cikanmusteriler();
            cknmst.ShowDialog();
        }

        private void exToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden  Eminmisiniz?","Uyarı!!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                Application.Exit();
            }
            
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stok stok = new stok();
            stok.ShowDialog();
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                odaucreti = Convert.ToDouble(TBODAUCRET.Text);
                gun = Convert.ToDouble(tbgun.Text);
                toplam = gun * odaucreti;
                tbtoplam.Text = toplam.ToString();

                dolar = Convert.ToDouble(lbldolaralis.Text);
                euro = Convert.ToDouble(lbleuroalis.Text);

                if (cbdöviz.Text == "DOLAR") { toplam = toplam / dolar; tbtoplam.Text = toplam.ToString(); }
                else if (cbdöviz.Text == "EURO") { toplam = toplam / euro; tbtoplam.Text = toplam.ToString(); }
                else { toplam = gun * odaucreti; tbtoplam.Text = toplam.ToString(); }

                MessageBox.Show("Check In İşleminiz Başarıyla Tamamlandı... Kontrol Etmek İçin (Guests-RemaningGuests)Gidiniz");
                genelkayit();
                Genelliste();
                kalan();
                kalanlarlistesi();
                sil();
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik Bilgi!! Lütfen Alanları Doldurun Ve Tekrar Deneyin");
            }
            yeniKayıtToolStripMenuItem.PerformClick();
        }

        private void CBODANO_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from odalar where odano='" + CBODANO.SelectedItem + "'", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TBYATAKSAYI.Text = reader["yataksayisi"].ToString();
                TBKAT.Text = reader["kat"].ToString();
                TBODAUCRET.Text = reader["ucret"].ToString();
            }
            conn.Close();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calisanlar cls = new calisanlar();
            cls.ShowDialog();
        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {

            string adres = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var Doviz = new XmlDocument();
            Doviz.Load(adres);
            string usdal = Doviz.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerText;
            lbldolaralis.Text = (usdal);
            string eural = Doviz.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerText;
            lbleuroalis.Text = (eural);

            //DateTime tarih = Convert.ToDateTime(Doviz.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            //string usdsat = Doviz.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerText;
            //lbldolarsatis.Text = (usdsat);
            //string eursat = Doviz.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerText;
            //lbleurosatis.Text =(eursat);

            foreach (Control a in Controls)
            {
                if (a is GroupBox)
                {
                    a.Visible = false;
                }
            }

        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Control a in Controls)
            {
                if (a is GroupBox)
                {
                    a.Visible = true;
                    kalanlarlistesi();
                    Genelliste();
                    odalarlistesi();
                    sehir();
                    cikanlar();
                }

            }
        }
    }
}
