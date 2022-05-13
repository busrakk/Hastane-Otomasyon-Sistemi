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
    public partial class kayitsecim : Form
    {
        public kayitsecim()
        {
            InitializeComponent();
        }

        //KAYIT SEÇİM PANELİ

        private void button3_Click(object sender, EventArgs e)
        {
            giris giris_new = new giris();
            giris_new.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasta_kayit hasta_kayit_new = new hasta_kayit();
            hasta_kayit_new.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktor_kayit doktor_kayit_new = new doktor_kayit();
            doktor_kayit_new.Show();
            this.Hide();
        }

        private void kayitsecim_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
