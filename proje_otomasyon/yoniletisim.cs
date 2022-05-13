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
    public partial class yoniletisim : Form
    {
        public yoniletisim()
        {
            InitializeComponent();
        }

        //YÖNETİCİ ŞİKAYET BİLGİLERİ

        giris giris = new giris();
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");

        private void button2_Click(object sender, EventArgs e)
        {
            yonetici yonetici_new = new yonetici();
            yonetici_new.Show();
            this.Hide();
        }

        private void iletisimBilgi_Goster()
        {
            try
            {
                giris.Aconnection.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select kimlik AS[ID],iad AS[Adı],isoyad AS[Soyadı],imail AS[Mail] ,italep AS[Talep/Şikayet] from IletisimTablo ORDER BY kimlik ASC", giris.Aconnection);
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
        private void yoniletisim_Load(object sender, EventArgs e)
        {
            iletisimBilgi_Goster();
        }
    }
}
