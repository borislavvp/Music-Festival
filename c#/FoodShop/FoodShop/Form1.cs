using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;

namespace FoodShop
{
    public partial class Form1 : Form
    {
        RFID myRfid;
        Datahelper dh;
        string rfidCode = "";
        int totalPrice = 0;

        int tShirtQuantity = 0;
        int magnetQuantity = 0;
        int keyChainQuantity = 0;
        int burgerQuantity = 0;
        int pancakesQuantity = 0;
        int iceCreamQuantity = 0;
        int colaQuantity = 0;
        int iceTeaQuantity = 0;
        int beerQuantity = 0;
        public Form1()
        {
            InitializeComponent();
            dh = new Datahelper();
            timer1.Start();

            lbBeerPrice.Text = "";
            lbBurgerPrice.Text = "";
            lbCokePrice.Text = "";
            lbIceCreamPrice.Text = "";
            lbIceTeaPrice.Text = "";
            lbKeyChainPrice.Text = "";
            lbMagnetPrice.Text = "";
            lbPancakesPrice.Text = "";
            lbTshirtPrice.Text = "";

            pbIceCream.Hide();
            pbBurger.Hide();
            pbPancakes.Hide();
            pbBeer.Hide();
            pbIceTea.Hide();
            pbCola.Hide();
            btnKeyChain.Hide();
            btnTShirt.Hide();
            btnMagnet.Hide();

            gbDrinks.Hide();
            gbSouvenirs.Hide();
            gbFood.Hide();
        }

        private void btnSouvenirs_Click(object sender, EventArgs e)
        {
            btnFood.BackgroundImage = Properties.Resources.button_food;
            btnSouvenirs.BackgroundImage = Properties.Resources.button_souvenirsY;
            btnDrinks.BackgroundImage = Properties.Resources.button_drinks1;

            btnFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnSouvenirs.BackgroundImageLayout = ImageLayout.Stretch;
            btnDrinks.BackgroundImageLayout = ImageLayout.Stretch;

            gbDrinks.Hide();
            gbFood.Hide();
            gbSouvenirs.Show();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            btnFood.BackgroundImage = Properties.Resources.button_food;
            btnSouvenirs.BackgroundImage = Properties.Resources.button_souvenirs_1_;
            btnDrinks.BackgroundImage = Properties.Resources.button_drinksY;

            btnFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnSouvenirs.BackgroundImageLayout = ImageLayout.Stretch;
            btnDrinks.BackgroundImageLayout = ImageLayout.Stretch;

            gbFood.Hide();
            gbSouvenirs.Hide();
            gbDrinks.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            btnFood.BackgroundImage = Properties.Resources.button_foodY;
            btnSouvenirs.BackgroundImage = Properties.Resources.button_souvenirs_1_;
            btnDrinks.BackgroundImage = Properties.Resources.button_drinks1;

            btnFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnSouvenirs.BackgroundImageLayout = ImageLayout.Stretch;
            btnDrinks.BackgroundImageLayout = ImageLayout.Stretch;

            gbDrinks.Hide();
            gbSouvenirs.Hide();
            gbFood.Show();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                lbPurchaseStatus.Text = "";
                myRfid = new RFID();

                myRfid.Attach += new AttachEventHandler(myRfidAttachMethod);
                myRfid.Tag += new RFIDTagEventHandler(CheckUserRfid);

                myRfid.Open();
            }
            catch (PhidgetException ex)
            {
                throw ex;
            }
        }

        public void myRfidAttachMethod(object sender, AttachEventArgs args)
        {
            lbVisitorName.Text = " Attached";
        }

