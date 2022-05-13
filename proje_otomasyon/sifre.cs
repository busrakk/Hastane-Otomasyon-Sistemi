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
using System.Net.Mail;

namespace proje_otomasyon
{
    public partial class sifre : Form
    {
        giris giris = new giris();
        public sifre()
        {
            InitializeComponent();
        }

        // ŞİFRE PANELİ

        private void sifre_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000, 9999);
            yeniS.Text = sayi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            
            kontrol.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            kontrol.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    if (kontrol.Text == "1")
                    {
                        if (giris.Aconnection.State == ConnectionState.Open)
                            giris.Aconnection.Close();
                        giris.Aconnection.Open();

                        OleDbCommand a = new OleDbCommand();
                        a.Connection = giris.Aconnection;
                        a.CommandText = ("Select DoktorTablo.dmail from DoktorTablo where dmail=2");
                        a.Parameters.AddWithValue("@q", textBox1.Text);
                        OleDbDataReader read = a.ExecuteReader();
                        /*
                        SqlCommand a = new SqlCommand("select doktorlar.doktor_eposta from doktorlar where doktor_eposta=@q ", giris.Aconnection);
                        a.Parameters.AddWithValue("@q", textBox1.Text);
                        SqlDataReader oku = a.ExecuteReader();
                        */
                        if (read.Read())
                        {
                            SmtpClient Kaynak = new SmtpClient();
                            Kaynak.Credentials = new System.Net.NetworkCredential("odev@gmail.com", "deneme_12");
                            Kaynak.Host = "smtp.gmail.com";
                            Kaynak.Port = 587;
                            MailAddress Giden = new MailAddress("odev@gmail.com", "HO Admin");
                            MailMessage Mesaj = new MailMessage();
                            Mesaj.From = Giden;
                            Mesaj.To.Add(textBox1.Text);
                            Mesaj.Subject = label1.Text;
                            Mesaj.Body = yeniS.Text;
                            Mesaj.IsBodyHtml = true;
                            Kaynak.EnableSsl = true;
                            Kaynak.Send(Mesaj);
                            kontrol2.Text = "2";
                            MessageBox.Show("Yeni Şifreniz Mailinize Gönderilmiştir");
                            giris.Aconnection.Close();


                        }
                        else
                            MessageBox.Show("Böyle bir e-posta sistemde kayıtlı değil");

                        if (kontrol2.Text == "2")
                        {
                            giris.Aconnection.Open();
                            OleDbCommand q = new OleDbCommand();
                            q.Connection = giris.Aconnection;
                            q.CommandText = ("update DoktorTablo set dsifre=@a where dmail=@eposta ");
                            q.Parameters.AddWithValue("@a", textBox1.Text);
                            q.ExecuteReader();
                            /*
                            SqlCommand q = new SqlCommand("update doktorlar set sifre=@a where doktor_eposta=@eposta ", giris.Aconnection);
                            q.Parameters.AddWithValue("@eposta", textBox1.Text);
                            q.Parameters.AddWithValue("@a", yeniS.Text);
                            q.ExecuteNonQuery();
                            */
                            giris.Aconnection.Close();
                            this.Close();
                        }
                    }

                    if (kontrol.Text == "2")
                    {
                        if (giris.Aconnection.State == ConnectionState.Open)
                            giris.Aconnection.Close();
                        giris.Aconnection.Open();

                        OleDbCommand a = new OleDbCommand();
                        a.Connection = giris.Aconnection;
                        a.CommandText = ("Select HasTablo.hmail from HasTablo where hmail=@q");
                        a.Parameters.AddWithValue("@q", textBox1.Text);
                        OleDbDataReader read = a.ExecuteReader();
                        /*
                        SqlCommand a = new SqlCommand("select hastalar.Hasta_ePosta from hastalar where Hasta_ePosta=@q ", giris.Aconnection);
                        a.Parameters.AddWithValue("@q", textBox1.Text);
                        SqlDataReader oku = a.ExecuteReader();
                        */
                        if (read.Read())
                        {
                            SmtpClient Kaynak = new SmtpClient();
                            Kaynak.Credentials = new System.Net.NetworkCredential("odev@gmail.com", "deneme_12");
                            Kaynak.Host = "smtp.gmail.com";
                            Kaynak.Port = 587;
                            MailAddress Giden = new MailAddress("odev@gmail.com", "HO Admin");
                            MailMessage Mesaj = new MailMessage();
                            Mesaj.From = Giden;
                            Mesaj.To.Add(textBox1.Text);
                            Mesaj.Subject = label1.Text;
                            Mesaj.Body = yeniS.Text;
                            Mesaj.IsBodyHtml = true;
                            Kaynak.EnableSsl = true;
                            Kaynak.Send(Mesaj);
                            kontrol2.Text = "2";
                            MessageBox.Show("Yeni Şifreniz Mailinize Gönderilmiştir");
                            giris giris = new giris();
                            giris.Aconnection.Close();


                        }
                        else
                            MessageBox.Show("Böyle bir e-posta sistemde kayıtlı değil");
                            
                            

                        if (kontrol2.Text == "2")
                        {
                            giris.Aconnection.Open();

                            OleDbCommand q = new OleDbCommand();
                            q.Connection = giris.Aconnection;
                            q.CommandText = ("update HasTablo set hparola=@a where hmail=@eposta ");
                            q.Parameters.AddWithValue("@a", textBox1.Text);
                            q.ExecuteReader();
                            /*
                            SqlCommand q = new SqlCommand("update doktorlar set Hasta_parola=@a where Hasta_ePosta=@eposta ", giris.Aconnection);
                            q.Parameters.AddWithValue("@eposta", textBox1.Text);
                            q.Parameters.AddWithValue("@a", yeniS.Text);
                            q.ExecuteNonQuery();
                            */
                            giris.Aconnection.Close();
                            this.Close();
                        }
                    }
                }
                else
                    MessageBox.Show("Lütfen bir e-posta giriniz.");
            }
            catch
            {
                MessageBox.Show("Yeni Şifreniz Mailinize Gönderilmiştir");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            giris giris_new = new giris();
            giris_new.Show();
            //this.Hide();
        }
    }
}
