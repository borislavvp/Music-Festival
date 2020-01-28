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
    public partial class FinanceOverview : Form
    {
        Datahelper db = new Datahelper();
        public FinanceOverview()
        {
            InitializeComponent();
            textBox3.Text = db.GetTotalMoneySpent().ToString() + "$";
            textBox1.Text = db.GetTotalBalance().ToString();
            textBox4.Text = db.GetCampingsBooked().ToString();
            textBox5.Text = db.GetTotalAmountCampings().ToString() + "$";
            tbRentShop.Text = db.GetRentShopMoneyEarned().ToString() + "$";
            tbFoodShop.Text = db.GetFoodShopAmountEarned().ToString() + "$";
            tbSouvenirShop.Text = db.GetSouvernirShopAmountEarned().ToString() + "$";

           
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = db.GetTotalMoneySpent().ToString() + "$";
            textBox1.Text = db.GetTotalBalance().ToString();
            textBox4.Text = db.GetCampingsBooked().ToString();
            textBox5.Text = db.GetTotalAmountCampings().ToString() + "$";
            tbRentShop.Text = db.GetRentShopMoneyEarned().ToString() + "$";
            tbFoodShop.Text = db.GetFoodShopAmountEarned().ToString() + "$";
            tbSouvenirShop.Text = db.GetSouvernirShopAmountEarned().ToString() + "$";
        }
        
    }
}
