using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class user
    {
        private int id;
        private string login;
        private string password;
        private string institutional_email;
        private string image;

        public user()
        {

        }

        public user(int id, String login, String password, String institutional_email, string image)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.institutional_email = institutional_email;
            this.image = image;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Institutional_email
        {
            get { return institutional_email; }
            set { institutional_email = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
