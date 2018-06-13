using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedulerr
{
    class Classes
    {
        int id;
        String ad;
        String tur;

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
        public String Tur
        {
            get { return tur; }
            set { tur = value; }
        }

        public Classes(int id, String ad,String tur)
        {
            this.id = id;
            this.ad = ad;
            this.tur = tur;
        }
    }
}
