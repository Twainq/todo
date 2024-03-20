using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.dao.Abstract;
using WinFormsApp1.entity;

namespace WinFormsApp1.dao.impl
{
    internal class TaskDataBaseDao : ITaskDao
    {
        SqlConnection _connection = DBConnection.GetInstance().GetConnection();
        public TasksEntity DeleteTask(TasksEntity task)
        {
            throw new NotImplementedException();
        }

        public TasksEntity ReadTask(TasksEntity task)
        {
            throw new NotImplementedException();
        }

        public TasksEntity SaveTask(TasksEntity task)
        {
            throw new NotImplementedException();
        }

        public TasksEntity UpdateTask(TasksEntity task)
        {
            throw new NotImplementedException();
        }
        public List<TasksEntity> FindTask(TasksEntity task)
        {
            _connection.Open();

            string sqlTask = "SELECT * FROM tasks WHERE user_id = @user_id";
            SqlCommand taskCommand = new SqlCommand(sqlTask, _connection);
            taskCommand.Parameters.Add("@user_id",System.Data.SqlDbType.BigInt).Value = task.Id;


            SqlDataReader taskReader = taskCommand.ExecuteReader();
            if (!taskReader.HasRows)
            {
                _connection.Close();
                throw new Exception();
            }
            List<TasksEntity> tasks = new List<TasksEntity>();
            while (taskReader.Read())
            {
                tasks.Add(new TasksEntity(
                    (long)taskReader.GetValue(0),
                    (long)taskReader.GetValue(1),
                    (string)taskReader.GetValue(2),
                    (string)taskReader.GetValue(3),
                    (DateTime)taskReader.GetValue(4),
                    (DateTime)taskReader.GetValue(5)
                    ));
            }

        }

    }
}
