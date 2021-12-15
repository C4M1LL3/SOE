using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class teacher
    {
        private int id;
        private int person_id;
        private string name_working_day;
        private int matter_id;

        public teacher()
        {

        }

        public teacher(int id, int person_id, String name_working_day, int matter_id)
        {
            this.id = id;
            this.person_id = person_id;
            this.name_working_day = name_working_day;
            this.matter_id = matter_id;
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

        public int Matter_id
        {
            get { return matter_id; }
            set { matter_id = value; }
        }
    }
}
