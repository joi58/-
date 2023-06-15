using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пользователь
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source = p58-06032020\SQLEXPRESS; Initial Catalog = Пользователь; Integrated Security=True";
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this) { Visible = false };
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            form2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            // Переменные для принятия введённых данных
            string login = LoginField.Text;
            string password = PasswordField.Text;

            // Запрос на выбрку(select) нужных данных из таблицы(from таблица) по условию(where) чтобы номер телефона и пароль совпадали с данными наших переменных
            string queryString = $"select id, Login, Password, idUsers from Users where Login = '{login}' and Password = '{password}'";

            // Для подключения
            SqlConnection connection = new SqlConnection(connectionString);
            // Для взаимодействия базы и приложения
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Представляет таблиц(Я хрен знает как ещё обЪяснить)
            DataTable dataTable = new DataTable();
            // Для того чтобы работало
            SqlCommand command = new SqlCommand(queryString, connection);
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            // Если в нашей таблице строка существет
            if (dataTable.Rows.Count == 1)
            {
                // Вывод сообщения об успехе
                MessageBox.Show("Вы успешно вошли!", "Уведомление");
                // Переход на другую форму
                Mainmenu main = new Mainmenu();
                main.Show();
                this.Hide();
            }
            else
                // Если такой строки не имеется, то вывод о провале
                MessageBox.Show("Такого аккаунта не существует!", "Уведомление");
        }
    }
}
