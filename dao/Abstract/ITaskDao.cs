using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.dao.Abstract
{
    internal interface ITaskDao
    {
        Task SetTask(Task task);
        Task ReadTask(Task task);
        Task UpdateTask(Task task);
        Task DeleteTask(Task task);
    }
}
