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
    public partial class yondoktorlar : Form
    {
        public yondoktorlar()
        {
            InitializeComponent();
        }

        //YÖNETİCİ DOKTOR BİLGİLERİ EKRANI

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

        private void doktorBilgi_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select d_id AS[ID],disim AS[Adı],dsoyisim AS[Soyadı],dtelefon AS[Telefon],dmail AS[Mail],dtc AS[TC],dbrans AS[Brans] from DoktorTablo ORDER BY d_id ASC", giris.Aconnection);
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

        private void yondoktorlar_Load(object sender, EventArgs e)
        {
            timer1.Start();
            doktorBilgi_Goster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            komut.CommandText = "delete from DoktorTablo where dtc='" + maskedTextBox1.Text.ToString() + "'  ";
            //where rsaat = '" + comboBox1.Text.ToString()+ "'
            komut.ExecuteNonQuery();
            baglanti.Close();
            maskedTextBox1.Clear();
            doktorBilgi_Goster();
        }
    }
}
