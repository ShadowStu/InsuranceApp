using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Insurance
{
    public partial class MainForm : Form
    {
        private string _userRole;

        // Конструктор теперь принимает строку с ролью
        public MainForm(string role)
        {
            InitializeComponent();
            _userRole = role;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // При загрузке формы меняем текст Label (проверь имя lblWelcome)
            if (_userRole == "Admin")
            {
                label1.Text = "Добро пожаловать, Господин Администратор!";
                label1.ForeColor = Color.Red; // Для пафоса
            }
            else if

            (_userRole == "Инспекрт")
            {
                label1.Text = "Работайте усердно, Инспектор!";
                label1.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }
    }
}

    
