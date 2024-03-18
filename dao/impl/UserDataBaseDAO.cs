using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.entity;

namespace WinFormsApp1.dao.impl
{
    internal class UserDataBaseDAO
    {
        private SqlConnection _connection = DBConnection.GetInstance().GetConnection();
        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User FindUser(int id)
        {
            throw new NotImplementedException();
        }

        public User SaveUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
