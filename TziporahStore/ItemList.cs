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
    public partial class ItemList : Form
    {
        public ItemList()
        {
            InitializeComponent();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                for (int i = 1; i <= context.Items.Count(); i++)
                {
                    Button button = (Button)Controls.Find("button" + i, true).FirstOrDefault();
                    Label label = (Label) Controls.Find("label" + i, true).FirstOrDefault();
                    var prod = context.Items.Where(it => it.itemID == i).First();
                    if (button != null)
                    {
                        button.Text = $"Purchase {prod.descript}";
                    }
                    if (label != null)
                    {
                        label.Text = $"{prod.price}";
                    }
                }
            }
        }

        private void purchaseItem(int item, decimal qty)
        {

            /*
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                var custID = context.Customers.Where(c => c.username == LoginForm.username)
                    .Select(c => c.userID);
                var price = context.Items.Where(i => i.itemID == item).Select(i => i.price);
                var PurchaseDate = DateTime.Now.ToShortDateString();
                string sql = $"INSERT INTO PURCHASE VALUES({custID},{item},{qty},{PurchaseDate}," +
                             $"{price})";
                ConsoleApplicationDBClasses.SingletonConnection.Instance.GetReader(sql);
               
            }
            */
            try
            {
                string sql = "declare @userid int;"
                             + "declare @price decimal(4,2);"
                             + $"select @userid = userID from Customer where username = '{LoginForm.username}'"
                             + $"select @price = price from Item where itemID = {item}"
                             +
                             "INSERT INTO PURCHASE(custID, itemNo, quantity, purchaseDate, price)" +
                             $" VALUES(@userid, {item}, {qty}, GETDATE(), @price)";
                ConsoleApplicationDBClasses.SingletonConnection.Instance.GetReader(sql);
            }
            catch (Exception e)
            {
                errorLabel.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            purchaseItem(1, numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            purchaseItem(2, numericUpDown2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            purchaseItem(3, numericUpDown3.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            purchaseItem(4, numericUpDown4.Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            purchaseItem(5, numericUpDown5.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            purchaseItem(6, numericUpDown6.Value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            purchaseItem(7, numericUpDown7.Value);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            purchaseItem(8, numericUpDown8.Value);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            purchaseItem(9, numericUpDown9.Value);
        }
    }
}
