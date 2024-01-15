using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace Cet301_ProjectManagement
{
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
        }

        public string connString = "Data Source=DESKTOP-HQGO42H\\SQLEXPRESS01;Initial Catalog=ProjectManagement;Integrated Security=True;Encrypt=False";

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calender_Load(object sender, EventArgs e)
        {
            Displays();

        }

        int month, year;
        private void Displays()
        {

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            DateTime beginOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(beginOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayOfWeek; i++)
            {
                blankpanel blankpanel = new blankpanel();
                pnlDays.Controls.Add(blankpanel);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                pnlDays.Controls.Add((UserControlDays)userControlDays);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlDays.Controls.Clear();
            month++;
            DateTime beginOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(beginOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayOfWeek; i++)
            {
                blankpanel blankpanel = new blankpanel();
                pnlDays.Controls.Add(blankpanel);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                pnlDays.Controls.Add((UserControlDays)userControlDays);
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            pnlDays.Controls.Clear();
            month--;
            DateTime beginOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(beginOfMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayOfWeek; i++)
            {
                blankpanel blankpanel = new blankpanel();
                pnlDays.Controls.Add(blankpanel);
            }

            for (int i = 1; i < days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                pnlDays.Controls.Add((UserControlDays)userControlDays);

                SqlConnection conn = new SqlConnection(connString);
                string query = "select count(*) from Project where dueDate='"+ userControlDays+"'";
                SqlCommand command = new SqlCommand(query, conn);
                int match= (int)command.ExecuteScalar();
                if (match > 0)
                {
                    UserControlDays.Ntasks(match); 
                }
            }


        }

        private void lblChooseProject_Click(object sender, EventArgs e)
        {

        }
    }
}
