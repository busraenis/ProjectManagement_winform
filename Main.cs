using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cet301_ProjectManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects();
            projects.Show();
            this.Hide();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Members users = new Members();
            users.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calender calender = new Calender();
            calender.Show();
            this.Hide();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
