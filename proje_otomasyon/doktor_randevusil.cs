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
    public partial class doktor_randevusil : Form
    {
        giris giris = new giris();

        public doktor_randevusil()
        {
            InitializeComponent();
        }

        //DOKTOR RANDEVU SİL

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        OleDbCommand komut = new OleDbCommand();

        private void hastarandevu_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select Kimlik AS[ID],rtc AS[TC],rdoktor AS[Doktor],rbolum AS[Bolum],rtarih AS[Tarih],rsaat AS[Saat] from RandevuTablo where rdoktor = '" + textBox1.Text + "'", giris.Aconnection);
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
        private void hastarandevu_Goster2()
        {
            try
            {
                dataGridView1.Refresh();
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("SELECT Kimlik AS[ID],rtc AS[TC],rdoktor AS[Doktor],rbolum AS[Bolum],rtarih AS[Tarih],rsaat AS[Saat] from RandevuTablo where rdoktor ='" + textBox1.Text.ToString() + "' and rtc='" + maskedTextBox1.Text.ToString() + "' ", giris.Aconnection);
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
        private void button2_Click(object sender, EventArgs e)
        {
            doktor dok = new doktor();
            dok.Show();
            this.Hide();
        }

        private void doktor_randevusil_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //RandevuBilgi_Goster();
        }

        //int index;

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //int a = Convert.ToInt64(textBox2.Text);
            komut.Connection = baglanti;
            komut.CommandText = "delete from RandevuTablo where rdoktor='" + textBox1.Text.ToString() + "' and rtc='" + maskedTextBox1.Text.ToString() + "' ";
            //where rsaat = '" + comboBox1.Text.ToString()+ "'
            komut.ExecuteNonQuery();
            baglanti.Close();
            hastarandevu_Goster();
           

            /*
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastarandevu_Goster2();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
