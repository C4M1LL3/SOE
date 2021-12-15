using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class secretary
    {
        private int id;
        private int person_id;
        private string name_working_day;


        public secretary()
        {
        }

        public secretary(int id, int person_id, string name_working_day)
        {
            this.id = id;
            this.person_id = person_id;
            this.name_working_day = name_working_day;
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
        public string Name_working_day
        {
            get { return name_working_day; }
            set { name_working_day = value; }
        }
    }
}
