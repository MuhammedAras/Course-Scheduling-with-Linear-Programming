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
    public partial class FakülteninAtayacagiDersSaati : Form
    {
        public FakülteninAtayacagiDersSaati()
        {
            InitializeComponent();
            baslikLABEL.Text = FakülteninBelirledigiDerslerForm.ders.ToString().ToUpper()+" DERSİNİN İŞLENECEĞİ SAATLER";
            baslikLABEL.TextAlign = ContentAlignment.MiddleCenter;

        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ AnasayfaForm.DosyaYolu);
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void saatekleBTN_Click(object sender, EventArgs e)
        {
            String atananderssaatleri=null;
            if (saatKontrol() == FakülteninBelirledigiDerslerForm.toplamsaat)
            {
                foreach (Control c in dersatamaPANEL.Controls)
                {
                    if (c.GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)c).Checked == true)
                        {
                            atananderssaatleri += ((CheckBox)c).Name + ",";
                        }
                    }
                }
                if (atananderssaatleri != null)
                {
                    atananderssaatleri = atananderssaatleri.Substring(0, atananderssaatleri.Length - 1);
                }

                // Veritabanına atanan ders daatlerini ekleme

                if (FakülteninBelirledigiDerslerForm.atanandersCOMBO.SelectedItem != null)
                {
                    baglantı.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand komut1 = new OleDbCommand("SELECT ders_id FROM Ders where ders_adi='" + FakülteninBelirledigiDerslerForm.ders + "'", baglantı);
                    reader = komut1.ExecuteReader();
                    ArrayList ar = new ArrayList();
                    while (reader.Read())
                    {
                        ar.Add(Convert.ToInt32(reader["ders_id"]));
                    }
                    komut.Connection = baglantı;
                    komut.CommandText = "insert into AtananDers(ders_id,atanan_saat) values('" + ar[0] + "','" + atananderssaatleri + "')";
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglantı.Close();

                    MessageBox.Show("Ders Ekleme Başarıyla Gerçekleşti.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atananderssaatleri = null;

                    FakülteninBelirledigiDerslerForm.atanandersCOMBO.ResetText();
                    ds.Clear();
                    atanandersleriListele();
                    this.Close();
                }                
            }
            else
            {
                DialogResult c = MessageBox.Show( "Lütfen toplam "+ FakülteninBelirledigiDerslerForm.toplamsaat +" saat seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void atanandersleriListele()
        {
            FakülteninBelirledigiDerslerForm.atananderslerGV.Refresh();
            baglantı.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select AtananDers.atananders_id, Ders.ders_adi, AtananDers.atanan_saat from AtananDers , Ders where AtananDers.ders_id=Ders.ders_id", baglantı);
            adtr.Fill(ds, "AtananDers");
            FakülteninBelirledigiDerslerForm.atananderslerGV.DataSource = ds.Tables["AtananDers"];
            adtr.Dispose();
            baglantı.Close();
        }
        private int saatKontrol() {
            int i = 0;
            foreach (Control c in dersatamaPANEL.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    if (((CheckBox)c).Checked == true)
                        i++;
                }
            }
            return i;
        }

        private void baslikLABEL_Click(object sender, EventArgs e)
        {

        }
    }
}
