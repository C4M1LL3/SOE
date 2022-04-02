using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class final_quarterly_grade
    {
        private int id;
        private int student_id;
        private int matter_id;
        private int number_quarter;
        private int seventy_porcentage;
        private int twenty_porcentage;
        private int ten_porcentage;
        private int final_grade;

        public final_quarterly_grade()
        {

        }

        public final_quarterly_grade(int id, int student_id, int matter_id, int number_quarter, int seventy_porcentage, int twenty_porcentage, int ten_porcentage, int final_grade)
        {
            this.id = id;
            this.student_id = student_id;
            this.matter_id = matter_id;
            this.number_quarter = number_quarter;
            this.seventy_porcentage = seventy_porcentage;
            this.twenty_porcentage = twenty_porcentage;
            this.ten_porcentage = ten_porcentage; ;
            this.final_grade = final_grade;
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
        public int Matter_id
        {
            get { return matter_id; }
            set { matter_id = value; }
        }
        public int Number_quarter
        {
            get { return number_quarter; }
            set { number_quarter = value; }
        }
        public int Seventy_porcentage
        {
            get { return seventy_porcentage; }
            set { seventy_porcentage = value; }
        }
        public int Twenty_porcentage
        {
            get { return twenty_porcentage; }
            set { twenty_porcentage = value; }
        }
        public int Ten_porcentage
        {
            get { return ten_porcentage; }
            set { ten_porcentage = value; }
        }
        public int Final_grade
        {
            get { return final_grade; }
            set { final_grade = value; }
        }
    }
}
