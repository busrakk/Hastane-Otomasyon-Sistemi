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
    public partial class Hasta : Form
    {
        giris giris = new giris();

        //HASTA PANELİ

        public Hasta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           hastabilgi bilgi = new hastabilgi();
            bilgi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            giris giris_new = new giris();
            giris_new.Show();
            this.Hide();
            */

            DialogResult karar = new DialogResult();
            karar = MessageBox.Show("Çıkış istediğinize emin misiniz ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (karar == DialogResult.Yes)
            {
                this.Hide();
                giris yeni = new giris();
                yeni.Show();
            }
            else if (karar == DialogResult.No)
            {
                MessageBox.Show("Oturum Kapatılmadı.");
            }
        }

        public string kullaniciAdi { get; set; }

        private void Hasta_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = kullaniciAdi;
            label5.Text = kullaniciAdi;
            label6.Text = kullaniciAdi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuEkrani randevu_new = new RandevuEkrani();
            randevu_new.tc = label2.Text;
            randevu_new.Show();
            this.Hide();
        }

       private void hastaBilgi_Goster()
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hastarandevular hastarandevular_new = new hastarandevular();
            hastarandevular_new.tc = label5.Text;
            hastarandevular_new.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastarandevusil hastarandevusil_new = new hastarandevusil();
            hastarandevusil_new.tc = label6.Text;
            hastarandevusil_new.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hastabilgi hastabilgi_new = new hastabilgi();
            hastabilgi_new.Show();
            this.Hide();
        }
    }
}
