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

            btnFinanceInfo.Size = new Size(165, 45);
            btnVisitorsInfo.Size = new Size(165, 45);
            btnCampingInfo.Size = new Size(165, 45);
            btnProductsInfo.Size = new Size(165, 45);

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
            btnVisitorsInfo.BackgroundImage = AdminPanel.Properties.Resources.button_visitorsY;
            btnCampingInfo.BackgroundImage = AdminPanel.Properties.Resources.button_camping_sites;
            btnProductsInfo.BackgroundImage = AdminPanel.Properties.Resources.button_products;
            btnFinanceInfo.BackgroundImage  = AdminPanel.Properties.Resources.button_finance;

            btnVisitorsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnCampingInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnProductsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnFinanceInfo.BackgroundImageLayout = ImageLayout.Stretch;

            campingOverview.Hide();
            financeOverview.Hide();
            productsOverview.Hide();
            visitorsOverview.Hide();

            visitorsOverview = new VisitorsOverview();
            visitorsOverview.TopLevel = false;
            visitorsOverview.FormBorderStyle = FormBorderStyle.None;
            visitorsOverview.Dock = DockStyle.Fill;
            panelOverview.Size = visitorsOverview.Size;
            panelOverview.Controls.Add(visitorsOverview);
            visitorsOverview.Show();
        }

        private void btnCampingInfo_Click(object sender, EventArgs e)
        {
            btnVisitorsInfo.BackgroundImage = AdminPanel.Properties.Resources.button_visitors;
            btnCampingInfo.BackgroundImage = AdminPanel.Properties.Resources.button_camping_sitesY;
            btnProductsInfo.BackgroundImage = AdminPanel.Properties.Resources.button_products;
            btnFinanceInfo.BackgroundImage = AdminPanel.Properties.Resources.button_finance;

            btnVisitorsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnCampingInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnProductsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnFinanceInfo.BackgroundImageLayout = ImageLayout.Stretch;

            campingOverview.Hide();
            financeOverview.Hide();
            productsOverview.Hide();
            visitorsOverview.Hide();

            campingOverview = new CampingsOverview();
            campingOverview.TopLevel = false;
            campingOverview.FormBorderStyle = FormBorderStyle.None;
            campingOverview.Dock = DockStyle.Fill;
            panelOverview.Size = campingOverview.Size;
            panelOverview.Controls.Add(campingOverview);
            campingOverview.Show();
        }

        private void btnProductsInfo_Click(object sender, EventArgs e)
        {
            btnVisitorsInfo.BackgroundImage = AdminPanel.Properties.Resources.button_visitors;
            btnCampingInfo.BackgroundImage = AdminPanel.Properties.Resources.button_camping_sites;
            btnProductsInfo.BackgroundImage = AdminPanel.Properties.Resources.button_productsY;
            btnFinanceInfo.BackgroundImage = AdminPanel.Properties.Resources.button_finance;

            btnVisitorsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnCampingInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnProductsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnFinanceInfo.BackgroundImageLayout = ImageLayout.Stretch;

            campingOverview.Hide();
            financeOverview.Hide();
            productsOverview.Hide();
            visitorsOverview.Hide();

            productsOverview = new ProductsOverview();
            productsOverview.TopLevel = false;
            productsOverview.FormBorderStyle = FormBorderStyle.None;
            productsOverview.Dock = DockStyle.Fill;
            panelOverview.Size = productsOverview.Size;
            panelOverview.Controls.Add(productsOverview);
            productsOverview.Show();
        }

        private void btnFinanceInfo_Click(object sender, EventArgs e)
        {
            btnVisitorsInfo.BackgroundImage = AdminPanel.Properties.Resources.button_visitors;
            btnCampingInfo.BackgroundImage = AdminPanel.Properties.Resources.button_camping_sites;
            btnProductsInfo.BackgroundImage = AdminPanel.Properties.Resources.button_products;
            btnFinanceInfo.BackgroundImage = AdminPanel.Properties.Resources.button_financeY;

            btnVisitorsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnCampingInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnProductsInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnFinanceInfo.BackgroundImageLayout = ImageLayout.Stretch;

            campingOverview.Hide();
            financeOverview.Hide();
            productsOverview.Hide();
            visitorsOverview.Hide();

            financeOverview = new FinanceOverview();
            financeOverview.TopLevel = false;
            financeOverview.FormBorderStyle = FormBorderStyle.None;
            financeOverview.Dock = DockStyle.Fill;
            panelOverview.Size = financeOverview.Size;
            panelOverview.Controls.Add(financeOverview);
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
