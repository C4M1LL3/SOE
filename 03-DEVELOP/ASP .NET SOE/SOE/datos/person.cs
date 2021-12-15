using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class person
    {
        private int id;
        private int document_number;
        private int type_document_id;
        private string first_name;
        private string second_name;
        private string first_last_name;
        private string second_last_name;
        private int user_id;

        public person()
        {

        }

        public person(int document_number, int type_document_id, String first_name, String second_name, String first_last_name, String second_last_name, int user_id)
        {
            this.document_number = document_number;
            this.type_document_id = type_document_id;
            this.first_name = first_name;
            this.second_name = second_name;
            this.first_last_name =first_last_name;
            this.second_last_name = second_last_name;
            this.user_id = user_id;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Document_number
        {
            get { return document_number; }
            set { document_number = value; }
        }
        public int Type_document_id
        {
            get { return type_document_id; }
            set { type_document_id = value; }
        }
        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string Second_name
        {
            get { return second_name; }
            set { second_name = value; }
        }
        public string First_last_name
        {
            get { return first_last_name; }
            set { first_last_name = value; }
        }
        public string Second_last_name
        {
            get { return second_last_name; }
            set { second_last_name = value; }
        }
        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
    }
}