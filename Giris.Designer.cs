namespace Cet301_ProjectManagement
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            panel1 = new Panel();
            label1 = new Label();
            lblBrand = new Label();
            imgBrand = new PictureBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBrand).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 49, 245);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblBrand);
            panel1.Controls.Add(imgBrand);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 480);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 329);
            label1.Name = "label1";
            label1.Size = new Size(261, 25);
            label1.TabIndex = 5;
            label1.Text = " Project Management System";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBrand.ForeColor = SystemColors.ButtonHighlight;
            lblBrand.Location = new Point(119, 286);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(115, 25);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "AgileSphere";
            // 
            // imgBrand
            // 
            imgBrand.Image = (Image)resources.GetObject("imgBrand.Image");
            imgBrand.Location = new Point(60, 24);
            imgBrand.Name = "imgBrand";
            imgBrand.Size = new Size(244, 330);
            imgBrand.SizeMode = PictureBoxSizeMode.Zoom;
            imgBrand.TabIndex = 3;
            imgBrand.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 117);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 16;
            label2.Text = "Emplyee Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(449, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 23);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(605, 308);
            button1.Name = "button1";
            button1.Size = new Size(66, 23);
            button1.TabIndex = 18;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(449, 308);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(449, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 238);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 21;
            label3.Text = "Choose your job";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(449, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 23;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 180);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 22;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(428, 53);
            label5.Name = "label5";
            label5.Size = new Size(125, 24);
            label5.TabIndex = 24;
            label5.Text = "Welcome...";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(775, 480);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            Load += Giris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBrand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblBrand;
        private PictureBox imgBrand;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
    }
}