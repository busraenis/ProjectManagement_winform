namespace Cet301_ProjectManagement
{
    partial class Projects
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            btnSettings = new Button();
            btnCalendar = new Button();
            btnTasks = new Button();
            btnUsers = new Button();
            lblAuthority = new Label();
            lblName = new Label();
            btnProjects = new Button();
            panel2 = new Panel();
            btnkapat = new Button();
            lblBrand = new Label();
            imgBrand = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            ProjectName = new DataGridViewTextBoxColumn();
            POwner = new DataGridViewTextBoxColumn();
            PStatus = new DataGridViewTextBoxColumn();
            PStartDate = new DataGridViewTextBoxColumn();
            PDueDate = new DataGridViewTextBoxColumn();
            PCompTasks = new DataGridViewTextBoxColumn();
            txtProjectName = new TextBox();
            btnNewAdd = new Button();
            txtOwner = new TextBox();
            pnlAddition = new Panel();
            dateTimePicker2 = new DateTimePicker();
            btnAdd1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblDueDate = new Label();
            lblOwner = new Label();
            lblProjectName = new Label();
            cmbPartners = new ComboBox();
            lblPersonnel = new Label();
            lblPartners = new Label();
            panel3 = new Panel();
            btnAdd2 = new Button();
            cmbPersonnel = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlAddition.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 49, 245);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnCalendar);
            panel1.Controls.Add(btnTasks);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(lblAuthority);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(btnProjects);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 470);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.AutoEllipsis = true;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ImageAlign = ContentAlignment.BottomCenter;
            btnLogout.ImeMode = ImeMode.NoControl;
            btnLogout.Location = new Point(124, 433);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(71, 32);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(123, 49, 245);
            btnSettings.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.Black;
            btnSettings.Location = new Point(-2, 357);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(204, 45);
            btnSettings.TabIndex = 10;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            btnSettings.MouseLeave += btnSettings_MouseLeave;
            btnSettings.MouseHover += btnSettings_MouseHover;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.FromArgb(123, 49, 245);
            btnCalendar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalendar.ForeColor = Color.Black;
            btnCalendar.Location = new Point(-2, 295);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(204, 45);
            btnCalendar.TabIndex = 9;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            btnCalendar.MouseLeave += btnCalendar_MouseLeave;
            btnCalendar.MouseHover += btnCalendar_MouseHover;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.FromArgb(123, 49, 245);
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTasks.ForeColor = Color.Black;
            btnTasks.Location = new Point(-2, 172);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(204, 45);
            btnTasks.TabIndex = 8;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            btnTasks.MouseLeave += btnTasks_MouseLeave;
            btnTasks.MouseHover += btnTasks_MouseHover;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(123, 49, 245);
            btnUsers.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.Black;
            btnUsers.Location = new Point(-2, 233);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(204, 45);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "Members";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            btnUsers.MouseLeave += btnUsers_MouseLeave;
            btnUsers.MouseHover += btnUsers_MouseHover;
            // 
            // lblAuthority
            // 
            lblAuthority.AutoSize = true;
            lblAuthority.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAuthority.ForeColor = Color.DarkSalmon;
            lblAuthority.Location = new Point(97, 52);
            lblAuthority.Name = "lblAuthority";
            lblAuthority.Size = new Size(51, 15);
            lblAuthority.TabIndex = 6;
            lblAuthority.Text = "Yönetici";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(97, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Büşra Enisoğlu";
            // 
            // btnProjects
            // 
            btnProjects.BackColor = SystemColors.ControlLightLight;
            btnProjects.FlatAppearance.BorderSize = 0;
            btnProjects.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProjects.ForeColor = Color.Black;
            btnProjects.Location = new Point(0, 112);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(202, 45);
            btnProjects.TabIndex = 1;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = false;
            btnProjects.Click += btnProjects_Click;
            btnProjects.MouseHover += btnProjects_MouseHover;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(123, 49, 245);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnkapat);
            panel2.Controls.Add(lblBrand);
            panel2.Controls.Add(imgBrand);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 80);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnkapat
            // 
            btnkapat.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnkapat.ImeMode = ImeMode.NoControl;
            btnkapat.Location = new Point(1026, 25);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(27, 25);
            btnkapat.TabIndex = 18;
            btnkapat.Text = "X";
            btnkapat.UseVisualStyleBackColor = true;
            btnkapat.Click += btnkapat_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBrand.ForeColor = SystemColors.ButtonHighlight;
            lblBrand.Location = new Point(76, 25);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(376, 25);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "AgileSphere - Project Management System";
            // 
            // imgBrand
            // 
            imgBrand.Image = (Image)resources.GetObject("imgBrand.Image");
            imgBrand.Location = new Point(13, 12);
            imgBrand.Name = "imgBrand";
            imgBrand.Size = new Size(58, 56);
            imgBrand.SizeMode = PictureBoxSizeMode.Zoom;
            imgBrand.TabIndex = 1;
            imgBrand.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(181, 30, 250);
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(181, 30, 250);
            tableLayoutPanel3.ColumnCount = 9;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(181, 30, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(109, 30, 250);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProjectName, POwner, PStatus, PStartDate, PDueDate, PCompTasks });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(294, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(760, 178);
            dataGridView1.TabIndex = 4;
            // 
            // ProjectName
            // 
            ProjectName.HeaderText = "Project Name";
            ProjectName.Name = "ProjectName";
            // 
            // POwner
            // 
            POwner.HeaderText = "Owner";
            POwner.Name = "POwner";
            // 
            // PStatus
            // 
            PStatus.HeaderText = "Status";
            PStatus.Name = "PStatus";
            // 
            // PStartDate
            // 
            PStartDate.HeaderText = "Start Date";
            PStartDate.Name = "PStartDate";
            // 
            // PDueDate
            // 
            PDueDate.HeaderText = "Due Date";
            PDueDate.Name = "PDueDate";
            // 
            // PCompTasks
            // 
            PCompTasks.HeaderText = "Rate of Completed Tasks";
            PCompTasks.Name = "PCompTasks";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(13, 82);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(100, 23);
            txtProjectName.TabIndex = 5;
            // 
            // btnNewAdd
            // 
            btnNewAdd.BackColor = Color.FromArgb(181, 30, 250);
            btnNewAdd.Location = new Point(223, 146);
            btnNewAdd.Name = "btnNewAdd";
            btnNewAdd.Size = new Size(48, 32);
            btnNewAdd.TabIndex = 6;
            btnNewAdd.Text = "Add New One";
            btnNewAdd.UseVisualStyleBackColor = false;
            btnNewAdd.Click += btnNewAdd_Click;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(137, 82);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(100, 23);
            txtOwner.TabIndex = 10;
            // 
            // pnlAddition
            // 
            pnlAddition.BorderStyle = BorderStyle.Fixed3D;
            pnlAddition.Controls.Add(dateTimePicker2);
            pnlAddition.Controls.Add(btnAdd1);
            pnlAddition.Controls.Add(dateTimePicker1);
            pnlAddition.Controls.Add(lblDueDate);
            pnlAddition.Controls.Add(lblOwner);
            pnlAddition.Controls.Add(lblProjectName);
            pnlAddition.Controls.Add(txtOwner);
            pnlAddition.Controls.Add(txtProjectName);
            pnlAddition.Location = new Point(223, 314);
            pnlAddition.Name = "pnlAddition";
            pnlAddition.Size = new Size(478, 217);
            pnlAddition.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(253, 111);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(194, 23);
            dateTimePicker2.TabIndex = 19;
            // 
            // btnAdd1
            // 
            btnAdd1.BackColor = Color.FromArgb(187, 112, 255);
            btnAdd1.Location = new Point(380, 173);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(67, 23);
            btnAdd1.TabIndex = 18;
            btnAdd1.Text = "ADD";
            btnAdd1.UseVisualStyleBackColor = false;
            btnAdd1.Click += btnAdd1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(253, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.BackColor = Color.FromArgb(38, 168, 255);
            lblDueDate.BorderStyle = BorderStyle.FixedSingle;
            lblDueDate.ForeColor = SystemColors.ButtonHighlight;
            lblDueDate.Location = new Point(253, 59);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(57, 17);
            lblDueDate.TabIndex = 13;
            lblDueDate.Text = "Due Date";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.BackColor = Color.FromArgb(38, 168, 255);
            lblOwner.BorderStyle = BorderStyle.FixedSingle;
            lblOwner.ForeColor = SystemColors.ButtonHighlight;
            lblOwner.Location = new Point(137, 59);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(44, 17);
            lblOwner.TabIndex = 12;
            lblOwner.Text = "Owner";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.BackColor = Color.FromArgb(38, 168, 255);
            lblProjectName.BorderStyle = BorderStyle.FixedSingle;
            lblProjectName.ForeColor = SystemColors.ButtonHighlight;
            lblProjectName.Location = new Point(13, 59);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(81, 17);
            lblProjectName.TabIndex = 11;
            lblProjectName.Text = "Project Name";
            // 
            // cmbPartners
            // 
            cmbPartners.FormattingEnabled = true;
            cmbPartners.Items.AddRange(new object[] { "Business Analysis", "IT Professional", "Subject Matter Expert", "Consultant", "Project Sponsor", "Resource Manager" });
            cmbPartners.Location = new Point(31, 84);
            cmbPartners.Name = "cmbPartners";
            cmbPartners.Size = new Size(121, 23);
            cmbPartners.TabIndex = 16;
            // 
            // lblPersonnel
            // 
            lblPersonnel.AutoSize = true;
            lblPersonnel.BackColor = Color.FromArgb(38, 168, 255);
            lblPersonnel.BorderStyle = BorderStyle.FixedSingle;
            lblPersonnel.ForeColor = SystemColors.ButtonHighlight;
            lblPersonnel.Location = new Point(176, 61);
            lblPersonnel.Name = "lblPersonnel";
            lblPersonnel.Size = new Size(61, 17);
            lblPersonnel.TabIndex = 15;
            lblPersonnel.Text = "Personnel";
            // 
            // lblPartners
            // 
            lblPartners.AutoSize = true;
            lblPartners.BackColor = Color.FromArgb(38, 168, 255);
            lblPartners.BorderStyle = BorderStyle.FixedSingle;
            lblPartners.ForeColor = SystemColors.ButtonHighlight;
            lblPartners.Location = new Point(31, 61);
            lblPartners.Name = "lblPartners";
            lblPartners.Size = new Size(27, 17);
            lblPartners.TabIndex = 14;
            lblPartners.Text = "Job";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnAdd2);
            panel3.Controls.Add(cmbPersonnel);
            panel3.Controls.Add(cmbPartners);
            panel3.Controls.Add(lblPartners);
            panel3.Controls.Add(lblPersonnel);
            panel3.Location = new Point(725, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 217);
            panel3.TabIndex = 17;
            // 
            // btnAdd2
            // 
            btnAdd2.BackColor = Color.FromArgb(187, 112, 255);
            btnAdd2.Location = new Point(230, 173);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(67, 23);
            btnAdd2.TabIndex = 19;
            btnAdd2.Text = "ADD";
            btnAdd2.UseVisualStyleBackColor = false;
            btnAdd2.Click += btnAdd2_Click;
            // 
            // cmbPersonnel
            // 
            cmbPersonnel.FormattingEnabled = true;
            cmbPersonnel.Location = new Point(176, 85);
            cmbPersonnel.Name = "cmbPersonnel";
            cmbPersonnel.Size = new Size(121, 23);
            cmbPersonnel.TabIndex = 17;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1080, 550);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(btnNewAdd);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlAddition);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Projects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "main";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlAddition.ResumeLayout(false);
            pnlAddition.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblAuthority;
        private Label lblName;
        private Button btnProjects;
        private Label lblBrand;
        private PictureBox imgBrand;
        private Button btnSettings;
        private Button btnCalendar;
        private Button btnTasks;
        private Button btnUsers;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProjectName;
        private DataGridViewTextBoxColumn POwner;
        private DataGridViewTextBoxColumn PStatus;
        private DataGridViewTextBoxColumn PStartDate;
        private DataGridViewTextBoxColumn PDueDate;
        private DataGridViewTextBoxColumn PCompTasks;
        private TextBox txtProjectName;
        private Button btnNewAdd;
        private TextBox txtOwner;
        private Panel pnlAddition;
        private Label lblOwner;
        private Label lblProjectName;
        private Label lblPersonnel;
        private Label lblPartners;
        private Label lblDueDate;
        private ComboBox cmbPartners;
        private DateTimePicker dateTimePicker1;
        private Panel panel3;
        private Button btnAdd1;
        private ComboBox cmbPersonnel;
        private Button btnAdd2;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnkapat;
        private DateTimePicker dateTimePicker2;
    }
}
