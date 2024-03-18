using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.entity;

namespace WinFormsApp1.dao.Abstract
{
    internal interface ISecurity
    {
        User Auth(User user);
        User Logauth(User user);
    }
}
