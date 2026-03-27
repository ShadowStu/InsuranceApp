namespace Insurance
{
    partial class MainForm
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
            btnClients = new Button();
            btnPolicies = new Button();
            btnUsers = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClients
            // 
            btnClients.Location = new Point(163, 216);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(146, 58);
            btnClients.TabIndex = 1;
            btnClients.Text = "База клиентов";
            btnClients.UseVisualStyleBackColor = true;
            // 
            // btnPolicies
            // 
            btnPolicies.Location = new Point(330, 216);
            btnPolicies.Name = "btnPolicies";
            btnPolicies.Size = new Size(146, 58);
            btnPolicies.TabIndex = 2;
            btnPolicies.Text = "Оформление полисов";
            btnPolicies.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(492, 216);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(146, 58);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "Управление сотрудниками";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(95, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 64);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(659, 411);
            button1.Name = "button1";
            button1.Size = new Size(113, 38);
            button1.TabIndex = 6;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(572, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 172, 180);
            ClientSize = new Size(784, 461);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(btnUsers);
            Controls.Add(btnPolicies);
            Controls.Add(btnClients);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ИС \"Страхование\" — Главное меню";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnClients;
        private Button btnPolicies;
        private Button btnUsers;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}