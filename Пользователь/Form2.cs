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
        string connectionString = @"Data Source = p58-06032020\\SQLEXPRESS; Initial Catalog = Пользователь; Integrated Security=True";

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
            string queryString = @"INSERT INTO users (Name, Surname, Middlename, BirthDate, Login, Password) " +
                "VALUES(@Name, @Surname, @Middlename, @BirthDate, @Login, @Password)";
            SqlConnction connction = new SqlConnction(@"Data Source = p58-06032020\\SQLEXPRESS; Initial Catalog = Пользователь; Integrated Security=True");
            SqlCommand command = new SqlCommand(queryString, connction);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.AddWithValue("@Name", NameField.Text);
            command.Parameters.AddWithValue("@Surname", SurnameField.Text);
            command.Parameters.AddWithValue("@Middlename", MiddField.Text);
            command.Parameters.AddWithValue("@BirthDate", BirthDateField.Text);
            command.Parameters.AddWithValue("@Login", LogField.Text);
            command.Parameters.AddWithValue("@Password", PassField.Text);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!", "Уведомление");
            }
        }

        private void RepeatPassField_Click(object sender, EventArgs e)
        {

        }
    }
}
