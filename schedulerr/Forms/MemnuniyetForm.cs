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
    public partial class MemnuniyetForm : Form
    {
        public static String memn = null;
        public MemnuniyetForm()
        {
            InitializeComponent();            
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AnasayfaForm.DosyaYolu);
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        
        private void memnuniyetkaydetBTN_Click(object sender, EventArgs e)
        {
            memn = "";
            foreach (Control c in memnuniyetPANEL.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    
                    if (((CheckBox)c).Checked == true)
                        memn += ((CheckBox)c).Name + ",";
                }
            }
            if (memn != null)
            {
                memn = memn.Substring(0, memn.Length - 1);
            }
            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
