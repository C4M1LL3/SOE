using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class user_rol
    {
        private int id;
        private string name_rol;

        public user_rol()
        {

        }

        public user_rol(String name_rol)
        {
            this.name_rol = name_rol;

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name_rol
        {
            get { return name_rol; }
            set { name_rol = value; }
        }
    }
}
