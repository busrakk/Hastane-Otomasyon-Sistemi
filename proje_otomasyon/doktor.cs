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
    public partial class doktor : Form
    {
        public doktor()
        {
            InitializeComponent();
        }

        //DOKTOR PANELİ

        giris giris1 = new giris();
        
        private void doktor_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
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


        
        private void button2_Click(object sender, EventArgs e)
        {
            doktor_randevu doktor_randevu_new = new doktor_randevu();
            doktor_randevu_new.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doktor_randevusil doktor_randevusil_new = new doktor_randevusil();
            doktor_randevusil_new.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doktorbilgi doktorbilgi_new = new doktorbilgi();
            doktorbilgi_new.Show();
            this.Hide();

        }
    }
}
