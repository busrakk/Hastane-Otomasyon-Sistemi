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
using LiveCharts;
using LiveCharts.Wpf;

namespace proje_otomasyon
{
    public partial class kanbilgi : Form
    {
        public kanbilgi()
        {
            InitializeComponent();
        }

        //YÖNETİCİ KAN GRAFİĞİ

        public OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        OleDbCommand komut = new OleDbCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            //checkBox1.Enabled = true;
            //float r1, r2, r3,r4,r5,r6,r7,r8, total;
            //baglanti.Open();
            
            //komut.Connection = baglanti;
            //komut.CommandText = "select COUNT(*) from HasTablo where hkan='" + label1.Text.ToString() + "'";
            //r1 = komut.ExecuteNonQuery();
            //textBox1.Text = r1.ToString();

            //baglanti.Close();

            //baglanti.Open();

            //komut.Connection = baglanti;
            //komut.CommandText = "select COUNT(*) from HasTablo where hkan='" + label2.Text.ToString() + "'";
            //r2 = komut.ExecuteNonQuery();
            //baglanti.Close();

            //komut.Connection = baglanti;
            //komut.CommandText = "select COUNT(*) from HasTablo where hkan='" + label3.Text.ToString() + "'";
            //r3 = komut.ExecuteNonQuery();

            //komut.Connection = baglanti;
            //komut.CommandText = "select COUNT(*) from HasTablo where hkan='" + label4.Text.ToString() + "'";
            //r4 = komut.ExecuteNonQuery();

            //komut.Connection = baglanti;
            //komut.CommandText = "select COUNT(*) from HasTablo where hkan='" + label5.Text.ToString() + "'";
            //r5 = komut.ExecuteNonQuery();

            //komut.Connection = baglanti;
            //komut.CommandText = "select COUNT(*) from HasTablo where hkan='" + label6.Text.ToString() + "'";
            //r6 = komut.ExecuteNonQuery();
            

            //komut.Connection = baglanti;
            //komut.CommandText = "select COUNT(*) from HasTablo where hkan='" + label7.Text.ToString() + "'";
            //r7 = komut.ExecuteNonQuery();

            //komut.Connection = baglanti;
            //komut.CommandText = "select COUNT(*) from HasTablo where hkan='" + label8.Text.ToString() + "'";
            //r8 = komut.ExecuteNonQuery();
            //baglanti.Close();

            //total = r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8;

            //float pr1, pr2, pr3, pr4, pr5, pr6, pr7, pr8;
            //pr1 = (r1 / total) * 360;
            //pr2 = (r2 / total) * 360;
            //pr3 = (r3 / total) * 360;
            //pr4 = (r4 / total) * 360;
            //pr5 = (r5 / total) * 360;
            //pr6 = (r6 / total) * 360;
            //pr7 = (r7 / total) * 360;
            //pr8 = (r8 / total) * 360;

            //Pen p = new Pen(Form1.DefaultBackColor);
            //if (checkBox1.Checked == true)
            //{
            //    p.Color = Color.Black;
            //    p.Width = 4;
            //}
            //else
            //{
            //    p.Color = Form1.DefaultBackColor;
            //    p.Width = 4;
            //}
            //Graphics g = this.CreateGraphics();

            //Rectangle rec = new Rectangle(button1.Location.X + button1.Size.Width + 20, 20, 250, 250);

            //Brush b1 = new SolidBrush(Color.Red);
            //Brush b2 = new SolidBrush(Color.White);
            //Brush b3 = new SolidBrush(Color.Turquoise);
            //Brush b4 = new SolidBrush(Color.Blue);
            //Brush b5 = new SolidBrush(Color.Pink);
            //Brush b6 = new SolidBrush(Color.Honeydew);
            //Brush b7 = new SolidBrush(Color.Yellow);
            //Brush b8 = new SolidBrush(Color.Green);


            //g.Clear(kanbilgi.DefaultBackColor);

            //g.DrawPie(p, rec, 0, pr1);
            //g.FillPie(b1, rec, 0, pr1);
            //g.DrawPie(p, rec, pr1, pr2);
            //g.FillPie(b2, rec, pr1, pr2);
            //g.DrawPie(p, rec, pr1 + pr2, pr3);
            //g.FillPie(b3, rec, pr1 + pr2, pr3);
            //g.DrawPie(p, rec, pr1 + pr2+pr3, pr4);
            //g.FillPie(b4, rec, pr1 + pr2+pr3, pr4);
            //g.DrawPie(p, rec, pr1 + pr2 + pr3+pr4, pr5);
            //g.FillPie(b5, rec, pr1 + pr2 + pr3+pr4, pr5);
            //g.DrawPie(p, rec, pr1 + pr2 + pr3 + pr4+pr5, pr6);
            //g.FillPie(b6, rec, pr1 + pr2 + pr3 + pr4+pr5, pr6);
            //g.DrawPie(p, rec, pr1 + pr2 + pr3 + pr4 + pr5+pr6, pr7);
            //g.FillPie(b7, rec, pr1 + pr2 + pr3 + pr4 + pr5+pr6, pr7);
            //g.DrawPie(p, rec, pr1 + pr2 + pr3 + pr4 + pr5 + pr6+pr7, pr8);
            //g.FillPie(b8, rec, pr1 + pr2 + pr3 + pr4 + pr5 + pr6+7, pr8);


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //button1_Click(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Func<ChartPoint, string> fu = x => string.Format("{0},{1:P}", x.X, x.Participation);
            SeriesCollection series = new SeriesCollection();
            foreach(var item in dataSet1.Kan)
            {
                PieSeries pie = new PieSeries();
                pie.Title = item.Kan_Grubu;
                pie.Values = new ChartValues<int> { item.Miktar };
                pie.DataLabels = true;
                pie.LabelPoint = fu;
                series.Add(pie);
                pieChart2.Series = series;
            }
        }

        private void kanbilgi_Load(object sender, EventArgs e)
        {
            pieChart2.LegendLocation = LegendLocation.Bottom;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetici yonetici_new = new yonetici();
            yonetici_new.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
