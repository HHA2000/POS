using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class User
    {
        private int _id;
        private string _name;
        private string _type;
        private string _password;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Username
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = encryptPassword(value); }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string encryptPassword(string password)
        {
            byte[] data = Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return Encoding.ASCII.GetString(data);
        }
    }
}
