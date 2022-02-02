using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class tutor
    {
        private int id;
        private int person_id;
        private int number_tutor;
        private string address_tutor;

        public tutor()
        {

        }

        public tutor(int id, int person_id, int number_tutor, String address_tutor)
        {
            this.id = id;
            this.person_id = person_id;
            this.number_tutor = number_tutor;
            this.address_tutor = address_tutor;
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
        public int Number_tutor
        {
            get { return number_tutor; }
            set { number_tutor = value; }
        }
        public string Address_tutor
        {
            get { return address_tutor; }
            set { address_tutor = value; }
        }
    }
}
