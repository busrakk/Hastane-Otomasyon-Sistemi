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
    public partial class doktor_randevu : Form
    {
        giris giris = new giris();

        //DOKTOR RANDEVU PANELİ 

        public doktor_randevu()
        {
            InitializeComponent();
        }

        private void hastarandevu_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select Kimlik AS[ID],rtc AS[TC],rdoktor AS[Doktor],rbolum AS[Bolum],rtarih AS[Tarih],rsaat AS[Saat] from RandevuTablo where rdoktor = '" + textBox1.Text + "'", giris.Aconnection);
                DataSet dshafiza = new DataSet();
                kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                giris.Aconnection.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "HASTANE OTOMASYON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                giris.Aconnection.Close();
            }
        }
        private void doktor_randevu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            hastarandevu_Goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktor dok = new doktor();
            dok.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastarandevu_Goster();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
