using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.entity;

namespace WinFormsApp1.dao.Abstract
{
    internal interface IUserDao
    {
        User SaveUser(User user);
        User FindUser(int id);
        User UpdateUser(User user);
        User DeleteUser(int id);
    }
}
