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
    public partial class hastarandevular : Form
    {

        //HASTA RANDEVU AL

        public hastarandevular()
        {
            InitializeComponent();
        }
        giris giris = new giris();
        public string tc { get; set; }

        private void hastarandevu_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select Kimlik AS[ID],rtc AS[TC],rdoktor AS[Doktor],rbolum AS[Bolum],rtarih AS[Tarih],rsaat AS[Saat] from RandevuTablo where rtc = '"+ maskedTextBox1.Text+"'", giris.Aconnection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hasta_new = new Hasta();
            hasta_new.Show();
            this.Hide();
        }

        private void hastarandevular_Load(object sender, EventArgs e)
        {
            timer1.Start();
            maskedTextBox1.Text = tc;
            hastarandevu_Goster();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hastarandevu_Goster();
        }
    }
}
