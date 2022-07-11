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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Otel.mdb");
        private void Odalar_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from odalar", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                foreach (Control a in Controls)
                {
                    if (a is Label)
                    {
                        if (dr["odano"].ToString() == "101" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p101.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "101" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p101.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "102" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p102.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "102" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p102.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "103" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p103.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "103" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p103.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "104" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p104.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "104" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p104.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "105" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p105.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "105" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p105.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "106" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p106.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "106" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p106.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "201" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p201.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "201" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p201.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "202" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p202.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "202" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p202.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "203" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p203.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "203" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p203.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "204" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p204.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "204" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p204.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "205" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p205.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "205" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p205.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "206" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p206.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "206" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p206.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }



                        if (dr["odano"].ToString() == "301" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p301.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "301" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p301.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "302" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p302.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "302" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p302.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "303" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p303.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "303" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p303.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "304" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p304.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "304" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p304.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "305" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p305.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "305" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p305.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "306" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p306.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "306" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p306.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "401" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p401.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "401" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p401.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "402" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p402.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "402" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p402.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "403" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p403.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "403" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p403.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "404" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p404.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "404" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p404.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }


                        if (dr["odano"].ToString() == "405" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p405.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "405" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p405.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }

                        if (dr["odano"].ToString() == "406" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "BOS")
                        {
                            p406.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\bosOda.png";
                        }
                        if (dr["odano"].ToString() == "406" && dr["odano"].ToString() == a.Text && dr["durumu"].ToString() == "DOLU")
                        {
                            p406.ImageLocation = "C:\\Users\\BERKAN\\Desktop\\Yeni klasör\\otel otomasyon\\otel otomasyon\\bin\\Debug\\doluOda.png";
                        }
                    }


                }

            }
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox)
                {
                    if (groupBox1.Controls[i].Text == "")
                    {
                        MessageBox.Show("Hata! Lütfen Alanları Doldurun");
                        break;
                    }
                    else
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand
                            ("insert into odalar(odano,yataksayisi,kat,ucret,durumu)values" +
                            "('" + textBox1.Text +
                            "','" + textBox2.Text +
                            "','" + textBox3.Text +
                            "','" + textBox4.Text +
                            "','" + textBox5.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }



        }
    }
}
