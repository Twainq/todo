using WinFormsApp1.dao.Abstract;
using WinFormsApp1.entity;
using WinFormsApp1.dao.impl;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(0, "", textBox1.Text, textBox2.Text);

            try
            {
                user = new BaseSecurity().auth(user);
                Tasks f2 = new Tasks();
                Hide();
                
                if (f2.ShowDialog() == DialogResult.Cancel)
                {
                     Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте данные");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}