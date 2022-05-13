using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_otomasyon
{
    public partial class yonetici : Form
    {

        //YONETİCİ GİRİŞ PANELİ 
        public yonetici()
        {
            InitializeComponent();
        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonbilgi yonbilgi_new = new yonbilgi();
            yonbilgi_new.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yoniletisim yoniletisim_new = new yoniletisim();
            yoniletisim_new.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yondoktorlar yondoktorlar_new = new yondoktorlar();
            yondoktorlar_new.Show();
            this.Hide();
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

        private void button3_Click(object sender, EventArgs e)
        {
            yonhastalar yonhastalar_new = new yonhastalar();
            yonhastalar_new.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kanbilgi kanbilgi_new = new kanbilgi();
            kanbilgi_new.Show();
            this.Hide();
        }
    }
}
