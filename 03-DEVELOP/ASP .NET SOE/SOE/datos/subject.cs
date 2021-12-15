using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class subject
    {
        private string name_subject;

        public subject()
        {

        }

        public subject(string name_subject)
        {
            this.name_subject = name_subject;
        }

        public string Name_subject
        {
            get { return name_subject; }
            set { name_subject = value; }
        }

    }
}
