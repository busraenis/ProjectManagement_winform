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

namespace Cet301_ProjectManagement
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        // sql connection
        public string connString = "Data Source=DESKTOP-HQGO42H\\SQLEXPRESS01;Initial Catalog=ProjectManagement;Integrated Security=True;Encrypt=False";
        SqlConnection conn = new SqlConnection();



        //bu kod bloğu data gitme kod bloğunun üstündedir çünkü
        public void displacingEmplyees()
        {
            try
            {
                //mssqlden data çekme
                conn.Open();
                string query = "select * from tblTasks";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dataset = new DataSet();
                adapter.Fill(dataset);

                dataGridView1.DataSource = dataset.Tables[0];

                conn.Close();

            }
            catch { }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            btnProjects.BackColor = SystemColors.ControlLightLight;
            Projects projects = new Projects();
            projects.Show();
        }

        private void btnProjects_MouseHover(object sender, EventArgs e)
        {
            btnProjects.BackColor = Color.BlueViolet;
        }

        private void btnProjects_MouseLeave(object sender, EventArgs e)
        {
            btnProjects.BackColor = Color.FromArgb(123, 49, 245);

        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            btnTasks.BackColor = SystemColors.ControlLightLight;
        }

        private void btnTasks_MouseHover(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.BlueViolet;

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnMembers.BackColor = SystemColors.ControlLightLight;
            this.Hide();
            Members members = new Members();
            members.Show();

        }

        private void btnUsers_MouseHover(object sender, EventArgs e)
        {
            btnMembers.BackColor = Color.BlueViolet;

        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnMembers.BackColor = Color.FromArgb(123, 49, 245);

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            btnCalendar.BackColor = SystemColors.ControlLightLight;
            Calender calender = new Calender();
            calender.Show();
        }

        private void btnCalendar_MouseHover(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.BlueViolet;
        }

        private void btnCalendar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                //using the connecition
                conn.Open();
                //control id any missing value
                if (cmbNames.Text == "" || txttaskdesc.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("!! please fill all blanks !!");
                }
                else
                {
                    try
                    {
                        string name= cmbNames.Text;
                        string job;
                        //mssqle den job datassını çekme ve tasklar tablosundaki job a girme
                        string q1 = "select JobDesc from Employee where EmployeeName= '{name}'";     
                        SqlCommand cmd = new SqlCommand(q1, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                       if (reader.Read()) 
                        {
                            string q2 = $"insert into tblTasks (employeeName, jobDesc) values('{name}', '{reader}')";
                            string query = "insert into tblTasks (DueDate, taskDesc) values('" + dateTimePicker1 + "')";
                            SqlCommand command = new SqlCommand(query, conn);
                            SqlCommand cmd2 = new SqlCommand(q2, conn);
                            cmd2.ExecuteNonQuery();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Done");
                        }
                        else { MessageBox.Show("işlem başarısız"); }


                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message + " 111"); }
                }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " 222"); }
        }

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            string query = "select EmployeeName from Employee";
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            cmbNames.Items.Add(reader.GetString(0));
            cmbNames.Items.Add(reader.GetString(1));

            conn.Close();
        }
    }
}

