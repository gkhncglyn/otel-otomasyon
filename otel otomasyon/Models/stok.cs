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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Otel.mdb");
        private void stok_Load(object sender, EventArgs e)
        {
            stoks();
        }
        public void sil()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = "";
                }
            }
        }
        public void stoks(string gkhn = "select *from stok")
        {
            OleDbDataAdapter da = new OleDbDataAdapter(gkhn, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw.DataSource = ds.Tables[0];

        }

        private void Btnekle_Click(object sender, EventArgs e)
        {

            try
            {
                double brim, toplam, adet;
                brim = Convert.ToDouble(textBox3.Text);
                adet = Convert.ToDouble(textBox2.Text);
                toplam = brim * adet;
                textBox4.Text = toplam.ToString();
                MessageBox.Show("Ürün Listelendi");

                conn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into stok (malzeme,adet,tarih,bfiyat,toplam)values(@ad,@kg,@giris,@birim,@topla)", conn);
                cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                cmd.Parameters.AddWithValue("@kg", textBox2.Text);
                cmd.Parameters.AddWithValue("@giris", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@birim", textBox3.Text);
                cmd.Parameters.AddWithValue("@topla", textBox4.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                stoks();
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş Lütfen Alanları Düzeltip Tekrar Deneyin", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            sil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("delete from stok where @ad=malzeme", conn);
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.ExecuteNonQuery();
            stoks();
            conn.Close();
        }
        private void dgw_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int a = dgw.SelectedCells[0].RowIndex;
            string b = dgw.Rows[a].Cells[1].Value.ToString();
            string c = dgw.Rows[a].Cells[2].Value.ToString();
            string d = dgw.Rows[a].Cells[3].Value.ToString();
            string h = dgw.Rows[a].Cells[4].Value.ToString();
            string f = dgw.Rows[a].Cells[5].Value.ToString();

            textBox1.Text = b;
            textBox2.Text = c;
            textBox3.Text = d;
            textBox4.Text = f;
            dateTimePicker1.Text = h;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from stok where malzeme like '%" + textBox6.Text + "%'", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw.DataSource = ds.Tables[0];
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
