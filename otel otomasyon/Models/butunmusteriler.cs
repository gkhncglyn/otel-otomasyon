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
    public partial class butunmusteriler : Form
    {
        public butunmusteriler()
        {
            InitializeComponent();
            
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Otel.mdb");


        private void butunmusteriler_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from yenikayit", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["odano"].ToString();
                item.SubItems.Add(dr["ad"].ToString());
                item.SubItems.Add(dr["soyad"].ToString());
                item.SubItems.Add(dr["tc"].ToString());
                item.SubItems.Add(dr["anaadi"].ToString());
                item.SubItems.Add(dr["babaadi"].ToString());
                item.SubItems.Add(dr["telefon"].ToString());
                item.SubItems.Add(dr["uyruk"].ToString());
                item.SubItems.Add(dr["dogumtarihi"].ToString());
                //item.SubItems.Add(dr["beraberindekiler"].ToString());
                item.SubItems.Add(dr["giristarihi"].ToString());
                item.SubItems.Add(dr["cikistarihi"].ToString());
                item.SubItems.Add(dr["odaucret"].ToString());
                item.SubItems.Add(dr["sehir"].ToString());
                item.SubItems.Add(dr["ilce"].ToString());
                item.SubItems.Add(dr["mahalle"].ToString());
                item.SubItems.Add(dr["adres"].ToString());
                item.SubItems.Add(dr["email"].ToString());
                item.SubItems.Add(dr["pk"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }
    }
}