        public void CheckUserRfid(object sender, RFIDTagEventArgs args)
        {
            rfidCode = args.Tag;
            Datahelper dh = new Datahelper();
            string userName = dh.GetUserFirstNameWithRfid(rfidCode);
            if (userName != "")
            {
                lbVisitorName.Text = userName;
            }
            else
            {
                lbVisitorName.Text = rfidCode;
            }
            myRfid.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tShirtQuantity = dh.GetBoughtQuantity("T-Shirt");
            magnetQuantity = dh.GetBoughtQuantity("Magnet");
            keyChainQuantity = dh.GetBoughtQuantity("Chain-Tag");
            burgerQuantity = dh.GetBoughtQuantity("Burger");
            pancakesQuantity = dh.GetBoughtQuantity("Pancakes");
            iceCreamQuantity = dh.GetBoughtQuantity("Ice Cream");
            colaQuantity = dh.GetBoughtQuantity("Cola");
            iceTeaQuantity = dh.GetBoughtQuantity("IceTea");
            beerQuantity = dh.GetBoughtQuantity("Beer");

            lbBeerPrice.Text = dh.GetPrdouctPrice("Beer") + " $";
            lbBurgerPrice.Text = dh.GetPrdouctPrice("Burger") + " $";
            lbCokePrice.Text = dh.GetPrdouctPrice("Cola") + " $";
            lbIceCreamPrice.Text = dh.GetPrdouctPrice("Ice Cream") + " $";
            lbIceTeaPrice.Text = dh.GetPrdouctPrice("IceTea") + " $";
            lbKeyChainPrice.Text = dh.GetPrdouctPrice("Chain-Tag") + " $";
            lbMagnetPrice.Text = dh.GetPrdouctPrice("Magnet") + " $";
            lbPancakesPrice.Text = dh.GetPrdouctPrice("Pancakes") + " $";
            lbTshirtPrice.Text = dh.GetPrdouctPrice("T-Shirt") + " $";

            if (tShirtQuantity < 1)
            {
                lbTShirtStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbTShirtStockQuantity.Text = tShirtQuantity + " LEFT";
            }

            if (magnetQuantity < 1)
            {
                lbMagnetStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbMagnetStockQuantity.Text = magnetQuantity + " LEFT";
            }

            if (keyChainQuantity < 1)
            {
                lbKeyChainStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbKeyChainStockQuantity.Text = keyChainQuantity + " LEFT";
            }

            if (burgerQuantity < 1)
            {
                lbBurgerStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbBurgerStockQuantity.Text = burgerQuantity + " LEFT";
            }

            if (pancakesQuantity < 1)
            {
                lbPancakesStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbPancakesStockQuantity.Text = pancakesQuantity + " LEFT";
            }

            if (iceCreamQuantity < 1)
            {
                lbIceCreamStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbIceCreamStockQuantity.Text = iceCreamQuantity + " LEFT";
            }

            if (colaQuantity < 1)
            {
                lbColaStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbColaStockQuantity.Text = colaQuantity + " LEFT";
            }

            if (iceTeaQuantity < 1)
            {
                lbIceTeaStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbIceTeaStockQuantity.Text = iceTeaQuantity + " LEFT";
            }

            if (beerQuantity < 1)
            {
                lbBeerStockQuantity.Text = "OUT OF";
            }
            else
            {
                lbBeerStockQuantity.Text = beerQuantity + " LEFT";
            }
            pbIceCream.Show();
            pbBurger.Show();
            pbPancakes.Show();
            pbBeer.Show();
            pbIceTea.Show();
            pbCola.Show();
            btnKeyChain.Show();
            btnTShirt.Show();
            btnMagnet.Show();
            timer1.Stop();
        }
        private int GetProductPrice(string product)
        {
            int end = product.LastIndexOf("$");
            int productPrice =Convert.ToInt32(product.Substring(0, end).TrimEnd());
            return productPrice;
        }
        private void pbIceCream_Click(object sender, EventArgs e)
        {
            if (iceCreamQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("Ice Cream - " + lbIceCreamPrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbIceCreamPrice.Text); ;
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                iceCreamQuantity--;
                lbIceCreamStockQuantity.Text = iceCreamQuantity + "LEFT";
            }
           
        }

        private void pbPancakes_Click(object sender, EventArgs e)
        {
            if (pancakesQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("Pancakes - " + lbPancakesPrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbPancakesPrice.Text); ;
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                pancakesQuantity--;
                lbPancakesStockQuantity.Text = pancakesQuantity + "LEFT";
            }
        }

        private void pbBurger_Click(object sender, EventArgs e)
        {
            if (burgerQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("Burger - " + lbBurgerPrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbBurgerPrice.Text); ;
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                burgerQuantity--;
                lbBurgerStockQuantity.Text = burgerQuantity + "LEFT";
            }
        }

        private void btnTShirt_Click(object sender, EventArgs e)
        {
            if (tShirtQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("T-Shirt - " + lbTshirtPrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbTshirtPrice.Text); ;
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                tShirtQuantity--;
                lbTShirtStockQuantity.Text = tShirtQuantity + "LEFT";
            }
        }

        private void btnMagnet_Click(object sender, EventArgs e)
        {
            if (magnetQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("Magnet - "+lbMagnetPrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbMagnetPrice.Text); ;
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                magnetQuantity--;
                lbMagnetStockQuantity.Text = magnetQuantity + "LEFT";
            }
        }

        private void btnKeyChain_Click(object sender, EventArgs e)
        {
            if (keyChainQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("Chain-Tag - " + lbKeyChainPrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbKeyChainPrice.Text); ;
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                keyChainQuantity--;
                lbKeyChainStockQuantity.Text = keyChainQuantity + "LEFT";
            }
        }

