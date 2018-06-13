using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedulerr.Data
{
    class StudentGroupCourses
    {
        int id;
        List<Courses> courses;

        public int Id {
            get { return id; }
            set { id = value; }
        }
        public List<Courses> Courses{
            get { return courses; }
            set { courses = value; }
        }

        public StudentGroupCourses(int id, List<Courses> courses){
            this.id = id;
            this.courses = courses;   
        }
    }
}
