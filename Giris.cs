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

namespace Cet301_ProjectManagement
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        //sql connection 
        public string connString = "Data Source=DESKTOP-HQGO42H\\SQLEXPRESS01;Initial Catalog=ProjectManagement;Integrated Security=True;Encrypt=False";

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                //control id any missing value
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("!! please fill all blanks !!");
                }
                else
                {
                    try
                    {
                        //using the connecition
                        conn.Open();
                        bool found = false;

                        string emp = textBox1.Text;
                        string pass = textBox2.Text;
                        string job = comboBox1.Text;
                        string query = $"Select* Count(*) from tblgiris where empName='{emp}' AND password ='{pass}'";
                        string query2 = $"Select count(*) from Employee where employeeName='{emp}' ANd jobDesc='{job}' ";
                        SqlCommand command = new SqlCommand(query, conn);
                        int match = (int)command.ExecuteScalar();
                        int match2= (int)command.ExecuteScalar();
                        if(match > 0 && match2>0) 
                        { found= true;
                            Main main = new Main(); 
                            main.Show();
                            this.Hide();
                        }



                        conn.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Project management");
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Owner");
            comboBox1.Items.Add("Resource manager");
        }
    }
}
