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
    public partial class cikanmusteriler : Form
    {
        public cikanmusteriler()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Otel.mdb");
        private void cikanmusteriler_Load(object sender, EventArgs e)
        {
            cikanliste.Items.Clear();
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
                cikanliste.Items.Add(a);
            }
            conn.Close();
        }
    }
}