        private void pbBeer_Click(object sender, EventArgs e)
        {
            if (beerQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("Beer - " + lbBeerPrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbBeerPrice.Text);
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                beerQuantity--;
                lbBeerStockQuantity.Text = beerQuantity + "LEFT";
            }
        }

        private void pbCola_Click(object sender, EventArgs e)
        {
            if (colaQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("Cola - " + lbCokePrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbCokePrice.Text);
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                colaQuantity--;
                lbColaStockQuantity.Text = colaQuantity + "LEFT";
            }
        }

        private void pbIceTea_Click(object sender, EventArgs e)
        {
            if (iceTeaQuantity == 0)
            {
                lbPurchaseStatus.Text = "Sorry this item is out of stock !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
            else
            {
                List<string> temp = new List<string>();
                lbReceipt.Items.Add("IceTea - " + lbIceTeaPrice.Text);
                foreach (string item in lbReceipt.Items)
                {
                    temp.Add(item);
                }
                temp.Sort();
                lbReceipt.Items.Clear();
                foreach (string item in temp)
                {
                    lbReceipt.Items.Add(item);
                }
                totalPrice += GetProductPrice(lbIceTeaPrice.Text);
                lbTotalPrice.Text = totalPrice.ToString() + "$";
                iceTeaQuantity--;
                lbIceTeaStockQuantity.Text = iceTeaQuantity + "LEFT";
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

            List<string> itemsToSell = new List<string>();
            foreach (string item in lbReceipt.Items)
            {
                itemsToSell.Add(item);
            }

            string status = dh.SellItemToVisitor(rfidCode, itemsToSell, totalPrice);
            if (status == "added")
            {
                lbPurchaseStatus.Text = "Successfully Sold !";
                lbPurchaseStatus.ForeColor = Color.Green;
            }
            else if (status == "nouser")
            {
                lbPurchaseStatus.Text = "There is no user with that RFID !";
                lbPurchaseStatus.ForeColor = Color.Red;
                List<string> items = new List<string>();
                foreach (string item in lbReceipt.Items)
                {
                    items.Add(item);
                }
                foreach (string item in items)
                {
                    lbReceipt.SelectedItem = item;
                    btnRemove.PerformClick();
                }
            }
            else if (status == "nobalance")
            {
                lbPurchaseStatus.Text = "Not enough balance !";
                lbPurchaseStatus.ForeColor = Color.Red;
                List<string> items = new List<string>();
                foreach (string item in lbReceipt.Items)
                {
                    items.Add(item);
                }
                foreach (string item in items)
                {
                    lbReceipt.SelectedItem = item;
                    btnRemove.PerformClick();
                }
            }
            else
            {
                MessageBox.Show(status);
            }
            totalPrice = 0;
            lbTotalPrice.Text = totalPrice.ToString();
            lbReceipt.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbReceipt.SelectedItem.ToString() == "IceTea - " + lbIceTeaPrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    iceTeaQuantity++;
                    lbIceTeaStockQuantity.Text = iceTeaQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbIceTeaPrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Ice Cream - " + lbIceCreamPrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    iceCreamQuantity++;
                    lbIceCreamStockQuantity.Text = iceTeaQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbIceCreamPrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Burger - " + lbBurgerPrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    burgerQuantity++;
                    lbBurgerStockQuantity.Text = burgerQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbBurgerPrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Beer - " + lbBeerPrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    beerQuantity++;
                    lbBeerStockQuantity.Text = beerQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbBeerPrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "T-Shirt - " + lbTshirtPrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    tShirtQuantity++;
                    lbTShirtStockQuantity.Text = tShirtQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbTshirtPrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Magnet - " + lbMagnetPrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    magnetQuantity++;
                    lbMagnetStockQuantity.Text = magnetQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbMagnetPrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Cola - " + lbCokePrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    colaQuantity++;
                    lbColaStockQuantity.Text = colaQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbCokePrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Chain-Tag - " + lbKeyChainPrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    keyChainQuantity++;
                    lbKeyChainStockQuantity.Text = keyChainQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbKeyChainPrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Pancakes - " + lbPancakesPrice.Text)
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    pancakesQuantity++;
                    lbPancakesStockQuantity.Text = pancakesQuantity + "LEFT";
                    totalPrice -= GetProductPrice(lbPancakesPrice.Text);
                    lbTotalPrice.Text = totalPrice.ToString() + "$";
                }
            }
            catch (NullReferenceException)
            {
                lbPurchaseStatus.Text = "Please first select the item you want to remove !";
                lbPurchaseStatus.ForeColor = Color.Red;
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.btnClose_Hover_tr;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_greenBTR;
        }

        public void HideLogo()
        {
            pictureBox1.Hide();
        }
        public void HideCloseBtn()
        {
            this.btnClose.Hide();
        }
    }
}
