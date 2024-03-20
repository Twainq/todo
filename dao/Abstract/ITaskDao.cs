using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.entity;

namespace WinFormsApp1.dao.Abstract
{
    internal interface ITaskDao
    {
        TasksEntity SaveTask(TasksEntity task);
        TasksEntity ReadTask(TasksEntity task);
        TasksEntity UpdateTask(TasksEntity task);
        TasksEntity DeleteTask(TasksEntity task);
    }
}
