﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class student_history
    {
        private int id;
        private int student_id;

        public student_history()
        {

        }

        public student_history(int id, int student_id)
        {
            this.id = id;
            this.student_id = student_id;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Student_id
        {
            get { return student_id; }
            set { student_id = value; }
        }
    }
}
