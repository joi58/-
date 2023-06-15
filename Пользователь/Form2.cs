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
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source = p58-06032020\SQLEXPRESS; Initial Catalog = Пользователь; Integrated Security=True";

        private Form1 _form1;
        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _form1.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {

            // строка запроса на добавление в таблицу В первых скобках идут колонки в которые мы добавляем после "VALUES" 
            // мы объявляем параметры(впринцепи как и в примере с регистрации можно создать переменные)
            string queryString = @"INSERT INTO Users (Name, Surname, Middlename, BirthDate, Login, Password, idUsers) " +
                "VALUES(@Name, @Surname, @Middlename, @BirthDate, @Login, @Password, 1)";
            // Здесь я объявил using(Чтобы после завершения операции было освобождение неуправляемых ресурсов. Я хрен знает как ещё объяснить, но чтобы потом не закрывать подключение, оно само закроется)
            // Так же как и в прошлом примере объявляю подключение к серверу
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открываю соединение
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                // command - вызываем переменную(экземпляр класса SqlCommand)
                // Parameters - объявляем параметр
                // AddWithValue() - добавляет то что указано в скобках в колекцию(т.е. в нашу таблицу). Сначала идёт параметр, что объявили выше(или переменная, если создал онную) и через запятую значение текстБокса
                command.Parameters.AddWithValue("@Name", NameField.Text);
                command.Parameters.AddWithValue("@Surname", SurnameField.Text);
                command.Parameters.AddWithValue("@Middlename", MiddField.Text);
                command.Parameters.AddWithValue("@BirthDate", BirthDateField.Text);
                command.Parameters.AddWithValue("@Login", LogField.Text);
                command.Parameters.AddWithValue("@Password", PassField.Text);
                // используем экземпляр класса SqlDataAdapter для взаимодействия с приложения и базы. Вызываем SelectCommand для того чтобы принила запрос 
                adapter.SelectCommand = command;
                // добавляет добавления строк в нашу таблицу
                adapter.Fill(table);

                // если всё успешно то выводит сообщение о успехе
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт создан!", "Уведомление");
                }
            }

            
         

            

        }
        private void RepeatPassField_Click(object sender, EventArgs e) { 

        }
    }
}
