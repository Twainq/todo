using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.dao.Abstract;
using WinFormsApp1.dao.impl;
using WinFormsApp1.entity;

namespace WinFormsApp1
{
    public partial class Tasks : Form
    {
        private User authUser = BaseSecurity.GetAuthUser();
        private ITaskDao taskDao;
        public Tasks()
        {
            InitializeComponent();
            User user = BaseSecurity.GetAuthUser();

            for (int i = 1; i < 11; i++)
            {
                flowLayoutPanel1.Controls.Add(new CurrentTask("Задача " + i.ToString()));
            }

            taskDao = new TaskDataBaseDao();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Task_FromClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveTask_Click(object sender, EventArgs e)
        {
            TasksEntity newTask = new TasksEntity(0, authUser.getId(), NewTaskName.Text,NewTaskStatus.Text,datetime_start.Value,datetime_end.Value);

            try
            {
                taskDao.SaveTask(newTask);
                flowLayoutPanel1.Controls.Add(new CurrentTask(newTask.NameT));
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
