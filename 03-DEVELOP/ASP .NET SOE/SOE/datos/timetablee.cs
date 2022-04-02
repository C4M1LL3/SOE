using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class timetablee
    {
        private int id;
        private string archive_timetable;
        private int course_id;


        public timetablee()
        {
        }

        public timetablee(int id, string archive_timetable, int course_id)
        {
            this.id = id;
            this.archive_timetable = archive_timetable;
            this.course_id = course_id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Archive_timetable
        {
            get { return archive_timetable; }
            set { archive_timetable = value; }
        }
        public int Course_id
        {
            get { return course_id; }
            set { course_id = value; }
        }
    }
}
