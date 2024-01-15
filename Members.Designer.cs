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
    partial class Members
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Members));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            txtjobDesc = new TextBox();
            btnAssign = new Button();
            txtEmpname = new TextBox();
            txtEmpPhone = new TextBox();
            lblJobDesc = new Label();
            lblEmpPhone = new Label();
            lblEmpName = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            btnkapat = new Button();
            lblBrand = new Label();
            imgBrand = new PictureBox();
            lblAuthority = new Label();
            lblName = new Label();
            imgProfil = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnCalendar = new Button();
            btnTasks = new Button();
            btnMembers = new Button();
            btnProjects = new Button();
            dataGridView1 = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            EmployeePhone = new DataGridViewTextBoxColumn();
            JobDesc = new DataGridViewLinkColumn();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)imgBrand).BeginInit();
            ((ISupportInitialize)imgProfil).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtjobDesc);
            panel3.Controls.Add(btnAssign);
            panel3.Controls.Add(txtEmpname);
            panel3.Controls.Add(txtEmpPhone);
            panel3.Controls.Add(lblJobDesc);
            panel3.Controls.Add(lblEmpPhone);
            panel3.Controls.Add(lblEmpName);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            panel3.Paint += panel3_Paint;
            // 
            // txtjobDesc
            // 
            resources.ApplyResources(txtjobDesc, "txtjobDesc");
            txtjobDesc.Name = "txtjobDesc";
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(79, 100, 240);
            btnAssign.ForeColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(btnAssign, "btnAssign");
            btnAssign.Name = "btnAssign";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // txtEmpname
            // 
            resources.ApplyResources(txtEmpname, "txtEmpname");
            txtEmpname.Name = "txtEmpname";
            txtEmpname.TextChanged += txtEmpPhone_TextChanged;
            // 
            // txtEmpPhone
            // 
            resources.ApplyResources(txtEmpPhone, "txtEmpPhone");
            txtEmpPhone.Name = "txtEmpPhone";
            txtEmpPhone.TextChanged += txtEmpPhone_TextChanged;
            // 
            // lblJobDesc
            // 
            resources.ApplyResources(lblJobDesc, "lblJobDesc");
            lblJobDesc.Name = "lblJobDesc";
            // 
            // lblEmpPhone
            // 
            resources.ApplyResources(lblEmpPhone, "lblEmpPhone");
            lblEmpPhone.Name = "lblEmpPhone";
            // 
            // lblEmpName
            // 
            resources.ApplyResources(lblEmpName, "lblEmpName");
            lblEmpName.Name = "lblEmpName";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(123, 49, 245);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnkapat);
            panel2.Controls.Add(lblBrand);
            panel2.Controls.Add(imgBrand);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // btnkapat
            // 
            resources.ApplyResources(btnkapat, "btnkapat");
            btnkapat.Name = "btnkapat";
            btnkapat.UseVisualStyleBackColor = true;
            btnkapat.Click += btnkapat_Click;
            // 
            // lblBrand
            // 
            resources.ApplyResources(lblBrand, "lblBrand");
            lblBrand.ForeColor = SystemColors.ButtonHighlight;
            lblBrand.Name = "lblBrand";
            // 
            // imgBrand
            // 
            resources.ApplyResources(imgBrand, "imgBrand");
            imgBrand.Name = "imgBrand";
            imgBrand.TabStop = false;
            // 
            // lblAuthority
            // 
            resources.ApplyResources(lblAuthority, "lblAuthority");
            lblAuthority.ForeColor = Color.DarkSalmon;
            lblAuthority.Name = "lblAuthority";
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Name = "lblName";
            // 
            // imgProfil
            // 
            resources.ApplyResources(imgProfil, "imgProfil");
            imgProfil.Name = "imgProfil";
            imgProfil.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 49, 245);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCalendar);
            panel1.Controls.Add(btnTasks);
            panel1.Controls.Add(btnMembers);
            panel1.Controls.Add(lblAuthority);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(btnProjects);
            panel1.Controls.Add(imgProfil);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.FromArgb(123, 49, 245);
            resources.ApplyResources(btnCalendar, "btnCalendar");
            btnCalendar.ForeColor = Color.Black;
            btnCalendar.Name = "btnCalendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.FromArgb(123, 49, 245);
            btnTasks.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnTasks, "btnTasks");
            btnTasks.ForeColor = Color.Black;
            btnTasks.Name = "btnTasks";
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(btnMembers, "btnMembers");
            btnMembers.ForeColor = Color.Black;
            btnMembers.Name = "btnMembers";
            btnMembers.UseVisualStyleBackColor = false;
            // 
            // btnProjects
            // 
            btnProjects.BackColor = Color.FromArgb(123, 49, 245);
            btnProjects.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnProjects, "btnProjects");
            btnProjects.ForeColor = Color.Black;
            btnProjects.Name = "btnProjects";
            btnProjects.UseVisualStyleBackColor = false;
            btnProjects.Click += btnProjects_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(79, 100, 240);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, EmployeePhone, JobDesc });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeName
            // 
            resources.ApplyResources(EmployeeName, "EmployeeName");
            EmployeeName.Name = "EmployeeName";
            // 
            // EmployeePhone
            // 
            resources.ApplyResources(EmployeePhone, "EmployeePhone");
            EmployeePhone.Name = "EmployeePhone";
            // 
            // JobDesc
            // 
            resources.ApplyResources(JobDesc, "JobDesc");
            JobDesc.Name = "JobDesc";
            JobDesc.Resizable = DataGridViewTriState.True;
            JobDesc.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Members
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Members";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)imgBrand).EndInit();
            ((ISupportInitialize)imgProfil).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnAssign;
        private TextBox txtEmpPhone;
        private Label lblJobDesc;
        private Label lblEmpPhone;
        private Label lblEmpName;
        private Panel panel2;
        private Label lblBrand;
        private PictureBox imgBrand;
        private Label lblAuthority;
        private Label lblName;
        private PictureBox imgProfil;
        private Panel panel1;
        private Button btnCalendar;
        private Button btnTasks;
        private Button btnMembers;
        private Button btnProjects;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnkapat;
        private PictureBox pictureBox2;
        private TextBox txtjobDesc;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn EmployeePhone;
        private DataGridViewLinkColumn JobDesc;
        private TextBox txtEmpname;
    }
}