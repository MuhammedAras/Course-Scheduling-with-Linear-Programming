using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace schedulerr.Forms
{
    public partial class FakülteninBelirledigiDerslerForm : Form
    {        
        public static string ders,atananderssaatleri;
        public static int toplamsaat;
       

        public FakülteninBelirledigiDerslerForm()
        {
            InitializeComponent();
            comboyaDersEkle();
            atanandersleriListele();
        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ AnasayfaForm.DosyaYolu);
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        void atanandersleriListele()
        {
            atananderslerGV.Refresh();
            baglantı.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select AtananDers.atananders_id, Ders.ders_adi, AtananDers.atanan_saat from AtananDers , Ders where AtananDers.ders_id=Ders.ders_id", baglantı);
            adtr.Fill(ds, "AtananDers");
            atananderslerGV.DataSource = ds.Tables["AtananDers"];
            adtr.Dispose();
            baglantı.Close();
        }

        void comboyaDersEkle()
        {
            baglantı.Open();
            OleDbCommand adtr = new OleDbCommand("select * from Ders", baglantı);
            OleDbDataReader data = adtr.ExecuteReader();

            while (data.Read())
            {
                atanandersCOMBO.Items.Add(data["ders_adi"]);
            }
            baglantı.Close();
            
        }
        private void atananderslerBTN_Click(object sender, EventArgs e)
        {
            if (atanandersCOMBO.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Ders Seçiniz.","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                ders = atanandersCOMBO.SelectedItem.ToString();

                baglantı.Open();
                OleDbDataReader reader = null;
                OleDbCommand komut1 = new OleDbCommand("SELECT oturum1,oturum2 FROM Ders where ders_adi='" + ders + "'", baglantı);
                reader = komut1.ExecuteReader();

                while (reader.Read())
                {
                    toplamsaat = Convert.ToInt32(reader["oturum1"]) + Convert.ToInt32(reader["oturum2"]);
                }

                baglantı.Close();

                FakülteninAtayacagiDersSaati fkt = new FakülteninAtayacagiDersSaati();
                fkt.Show();
            }
        }

        private void dersekleBTN_Click(object sender, EventArgs e)
        {
            
        }

        

        private void silBTN_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (c == DialogResult.Yes && dersidTXT.Text != "")
            {
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "Delete from AtananDers where atananders_id=" + Convert.ToInt32(dersidTXT.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();

                MessageBox.Show("Ders kaydı silindi.", "Silme-İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Tables["AtananDers"].Clear();
                dersidTXT.Clear();
                atanandersleriListele();
            }
        }
    }
}
