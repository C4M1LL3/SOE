using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class father
    {
        private int id;
        private int person_id;
        private int number_father;
        private string address_father;

        public father()
        {

        }

        public father(int id, int person_id, int number_father, String address_father)
        {
            this.id = id;
            this.person_id = person_id;
            this.number_father = number_father;
            this.address_father = address_father;
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
        public int Number_father
        {
            get { return number_father; }
            set { number_father = value; }
        }
        public string Address_father
        {
            get { return address_father; }
            set { address_father = value; }
        }

    }

}
