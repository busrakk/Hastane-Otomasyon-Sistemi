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
    public partial class giris : Form
    {
        // GİRİS SAYFASI
        public OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //public OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        public giris()
        {
            InitializeComponent();
        }

        void gizle()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            pictureBox1.Visible = false;
            buttonSifreUnut.Visible = false;
        }

        //yönetici butonu
        private void button1_Click_1(object sender, EventArgs e)
        {
            gizle();
            GirisPaneli.Visible = true;
            groupBox1.Visible = true;
            buttonSifreUnut.Visible = false;
            pictureBox1.Visible = true;
        }

        //doktor butonu
        private void button2_Click_1(object sender, EventArgs e)
        {
            gizle();
            GirisPaneli.Visible = true;
            groupBox2.Visible = true;
            buttonSifreUnut.Visible = true;
            pictureBox1.Visible = true;
        }

        //hasta butonu
        private void button3_Click_1(object sender, EventArgs e)
        {
            gizle();
            groupBox3.Visible = true;
            buttonSifreUnut.Visible = true;
            pictureBox1.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            kayitsecim kayitsecim_new = new kayitsecim();
            kayitsecim_new.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            iletisim iletisim_new = new iletisim();
            iletisim_new.Show();
            this.Hide();
        }

        private void buttonSifreUnut_Click(object sender, EventArgs e)
        {
            sifre yeni = new sifre();
            yeni.Show();
            pictureBox1.Visible = true;
            this.Hide();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;
            timer1.Start();
            gizle();
        }

        private void doktorButton_Click(object sender, EventArgs e)
        {

            if (dEpostaTextBox.Text != " " && dSifretextBox.Text != " ")
            {
                try
                {
                    Aconnection.Open();
                    OleDbCommand AccessCommand = new OleDbCommand("select dtc, dsifre from DoktorTablo where dtc= '" + dEpostaTextBox.Text + "'", Aconnection);
                    OleDbDataReader read = AccessCommand.ExecuteReader();
                    
                    if (read.Read() == true)
                    {
                        if (dEpostaTextBox.Text == read["dtc"].ToString() && dSifretextBox.Text == read["dsifre"].ToString())
                        {
                            doktor dok = new doktor();
                            dok.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
                }
                finally
                {
                    dEpostaTextBox.Text = "";
                    dSifretextBox.Clear();
                }
            }
            else
                MessageBox.Show("Boş Alanları Doldurunuz");
        }

        private void yoneticiButton_Click(object sender, EventArgs e)
        {

            if (yPostaTextBox.Text != " " && ySifretextBox.Text != " ")
            {
                try
                {
                    Aconnection.Open();
                    //OleDbCommand AccessCommand = new OleDbCommand("select yeposta, ysifre from YoneticiTablo where yeposta==@yeposta1 and ysifre==@ysifre1 ", Aconnection);
                    OleDbCommand AccessCommand = new OleDbCommand("select yeposta, ysifre from YoneticiTablo where yeposta= '" + yPostaTextBox.Text + "'", Aconnection); 
                    OleDbDataReader read = AccessCommand.ExecuteReader();
                    
                    if (read.Read() == true)
                    {
                        if (yPostaTextBox.Text == read["yeposta"].ToString() && ySifretextBox.Text == read["ysifre"].ToString())
                        {
                            yonetici yonet = new yonetici();
                            yonet.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
                }
                finally
                {
                    yPostaTextBox.Text = "";
                    ySifretextBox.Clear();
                }
            }
            else
                MessageBox.Show("Boş Alanları Doldurunuz");
        }

        private void hastabutton_Click_1(object sender, EventArgs e)
        {
           
            if (hastatextBox1.Text != " " && hastatextBox2.Text != " ")
            {
                try
                {
                    Aconnection.Open();
                    OleDbCommand AccessCommand = new OleDbCommand("select htc, hparola from HasTablo where htc= '" + hastatextBox1.Text + "'", Aconnection);
                    OleDbDataReader read = AccessCommand.ExecuteReader();

                    if (read.Read() == true)
                    {
                        if (hastatextBox1.Text == read["htc"].ToString() && hastatextBox2.Text == read["hparola"].ToString())
                        {
                            Hasta hasta_new = new Hasta();
                            //hasta_new.Show();
                            hasta_new.kullaniciAdi = hastatextBox1.Text;
                            hasta_new.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Hata!! Daha Sonra Tekrar Deneyiniz");
                }
                finally
                {
                    hastatextBox1.Text = "";
                    hastatextBox2.Clear();
                }
            }
            else
                MessageBox.Show("Boş Alanları Doldurunuz");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                dSifretextBox.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                dSifretextBox.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                ySifretextBox.UseSystemPasswordChar = true;
                checkBox2.Text = "Gizle";
            }
            else if (checkBox2.CheckState == CheckState.Unchecked)
            {
                ySifretextBox.UseSystemPasswordChar = false;
                checkBox2.Text = "Göster";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                hastatextBox2.UseSystemPasswordChar = true;
                checkBox3.Text = "Gizle";
            }
            else if (checkBox3.CheckState == CheckState.Unchecked)
            {
                hastatextBox2.UseSystemPasswordChar = false;
                checkBox3.Text = "Göster";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongDateString();
            label10.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }    
}
