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
            
        }
    }
}
