using System;
using System.Collections.Generic;
using System.Text;

namespace diseño
{
    class Persona
    {
        public Int32 id { get; set; }
        public string document_number { get; set; }
        public string type_document_id { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string first_last_name { get; set; }
        public string second_last_name { get; set; }

        public Persona() { }
        public Persona(Int32 pid, string pdocument_number, string ptype_document_id, string pfirst_name, string psecond_name, string pfirst_last_name, string psecond_last_name)
        {
            this.id = pid;
            this.document_number = pdocument_number;
            this.type_document_id = ptype_document_id;
            this.first_name = pfirst_name;
            this.second_name = psecond_name;
            this.first_last_name = pfirst_last_name;
            this.second_last_name = psecond_last_name;
        }
    }
}

