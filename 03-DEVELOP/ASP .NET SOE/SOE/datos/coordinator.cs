using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class coordinator
    {
        private int id;
        private int person_id;
        private int number_cycle;


        public coordinator()
        {
        }

        public coordinator(int id, int person_id, int number_cycle)
        {
            this.id = id;
            this.person_id = person_id;
            this.number_cycle = number_cycle;
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
        public int Number_cycle
        {
            get { return number_cycle; }
            set { number_cycle = value; }
        }
    }
}
