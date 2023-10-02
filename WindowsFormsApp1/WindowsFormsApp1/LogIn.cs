using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {       
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            regLogin.Text = "Введите логин";
            regLogin.ForeColor = Color.Gray;

            logPassword.Text = "Введите пароль";
            logPassword.UseSystemPasswordChar = false;
            logPassword.ForeColor = Color.Gray;
        }
        private void lookPass_Click(object sender, EventArgs e)
        {
            if (lookPass.Checked)
                logPassword.UseSystemPasswordChar = false;
            else if (logPassword.Text == "")
                logPassword.UseSystemPasswordChar = true;
            else if (logPassword.Text == "Введите пароль")
                logPassword.UseSystemPasswordChar = true;
            else
                logPassword.UseSystemPasswordChar = true;
        }
        // 
        private void regLogin_Enter(object sender, EventArgs e)
        {
            if (regLogin.Text == "Введите логин")
            {
                regLogin.Text = "";
                regLogin.ForeColor = Color.Black;
            }
        }
        private void regLogin_Leave(object sender, EventArgs e)
        {
            if (regLogin.Text == "")
            {
                regLogin.Text = "Введите логин";
                regLogin.ForeColor = Color.Gray;
            }
        }
        private void regPassword_Enter(object sender, EventArgs e)
        {
            if (logPassword.Text == "Введите пароль")
            {
                logPassword.UseSystemPasswordChar = true;
                logPassword.Text = "";
                logPassword.ForeColor = Color.Black;
            }
        }
        private void regPassword_Leave(object sender, EventArgs e)
        {
            if (logPassword.Text == "")
            {
                logPassword.UseSystemPasswordChar = false;
                logPassword.Text = "Введите пароль";
                logPassword.ForeColor = Color.Gray;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(userDataBase.con);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", connection);
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = regLogin.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = logPassword.Text;
           
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                PizzaShop.usersLogin = regLogin.Text;
                PizzaShop pizzaShop = new PizzaShop();
                pizzaShop.Show();
            }
            else
            {
                RegPanel reg = new RegPanel();
                reg.Show();
                MessageBox.Show("Такого пользователя нет. Пожалуйста, зарегестрируйтесь!");
            }
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
