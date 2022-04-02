using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class type_document
    {
        private int id;
        private string abbrevation;
        private string document_name;
        private string document_status;

        public type_document()
        {

        }

        public type_document(int id, String abbrevation, String document_name, String document_status)
        {
            this.id = id;
            this.abbrevation = abbrevation;
            this.document_name = document_name;
            this.document_status = document_status;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Abbrevation
        {
            get { return abbrevation; }
            set { abbrevation = value; }
        }
        public string Document_name
        {
            get { return document_name; }
            set { document_name = value; }
        }
        public string Document_status
        {
            get { return document_status; }
            set { document_status = value; }
        }

    }
}
