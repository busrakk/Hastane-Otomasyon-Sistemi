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
    public partial class doktorbilgideneme : Form
    {
        giris giris = new giris();
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        DataTable tablo = new DataTable();
        IDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();

        private void doktorbilgiiii_Load(object sender, EventArgs e)
        {
            giris.Aconnection.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from DoktorTablo ", giris.Aconnection);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            giris.Aconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doktor doktor_new = new doktor();
            doktor_new.Show();
            this.Hide();
        }
    }
}
