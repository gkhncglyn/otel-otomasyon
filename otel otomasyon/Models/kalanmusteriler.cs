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
    public partial class kalanmusteriler : Form
    {
        public kalanmusteriler()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Otel.mdb");
        public void uyari()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from kalan", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["cikis"].ToString() == DateTime.Now.ToShortDateString())
                {
                    label1.Visible = true;
                    label1.Text = "ÇIKIŞ YAPACAK ODALAR VAR!!!";
                }
                else
                {
                    label1.Visible = false; 
                }
               
            }

            conn.Close();
        }
        private void kalanmusteriler_Load(object sender, EventArgs e)
        {
            uyari();
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
    }
}
