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
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }
        giris giris = new giris();

        //İLETİŞİM 

        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");

        private void iletisim_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            giris giris_new = new giris();
            giris_new.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            giris.Aconnection.Open();

            string sqlText = "INSERT INTO IletisimTablo (iad,isoyad,imail,italep) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')";

            OleDbCommand AccessCommand = new OleDbCommand(sqlText, giris.Aconnection);
            AccessCommand.ExecuteNonQuery();
            giris.Aconnection.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("Talep veya Şikayetiniz alınmıştır. En kısa zamanda size dönüş yapılacaktır.");
            giris giris_new = new giris();
            giris_new.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
