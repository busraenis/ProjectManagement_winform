namespace Cet301_ProjectManagement
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnkapat = new Button();
            imglogo = new PictureBox();
            lblBrand = new Label();
            imgBrand = new PictureBox();
            lblAuthority = new Label();
            lblName = new Label();
            imgProfil = new PictureBox();
            panel1 = new Panel();
            btnLogout = new Button();
            pictureBox2 = new PictureBox();
            btnCalendar = new Button();
            btnTasks = new Button();
            btnMembers = new Button();
            btnProjects = new Button();
            dataGridView1 = new DataGridView();
            EmployeeName = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            TaskStatus = new DataGridViewCheckBoxColumn();
            Desc = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnAssign = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblDueDate = new Label();
            lblTaskDesc = new Label();
            txttaskdesc = new TextBox();
            lblEmpName = new Label();
            cmbNames = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imglogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgProfil).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(123, 49, 245);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnkapat);
            panel2.Controls.Add(imglogo);
            panel2.Controls.Add(lblBrand);
            panel2.Controls.Add(imgBrand);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // btnkapat
            // 
            resources.ApplyResources(btnkapat, "btnkapat");
            btnkapat.Name = "btnkapat";
            btnkapat.UseVisualStyleBackColor = true;
            btnkapat.Click += btnkapat_Click;
            // 
            // imglogo
            // 
            resources.ApplyResources(imglogo, "imglogo");
            imglogo.Name = "imglogo";
            imglogo.TabStop = false;
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
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox2);
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
            // btnLogout
            // 
            btnLogout.AutoEllipsis = true;
            btnLogout.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLogout, "btnLogout");
            btnLogout.Name = "btnLogout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.FromArgb(123, 49, 245);
            resources.ApplyResources(btnCalendar, "btnCalendar");
            btnCalendar.ForeColor = Color.Black;
            btnCalendar.Name = "btnCalendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            btnCalendar.MouseLeave += btnCalendar_MouseLeave;
            btnCalendar.MouseHover += btnCalendar_MouseHover;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = SystemColors.ControlLightLight;
            btnTasks.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnTasks, "btnTasks");
            btnTasks.ForeColor = Color.Black;
            btnTasks.Name = "btnTasks";
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            btnTasks.MouseHover += btnTasks_MouseHover;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.FromArgb(123, 49, 245);
            resources.ApplyResources(btnMembers, "btnMembers");
            btnMembers.ForeColor = Color.Black;
            btnMembers.Name = "btnMembers";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnUsers_Click;
            btnMembers.MouseLeave += btnUsers_MouseLeave;
            btnMembers.MouseHover += btnUsers_MouseHover;
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
            btnProjects.MouseLeave += btnProjects_MouseLeave;
            btnProjects.MouseHover += btnProjects_MouseHover;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(79, 100, 240);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeName, DueDate, TaskStatus, Desc });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeName
            // 
            resources.ApplyResources(EmployeeName, "EmployeeName");
            EmployeeName.Name = "EmployeeName";
            // 
            // DueDate
            // 
            resources.ApplyResources(DueDate, "DueDate");
            DueDate.Name = "DueDate";
            // 
            // TaskStatus
            // 
            resources.ApplyResources(TaskStatus, "TaskStatus");
            TaskStatus.Name = "TaskStatus";
            TaskStatus.Resizable = DataGridViewTriState.True;
            TaskStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Desc
            // 
            resources.ApplyResources(Desc, "Desc");
            Desc.Name = "Desc";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnAssign);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(lblDueDate);
            panel3.Controls.Add(lblTaskDesc);
            panel3.Controls.Add(txttaskdesc);
            panel3.Controls.Add(lblEmpName);
            panel3.Controls.Add(cmbNames);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
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
            // dateTimePicker1
            // 
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.Name = "dateTimePicker1";
            // 
            // lblDueDate
            // 
            resources.ApplyResources(lblDueDate, "lblDueDate");
            lblDueDate.Name = "lblDueDate";
            // 
            // lblTaskDesc
            // 
            resources.ApplyResources(lblTaskDesc, "lblTaskDesc");
            lblTaskDesc.Name = "lblTaskDesc";
            // 
            // txttaskdesc
            // 
            resources.ApplyResources(txttaskdesc, "txttaskdesc");
            txttaskdesc.Name = "txttaskdesc";
            // 
            // lblEmpName
            // 
            resources.ApplyResources(lblEmpName, "lblEmpName");
            lblEmpName.Name = "lblEmpName";
            // 
            // cmbNames
            // 
            cmbNames.FormattingEnabled = true;
            resources.ApplyResources(cmbNames, "cmbNames");
            cmbNames.Name = "cmbNames";
            cmbNames.SelectedIndexChanged += cmbNames_SelectedIndexChanged;
            // 
            // Tasks
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tasks";
            Load += Tasks_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imglogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgProfil).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panel3;
        private Label lblEmpName;
        private ComboBox cmbNames;
        private TextBox txttaskdesc;
        private Label lblTaskDesc;
        private DateTimePicker dateTimePicker1;
        private Label lblDueDate;
        private Button btnAssign;
        private PictureBox imglogo;
        private PictureBox pictureBox2;
        private Button btnLogout;
        private Button btnkapat;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewCheckBoxColumn TaskStatus;
        private DataGridViewTextBoxColumn Desc;
    }
}