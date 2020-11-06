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
    public partial class LoginForm : Form
    {
        public static bool isGuest;
        public static string username;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guestEntranceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDataForm udf = new UserDataForm();
            MessageBox.Show("Вы вошли в систему в качестве гостя.Функционал для вас будет ограничен!", "Внимание!");
            isGuest = true;
            username = "Гость";
            udf.Show();
        }

        private void gotoRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }

        private void userEntranceButton_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=COMP1;Initial Catalog=Users;Integrated Security=True";
            string user = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string query = "Select * from users where username = '" + user + "' and password = '" + password + "'";

            SQLWorker sqlWorker = new SQLWorker(connection, query);
            if(sqlWorker.IsUserExists())
            {
                username = user;
                MessageBox.Show("Вы вошли в систему!", "Внимание!");
                isGuest = false;
                this.Hide();
                UserDataForm udf = new UserDataForm();
                udf.Show();
            }
            else
            {
                MessageBox.Show("Такой пользователь отсутсвует!", "Внимание!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
