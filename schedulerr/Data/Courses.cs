using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedulerr.Data
{
    public class Courses
    {
        int id;
        String ad;
        String sinifTur;
        List<int> oturum;
        String tip;
        int saat;
        int sinif;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public String Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        
        public String SinifTur
        {
            get { return sinifTur; }
            set { sinifTur = value; }
        }
        public int Saat
        {
            get { return saat; }
        }
        public List<int> Oturum
        {
            get { return oturum; }
            set { oturum = value; }
        }
        public int Sinif
        {
            get { return sinif; }
            set { sinif = value; }
        }


        public Courses(int id,String ad,String tip,String sinifTur, List<int> oturum,int sinif)
        {
            this.id = id;
            this.ad = ad;
            this.sinifTur = sinifTur;
            this.oturum = oturum;
            this.tip = tip;
            foreach (var ot in oturum)
                saat += ot;
            this.sinif = sinif;
        }
    }
}
