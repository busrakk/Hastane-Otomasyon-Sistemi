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
    public partial class yonhastalar : Form
    {
        public yonhastalar()
        {
            InitializeComponent();
        }

        //YÖNETİCİ HASTA BİLGİLERİ EKRANI

        giris giris = new giris();
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void button2_Click(object sender, EventArgs e)
        {
            
            yonetici yonetici_new = new yonetici();
            yonetici_new.Show();
            this.Hide();
        }
       
        private void hastaBilgi_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select h_id AS[ID],hadi AS[Adı],hsoyadi AS[Soyadı],hbabaadi AS[Baba Adı],hanneadi AS[Anne Adı],hmail AS[Mail],hcinsiyet AS[Cinsiyet],hkan AS[Kan Grubu],hdyeri AS[Doğum Yeri],htc AS[TC],hdtarihi AS[Doğum Tarihi],hcepno AS[Cep Telefonu],hadres AS[Adres] from HasTablo ORDER BY h_id ASC", giris.Aconnection);
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
        private void yonhastalar_Load(object sender, EventArgs e)
        {
            timer1.Start();
            hastaBilgi_Goster();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //int a = Convert.ToInt64(textBox2.Text);
            komut.Connection = baglanti;
            komut.CommandText = "delete from HasTablo where htc='" + maskedTextBox1.Text.ToString() + "'  ";
            //where rsaat = '" + comboBox1.Text.ToString()+ "'
            komut.ExecuteNonQuery();
            baglanti.Close();
            maskedTextBox1.Clear();
            hastaBilgi_Goster();
        }
    }
}
