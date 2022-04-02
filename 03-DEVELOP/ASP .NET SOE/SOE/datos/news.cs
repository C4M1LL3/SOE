using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class news
    {
        private int id;
        private int id_user;
        private string text;
        private string image;

        public news()
        {

        }

        public news(int id, int id_user, String text, String image)
        {
            this.id = id;
            this.id_user = id_user;
            this.image = text;
            this.image = image;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
