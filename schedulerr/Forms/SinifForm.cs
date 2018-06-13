using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedulerr
{
    public partial class SiniflarForm : Form
    {
        public SiniflarForm()
        {
            InitializeComponent();
            sinifListele();
        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ AnasayfaForm.DosyaYolu);
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();


        /// SINIFLAR

        void sinifListele()
        {
            listeleGV.Refresh();
            baglantı.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Sinif", baglantı);
            adtr.Fill(ds, "Sinif");
            listeleGV.DataSource = ds.Tables["Sinif"];
            adtr.Dispose();
            baglantı.Close();

        }

        // Sınıf Ekleme İşlemi
        private void sinifekleBTN_Click(object sender, EventArgs e)
        {
            if (sinifadiTXT.Text.Trim() != "" && sinifturuTXT.Text.Trim() != "")
            {
                komut.Connection = baglantı;
                komut.CommandText = "insert into Sinif(sinif_adi,sinif_türü) values('" + sinifadiTXT.Text + "','" + sinifturuTXT.Text + "')";
                baglantı.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();

                MessageBox.Show("Sınıf Ekleme Başarıyla Gerçekleşti.", "Ekleme tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sinifadiTXT.Clear();
                sinifturuTXT.Clear();
                ds.Clear();
                sinifListele();
            }
            else
                MessageBox.Show("Lütfen içeriklerin tamamını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Sınıf Güncelleme İşlemi
        private void sinifguncelleBTN_Click(object sender, EventArgs e)
        {
            if (sinifadiTXT.Text.Trim() != "" && sinifturuTXT.Text.Trim() != "")
            {

                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "Update Sinif set sinif_adi= '" + sinifadiTXT.Text + "',sinif_türü='" + sinifturuTXT.Text + "' where sinif_id =" + Convert.ToInt32(sinifidTXT.Text) + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();

                MessageBox.Show("Sınıf Güncelleme Başarıyla Tamamlandı.", "Güncelleme tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sinifadiTXT.Clear();
                sinifturuTXT.Clear();
                ds.Clear();
                sinifListele();

            }
            else
                MessageBox.Show("Lütfen içeriklerin tamamını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        // Sınıf Silme İşlemi
        private void sinifsilBTN_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (c == DialogResult.Yes && sinifidTXT.Text != "")
            {
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "Delete from Sinif where sinif_id=" + Convert.ToInt32(sinifidTXT.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();

                MessageBox.Show("Sınıf kaydı silindi.", "Silme-İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Tables["Sinif"].Clear();
                sinifidTXT.Clear();
                sinifListele();
            }
        }

        // Pencereyi kapatma işlemleri
        private void sinifkaydetBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Kapatmak istediğinizden emin misiniz?", "Kaydediliyor...", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
    }
}
