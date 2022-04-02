using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class eps
    {
        private int id;
        private string name_eps;

        public eps()
        {

        }

        public eps(int id, string name_eps)
        {
            this.id = id;
            this.name_eps = name_eps;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name_eps
        {
            get { return name_eps; }
            set { name_eps = value; }
        }
    }
}
