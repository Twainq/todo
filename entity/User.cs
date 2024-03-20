using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.entity
{
    internal class User
    {
        long _id;
        string _name;
        string _login;
        string _password;
        public User() { }
        public User(long id, string name, string login, string password)
        {
            _id = id;
            _name = name;
            _login = login;
            _password = password;
        }
        public long getId() { return _id; }
        public string getName() { return _name; }
        public string getLogin() { return _login; }
        public string getPassword() { return _password; }

        public void SetId(long id)
        {
            _id = id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetLogin(string login)
        {
            _login = login;
        }
        public void SetPass(string password)
        {
            _password = password;
        }
    }
}
