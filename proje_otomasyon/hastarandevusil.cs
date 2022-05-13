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
    public partial class hastarandevusil : Form
    {
        public hastarandevusil()
        {
            InitializeComponent();
        }

        //HASTA RANDEVU SİL

        giris giris = new giris();
        public string tc { get; set; }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void hastarandevu_Goster()
           
        {
            try
            {
                dataGridView1.Refresh();
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select Kimlik AS[ID],rtc AS[TC],rdoktor AS[Doktor],rbolum AS[Bolum],rtarih AS[Tarih],rsaat AS[Saat] from RandevuTablo where rtc = '" + maskedTextBox1.Text + "'", giris.Aconnection);
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
        private void hastarandevu_Sil()
        {
            try
            {
                giris.Aconnection.Open();
               // OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("DELETE Kimlik AS[ID],rtc AS[TC],rdoktor AS[Doktor],rbolum AS[Bolum],rtarih AS[Tarih],rsaat AS[Saat] from RandevuTablo where Kimlik = '" + textBox2.Text.ToString() + "'", giris.Aconnection);
                DataSet dshafiza = new DataSet();
                //kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                giris.Aconnection.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "HASTANE OTOMASYON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                giris.Aconnection.Close();
            }
        }
        private void hastarandevusil_Load(object sender, EventArgs e)
        {
            timer1.Start();
            maskedTextBox1.Text = tc;
            
            hastarandevu_Goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hasta_new = new Hasta();
            hasta_new.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hastarandevu_Goster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //int a = Convert.ToInt64(textBox2.Text);
            komut.Connection = baglanti;
            komut.CommandText = "delete from RandevuTablo where rtarih='" + dateTimePicker1.Text.ToString() + "' and rsaat='" + comboBox1.Text.ToString()+ "' and rtc='" + maskedTextBox1.Text.ToString() + "' ";
            //where rsaat = '" + comboBox1.Text.ToString()+ "'
            komut.ExecuteNonQuery();
            baglanti.Close();
            hastarandevu_Goster();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
