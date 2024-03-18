using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.entity;

namespace WinFormsApp1.dao.impl
{
    internal class BaseSecurity
    {
        SqlConnection sqlConnection = DBConnection.GetInstance().GetConnection();

        private static User AuthUser;
        public User auth(User user)
        {
            sqlConnection.Open();

            string sqlAuth = "SELECT * FROM users1 WHERE login = @login AND password = @password";
            SqlCommand authCommand = new SqlCommand(sqlAuth, sqlConnection);
            authCommand.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.getLogin();
            authCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.getPassword();

            SqlDataReader reader = authCommand.ExecuteReader();

            if (!reader.HasRows)
            {

                sqlConnection.Close();
                throw new Exception();
            }

            while (reader.Read())
            {
                user.SetId((long)reader.GetValue(0));
                user.SetName((string)reader.GetValue(1));
            }

            sqlConnection.Close();
            SetUser(user);
            return user;
        }

        private void SetUser(User user)
        {
            AuthUser = user;
        }

        public static User GetAuthUser()
        {
            return AuthUser;
        }

        public User logout(User user)
        {
            AuthUser = new User();
            return AuthUser;
        }
    }
}
