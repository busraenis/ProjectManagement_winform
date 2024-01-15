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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void lblsunday_Click(object sender, EventArgs e)
        {

        }

        public void days(int DayNum)
        {
            lblday.Text = DayNum + "";
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void Ntasks(int task) { numTask.Text = task + ""; }
    }
}
