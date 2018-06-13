using System;
using System.Collections.Generic;
using System.Linq;
using lpsolve55;


using schedulerr.Data;
using System.Threading;
using System.IO;
using System.Data.OleDb;

namespace schedulerr
{
    
    class Constraints
    {
        int i, j;
        List<Courses> courses;
        List<Lecturer> lecturers;
        List<Classes> classes;
        List<StudentGroupCourses> students;
        int[,,] memnuniyet;

        public Constraints()
        {

        }
        public void GetContext(List<Courses> courses, List<Lecturer> lecturers, List<Classes> classes, List<StudentGroupCourses> students, int j, int [,,] memnuniyet)
        {
            this.courses = courses;
            this.lecturers = lecturers;
            this.classes = classes;
            this.students = students;
            this.j = j;
            this.memnuniyet = memnuniyet;
        }
        public void Calistir()
        {
            i = 5;
            int r = 1;

            //Parametreler
            int[] sl = new int[1000];    //l öğretim elemanının haftalık toplam ders saati
            int[] ak = new int[students.Count];     //k öğrenci grubunun toplam ders saati


            foreach (var lecturer in lecturers)
            {
                foreach (var course in lecturer.Course)
                {
                    sl[lecturer.Id] += course.Saat;
                }
            }
            foreach (var student in students)
            {
                foreach (var course in student.Courses)
                {
                    ak[student.Id] += course.Saat;
                }
            }

            // Değişkenler
            // m dersi i gününün j zaman aralığında n sınıfında yapılıyorsa...
            int[,,,] Xvars2 = new int[i, j, 1000, 1000];

            String variables = "bin ";

           
                    foreach (var course in courses)
                    {
                        for (int a = 0; a < i; a++) { 
                            for (int b = 0; b < j; b++) { 
                                var query = from sinif in classes
                                            where course.SinifTur.ToLower().Equals(sinif.Tur.ToLower())
                                            select sinif.Id;
                                 foreach (var sinif in query)
                                {
                                    variables += "X" + a + "." + +b + "." + course.Id + "." + sinif + ",";
                                }
                            }
                        }
                    }
            variables = variables.Substring(0, variables.Length - 1);
            variables += ";";

                                                            //KISITLAR

            // Bir öğretim elemanının belirli gün ve zaman aralığında, iki farklı fiziki mekana atanmasını engelleyen kısıttır.
            // 1
            List<String> constraints1 = new List<string>();
            foreach (var lecturer in lecturers)
            {
                if (lecturer.Course.Count != 0) {
                    for (int a = 0; a < i; a++)
                    {
                        for (int b = 0; b < j; b++)
                        {   
                            String expression = null;
                            foreach (var course in lecturer.Course)
                            {
                                var query = from sinif in classes
                                            where sinif.Tur.ToLower() == course.SinifTur.ToLower()
                                            select sinif.Id;
                                foreach (var id in query)
                                {
                                    expression += "X" + a + "." + b + "." + course.Id + "." + id + "+";
                                }
                            }
                            expression = expression.Substring(0, expression.Length - 1);
                            expression += "<=1;";
                            constraints1.Add(expression);
                        }  
                    }
                }
            }

            // Bir fiziki mekana, belirli gün ve zaman aralığında birden fazla ders / öğretim elemanı / öğrenci grubu atanmasını engelleyen kısıttır.
            // 2
            List<String> constraints2 = new List<string>();
            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    foreach (var sinif in classes)
                    {
                        String expression = null;
                        var query = from course in courses
                                    where sinif.Tur.ToLower() == course.SinifTur.ToLower()
                                    select course;
                        foreach (var course in query)
                        {
                            expression += "X" + a + "." + b + "." + course.Id + "." + sinif.Id + "+";
                        }
                        expression = expression.Substring(0, expression.Length - 1);
                        expression += "<=1;";
                        constraints2.Add(expression);
                    }
                }
            }

            // Belirli gün ve zaman aralığında, bir öğrenci grubuna birden fazla ders atanmasını engelleyen kısıttır..  
            // 3

