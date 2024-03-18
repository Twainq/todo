using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.dao.impl;
using WinFormsApp1.entity;

namespace WinFormsApp1
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            User user = BaseSecurity.GetAuthUser();

            for (int i = 1; i < 11; i++)
            {
                flowLayoutPanel1.Controls.Add(new CurrentTask("Задача " + i.ToString()));
            }
        }

        private void Tasks_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
