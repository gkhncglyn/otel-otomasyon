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
namespace otel_otomasyon
{
    public partial class Musteriler : Form
    {

        public Musteriler()
        {
            InitializeComponent();

        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Otel.mdb");
        int oda;
        public void kalanlarlistesi()
        {
            listekalan.Items.Clear();
            conn.Open();
            OleDbCommand cmd2 = new OleDbCommand(@"select *from kalan", conn);
            OleDbDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem a = new ListViewItem();
                a.Text = dr["Odano"].ToString();
                a.SubItems.Add(dr["ad"].ToString());
                a.SubItems.Add(dr["soyad"].ToString());
                a.SubItems.Add(dr["giris"].ToString());
                a.SubItems.Add(dr["cikis"].ToString());
                a.SubItems.Add(dr["odaucret"].ToString());
                a.SubItems.Add(dr["toplam"].ToString());
                listekalan.Items.Add(a);
            }
            conn.Close();

        }
        public void cikis()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into cikan(odano,ad,soyad,giris,cikis,ucret,toplam)values(@oda,@adi,@soy,@gir,@cik,@para,@topla)", conn);
            cmd.Parameters.AddWithValue("@oda", tboda.Text);
            cmd.Parameters.AddWithValue("@adi", tbad.Text);
            cmd.Parameters.AddWithValue("@soy", tbsoyad.Text);
            cmd.Parameters.AddWithValue("@gir", TBGIRIS.Text);
            cmd.Parameters.AddWithValue("@cik", TBCIKIS.Text);
            cmd.Parameters.AddWithValue("@para", tbücret.Text);
            cmd.Parameters.AddWithValue("@topla", TBTOPLAMTUTAR.Text);
            cmd.ExecuteNonQuery();
            OleDbCommand cmd2 = new OleDbCommand("delete from kalan where Odano='" + tboda.Text + "'", conn);
            cmd2.ExecuteNonQuery();
            OleDbCommand cmd3 = new OleDbCommand("update odalar set durumu='BOS' where odano='"+tboda.Text + "'", conn);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Check Out İşleminiz Başarıyla Gerçekleştirildi");
            conn.Close();
            kalanlarlistesi();
        }
        private void Musteriler_Load(object sender, EventArgs e)
        {
            kalanlarlistesi();
        }
        
        private void listekalan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            oda = int.Parse(listekalan.SelectedItems[0].SubItems[0].Text);

            tboda.Text = listekalan.SelectedItems[0].SubItems[0].Text;
            tbad.Text = listekalan.SelectedItems[0].SubItems[1].Text;
            tbsoyad.Text = listekalan.SelectedItems[0].SubItems[2].Text;
            TBGIRIS.Text = listekalan.SelectedItems[0].SubItems[3].Text;
            TBCIKIS.Text = listekalan.SelectedItems[0].SubItems[4].Text;
            tbücret.Text = listekalan.SelectedItems[0].SubItems[5].Text;
            TBTOPLAMTUTAR.Text = listekalan.SelectedItems[0].SubItems[6].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                cikis();
        }
    }
}
