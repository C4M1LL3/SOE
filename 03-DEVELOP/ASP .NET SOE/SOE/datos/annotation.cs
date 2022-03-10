using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class annotation
    {
        private int id;
        private string notation;
        private DateTime notation_date;

        public annotation()
        {

        }

        public annotation(int id, string notation, DateTime notation_date)
        {
            this.id = id;
            this.notation = notation;
            this.notation_date = notation_date;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Notation
        {
            get { return notation; }
            set { notation = value; }
        }
        public DateTime Notation_date
        {
            get { return notation_date; }
            set { notation_date = value; }
        }
    }
}
