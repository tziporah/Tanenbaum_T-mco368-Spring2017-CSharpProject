using ConsoleApplicationDBClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TziporahStore
{
    public partial class LoginForm : Form
    {
        public static string username;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                username = usernameTextBox.Text;

                var password = context.Customers.Where(a => a.username == username)
                    .Select(a => a.aPassword).FirstOrDefault();
                if (!string.IsNullOrEmpty(password) && passwordTextBox.Text == password.ToString())
                {
                    Program.Items.Show();
                    this.Hide();
                }
                else
                {
                    errorLabel.Visible = true;
                }

            }
        }
    }
}
