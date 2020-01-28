using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
    public partial class ProductsOverview : Form
    {
        Datahelper db = new Datahelper();
        public ProductsOverview()
        {
            InitializeComponent();

            foreach (string item in db.GetProductsForSelling())
            {
                cbProductsSold.Items.Add(item);
            }
            foreach (string item in db.GetProductsForRenting())
            {
                cbProductsLoaned.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quantity = db.GetBoughtQuantity(cbProductsSold.SelectedItem.ToString()).ToString();
            label10.Text = quantity;
            int product_price = db.GetPrdouctPrice(cbProductsSold.SelectedItem.ToString());
            int prdouct_quantity = int.Parse(label10.Text);
            label11.Text =  (prdouct_quantity * product_price).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string quantity = db.GetRentQuantity(cbProductsLoaned.SelectedItem.ToString()).ToString();
            label8.Text = quantity;
            int product_price = db.GetRentPrdouctPrice(cbProductsLoaned.SelectedItem.ToString());
            int prdouct_quantity = int.Parse(label8.Text);
            label9.Text = (prdouct_quantity * product_price).ToString();

        }
    }
}
