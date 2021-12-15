using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class course
    {
        private int id;
        private int number_course;
        private int number_year;
        private int number_cycle;
        private int teacher_id;

        public course()
        {

        }

        public course(int id, int number_course, int number_year, int number_cycle, int teacher_id)
        {
            this.id = id;
            this.number_course = number_course;
            this.number_year = number_year;
            this.number_cycle = number_cycle;
            this.teacher_id = teacher_id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Number_course
        {
            get { return number_course; }
            set { number_course = value; }
        }

        public int Number_year
        {
            get { return number_year; }
            set { number_year = value; }
        }
        public int Number_cycle
        {
            get { return number_cycle; }
            set { number_cycle = value; }
        }
        public int Teacher_id
        {
            get { return teacher_id; }
            set { teacher_id = value; }
        }
    }
}
