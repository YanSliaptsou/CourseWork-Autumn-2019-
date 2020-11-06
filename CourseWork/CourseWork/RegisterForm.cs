using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void gotoLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=COMP1;Initial Catalog=Users;Integrated Security=True";
            string user = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string query = "Select * from users where username = '"+user+"' and password = '"+password+"'";
            SQLWorker sqlWorker = new SQLWorker(connection, query);

            if (textBoxUsername.Text.Length < 5 || textBoxUsername.Text.Length > 20)
            {
                MessageBox.Show("Имя пользователя должно быть длиной от 5 до 20 символов!", "Внимание!");
            }
            else if(textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Внимание!");
            }
            else if(textBoxUsername.Text.Length == 0 || textBoxPassword.Text.Length == 0 || textBoxRepeatPassword.Text.Length == 0)
            {
                MessageBox.Show("Заполнены не все поля!", "Внимание!");
            }
            else if(textBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("Длина пароля должна быть минимум 8 символов!", "Внимание!");
            }
            else if (sqlWorker.IsUserExists())
            {
                MessageBox.Show("Такой аользователь уже имеется!", "Внимание!");
            }
            else
            {
                MessageBox.Show("Регистрация прошла успешно!", "Внимание!");
                sqlWorker.Register(user,password);
                Clear(new TextBox[] { textBoxUsername, textBoxPassword, textBoxRepeatPassword });
            }
            
        }

        private void Clear(TextBox[] array)
        {
            foreach(TextBox txtbx in array)
            {
                txtbx.Text = "";
            }
        }


    }
}
