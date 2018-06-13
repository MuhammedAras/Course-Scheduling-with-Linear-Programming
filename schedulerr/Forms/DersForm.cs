using schedulerr.Forms;
using System;
using System.Collections;
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
    public partial class DersForm : Form
    {

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AnasayfaForm.DosyaYolu);
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public DersForm()
        {
            InitializeComponent();
            dersleriListele();
            comboyaHocaEkle();

            derstipiCOMBO.Items.Add("Seçmeli");
            derstipiCOMBO.Items.Add("Zorunlu");

            baglantı.Open();
            OleDbCommand adtr = new OleDbCommand("SELECT Sinif.sinif_türü from Sinif group by Sinif.sinif_türü;", baglantı);
            OleDbDataReader data = adtr.ExecuteReader();
           
            while (data.Read())
            {
                sinifturuCOMBO.Items.Add(data["sinif_türü"]);
            }
            baglantı.Close();

            dersdonemCOMBO.Items.Add("1");
            dersdonemCOMBO.Items.Add("2");
            dersdonemCOMBO.Items.Add("3");
            dersdonemCOMBO.Items.Add("4");

            teopraCOMBO.Items.Add("Teo");
            teopraCOMBO.Items.Add("Pra");
            teopraCOMBO.Items.Add(" ");
            teopraCOMBO.SelectedIndex=2;


        }

        

        void dersleriListele()
        {
            dersGV.Refresh();
            baglantı.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Ders", baglantı);
            adtr.Fill(ds, "Ders");
            dersGV.DataSource = ds.Tables["Ders"];
            adtr.Dispose();
            baglantı.Close();
        }

        void comboyaHocaEkle()
        {

            baglantı.Open();
            OleDbCommand adtr = new OleDbCommand("select * from Hoca", baglantı);
            OleDbDataReader data = adtr.ExecuteReader();
            while (data.Read())
            {
                dershocasiCOMBO.Items.Add(data["adsoyad"]);
            }
            baglantı.Close();
        }



        int HocaIDogren()
        {
            baglantı.Open();
            OleDbCommand adtr = new OleDbCommand("select * from Hoca where adsoyad ='" + dershocasiCOMBO.SelectedItem + "'", baglantı);
            OleDbDataReader data = adtr.ExecuteReader();

            ArrayList hocalar = new ArrayList();
            while (data.Read())
            {
                hocalar.Add(data["hoca_id"]);
            }
            baglantı.Close();
            return Convert.ToInt32(hocalar[0]);
        }

        
        private void dersekleBTN_Click(object sender, EventArgs e)
        {
            if (dersadiTXT.Text.Trim() != "" && dersdonemCOMBO.SelectedItem != null && derstipiCOMBO.SelectedItem != null &&
               oturum1TXT.Text.Trim() != "" && oturum2TXT.Text.Trim() != "" && sinifturuCOMBO.SelectedItem != null)
            {
                string teopra = "";
                if (teopraCOMBO.SelectedItem != null) { teopra = teopraCOMBO.SelectedItem.ToString(); }

                int id = HocaIDogren();
                komut.Connection = baglantı;
                komut.CommandText = "insert into Ders(ders_adi,ders_sinifturu,ders_tipi,oturum1,oturum2,ders_donemi,ders_hocaid) values('" + dersadiTXT.Text +" "+ teopra
                                            + "','" + sinifturuCOMBO.SelectedItem.ToString() + "','" + derstipiCOMBO.SelectedItem.ToString()
                                            + "','" + oturum1TXT.Text + "','" + oturum2TXT.Text + "','"
                                            + Convert.ToInt32(dersdonemCOMBO.SelectedItem.ToString()) + "','" + Convert.ToInt32(id) + "')";
                baglantı.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();

                MessageBox.Show("Ders Ekleme Başarıyla Gerçekleşti.", "Ekleme tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dersadiTXT.Clear();
                derstipiCOMBO.ResetText();
                oturum1TXT.Clear();
                oturum2TXT.Clear();
                sinifturuCOMBO.ResetText();
                teopraCOMBO.ResetText();
                dersdonemCOMBO.ResetText();
                dershocasiCOMBO.ResetText();
                ds.Clear();
                dersleriListele();
            }
            else
                MessageBox.Show("Lütfen içeriklerin tamamını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dersguncelleBTN_Click(object sender, EventArgs e)
        {
            if (dersadiTXT.Text.Trim() != "" && dersdonemCOMBO.SelectedItem != null && derstipiCOMBO.SelectedItem != null &&
                oturum1TXT.Text.Trim() != "" && oturum2TXT.Text.Trim() != "" && sinifturuCOMBO.SelectedItem != null)
            {
                string teopra = "";
                if (teopraCOMBO.SelectedItem != null) { teopra = teopraCOMBO.SelectedItem.ToString(); }
                int id = HocaIDogren();
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "Update Ders set ders_adi= '" + dersadiTXT.Text+" " + teopra + "',ders_sinifturu='" + sinifturuCOMBO.SelectedItem.ToString()
                                              + "',ders_tipi = '" + derstipiCOMBO.SelectedItem.ToString() + "',oturum1 = '" + oturum1TXT.Text + "',oturum2 = '" + oturum2TXT.Text
                                              + "',ders_donemi = '" + Convert.ToInt32(dersdonemCOMBO.SelectedItem.ToString()) + "',ders_hocaid = '" + Convert.ToInt32(id)
                                              + "' where ders_id =" + Convert.ToInt32(dersidTXT.Text) + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();

                MessageBox.Show("Ders Güncelleme Başarıyla Tamamlandı.", "Kayıt tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dersadiTXT.Clear();
                derstipiCOMBO.ResetText();
                oturum1TXT.Clear();
                oturum2TXT.Clear();
                teopraCOMBO.ResetText();
                sinifturuCOMBO.ResetText();
                dersdonemCOMBO.ResetText();
                dershocasiCOMBO.ResetText();
                dersidTXT.Clear();
                ds.Clear();
                dersleriListele();
            }
            else
                MessageBox.Show("Lütfen içeriklerin tamamını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void derssilBTN_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (c == DialogResult.Yes && dersidTXT.Text != "")
            {
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "Delete from Ders where ders_id=" + Convert.ToInt32(dersidTXT.Text);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglantı.Close();

                MessageBox.Show("Ders kaydı silindi.", "Silme-İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Tables["Ders"].Clear();
                dersidTXT.Clear();
                dersleriListele();
            }
        }

        // Pencere Kapatma İşlemi
        private void dersislemlerikaydetBTN_Click(object sender, EventArgs e)
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

        private void atananBTN_Click(object sender, EventArgs e)
        {
            FakülteninBelirledigiDerslerForm f = new FakülteninBelirledigiDerslerForm();
            f.ShowDialog();
        }

        private void dersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
