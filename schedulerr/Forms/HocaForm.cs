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
    public partial class HocaForm : Form
    {
        public HocaForm()
        {
            InitializeComponent();
            hocalariListele();

            unvanCOMBO.Items.Add("Prof.Dr.");
            unvanCOMBO.Items.Add("Doç.Dr.");
            unvanCOMBO.Items.Add("Yrd.Doc.Dr.");
            unvanCOMBO.Items.Add("Arş.Gör.Dr.");
            unvanCOMBO.Items.Add("Öğr.Gör.Dr.");
            unvanCOMBO.Items.Add("Dr.");
            unvanCOMBO.Items.Add("Öğr.Gör.");
            unvanCOMBO.Items.Add("Arş.Gör.");

        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ AnasayfaForm.DosyaYolu);
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        void hocalariListele()
        {
            hocaGV.Refresh();
            baglantı.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Hoca", baglantı);
            adtr.Fill(ds, "Hoca");
            hocaGV.DataSource = ds.Tables["Hoca"];
            adtr.Dispose();
            baglantı.Close();        
        }

        // Hoca Ekleme İşlemi
        private void hocaEkleBTN_Click(object sender, EventArgs e)
        {
            if (unvanCOMBO.SelectedItem != null && hocaadsoyadTXT.Text.Trim() != "")
            {
                komut.Connection = baglantı;
                komut.CommandText = "insert into Hoca(unvan,adsoyad,dolu_saat) values('" + unvanCOMBO.SelectedItem.ToString() + "','" + hocaadsoyadTXT.Text +"','"+ MemnuniyetForm.memn+ "')";
                baglantı.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MemnuniyetForm.memn = null;
                MessageBox.Show("Hoca Ekleme Başarıyla Gerçekleşti.", "Ekleme tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unvanCOMBO.ResetText();
                hocaadsoyadTXT.Clear();
                ds.Clear();
                hocalariListele();
            }
            else
                MessageBox.Show("Lütfen içeriklerin tamamını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Hoca Güncelleme İşlemi
        private void hocaGuncelleBTN_Click(object sender, EventArgs e)
        {
            if (unvanCOMBO.SelectedItem != null && hocaadsoyadTXT.Text.Trim() != "")
            {

                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "Update Hoca set unvan= '" + unvanCOMBO.SelectedItem.ToString() + "',adsoyad='" + hocaadsoyadTXT.Text
                                     +"',dolu_saat='"+MemnuniyetForm.memn+ "' where hoca_id =" + Convert.ToInt32(hocaIdTXT.Text) + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();
                MemnuniyetForm.memn = null;

                MessageBox.Show("Hoca Güncelleme Başarıyla Tamamlandı.", "Güncelleme tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unvanCOMBO.ResetText();
                hocaadsoyadTXT.Clear();
                ds.Clear();
                hocalariListele();

            }
            else
                MessageBox.Show("Lütfen içeriklerin tamamını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Hoca Silme İşlemi
        private void hocaSilBTN_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (c == DialogResult.Yes && hocaIdTXT.Text != "")
            {
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "Delete from Hoca where hoca_id=" + Convert.ToInt32(hocaIdTXT.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();

                MessageBox.Show("Hoca kaydı silindi.", "Silme-İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Tables["Hoca"].Clear();
                hocaIdTXT.Clear();
                hocalariListele();
            }
        }

        //Pencere Kapatma 
        private void hocaislemlerikaydetBTN_Click(object sender, EventArgs e)
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

        private void dolusaatBTN_Click(object sender, EventArgs e)
        {
            MemnuniyetForm mf = new MemnuniyetForm();
            mf.ShowDialog();
        }
    }
}
