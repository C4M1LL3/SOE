using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class matter
    {
        private int id;
        private string name_matter;
        private string name_subject;

        public matter()
        {

        }

        public matter(int id, String name_matter, String name_subject)
        {
            this.id = id;
            this.name_matter = name_matter;
            this.name_subject = name_subject;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name_matter
        {
            get { return name_matter; }
            set { name_matter = value; }
        }

        public string Name_subject
        {
            get { return name_subject; }
            set { name_subject = value; }
        }

    }
}
