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
    public partial class doktorkendibilgisi : Form
    {
        public doktorkendibilgisi()
        {
            InitializeComponent();
        }
        giris giris = new giris();
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASUS\\Desktop\\hastane_otomasyonu_yeni.mdb");
        //OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\databasesonunsonu\\hastane_otomasyonu_yeni.mdb");
        private void showInformation()
        {
            listView1.Items.Clear();
            giris.Aconnection.Open();
            OleDbCommand AccessCommand = new OleDbCommand();
            AccessCommand.Connection = giris.Aconnection;
            
            AccessCommand.CommandText = ("Select * from DoktorTablo");
            OleDbDataReader read = AccessCommand.ExecuteReader();

            while (read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["d_id"].ToString();
                addNew.SubItems.Add(read["disim"].ToString());
                addNew.SubItems.Add(read["dsoyisim"].ToString());
                addNew.SubItems.Add(read["dtelefon"].ToString());
                addNew.SubItems.Add(read["dmail"].ToString());
                addNew.SubItems.Add(read["dtc"].ToString());
                addNew.SubItems.Add(read["dbrans"].ToString());
                addNew.SubItems.Add(read["dsifre"].ToString());


                listView1.Items.Add(addNew);
            }
            giris.Aconnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktor doktor_new = new doktor();
            doktor_new.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showInformation();
        }

        private void doktorkendibilgisi_Load(object sender, EventArgs e)
        {

        }
    }
}
