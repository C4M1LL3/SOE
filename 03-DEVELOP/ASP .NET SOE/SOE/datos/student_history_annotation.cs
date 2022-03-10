using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class student_history_annotation
    {
        private int id;
        private int student_history_id;
        private int annotation_id;

        public student_history_annotation()
        {

        }

        public student_history_annotation(int id, int student_history_id, int annotation_id)
        {
            this.id = id;
            this.student_history_id = student_history_id;
            this.annotation_id = annotation_id;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Student_history_id
        {
            get { return student_history_id; }
            set { student_history_id = value; }
        }
        public int Annotation_id
        {
            get { return annotation_id; }
            set { annotation_id = value; }
        }

    }
}
