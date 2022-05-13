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
    public partial class RandevuEkrani : Form
    {
        public RandevuEkrani()
        {
            InitializeComponent();
        }

        //RANDEVU EKRANI

        giris giris = new giris();
        
        private void button18_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            this.Hide();
            hasta.Show();
        }

        public string tc{ get; set; }

        class dgvSettings
        {
            public void modf(DataGridView d1)
            {
                d1.ColumnCount = 5;

                d1.Columns[0].Name = "tc";
                d1.Columns[1].Name = "bolum";
                d1.Columns[2].Name = "doktor";
                d1.Columns[3].Name = "tarih";
                d1.Columns[4].Name = "saat";

                d1.Columns["tc"].HeaderText = "TC";
                d1.Columns["bolum"].HeaderText = "Bölüm";
                d1.Columns["doktor"].HeaderText = "Doktor";
                d1.Columns["tarih"].HeaderText = "Tarih";
                d1.Columns["saat"].HeaderText = "Saat";

                d1.Columns[0].Width = 100;
                d1.Columns[1].Width = 100;
                d1.Columns[2].Width = 100;
                d1.Columns[3].Width = 100;
                d1.Columns[4].Width = 100;

            }

            public void clr(DataGridView dgv1)
            {
                dgv1.DataSource = null;
                dgv1.Rows.Clear();
                dgv1.Columns.Clear();
                dgv1.Refresh();
            }
        }



        private void RandevuEkrani_Load(object sender, EventArgs e)
        {
            timer1.Start();
            maskedTextBox1.Text = tc;

            dgvSettings dgv1 = new dgvSettings();
            dgv1.modf(dataGridView1);

            //OleDbConnection baglanti = new OleDbConnection();
            ////baglanti.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb";
            //baglanti.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb";
            //OleDbCommand komut = new OleDbCommand();
            //komut.CommandText = "select * from Randevualbolum";
            //komut.Connection = baglanti;
            //komut.CommandType = CommandType.Text;
            //OleDbDataReader dr;
            //baglanti.Open();
            //dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr["Bolumler"]);
            //}
            //baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem == "Diş Hekimliği")
            {
                comboBox2.Items.Add("Özde Baydar");
                comboBox2.Items.Add("Firuz Tekin");
                comboBox2.Items.Add("Fatih Garip");
                comboBox2.Items.Add("Emine Akca");
            }
            else if (comboBox1.SelectedItem == "Beyin ve Sinir Cerrahisi")
            {
                comboBox2.Items.Add("Ahmet Yasin Çark");
                comboBox2.Items.Add("Umut Salih Tokalı");
                comboBox2.Items.Add("Kerem Göçmen");
            }
            else if (comboBox1.SelectedItem == "Çocuk Hastalıkları")
            {
                comboBox2.Items.Add("Atahan Adanır");
                comboBox2.Items.Add("Muhammed Yapar");
                comboBox2.Items.Add("Meltem Gülkan");
            }
            else if (comboBox1.SelectedItem == "Deri ve Zührevi Hastalıkları")
            {
                comboBox2.Items.Add("Talip Öz");
                comboBox2.Items.Add("Ayşe Melisa Atan");
                comboBox2.Items.Add("Fahri Güven");
            }
            else if (comboBox1.SelectedItem == "Enfeksiyon Hastalıkları")
            {
                comboBox2.Items.Add("Elif Kapsız");
                comboBox2.Items.Add("Murat Sinan Ayaz");
                comboBox2.Items.Add("Ramazan Hilal");
            }
            else if (comboBox1.SelectedItem == "Genel Cerrahi")
            {
                comboBox2.Items.Add("Şennur Ağnar");
                comboBox2.Items.Add("Zeynep Bahtıyar");
                comboBox2.Items.Add("Sude Kanmaz");
            }
            else if (comboBox1.SelectedItem == "Göğüs Hastalıkları")
            {
                comboBox2.Items.Add("Aysel Samancı");
                comboBox2.Items.Add("Yüksel Balcı");
                comboBox2.Items.Add("Haluk Karadağ");
            }
            else if (comboBox1.SelectedItem == "Göz Hastalıkları")
            {
                comboBox2.Items.Add("Melike Göksoy");
                comboBox2.Items.Add("Bensu Çakan");
                comboBox2.Items.Add("Hayriye Kayalı");
            }
            else if (comboBox1.SelectedItem == "İç Hastalıkları")
            {
                comboBox2.Items.Add("Birsen Dursun");
                comboBox2.Items.Add("Aydın Çini");
                comboBox2.Items.Add("Hatice Kızıl");
            }
            else if (comboBox1.SelectedItem == "Kadın Hastalıkları ve Doğum")
            {
                comboBox2.Items.Add("Selma Mumcu");
                comboBox2.Items.Add("Mert Dayıoğlu");
                comboBox2.Items.Add("Özge Masaracı");
            }
            else if (comboBox1.SelectedItem == "Kalp ve Damar Cerrahisi")
            {
                comboBox2.Items.Add("Türkan Oduncu");
                comboBox2.Items.Add("Osman Diri");
                comboBox2.Items.Add("Tuba Önen");
            }
            else if (comboBox1.SelectedItem == "Kardiyoloji")
            {
                comboBox2.Items.Add("Hacı Mehmet Adıgüzel");
                comboBox2.Items.Add("Zehra Duymuş");
                comboBox2.Items.Add("Aysel Paksoy");
            }
            else if (comboBox1.SelectedItem == "Kulak Burun Boğaz Hastalıkları")
            {
                comboBox2.Items.Add("Ceyhun Kul");
                comboBox2.Items.Add("Fidan Balcı");
                comboBox2.Items.Add("Şaban Pehlivan");
            }
            else if (comboBox1.SelectedItem == "Nöroloji")
            {
                comboBox2.Items.Add("Ezgin Dallı");
                comboBox2.Items.Add("Ahmet Erbay");
                comboBox2.Items.Add("Kevser Rauf");
            }
            else if (comboBox1.SelectedItem == "Ruh Sağlığı ve Hastalıkları")
            {
                comboBox2.Items.Add("Selman Erten");
                comboBox2.Items.Add("Nadire Erkuş");
                comboBox2.Items.Add("Mina Saygın");
            }
            else if (comboBox1.SelectedItem == "Üroloji")
            {
                comboBox2.Items.Add("Mustafa Karakan");
                comboBox2.Items.Add("Faik Ezber");
                comboBox2.Items.Add("Abdullah Seyfi");
            }
            //else
            //{
            //    comboBox2.Items.Add("Bölüm seçimi yapınız!");
            //}
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "08:00";
            button2.Enabled = false;
            button2.BackColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "08:30";
            button3.Enabled = false;
            button3.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "09:00";
            button4.Enabled = false;
            button4.BackColor = Color.Gray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "09:30";
            button5.Enabled = false;
            button5.BackColor = Color.Gray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "10:00";
            button6.Enabled = false;
            button6.BackColor = Color.Gray;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "10:30";
            button7.Enabled = false;
            button7.BackColor = Color.Gray;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = "11:00";
            button8.Enabled = false;
            button8.BackColor = Color.Gray;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "11:30";
            button9.Enabled = false;
            button9.BackColor = Color.Gray;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "13:00";
            button10.Enabled = false;
            button10.BackColor = Color.Gray;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "13:30";
            button11.Enabled = false;
            button11.BackColor = Color.Gray;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "14:00";
            button12.Enabled = false;
            button12.BackColor = Color.Gray;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "14:30";
            button13.Enabled = false;
            button13.BackColor = Color.Gray;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "15:00";
            button14.Enabled = false;
            button14.BackColor = Color.Gray;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "15:30";
            button15.Enabled = false;
            button15.BackColor = Color.Gray;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "16:00";
            button16.Enabled = false;
            button16.BackColor = Color.Gray;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "16:30";
            button17.Enabled = false;
            button17.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Refresh();
            giris.Aconnection.Open();
            string sqlText = "INSERT INTO RandevuTablo (rtc,rbolum,rdoktor,rtarih,rsaat) values ('" + maskedTextBox1.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" + textBox2.Text.ToString() + "')";

            OleDbCommand AccessCommand = new OleDbCommand(sqlText, giris.Aconnection);
            AccessCommand.ExecuteNonQuery();
            giris.Aconnection.Close();
            
            if (dataGridView1.DataSource == null)
            {
                RandevuEkrani_Load(sender, e);
            }

            dataGridView1.Rows.Add(maskedTextBox1.Text.ToString(), comboBox1.Text.ToString(), comboBox2.Text.ToString(), dateTimePicker1.Text.ToString(), textBox2.Text.ToString());

            MessageBox.Show("Randevunuz Başarıyla Kaydedildi");

            comboBox1.Refresh();
            comboBox2.Refresh();
            textBox2.Clear();
            button3.Refresh();
            button4.Refresh();
            button5.Refresh();
            button6.Refresh();
            button7.Refresh();
            button8.Refresh();
            button8.Refresh();
            button9.Refresh();
            button10.Refresh();
            button11.Refresh();
            button12.Refresh();
            button13.Refresh();
            button14.Refresh();
            button15.Refresh();
            button16.Refresh();
            button17.Refresh();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //dgvSettings dgv1 = new dgvSettings();
            //dgv1.clr(dataGridView1);
            giris.Aconnection.Open();
            OleDbCommand komut = new OleDbCommand();

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
            label8.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