            List<String> constraints3 = new List<string>();
            foreach (var student in students)
            {
                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j; b++)
                    {
                        String expression = null;
                        foreach (var studentcourse in student.Courses)
                        {
                            var query2 = from sinif in classes
                                         where sinif.Tur.ToLower() == studentcourse.SinifTur.ToLower()
                                         select sinif.Id;
                            foreach (var id2 in query2)
                            {
                                expression += "X" + a + "." + b + "." + studentcourse.Id + "." + id2 + "+";
                            }
                        }
                        expression = expression.Substring(0, expression.Length - 1);
                        expression += "<=1;";
                        constraints3.Add(expression);
                    }
                }
            }

            //Her dersin tamamlanma kısıtı
            //4
            List<String> constraints4 = new List<string>();
            foreach (var course1 in courses)
            {
                String expression = null;
                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j; b++)
                    {
                        var query3 = from sinif in classes
                                     where sinif.Tur.ToLower() == course1.SinifTur.ToLower()
                                     select sinif.Id;
                        foreach (var id2 in query3)
                        {
                            expression += "X" + a + "." + b + "." + course1.Id + "." + id2 + "+";
                        }
                    }
                }
                expression = expression.Substring(0, expression.Length - 1);
                expression += "=" + course1.Saat + ";";
                constraints4.Add(expression);
            }

            // Öğretim elemanının toplam ders yükü ders programında yer almalıdır
            // 5
            List<String> constraints5 = new List<string>();
            foreach (var lecturer1 in lecturers)
            {
                if (lecturer1.Course.Count != 0)
                {
                    String expression = null;
                    foreach (var lecturercourse1 in lecturer1.Course)
                    {
                        for (int a = 0; a < i; a++)
                        {
                            for (int b = 0; b < j; b++)
                            {
                                var query2 = from sinif in classes
                                             where sinif.Tur.ToLower() == lecturercourse1.SinifTur.ToLower()
                                             select sinif.Id;
                                foreach (var id2 in query2)
                                {
                                    expression += "X" + a + "." + b + "." + lecturercourse1.Id + "." + id2 + "+";
                                }
                            }
                        }
                    }
                    expression = expression.Substring(0, expression.Length - 1);
                    expression += "=" + sl[lecturer1.Id] + ";";
                    constraints5.Add(expression);
                }
            }


            // Her bir öğrenci grubu için ders yükü tamamlanma kısıtı
            // 6
            List<String> constraints6 = new List<string>();
            foreach (var student in students)
            {
                String expression = null;
                foreach (var studentcourse in student.Courses)
                {
                    for (int a = 0; a < i; a++)
                    {
                        for (int b = 0; b < j; b++)
                        {
                            var query2 = from sinif in classes
                                         where sinif.Tur.ToLower() == studentcourse.SinifTur.ToLower()
                                         select sinif.Id;
                            foreach (var id2 in query2)
                            {
                                expression += "X" + a + "." + b + "." + studentcourse.Id + "." + id2 + "+";
                            }
                        }
                    }
                }
                expression = expression.Substring(0, expression.Length - 1);
                expression += "=" + ak[student.Id] + ";";
                constraints6.Add(expression);
            }


            // Günlük ders yükü kısıtı
            // 7
            List<String> constraints7 = new List<string>();
            foreach (var student in students)
            {
                if (student.Id != 3)
                {
                    for (int a = 0; a < i; a++)
                    {
                        String expression = null;
                        for (int b = 0; b < j; b++)
                        {
                            foreach (var studentcourse in student.Courses)
                            {
                                var query2 = from sinif in classes
                                             where sinif.Tur.ToLower() == studentcourse.SinifTur.ToLower()
                                             select sinif.Id;
                                foreach (var id2 in query2)
                                {
                                    expression += "X" + a + "." + b + "." + studentcourse.Id + "." + id2 + "+";
                                }
                            }
                        }
                        expression = expression.Substring(0, expression.Length - 1);
                        expression += "<= 8;";
                        constraints5.Add(expression);
                    }
                }
            }


            // Derslerin ardışıklığı-1 Kısıt

            List<String> constraints8 = new List<string>();

            foreach (var course in courses)
            {
                for (int a = 0; a < i; a++)
                {
                    var query2 = from sinif in classes
                                 where sinif.Tur.ToLower() == course.SinifTur.ToLower()
                                 select sinif.Id;

                    foreach (var id2 in query2)
                    {
                        int c = 0;
                        String expression = null;
                        expression += "X" + a + "." + c + "." + course.Id + "." + id2 + "-" + "X" + a + "." + 1 + "." + course.Id + "." + id2 + "<=0;";
                        constraints8.Add(expression);
                    }
                }
            }
            
            // İki dersin ardişik olma kısıtı

            List<String> constraints9 = new List<string>();
            foreach (var student in students)
            {
                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j-2; b++)
                    {
                        foreach (var studentcourse in student.Courses)
                        {
                            String expression = null;
                            var query2 = from sinif in classes
                                         where sinif.Tur.ToLower() == studentcourse.SinifTur.ToLower()
                                         select sinif.Id;
                            foreach (var id2 in query2)
                            {
                                int b1 = b + 1;
                                int b2 = b + 2;
                                expression += "-" + "X" + a + "." + b + "." + studentcourse.Id + "." + id2 + "+"
                                                + "X" + a + "." + b1 + "." + studentcourse.Id + "." + id2 + "-"
                                                + "X" + a + "." + b2 + "." + studentcourse.Id + "." + id2 + "+";                               
                            }
                            expression = expression.Substring(0, expression.Length - 1);
                            expression += "<=0;";
                            constraints9.Add(expression);
                        }
                    }                    
                }
            }
            
            
            // Üç dersin ardişik olma kısıtı

            List<String> constraints10 = new List<string>();
            foreach (var student in students)
            {
                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j - 3; b++)
                    {
                        foreach (var studentcourse in student.Courses)
                        {
                            if (studentcourse.Oturum[1] == 3)
                            {
                                String expression = null;
                                var query2 = from sinif in classes
                                             where sinif.Tur.ToLower() == studentcourse.SinifTur.ToLower()
                                             select sinif.Id;
                                foreach (var id2 in query2)
                                {
                                    int b1 = b + 1;
                                    int b3 = b + 3;
                                    expression += "-" + "X" + a + "." + b + "." + studentcourse.Id + "." + id2 + "+"
                                                    + "X" + a + "." + b1 + "." + studentcourse.Id + "." + id2 + "-"
                                                    + "X" + a + "." + b3 + "." + studentcourse.Id + "." + id2 + "+";
                                }
                                expression = expression.Substring(0, expression.Length - 1);
                                expression += "<=0;";
                                constraints10.Add(expression);
                            }
                        }
                    }
                }
            }


            // Derslerin ardışıklığı-3 Kısıt

            List<String> constraints11 = new List<string>();           
            foreach (var course in courses)
            {
                for (int a = 0; a < i; a++)
                {
                    
                        var query2 = from sinif in classes
                                     where sinif.Tur.ToLower() == course.SinifTur.ToLower()
                                     select sinif.Id;

                        foreach (var id2 in query2)
                        {
                            String expression = null;

                            expression += "X" + a + "." + "9" + "." + course.Id + "." + id2 + "-" + "X" + a + "." + 8 + "." + course.Id + "." + id2 + "<=0;";
                            constraints11.Add(expression);
                        }
                    

                }
            }

            
            // Bir dersin gün içerisinde 2 saatten fazla işlenmemesi durumu

            List<String> constraints12 = new List<string>();
            foreach (var student in students)
            {
                for (int a = 0; a < i; a++)
                {
                    foreach (var studentcourse in student.Courses)
                    {
                        if (studentcourse.Saat == 4)
                        {
                            String expression = null;
                            for (int b = 0; b < j; b++)
                            {


                                var query2 = from sinif in classes
                                             where sinif.Tur.ToLower() == studentcourse.SinifTur.ToLower()
                                             select sinif.Id;
                                foreach (var id2 in query2)
                                {
                                    expression += "X" + a + "." + b + "." + studentcourse.Id + "." + id2 + "+";
                                }
                            }
                            expression = expression.Substring(0, expression.Length - 1);
                            expression += "<=2;";
                            constraints12.Add(expression);
                        }

                    }
                }
            }
        
            // Dersin aynı sınıfta işlenmesi kısıtı 

            List<String> constraints13 = new List<string>();
            foreach (var course in courses)
            {
                for (int b = 0; b < j; b++)
                {
                    var query2 = from sinif in classes
                                 where sinif.Tur.ToLower() == course.SinifTur.ToLower()
                                 select sinif.Id;
                    foreach (var id2 in query2)
                    {
                        String expression2 = null, expression1;
                        for (int a = 0; a < i; a++)
                        {
                            expression1 = "R" + r + ":";
                            expression2 = null;
                            expression1 += course.Saat + " " + "X" + a + "." + b + "." + course.Id + "." + id2 + "+";
                            for (int aa = 0; aa < i; aa++)
                            {
                                for (int bb = 0; bb < j; bb++)
                                {
                                    expression2 += "X" + aa + "." + bb + "." + course.Id + "." + id2 + "+";
                                }
                            }
                            expression1 = expression1.Substring(0, expression1.Length - 1);
                            expression2 = expression2.Substring(0, expression2.Length - 1);
                            expression1 += "<=";
                            expression1 += expression2 + ";";
                            constraints13.Add(expression1);
                            r++;
                        }                            
                    }
                }
            }
           
            //Teori-Pratik önceliği

            List<String> constraints14 = new List<string>();
            foreach (var course in courses)
            {
                String expression2 = null;
                String expression1 = "R" + r + ":";
                for (int a = 0; a < i; a++)
                {                    
                    if (course.Ad.ToLower().IndexOf("teo") > 0)
                    {
                        for (int b = 0; b < j; b++)
                        {
                            var query2 = from sinif in classes
                                         where sinif.Tur.ToLower() == course.SinifTur.ToLower()
                                         select sinif.Id;
                            foreach (var id2 in query2)
                            {                            
                                    int aa = 100*(a+1)+ (b+1);
                                    expression1 += aa + " " + "X" + a + "." + b + "." + course.Id + "." + id2 + "+";                                   
                            }
                        }
                        foreach (var course2 in courses)
                        {
                            if (course2.Ad.ToLower().IndexOf("pra") > 0 && course.Ad.ToLower().Substring(0, course.Ad.Length - 3).Equals(course2.Ad.ToLower().Substring(0, course2.Ad.Length - 3)))
                            {
                                for (int b = 0; b < j; b++)
                                {
                                    var query2 = from sinif in classes
                                                  where sinif.Tur.ToLower() == course2.SinifTur.ToLower()
                                                 select sinif.Id;
                                    foreach (var id3 in query2)
                                    {
                                        int aa = 100 * (a + 1) + (b + 1);
                                        expression2 += aa + " " + "X" + a + "." + b + "." + course2.Id + "." + id3 + "+";
                                    }
                                }
                            }
                        }                        
                    }
                }
                if (!expression1.EndsWith(":") && expression2 != null)
                {
                    expression1 = expression1.Substring(0, expression1.Length - 1);
                    expression2 = expression2.Substring(0, expression2.Length - 1);
                    expression1 += "<";
                    expression1 += expression2 + ";";
                    constraints14.Add(expression1);
                    r++;
                }
            }

            //Fakülte Tarafından Atanan Dersler

            List<String> constraints15 = new List<string>();

            OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ AnasayfaForm.DosyaYolu);
            OleDbCommand komut = new OleDbCommand();
            baglantı.Open();
            OleDbDataReader reader = null;
            komut = new OleDbCommand("select Ders.ders_adi,AtananDers.ders_id,AtananDers.atanan_saat,Ders.ders_sinifturu from AtananDers,Ders  where Ders.ders_id=AtananDers.ders_id", baglantı);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                int gun=0, saat=0;
                
                if (reader["atanan_saat"].ToString() != "")
                {
                    string[] words = reader["atanan_saat"].ToString().Split(',');
                    foreach (var parcala in words)
                    {
                        String expr = null;
                        gun = Convert.ToInt32(parcala.Substring(1, 1));
                        saat = Convert.ToInt32(parcala.Substring(2, parcala.Length - 2));
                        gun = gun - 1;
                        saat = saat - 1;
                        var query2 = from sinif in classes
                                     where sinif.Tur.ToLower() == reader["ders_sinifturu"].ToString().ToLower()
                                     select sinif.Id;
                        foreach (var id2 in query2)
                        {
                            expr += "X" + gun + "." + saat + "." + reader["ders_id"] + "." + id2 + "+";
                        }
                        expr = expr.Substring(0, expr.Length - 1);
                        expr += ">1;";
                        constraints15.Add(expr);
                    }
                    
                }
            }

            

            // Amaç fonksiyonu

            String goalfunc = "min: ";
            foreach (var lecturer in lecturers)
            {
                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j; b++)
                    {
                        foreach (var course in lecturer.Course)
                        {
                            var query = from sinif in classes
                                        where sinif.Tur.ToLower() == course.SinifTur.ToLower()
                                        select sinif.Id;
                            foreach (var id in query)
                            {
                                if(memnuniyet[lecturer.Id, a, b] == 15)
                                    goalfunc += memnuniyet[lecturer.Id,a,b] + " " + "X" + a + "." + b + "." + course.Id + "." + id + "+";
                                else if (memnuniyet[lecturer.Id, a, b] != 15)
                                    goalfunc += "X" + a + "." + b + "." + course.Id + "." + id + "+";
                            }
                        }
                    }
                }
            }
            goalfunc = goalfunc.Substring(0, goalfunc.Length - 1);
            goalfunc += ";";


           
           
            System.IO.File.WriteAllText(@"model.lp", goalfunc+"\n\n");

            System.IO.File.AppendAllLines(@"model.lp", constraints1);
            System.IO.File.AppendAllLines(@"model.lp", constraints2);
            System.IO.File.AppendAllLines(@"model.lp", constraints3);
            System.IO.File.AppendAllLines(@"model.lp", constraints4);
            System.IO.File.AppendAllLines(@"model.lp", constraints5);
            System.IO.File.AppendAllLines(@"model.lp", constraints6);
            System.IO.File.AppendAllLines(@"model.lp", constraints7);
            System.IO.File.AppendAllLines(@"model.lp", constraints8);
            System.IO.File.AppendAllLines(@"model.lp", constraints9);
            //System.IO.File.AppendAllLines(@"model.lp", constraints10);
            System.IO.File.AppendAllLines(@"model.lp", constraints11);
            System.IO.File.AppendAllLines(@"model.lp", constraints12);
            System.IO.File.AppendAllLines(@"model.lp", constraints13);
            System.IO.File.AppendAllLines(@"model.lp", constraints14);
            System.IO.File.AppendAllLines(@"model.lp", constraints15);
            System.IO.File.AppendAllText(@"model.lp", variables);

            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Ders Programi.xls");
            int lp;
            lp = lpsolve.read_LP("model.lp", 0, "test");

            if (lp == 0)

            {

                Console.WriteLine("Dosya bulunamadı\n\n");

                return;

            }
            lpsolve.set_outputfile(lp, "result.txt");

            lpsolve.solve(lp);

            lpsolve.print_solution(lp, 1);
            lpsolve.delete_lp(lp);

            string dosya_yolu = @"result.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi ;
            yazi = sw.ReadLine();
            yazi = sw.ReadLine();
            while ((yazi = sw.ReadLine()) != null)
            {
                string[] words = yazi.Split('.');
                int ii, jj, mm, nn,deger;
                ii = Convert.ToInt32(words[0].Substring(1, 1));
                jj = Convert.ToInt32(words[1]);
                mm= Convert.ToInt32(words[2]);
                nn= Convert.ToInt32(words[3].Substring(0,2));
                words[3] = words[3].Remove(0,2);
                deger= Convert.ToInt32(words[3]);
                Xvars2[ii, jj, mm, nn] = deger;
            }

            sw.Close();
            fs.Close();
          


            BuildExcel excel = new BuildExcel(courses,lecturers,classes,students,j,Xvars2);
            Thread thread1 = new Thread(new ThreadStart(excel.Build));            
            thread1.Start();

            Console.ReadLine();
        }

    }

}

