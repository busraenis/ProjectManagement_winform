using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cet301_ProjectManagement
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
            displacingEmplyees();
        }


        // sql connection
        public string connString = "Data Source=DESKTOP-HQGO42H\\SQLEXPRESS01;Initial Catalog=ProjectManagement;Integrated Security=True;Encrypt=False";
        SqlConnection conn = new SqlConnection();

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //bu kod bloğu data gitme kod bloğunun üstündedir çünkü
        public void displacingEmplyees()
        {
            try
            {
                //mssqlden data çekme
                conn.Open();
                string query = "select * from Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var dataset = new DataSet();
                adapter.Fill(dataset);

                dataGridView1.DataSource = dataset.Tables[0];

                conn.Close();

            }
            catch { }
        }





        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                //using the connecition
                conn.Open();
                //control id any missing value
                if (txtEmpname.Text == "" || txtEmpPhone.Text == "" || JobDesc.Text == "")
                {
                    MessageBox.Show("!! please fill all blanks !!");
                }
                else
                {
                    try
                    {
                        //mssqle data girme
                        string query = "insert into Employee (EmployeeName, EmployeePhone, JobDesc) values('" + txtEmpname + "','" + txtEmpPhone + "','" + JobDesc + "')";
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



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmpPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data girid'den veri çekme işlemi
            txtEmpname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmpPhone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            JobDesc.Text = dataGridView1.SelectedRows[3].Cells[3].Value.ToString();


        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Projects Projects = new Projects();
            Projects.Show();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasks Tasks = new Tasks();
            Tasks.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calender calender = new Calender();
            calender.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();  
            giris.Show();
        }
    }
}

        
    

