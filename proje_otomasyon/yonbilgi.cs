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

namespace proje_otomasyon
{
    public partial class yonbilgi : Form
    {
        public yonbilgi()
        {
            InitializeComponent();
        }

        //YÖNETİCİ BİLGİ EKRANI

        giris giris = new giris();
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        
        private void button2_Click(object sender, EventArgs e)
        {
            yonetici yonetici_new = new yonetici();
            yonetici_new.Show();
            this.Hide();
        }

        private void yoneticiBilgi_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select Kimlik AS[ID],yisim AS[Adı],ysoyisim AS[Soyadı],yeposta AS[Mail],ytc AS[TC] from YoneticiTablo where ytc = '" + maskedTextBox1.Text + "'", giris.Aconnection);
                DataSet dshafiza = new DataSet();
                kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                giris.Aconnection.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "HASTANE OTOMASYON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                giris.Aconnection.Close();
            }
        }

        private void yonbilgi_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //yoneticiBilgi_Goster();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yoneticiBilgi_Goster();
        }
    }
}
