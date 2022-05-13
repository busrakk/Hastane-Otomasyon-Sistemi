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
    public partial class doktorbilgi : Form
    {
        public doktorbilgi()
        {
            InitializeComponent();
        }

        //DOKTOR KENDİ BİLGİLERİ FORMU

        giris giris = new giris();

        public OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void doktorBilgi_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select d_id AS[ID],disim AS[Adı],dsoyisim AS[Soyadı],dtelefon AS[Telefon],dmail AS[Mail],dtc AS[TC],dbrans AS[Brans] from DoktorTablo where dtc='" + maskedTextBox1.Text.ToString() + "'  ", giris.Aconnection);
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
            doktor doktor_new = new doktor();
            doktor_new.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doktorBilgi_Goster();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void doktorbilgi_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
