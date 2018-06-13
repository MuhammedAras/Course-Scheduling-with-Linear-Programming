using Microsoft.Office.Interop.Excel;
using schedulerr.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedulerr
{
    class BuildExcel
    {
        List<Courses> courses, l1, l2;
        List<Lecturer> lecturers;
        List<Classes> classes;
        List<Courses> s1, s2;
        List<StudentGroupCourses> students;
        int j;
        int[,,,] Xvars;
        int i = 5;

        public BuildExcel(List<Courses> courses,  List<Lecturer> lecturers, List<Classes> classes, List<StudentGroupCourses> students,int j, int[,,,] Xvars)
        {
            this.courses = courses;
            this.lecturers = lecturers;
            this.classes = classes;
            this.students = students;
            this.j = j;
            this.Xvars = Xvars;

            if (AnasayfaForm.k == 1) {
                //AnasayfaForm.circularProgressBar1.Visible = false;
            }
                

        }
        public void Build() {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;
                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                oSheet.Cells[1, 5] = "1.SINIF";
                oSheet.Cells[j+3, 5] = "2.SINIF";
                oSheet.Cells[2*j+6, 5] = "3.SINIF";
                oSheet.Cells[3*j+9, 5] = "4.SINIF";

                oSheet.Cells[1, 5].Font.Bold = true;
                oSheet.Cells[1, 5].VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                oSheet.Cells[j + 3, 5].Font.Bold = true;
                oSheet.Cells[j + 3, 5].VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                oSheet.Cells[2 * j + 6, 5].Font.Bold = true;
                oSheet.Cells[2 * j + 6, 5].VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                oSheet.Cells[3 * j +9, 5].Font.Bold = true;
                oSheet.Cells[3 * j +9, 5].VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                //Add table headers going cell by cell.
                oSheet.Cells[2, 3] = "PAZARTESİ           ";
                oSheet.Cells[2, 4] = "SALI               ";
                oSheet.Cells[2, 5] = "ÇARŞAMBA          ";
                oSheet.Cells[2, 6] = "PERŞEMBE          ";
                oSheet.Cells[2, 7] = "CUMA            ";

                oSheet.Cells[4 + j, 3] = "PAZARTESİ";
                oSheet.Cells[4 + j, 4] = "SALI";
                oSheet.Cells[4 + j, 5] = "ÇARŞAMBA";
                oSheet.Cells[4 + j, 6] = "PERŞEMBE";
                oSheet.Cells[4 + j, 7] = "CUMA";

                oSheet.Cells[8 + (2 * j), 3] = "PAZARTESİ";
                oSheet.Cells[8 + (2 * j), 4] = "SALI";
                oSheet.Cells[8 + (2 * j), 5] = "ÇARŞAMBA";
                oSheet.Cells[8 + (2 * j), 6] = "PERŞEMBE";
                oSheet.Cells[8 + (2 * j), 7] = "CUMA";

                oSheet.Cells[12 + (3 * j), 3] = "PAZARTESİ";
                oSheet.Cells[12 + (3 * j), 4] = "SALI";
                oSheet.Cells[12 + (3 * j), 5] = "ÇARŞAMBA";
                oSheet.Cells[12 + (3 * j), 6] = "PERŞEMBE";
                oSheet.Cells[12 + (3 * j), 7] = "CUMA";

                oSheet.Cells[3, 2] = "08:15-09:00";
                oSheet.Cells[4, 2] = "09:10-09:55";
                oSheet.Cells[5, 2] = "10:05-10:50";
                oSheet.Cells[6, 2] = "11:00-11:45";
                oSheet.Cells[7, 2] = "11:55-12:40";
                oSheet.Cells[8, 2] = "12:50-13:35";
                oSheet.Cells[9, 2] = "13:45-14:30";
                oSheet.Cells[10, 2] = "14:40-15:25";
                oSheet.Cells[11, 2] = "15:35-16:20";
                oSheet.Cells[12, 2] = "16:30-17:15";

                oSheet.Cells[15, 2] = "08:15-09:00";
                oSheet.Cells[16, 2] = "09:10-09:55";
                oSheet.Cells[17, 2] = "10:05-10:50";
                oSheet.Cells[18, 2] = "11:00-11:45";
                oSheet.Cells[19, 2] = "11:55-12:40";
                oSheet.Cells[20, 2] = "12:50-13:35";
                oSheet.Cells[21, 2] = "13:45-14:30";
                oSheet.Cells[22, 2] = "14:40-15:25";
                oSheet.Cells[23, 2] = "15:35-16:20";
                oSheet.Cells[24, 2] = "16:30-17:15";

                oSheet.Cells[29, 2] = "08:15-09:00";
                oSheet.Cells[30, 2] = "09:10-09:55";
                oSheet.Cells[31, 2] = "10:05-10:50";
                oSheet.Cells[32, 2] = "11:00-11:45";
                oSheet.Cells[33, 2] = "11:55-12:40";
                oSheet.Cells[34, 2] = "12:50-13:35";
                oSheet.Cells[35, 2] = "13:45-14:30";
                oSheet.Cells[36, 2] = "14:40-15:25";
                oSheet.Cells[37, 2] = "15:35-16:20";
                oSheet.Cells[38, 2] = "16:30-17:15";

                oSheet.Cells[43, 2] = "08:15-09:00";
                oSheet.Cells[44, 2] = "09:10-09:55";
                oSheet.Cells[45, 2] = "10:05-10:50";
                oSheet.Cells[46, 2] = "11:00-11:45";
                oSheet.Cells[47, 2] = "11:55-12:40";
                oSheet.Cells[48, 2] = "12:50-13:35";
                oSheet.Cells[49, 2] = "13:45-14:30";
                oSheet.Cells[50, 2] = "14:40-15:25";
                oSheet.Cells[51, 2] = "15:35-16:20";
                oSheet.Cells[52, 2] = "16:30-17:15";



                oSheet.get_Range("C2", "G2").Font.Bold = true;
                oSheet.get_Range("C2", "G2").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("C"+ (4 + j), "G"+ (4 + j)).Font.Bold = true;
                oSheet.get_Range("C"+ (4 + j), "G"+ (4 + j)).VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("C"+ (8 + (2 * j)), "G"+(8 + (2 * j))).Font.Bold = true;
                oSheet.get_Range("C"+ (8 + (2 * j)), "G"+ (8 + (2 * j))).VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("C"+ (12 + (3 * j)), "G"+ (12 + (3 * j))).Font.Bold = true;
                oSheet.get_Range("C"+ (12 + (3 * j)), "G"+ (12 + (3 * j))).VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                oSheet.get_Range("B3", "B52").Font.Bold = true;
                oSheet.get_Range("B3", "B52").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                for (int a = 0; a < i; a++)
                    for (int b = 0; b < j; b++)
                        foreach (var course in courses)
                        {
                            var query = from sinif in classes
                                        where course.SinifTur.Equals(sinif.Tur)
                                        select sinif;
                            foreach (var sinif in query)
                            {
                                if (Xvars[a, b, course.Id, sinif.Id] == 1) { 
                                    if(course.Sinif==1){
                                        oSheet.Cells[(b + 3),( a + 3)] =course.Ad + "(" + sinif.Ad + ")";
                                    }
                                    else if (course.Sinif == 2)
                                    {
                                        oSheet.Cells[(b+5+j), (a + 3)] = course.Ad + "(" + sinif.Ad + ")";
                                    }
                                    else if (course.Sinif == 3)
                                    {
                                        oSheet.Cells[b + 9 + 2*j, a + 3] = course.Ad + "(" + sinif.Ad + ")";
                                    }
                                    else if (course.Sinif == 4)
                                    {
                                        oSheet.Cells[b + 13 + 3*j, a + 3] = course.Ad + "(" + sinif.Ad + ")";
                                    }
                                }
                            }
                        }
                Range range = oSheet.get_Range("A2", "H50");
                range.EntireColumn.AutoFit();

                /*
                Range tRange = oSheet.get_Range("B2", "G12");

                oSheet.ListObjects.Add(XlListObjectSourceType.xlSrcRange, tRange,
                    Type.Missing, XlYesNoGuess.xlYes, Type.Missing).Name = "TestTable";
                oSheet.ListObjects["TestTable"].TableStyle = "TableStyleMedium3";
                */

                oXL.Visible = false;
                oXL.UserControl = false;                
                oWB.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Ders Programi.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Thread.Sleep(1000);

                System.Diagnostics.Process.Start(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Ders Programi.xls");
                oWB.Close();

            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
            

        }

    }
}
