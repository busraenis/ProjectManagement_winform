



namespace Cet301_ProjectManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel2 = new Panel();
            btnkapat = new Button();
            pictureBox2 = new PictureBox();
            lblBrand = new Label();
            imgBrand = new PictureBox();
            btnCalendar = new Button();
            btnTasks = new Button();
            btnUsers = new Button();
            btnProjects = new Button();
            lblAuthority = new Label();
            lblName = new Label();
            imgProfil = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgProfil).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(123, 49, 245);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnkapat);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblBrand);
            panel2.Controls.Add(imgBrand);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 80);
            panel2.TabIndex = 2;
            // 
            // btnkapat
            // 
            btnkapat.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnkapat.ImeMode = ImeMode.NoControl;
            btnkapat.Location = new Point(1040, 25);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(27, 25);
            btnkapat.TabIndex = 19;
            btnkapat.Text = "X";
            btnkapat.UseVisualStyleBackColor = true;
            btnkapat.Click += btnkapat_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
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
            imgBrand.Location = new Point(12, 7);
            imgBrand.Name = "imgBrand";
            imgBrand.Size = new Size(58, 56);
            imgBrand.TabIndex = 1;
            imgBrand.TabStop = false;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.FromArgb(123, 49, 245);
            btnCalendar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalendar.ForeColor = Color.Black;
            btnCalendar.Location = new Point(687, 389);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(227, 94);
            btnCalendar.TabIndex = 13;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.FromArgb(123, 49, 245);
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTasks.ForeColor = Color.Black;
            btnTasks.Location = new Point(687, 217);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(227, 94);
            btnTasks.TabIndex = 12;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(123, 49, 245);
            btnUsers.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.Black;
            btnUsers.Location = new Point(318, 389);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(230, 94);
            btnUsers.TabIndex = 11;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnProjects
            // 
            btnProjects.BackColor = Color.FromArgb(123, 49, 245);
            btnProjects.FlatAppearance.BorderSize = 0;
            btnProjects.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProjects.ForeColor = Color.Black;
            btnProjects.Location = new Point(318, 218);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(230, 94);
            btnProjects.TabIndex = 10;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = false;
            btnProjects.Click += btnProjects_Click;
            // 
            // lblAuthority
            // 
            lblAuthority.AutoSize = true;
            lblAuthority.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAuthority.ForeColor = Color.DarkSalmon;
            lblAuthority.Location = new Point(51, 176);
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
            lblName.Location = new Point(51, 139);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Büşra Enisoğlu";
            // 
            // imgProfil
            // 
            imgProfil.Location = new Point(63, 45);
            imgProfil.Name = "imgProfil";
            imgProfil.Size = new Size(79, 79);
            imgProfil.TabIndex = 0;
            imgProfil.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 49, 245);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblAuthority);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(imgProfil);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 540);
            panel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(140, 495);
            button1.Name = "button1";
            button1.Size = new Size(71, 32);
            button1.TabIndex = 17;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(63, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1080, 620);
            Controls.Add(panel1);
            Controls.Add(btnCalendar);
            Controls.Add(panel2);
            Controls.Add(btnTasks);
            Controls.Add(btnUsers);
            Controls.Add(btnProjects);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgProfil).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblBrand;
        private PictureBox imgBrand;
        private Button btnCalendar;
        private Button btnTasks;
        private Button btnUsers;
        private Button btnProjects;
        private Label lblAuthority;
        private Label lblName;
        private PictureBox imgProfil;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button btnkapat;
    }
}