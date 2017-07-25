using ConsoleApplicationDBClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TziporahStore
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            this.itemTableAdapter.Fill(this.tziporahStoreDataSet.Item);
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                for (int i = 0; i <= context.Items.Count(); i++)
                {
                    Button item = (Button)Controls.Find("button" + i, true).FirstOrDefault();
                    if (item != null)
                    {
                        var prod = context.Items.Where(it => it.itemID == i).First();
                        item.Text = $"Purchase {prod.descript}";

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            purchaseItem(1, qty1.Value);
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
                             + $"declare @price decimal(4,2);"
                             + $"select @userid = userID from Customer where username = '{LoginForm.username}'"
                             + $"select @price = price from Item where itemNo == item"
                             +
                             $"INSERT INTO PURCHASE(custID, itemNo, quantity, purchaseDate, price)" +
                             $" VALUES(@userid, {item}, {qty}, GETDATE(), @price)";
                ConsoleApplicationDBClasses.SingletonConnection.Instance.GetReader(sql);
            }
            catch (Exception e)
            {
                Label errorLabel = new Label();
                errorLabel.Text = "Unable to process transaction.";
            }

        }
    }
}
