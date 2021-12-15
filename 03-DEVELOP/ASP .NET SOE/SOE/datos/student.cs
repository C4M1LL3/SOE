using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class student
    {
        private int id;
        private int person_id;
        private DateTime birth_date;
        private string birth_place;
        private int course_id;

        public student()
        {

        }

        public student(int id, int person_id, DateTime birth_date, String birth_place, int course_id)
        {
            this.id = id;
            this.person_id = person_id;
            this.birth_date = birth_date;
            this.birth_place = birth_place;
            this.course_id = course_id;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Person_id
        {
            get { return person_id; }
            set { person_id = value; }
        }
        public DateTime Birth_date
        {
            get { return birth_date; }
            set { birth_date = value; }
        }
        public string Birth_place
        {
            get { return birth_place; }
            set { birth_place = value; }
        }

        public int Course_id
        {
            get { return course_id; }
            set { course_id = value; }
        }
    }
}
