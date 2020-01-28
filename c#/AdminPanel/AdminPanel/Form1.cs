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
    public partial class Form1 : Form
    {
        VisitorsOverview visitorsOverview;
        CampingsOverview campingOverview;
        ProductsOverview productsOverview;
        FinanceOverview financeOverview;

        Datahelper dh;

        public Form1()
        {
            InitializeComponent();
            dh = new Datahelper();

            visitorsOverview = new VisitorsOverview();
            campingOverview = new CampingsOverview();
            productsOverview = new ProductsOverview();
            financeOverview = new FinanceOverview();

            lbCurrVisitors.Text = dh.GetPresentCount().ToString();
            lbProfit.Text = dh.GetTotalMoneySpent().ToString();
            lbProductsSold.Text = dh.GetTotalProductsSoldAndRent().ToString();
            lbCampTaken.Text = dh.GetCampingsBooked().ToString();
            timer1.Start();
        }

        private void btnVisitorsInfo_Click(object sender, EventArgs e)
        {
            visitorsOverview.Show();
        }

        private void btnCampingInfo_Click(object sender, EventArgs e)
        {
            campingOverview.Show();
        }

        private void btnProductsInfo_Click(object sender, EventArgs e)
        {
            productsOverview.Show();
        }

        private void btnFinanceInfo_Click(object sender, EventArgs e)
        {
            financeOverview.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbCurrVisitors.Text = dh.GetPresentCount().ToString();
            lbProfit.Text = dh.GetTotalMoneySpent().ToString();
            lbProductsSold.Text = dh.GetTotalProductsSoldAndRent().ToString();
            lbCampTaken.Text = dh.GetCampingsBooked().ToString();
        }
    }
}
