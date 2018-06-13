using schedulerr.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace schedulerr
{

    class Lecturer
    {
        String ad;
        List<Courses> course;
        int id;       

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
        public List<Courses> Course
        {
            get { return course; }
            set { course = value; }
        }

        public Lecturer(int id,String ad,List<Courses> course)
        {
            this.id = id;
            this.ad = ad;
            this.course = course;           
        }
        
        
    }
}
