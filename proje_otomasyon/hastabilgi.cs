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
    public partial class hastabilgi : Form
    {

        //HASTA KENDİ BİLGİLERİ

        public hastabilgi()
        {
            InitializeComponent();
        }
        giris giris = new giris();

        private void hastaBilgi_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select h_id AS[ID],hadi AS[Adı],hsoyadi AS[Soyadı],hbabaadi AS[Baba Adı],hanneadi AS[Anne Adı],hmail AS[Mail],hcinsiyet AS[Cinsiyet],hkan AS[Kan Grubu],hdyeri AS[Doğum Yeri],htc AS[TC],hdtarihi AS[Doğum Tarihi],hcepno AS[Cep Telefonu],hadres AS[Adres] from HasTablo where htc='" + maskedTextBox1.Text.ToString() + "' ", giris.Aconnection);
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastaBilgi_Goster();
        }

        private void hastabilgi_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hasta hasta_new = new Hasta();
            hasta_new.Show();
            this.Hide();
        }
    }
}
