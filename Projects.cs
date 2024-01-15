using System.Data.SqlClient;
using System.Data;

namespace Cet301_ProjectManagement
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
            displacingProjectss();
        }

        // sql connection
        public string connString = "Data Source=DESKTOP-HQGO42H\\SQLEXPRESS01;Initial Catalog=ProjectManagement;Integrated Security=True;Encrypt=False";
        SqlConnection conn = new SqlConnection();



        //bu kod bloðu data gitme kod bloðunun üstündedir çünkü
        public void displacingProjectss()
        {
            try
            {
                //mssqlden data çekme
                conn.Open();
                string query = "select * from Project";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dataset = new DataSet();
                adapter.Fill(dataset);

                dataGridView1.DataSource = dataset.Tables[0];

                conn.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pnlAddition.Enabled = false;
            panel3.Enabled = false;
            string query = "select EmployeeName from Employee";
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            cmbPersonnel.Items.Add(reader.GetString(0));
            cmbPersonnel.Items.Add(reader.GetString(1));

            string q1 = "select JobDesc from Employee";
            conn.Open();
            SqlCommand cmd = new SqlCommand(q1, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            cmbPartners.Items.Add(rdr.GetString(0));
            cmbPartners.Items.Add(rdr.GetString(1));

            conn.Close();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            btnProjects.BackColor = SystemColors.ControlLightLight;
        }

        private void btnProjects_MouseHover(object sender, EventArgs e)
        {
            btnProjects.BackColor = Color.BlueViolet;
        }


        private void btnTasks_Click(object sender, EventArgs e)
        {
            btnTasks.BackColor = SystemColors.ControlLightLight;
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();

        }

        private void btnTasks_MouseHover(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.BlueViolet;

        }

        private void btnTasks_MouseLeave(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.FromArgb(123, 49, 245);

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnUsers.BackColor = SystemColors.ControlLightLight;
            Members users = new Members();
            users.Show();
            this.Hide();

        }

        private void btnUsers_MouseHover(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.BlueViolet;

        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(123, 49, 245);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            btnCalendar.BackColor = SystemColors.ControlLightLight;
            Calender calender = new Calender();
            calender.Show();
            this.Hide();
        }

        private void btnCalendar_MouseHover(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.BlueViolet;

        }

        private void btnCalendar_MouseLeave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(123, 49, 245);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.BackColor = SystemColors.ControlLightLight;

        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.BlueViolet;

        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(123, 49, 245);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            pnlAddition.Enabled = true;
            panel3.Enabled = true;
            projectID++;
        }

        int projectID = 0;
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            try
            {
                //using the connecition
                conn.Open();
                //control id any missing value
                if (txtProjectName.Text == "" || txtOwner.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("!! please fill all blanks !!");
                }
                else
                {
                    try
                    {
                        DateTime duedate = dateTimePicker1.Value;
                        DateTime date = dateTimePicker2.Value;
                        string name = txtProjectName.Text;
                        string ownmer = txtOwner.Text;
                        string query = $"insert into Project (ProjectID, projectName, OwnerName, startDate, dueDate) values('{projectID}', '{name}', '{ownmer}','{date}', '{duedate}' )";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Done");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message + " 111"); }
                }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + " 222"); }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            string job = cmbPartners.Text;
            string member = cmbPersonnel.Text;
            string q1 = $"select count(*) from Employee where EmployeeName='{member}' AND JobDesc= '{job}'";
            SqlCommand command = new SqlCommand(q1, conn);
            int match = (int)command.ExecuteScalar();
            if(match == 0)
            {
                string query = "insert into Employee (EmployeeName,JobDesc) values('" + cmbPersonnel + "', '" + cmbPartners + "')";
                SqlCommand command2 = new SqlCommand(query, conn);
                command2.ExecuteNonQuery();
            }
        }
    }
}
