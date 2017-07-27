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
    public partial class PurchasesForm : Form
    {
        public PurchasesForm()
        {
            InitializeComponent();
        }

        private void dateButton_Click(object sender, EventArgs e)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                label1.Visible = true;
                label1.Text = "PurchaseID     CustomerID ItemNo     Quantity PurchaseDate               Price";
        var all = context.Purchases.Where(p => p.Customer.username == LoginForm.username)
                    .Where(p => p.purchaseDate >= beginDate.Value && p.purchaseDate <= endDate.Value)
                    .ToList();
                if (!all.Any())
                {
                    label1.Text = "No Purchase History";
                }
                else
                {
                    foreach (Purchase a in all)
                    {
                        label1.Text += "\n" + a.purchaseID + "                    " + a.custID
                                       + "                    " + a.itemNo +
                                       "                    " + a.quantity + "     " + a.purchaseDate + "     " + a.price;
                    }
                }

            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
           
            //fill label1 with results of query to get all purchases
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                /*
                var custID = context.Customers.Where(c => c.username == LoginForm.username)
                    .Select(c => c.userID)
                    .FirstOrDefault();
                */
                label1.Visible = true;
                var all = context.Purchases.Where(p => p.Customer.username == LoginForm.username).ToList();
                if (!all.Any())
                {
                    label1.Text = "No Purchase History";
                }
                else
                {
                    foreach (Purchase a in all)
                    {
                        label1.Text += "\n" + a.purchaseID + "                    " + a.custID
                            + "                    " + a.itemNo + 
                            "                    " + a.quantity + "     " + a.purchaseDate + "     " + a.price;
                    }
                }
               
            }
        }

        private void PurchasesForm_Load(object sender, EventArgs e)
        {

        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                label1.Visible = true;
                label1.Text = "PurchaseID     CustomerID ItemNo     Quantity PurchaseDate               Price";
                var all = context.Purchases.Where(p => p.Customer.username == LoginForm.username)
                    .Where(p => p.price >= minPrice.Value && p.price <= maxPrice.Value)
                    .ToList();
                if (!all.Any())
                {
                    label1.Text = "No Purchase History";
                }
                else
                {
                    foreach (Purchase a in all)
                    {
                        label1.Text += "\n" + a.purchaseID + "                    " + a.custID
                                       + "                    " + a.itemNo +
                                       "                    " + a.quantity + "     " + a.purchaseDate + "     " + a.price;
                    }
                }

            }
        }
    }
}
