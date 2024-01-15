namespace Cet301_ProjectManagement
{
    partial class UserControlDays
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            lblday = new Label();
            numTask = new Label();
            SuspendLayout();
            // 
            // lblday
            // 
            lblday.AutoSize = true;
            lblday.ImeMode = ImeMode.NoControl;
            lblday.Location = new Point(3, 9);
            lblday.Name = "lblday";
            lblday.Size = new Size(19, 15);
            lblday.TabIndex = 11;
            lblday.Text = "00";
            lblday.Click += lblsunday_Click;
            // 
            // numTask
            // 
            numTask.AutoSize = true;
            numTask.ImeMode = ImeMode.NoControl;
            numTask.Location = new Point(56, 62);
            numTask.Name = "numTask";
            numTask.Size = new Size(0, 15);
            numTask.TabIndex = 12;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numTask);
            Controls.Add(lblday);
            Name = "UserControlDays";
            Load += UserControlDays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblday;
        private Label numTask;
    }
}
