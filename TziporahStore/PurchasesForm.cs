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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void allButton_Click(object sender, EventArgs e)
        {
            /*
            string sql = $"SELECT * FROM PURCHASE WHERE custID = (SELECT userID FROM CUSTOMER WHERE username" +
                         $"= '{LoginForm.username}')";
            var rs = ConsoleApplicationDBClasses.SingletonConnection.Instance.GetReader(sql);
           
            while (rs.Read())
            {
                try
                {
                    if (rs.GetString(0) == null)
                    {
                        label1.Text = "No Purchase History";
                    }
                    label1.Text += "\n" +  rs.GetString(0) + "\t " + rs.GetString(1) + "\t " + rs.GetString(2) + "\t "
                                   + rs.GetString(3);
                        label1.Visible = true;
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                    label1.Visible = true;
                }

            }
            label1.Visible = true;
            */
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
    }
}
