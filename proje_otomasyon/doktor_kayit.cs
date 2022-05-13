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
    public partial class doktor_kayit : Form
    {
        public doktor_kayit()
        {
            InitializeComponent();
        }

        //DOKTOR KAYIT PANELİ 

        // OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");

        giris giris = new giris();

        private void doktor_kayit_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kayitsecim kayitsecim_new = new kayitsecim();
            kayitsecim_new.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            giris.Aconnection.Open();

            string sqlText = "INSERT INTO DoktorTablo (disim,dsoyisim,dtelefon,dmail,dtc,dbrans,dsifre) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + maskedTextBox3.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + maskedTextBox1.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + textBox4.Text.ToString() + "')";

            OleDbCommand AccessCommand = new OleDbCommand(sqlText, giris.Aconnection);
            AccessCommand.ExecuteNonQuery();
            giris.Aconnection.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox1.Clear();
            textBox4.Clear();
            comboBox1.Refresh();
            this.Hide();
            MessageBox.Show("Kayıt Başarıyla Eklendi.");
            giris giris_new = new giris();
            giris_new.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox4.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox4.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongDateString();
            label9.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
