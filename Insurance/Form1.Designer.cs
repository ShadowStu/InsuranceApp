using System.Data.SqlClient;
namespace Insurance
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtLogin = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(30, 58);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(30, 109);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(131, 51);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(241, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(131, 102);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(241, 23);
            txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(114, 194);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(154, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 172, 180);
            ClientSize = new Size(384, 261);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация — Страховая компания";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtPass;
        private Button btnLogin;
    }
}
