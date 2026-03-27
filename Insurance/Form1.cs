using Insurance;
using System.Data;
using System.Data.SqlClient;
namespace Insurance

{
    public partial class LoginForm : Form
    {
        database db = new database();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string pass = txtPass.Text.Trim();
            var db = new database();
            using (var connection = db.connect())
            {
                try
                {
                    connection.Open();
                    // ВАЖНО: Убедись, что в таблице Users колонка называется Role
                    string sql = "SELECT Role FROM Users WHERE Login = @login AND Password = @pass";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    object result = cmd.ExecuteScalar(); // Получаем роль напрямую

                    if (result != null)
                    {
                        string userRole = result.ToString();
                        MessageBox.Show($"Добро пожаловать! Ваша роль: {userRole}", "Успех");

                        this.Hide();
                        // Передаем роль в конструктор
                        MainForm main = new MainForm(userRole);
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка БД: " + ex.Message);
                }
            }
        }
    }
}
    

    
        