using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class enrollmentt
    {
        private int id;
        private int student_id;
        private int eps_id;
        private string address;
        private int home_number;
        private int state;
        private int father_id;
        private int mother_id;
        private int tutor_id;

        public enrollmentt()
        {

        }

        public enrollmentt(int id, int student_id, int eps_id, String address, int home_number, int state, int father_id, int mother_id, int tutor_id)
        {
            this.id = id;
            this.student_id = student_id;
            this.eps_id = eps_id;
            this.address = address;
            this.home_number = home_number;
            this.state = state;
            this.father_id = father_id;
            this.mother_id = mother_id;
            this.tutor_id = tutor_id;
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
        public int Eps_id
        {
            get { return eps_id; }
            set { eps_id = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Home_number
        {
            get { return home_number; }
            set { home_number = value; }
        }
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        public int Father_id
        {
            get { return father_id; }
            set { father_id = value; }
        }
        public int Mother_id
        {
            get { return mother_id; }
            set { mother_id = value; }
        }
        public int Tutor_id
        {
            get { return tutor_id; }
            set { tutor_id = value; }
        }
    }
}
