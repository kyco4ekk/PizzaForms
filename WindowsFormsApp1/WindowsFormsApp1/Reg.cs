using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegPanel : Form
    {
        public RegPanel()
        {
            InitializeComponent();
            regPassword.AutoSize = false;
            regPassword.Size = new Size(regPassword.Size.Width, 34);
        }


        private void regPanel_Load(object sender, EventArgs e)
        {
            
            regLogin.Text = "Введите логин";
            regLogin.ForeColor = Color.Gray;

            regPassword.Text = "Введите пароль";
            regPassword.UseSystemPasswordChar = false;
            regPassword.ForeColor = Color.Gray;

            regName.Text = "Введите имя";
            regName.ForeColor = Color.Gray;

            regSurname.Text = "Введите фамилию";
            regSurname.ForeColor = Color.Gray;

        }
        private void lookPass_Click(object sender, EventArgs e)
        {
            if (lookPass.Checked)
                regPassword.UseSystemPasswordChar = false;
            else if (regPassword.Text == "")
                regPassword.UseSystemPasswordChar = true;
            else if (regPassword.Text == "Введите пароль")
                regPassword.UseSystemPasswordChar = true;
            else
                regPassword.UseSystemPasswordChar = true;
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
            if (regPassword.Text == "Введите пароль")
            {
                regPassword.UseSystemPasswordChar = true;
                regPassword.Text = "";
                regPassword.ForeColor = Color.Black;
            }
        }
        private void regPassword_Leave(object sender, EventArgs e)
        {
            if (regPassword.Text == "")
            {
                regPassword.UseSystemPasswordChar = false;
                regPassword.Text = "Введите пароль";
                regPassword.ForeColor = Color.Gray;
            }
        }
        private void regName_Enter(object sender, EventArgs e)
        {
            if (regName.Text == "Введите имя")
            {
                regName.Text = "";
                regName.ForeColor = Color.Black;
            }
        }
        private void regName_Leave(object sender, EventArgs e)
        {
            if (regName.Text == "")
            {
                regName.Text = "Введите имя";
                regName.ForeColor = Color.Gray;
            }
        }
        private void regSurname_Enter(object sender, EventArgs e)
        {
            if (regSurname.Text == "Введите фамилию")
            {
                regSurname.Text = "";
                regSurname.ForeColor = Color.Black;
            }
        }
        private void regSurname_Leave(object sender, EventArgs e)
        {
            if (regSurname.Text == "")
            {
                regSurname.Text = "Введите фамилию";
                regSurname.ForeColor = Color.Gray;
            }
        }

        private bool notCorrectFormatTextForRegistration(string checkWord)
        {
            if (checkWord == null || checkWord == " ")
                return true;

            int counter = checkWord.Length;
            checkWord = checkWord.Replace(" ", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "")
                .Replace("^", "").Replace("&", "").Replace("\"", "").Replace("*", "").Replace("!", "").Replace("~", "")
                .Replace("<", "").Replace(">", "").Replace("|", "").Replace("/", "").Replace(".", "").Replace(",", "")
                .Replace("`", "").Replace("№", "").Replace(";", "").Replace(":", "").Replace("?", "").Replace("(", "")
                .Replace("{", "").Replace("}", "").Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "");
            if (checkWord.Length < counter)
                return true;
            else
                return false;
        }
        private bool notCorrectBioTextForRegistration(string checkWord)
        {
            for (int i = 0; i < checkWord.Length; i++)
            {
                if (char.IsDigit(checkWord[i]) || char.IsControl(checkWord[i]))
                    return true;
            }
            return false;
        }
        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (regLogin.Text == "" || regLogin.Text == "Введите логин" || notCorrectFormatTextForRegistration(regLogin.Text))
                MessageBox.Show("Поле логина заполнено некоректно");
            else if (regPassword.Text == "" || regPassword.Text == "Введите пароль")
                MessageBox.Show("Поле пароля заполнено некоректно");
            else if (regName.Text == "" || regName.Text == "Введите имя" || notCorrectFormatTextForRegistration(regName.Text) || notCorrectBioTextForRegistration(regName.Text))
                MessageBox.Show("Поле имени заполнено некоректно");
            else if (regSurname.Text == "" || regSurname.Text == "Введите фамилию" || notCorrectFormatTextForRegistration(regSurname.Text) || notCorrectBioTextForRegistration(regSurname.Text))
                MessageBox.Show("Поле фамилии заполнено некоректно");
            else
            {
                MySqlConnection connection = new MySqlConnection(userDataBase.con);

                connection.Open();

                MySqlCommand checkCommand = new MySqlCommand($"SELECT login FROM users WHERE login = @login", connection);
                checkCommand.Parameters.AddWithValue("@login", regLogin.Text);

                bool userInDataBaseFlag = checkCommand.ExecuteScalar()?.ToString() == null ? true : false;

                connection.Close();

                if (userInDataBaseFlag)
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `userFirstName`, `userLastName`, `personalDiscount`, `dateTime`) VALUES (@lg, @pass, @ufn, @uln, @pd, @dt);", connection);

                    command.Parameters.Add("@lg", MySqlDbType.VarChar).Value = regLogin.Text;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = regPassword.Text;
                    command.Parameters.Add("@ufn", MySqlDbType.VarChar).Value = regName.Text;
                    command.Parameters.Add("@uln", MySqlDbType.VarChar).Value = regSurname.Text;
                    command.Parameters.Add("@pd", MySqlDbType.Int32).Value = 0;
                    command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = DateTime.Now;

                    command.ExecuteNonQuery();
                    connection.Close();

                    PizzaShop.usersLogin = regLogin.Text;
                    PizzaShop pizzaShop = new PizzaShop();
                    pizzaShop.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                    RegPanel regPanel = new RegPanel();
                    regPanel.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
