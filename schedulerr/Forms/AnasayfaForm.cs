using schedulerr.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;

namespace schedulerr
{
    

    public partial class AnasayfaForm : Form
    {
        public static int k ;
        public static string DosyaYolu;

        public AnasayfaForm()
        {
            
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;

        }

        private void kayitlidersprogramiacBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Access Veritabanı Dosyası |*.accdb"; //"Access Veritabanı Dosyası |*.accbd| Tüm Dosyalar |*.*";
            dosya.InitialDirectory = Environment.CurrentDirectory + "\\Veritabanları";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            if (dosya.FileName != "")
            {
                dersprogramiPANEL.Visible = true;
            }
        }

        private void anasayfayageriBTN_Click(object sender, EventArgs e)
        {
            dersprogramiPANEL.Visible = false;
            DosyaYolu = "";
        }

        private void sinifBTN_Click(object sender, EventArgs e)
        {
            SiniflarForm sf = new SiniflarForm();
            sf.ShowDialog(); 
        }

        private void hocaBTN_Click(object sender, EventArgs e)
        {
            HocaForm hf = new HocaForm();
            hf.ShowDialog();
        }

        private void dersBTN_Click(object sender, EventArgs e)
        {
            DersForm df = new DersForm();
            df.ShowDialog();
        }

        private void hazırlaBTN_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            Thread thread = new Thread(LongTask);
            thread.IsBackground = true;
            thread.Start();

            
            circularProgressBar1.Visible = true;
            k = 1;

            OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ DosyaYolu);
            OleDbCommand komut = new OleDbCommand();
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            baglantı.Open();
            
            List<Courses> courses = new List<Courses>();
            OleDbDataReader reader = null;
            komut = new OleDbCommand("select * from Ders", baglantı);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                List<int> oturum = new List<int>();
                oturum.Add(Convert.ToInt32(reader["oturum1"]));
                oturum.Add(Convert.ToInt32(reader["oturum2"]));
                courses.Add(new Courses(Convert.ToInt32(reader["ders_id"]), reader["ders_adi"].ToString(), reader["ders_tipi"].ToString(), reader["ders_sinifturu"].ToString(), oturum, Convert.ToInt32(reader["ders_donemi"])));
            }

            List<Lecturer> lecturers = new List<Lecturer>();
            komut = new OleDbCommand("select * from Hoca", baglantı);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                List<Courses> hocaders = new List<Courses>();
                OleDbCommand komut2 = new OleDbCommand("SELECT d.ders_id,h.adsoyad from Hoca as h,Ders as d Where h.hoca_id=d.ders_hocaid and h.hoca_id=" + reader["hoca_id"], baglantı);
                OleDbDataReader reader2 = komut2.ExecuteReader();
                while (reader2.Read())
                {
                    foreach (var derss in courses)
                    {
                        if (Convert.ToInt32(reader2["ders_id"]) == derss.Id)
                            hocaders.Add(derss);
                    }
                }

                lecturers.Add(new Lecturer(Convert.ToInt32(reader["hoca_id"]), reader["adsoyad"].ToString(), hocaders));
            }



            int[,,] HocaMemnuniyetleri = new int[1000, 5, 10];
            komut = new OleDbCommand("SELECT hoca_id,dolu_saat FROM Hoca", baglantı);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (reader["dolu_saat"].ToString() != "")
                {
                    string[] words = reader["dolu_saat"].ToString().Split(',');
                    foreach (var parcala in words)
                    {
                        int gun = Convert.ToInt32(parcala.Substring(1, 1));
                        int saat = Convert.ToInt32(parcala.Substring(2, parcala.Length - 2));
                        HocaMemnuniyetleri[Convert.ToInt32(reader["hoca_id"]), gun - 1, saat - 1] = 15;
                    }
                }
            }


            List<Classes> classes = new List<Classes>();
            komut = new OleDbCommand("select * from Sinif", baglantı);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                classes.Add(new Classes(Convert.ToInt32(reader["sinif_id"]), reader["sinif_adi"].ToString(), reader["sinif_türü"].ToString()));
            }

            List<StudentGroupCourses> students = new List<StudentGroupCourses>();
            List<Courses> s1 = new List<Courses>();
            List<Courses> s2 = new List<Courses>();
            List<Courses> s3 = new List<Courses>();
            List<Courses> s4 = new List<Courses>();
            komut = new OleDbCommand("select * from Ders", baglantı);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader["ders_donemi"]) == 1)
                {
                    foreach (var derss in courses)
                    {
                        if (Convert.ToInt32(reader["ders_id"]) == derss.Id)
                            s1.Add(derss);
                    }
                }
                if (Convert.ToInt32(reader["ders_donemi"]) == 2)
                {
                    foreach (var derss in courses)
                    {
                        if (Convert.ToInt32(reader["ders_id"]) == derss.Id)
                            s2.Add(derss);
                    }
                }
                if (Convert.ToInt32(reader["ders_donemi"]) == 3)
                {
                    foreach (var derss in courses)
                    {
                        if (Convert.ToInt32(reader["ders_id"]) == derss.Id)
                            s3.Add(derss);
                    }
                }
                if (Convert.ToInt32(reader["ders_donemi"]) == 4)
                {
                    foreach (var derss in courses)
                    {
                        if (Convert.ToInt32(reader["ders_id"]) == derss.Id)
                            s4.Add(derss);
                    }
                }
            }
            students.Add(new StudentGroupCourses(0, s1)); // 1.Sınıf
            students.Add(new StudentGroupCourses(1, s2)); // 2.Sınıf
            students.Add(new StudentGroupCourses(2, s3)); // 3.Sınıf
            students.Add(new StudentGroupCourses(3, s4)); // 4.Sınıf

            Constraints cons = new Constraints();
            cons.GetContext(courses, lecturers, classes, students, 10, HocaMemnuniyetleri);
            cons.Calistir();
            
        }


        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Your background task goes here
            for (int i = 0; i <= 100; i++)
            {
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(i);
                // Simulate long task
                System.Threading.Thread.Sleep(100);
            }
        }
        // Back on the 'UI' thread so we can update the progress bar
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            circularProgressBar1.Value = e.ProgressPercentage;
        }
        private void LongTask()
        {
            for (int i = 0; i < 100; i++)
            {
                Update1(i);
                Thread.Sleep(500);
            }
        }

        public void Update1(int i)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<int>(Update1), new object[] { i });
                return;
            }

            circularProgressBar1.Value = i;
        }

        private void yenidersprogramiac_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Access Veritabanı Dosyası |*.accdb";
            save.InitialDirectory = Environment.CurrentDirectory+"\\Veritabanları";
            save.Title = "Ders Programı Veritabanı";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            save.ShowDialog();
            DosyaYolu = save.FileName;
            if (DosyaYolu != "") { 
                System.IO.File.Copy("bos.accdb", DosyaYolu, true);
            }
            if (save.FileName != "") { 
                dersprogramiPANEL.Visible = true;
            }


        }
    }    
}
