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
    public partial class calisanlar : Form
    {
        public calisanlar()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Otel.mdb");

        private void calisanlar_Load(object sender, EventArgs e)
        {
            workers();
        }
        public void workers()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select *from calisanlar", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gozde.DataSource = ds.Tables[0];
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            OleDbCommand cmd = new OleDbCommand("insert into calisanlar(ad,soyad,tc,telefon,giriş,bölümü,maaş)values(@adi,@soy,@tcsi,@tlfn,@girdi,@bol,@para)", conn);
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@soy", textBox2.Text);
            cmd.Parameters.AddWithValue("@tcsi",maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@tlfn", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@girdi",dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@bol", textBox3.Text);
            cmd.Parameters.AddWithValue("@para", textBox4.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            workers();
        }
    }
}
