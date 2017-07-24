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
    public partial class ItemsForSale : Form
    {
        public ItemsForSale()
        {
            InitializeComponent();
        }

        private void LoadLabels()
        {
            using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                for (int i = 0; i < context.Items.Count(); i++)
                {
                    Button item = (Button) Controls.Find("label" + i, true).FirstOrDefault();
                    item.Text = context.Items.Where(it => it.itemID == i).Select(it => it.descript).ToString();
                    Label price = (Label) Controls.Find("button" + i, true).FirstOrDefault();
                    price.Text = context.Items.Where(it => it.itemID == i).Select(it => it.price).ToString();

                }
            }
        }

        private void ItemsForSale_Load(object sender, EventArgs e)
        {

        }
    }
}
