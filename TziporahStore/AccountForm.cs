using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplicationDBClasses;

namespace TziporahStore
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                var userID = context.Customers.Where(c => c.username == LoginForm.username)
                    .Select(c => c.userID)
                    .FirstOrDefault();
                var balance = context.Accounts.Where(a => a.userID == userID).Select(a => a.balance).FirstOrDefault();

                accountLabel.Text = $"Welcome, {LoginForm.username}!\n" +
                                    $"Your current balance is {balance}";
            }
        }

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            enterAmountLabel.Visible = true;
            numericUpDown1.Visible = true;
            makePaymentButton.Visible = false;
            updateAccountButton.Visible = true;
        }

        private void updateAccountButton_Click(object sender, EventArgs e)
        {
            decimal amount = numericUpDown1.Value;
            
            try
            {
                string sql = $"declare @userID int;"
                             + $"select @userid = userID from Customer where username = '{LoginForm.username}'"
                             + $"update Account set balance = balance - {amount} where userID = @userID";
                ConsoleApplicationDBClasses.SingletonConnection.Instance.GetReader(sql);

            }
            catch (Exception ex)
            {
                errorLabel.Visible = true;
            }
        }

        private void viewPurchasesButton_Click(object sender, EventArgs e)
        {
            Program.Purchases.Show();
            this.Hide();
        }
    }
}
