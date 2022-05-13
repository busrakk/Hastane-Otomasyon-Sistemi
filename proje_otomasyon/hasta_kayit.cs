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
    public partial class hasta_kayit : Form
    {
        public hasta_kayit()
        {
            InitializeComponent();
        }

        //HASTA KAYIT PANELİ

        giris giris = new giris();
          //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
           //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
      
        private void hasta_kayit_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

            string sqlText = "INSERT INTO HasTablo (hadi,hsoyadi,hbabaadi,hanneadi,hmail,hcinsiyet,hkan,hdyeri,htc,hdtarihi,hcepno,hparola,hadres) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + maskedTextBox1.Text.ToString() + "','" + maskedTextBox2.Text.ToString() + "','" + maskedTextBox3.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + richTextBox1.Text.ToString() + "')";

            OleDbCommand AccessCommand = new OleDbCommand(sqlText, giris.Aconnection);
            AccessCommand.ExecuteNonQuery();
            giris.Aconnection.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Refresh();
            comboBox2.Refresh();
            comboBox3.Refresh();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            textBox6.Clear();
            richTextBox1.Clear();

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
                textBox6.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox6.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToLongDateString();
            label17.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
