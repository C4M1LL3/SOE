using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class mother
    {
        private int id;
        private int person_id;
        private int number_mother;
        private string address_mother;

        public mother()
        {

        }

        public mother(int id, int person_id, int number_mother, String address_mother)
        {
            this.id = id;
            this.person_id = person_id;
            this.number_mother = number_mother;
            this.address_mother = address_mother;
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
        public int Number_mother
        {
            get { return number_mother; }
            set { number_mother = value; }
        }
        public string Address_mother
        {
            get { return address_mother; }
            set { address_mother = value; }
        }
    }
}
