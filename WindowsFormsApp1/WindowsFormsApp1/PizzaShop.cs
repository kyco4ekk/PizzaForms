using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PizzaShop : Form
    {
        public static string usersLogin = "";
        private List<List<string>> informationAboutPizza = new List<List<string>>();
        private Dictionary<string, int> pizzasCount = new Dictionary<string, int>();
        private static int counter = 0;
        private bool flagBox = false;

        public PizzaShop()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(userDataBase.con);

            connection.Open();

            MySqlCommand checkCommand = new MySqlCommand("SELECT personalDiscount FROM users WHERE login = @login", connection);
            checkCommand.Parameters.AddWithValue("@login", usersLogin);

            Discount.Text = "Ваша персональная скидка - " + checkCommand.ExecuteScalar()?.ToString() + "%";

            connection.Close();

            connection.Open();

            MySqlCommand command = new MySqlCommand($"SELECT typeOfPizza, pizzaComposition, caloricContent, price, discountOnPizza FROM pizzaspec", connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                informationAboutPizza.Add(new List<string> { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() });

            connection.Close();

            pizzaButtonOne.Text = informationAboutPizza[0][0];
            pizzaButtonTwo.Text = informationAboutPizza[1][0];
            pizzaButtonThree.Text = informationAboutPizza[2][0];

            pricePizzaOne.Text = (Convert.ToDouble(informationAboutPizza[0][3]) * ((100.0 - Convert.ToDouble(informationAboutPizza[0][4])) / 100)).ToString();
            pricePizzaTwo.Text = (Convert.ToDouble(informationAboutPizza[1][3]) * ((100.0 - Convert.ToDouble(informationAboutPizza[1][4])) / 100)).ToString();
            pricePizzaThree.Text = (Convert.ToDouble(informationAboutPizza[2][3]) * ((100.0 - Convert.ToDouble(informationAboutPizza[2][4])) / 100)).ToString();

            countOfPizzaInBox.Text = "0";

            string imagePath = @"C:\Users\kyco4ekk\Downloads\pizza-3000285_640.png"; // Замените на путь к вашему изображению
            picturePizza1.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePizza1.Load(imagePath);


            picturePizza2.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePizza2.Load(imagePath);

            picturePizza3.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePizza3.Load(imagePath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == true)
            {
                textBox2.Visible = false;
                cleanTheBox.Visible = false;
            }
            else
            {
                textBox2.Visible = true;
                cleanTheBox.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pizzasCount.ContainsKey(informationAboutPizza[0][0]))
            {
                pizzasCount[informationAboutPizza[0][0]]++;
            }
            else
            {
                pizzasCount.Add(informationAboutPizza[0][0], 1);
            }
            countOfPizzaInBox.Text = (++counter).ToString();

            string text = "";
            foreach (var item in pizzasCount)
                text += $"{item.Key} {item.Value}\n";
            textBox2.Text = text;

            flagBox = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pizzasCount.ContainsKey(informationAboutPizza[1][0]))
            {
                pizzasCount[informationAboutPizza[1][0]]++;
            }
            else
            {
                pizzasCount.Add(informationAboutPizza[1][0], 1);
            }
            countOfPizzaInBox.Text = (++counter).ToString();

            string text = "";
            foreach (var item in pizzasCount)
                text += $"{item.Key} {item.Value}\n";
            textBox2.Text = text;

            flagBox = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pizzasCount.ContainsKey(informationAboutPizza[2][0]))
            {
                pizzasCount[informationAboutPizza[2][0]]++;
            }
            else
            {
                pizzasCount.Add(informationAboutPizza[2][0], 1);
            }
            countOfPizzaInBox.Text = (++counter).ToString();

            string text = "";
            foreach (var item in pizzasCount)
                text += $"{item.Key} {item.Value}\n";
            textBox2.Text = text;

            flagBox = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void final_Click(object sender, EventArgs e)
        {
            if (flagBox)
            {
                int price = 0;

                foreach (var item in pizzasCount)
                {
                    int priceAboutPizza = 0;
                    for (int i = 0; i < informationAboutPizza.Count; i++)
                    {
                        if (item.Key == informationAboutPizza[i][0])
                        {
                            priceAboutPizza = Convert.ToInt32(Convert.ToDouble(informationAboutPizza[i][3]) * ((100.0 - Convert.ToDouble(informationAboutPizza[i][4])) / 100));
                            break;
                        }
                    }
                    price += item.Value * priceAboutPizza;
                }

                MessageBox.Show($"Ваш заказ на сумму {price} рублёв оформлен\nВнимание, стоимость доставки - 340 рублёв НЕ включена в чек!");
            }
            else
                MessageBox.Show("Ваша корзина пуста. Для оформления заказа нужно что-то добавить");
        }

        private void textBoxConfig_TextChanged(object sender, EventArgs e)
        {

        }

        private void structure1_Click(object sender, EventArgs e)
        {
            textBoxConfig.Text = $"Состав пиццы {informationAboutPizza[0][0]}: " + informationAboutPizza[0][1];
            textBoxConfig.Visible = true;
            button2.Visible = true;
        }

        private void structure2_Click(object sender, EventArgs e)
        {
            textBoxConfig.Text = $"Состав пиццы {informationAboutPizza[1][0]}: " + informationAboutPizza[1][1];
            textBoxConfig.Visible = true;
            button2.Visible = true;
        }

        private void structure3_Click(object sender, EventArgs e)
        {
            textBoxConfig.Text = $"Состав пиццы {informationAboutPizza[2][0]}: " + informationAboutPizza[2][1];
            textBoxConfig.Visible = true;
            button2.Visible = true;
        }

        private void cal1_Click(object sender, EventArgs e)
        {
            textBoxConfig.Text = informationAboutPizza[0][2] + " калорий в данной пицце";
            textBoxConfig.Visible = true;
            button2.Visible = true;
        }

        private void cal2_Click(object sender, EventArgs e)
        {
            textBoxConfig.Text = informationAboutPizza[1][2] + " калорий в данной пицце";
            textBoxConfig.Visible = true;
            button2.Visible = true;
        }

        private void cal3_Click(object sender, EventArgs e)
        {
            textBoxConfig.Text = informationAboutPizza[2][2] + " калорий в данной пицце";
            textBoxConfig.Visible = true;
            button2.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxConfig.Visible = false;
            button2.Visible = false;
        }

        private void cleanTheBox_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Ничего нет (теперь)";
            counter = 0;
            pizzasCount.Clear();
            countOfPizzaInBox.Text = "0";
            flagBox = false;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
