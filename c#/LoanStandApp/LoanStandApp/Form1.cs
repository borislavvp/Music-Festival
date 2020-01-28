using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace LoanStandApp
{
    public partial class Form1 : Form
    {
        private RFID myRfid;
        Datahelper dh;
        int totalPrice = 0;
        bool hasItemsLoaned = false;
        int backpackQuantity = 0;
        int chargerQuantity = 0;
        int selfieStickQuantity = 0;
        int cameraQuantity = 0;
        

        string rfidCode = "";
        string problem = "no";
        public Form1()
        {
            InitializeComponent();

            lbCameraQuantity.Text = "LOADING..";
            lbChargerQuantity.Text = "LOADING..";
            lbBackpackQuantity.Text = "LOADING..";
            lbSelfieStickQuantity.Text = "LOADING..";

            pbBackpack.Hide();
            pbStick.Hide();
            pbCharger.Hide();
            pbCamera.Hide();


            lbCameraPrice.Hide();
            lbChargerPrice.Hide();
            lbBackpackPrice.Hide();
            lbStickPrice.Hide();

            lbLoanStatus.Text = "";

            timer1.Start();
            
        }

        private void btnScanRfid_Click(object sender, EventArgs e)
        {
                try
                {
                lbLoanStatus.Text = "";
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
            lbRfidStatus.Text = " Attached";
        }

        public void CheckUserRfid(object sender, RFIDTagEventArgs args)
        {
            rfidCode = args.Tag;
            dh = new Datahelper();
            string userName = dh.GetUserFirstNameWithRfid(rfidCode);
            if (userName != "")
            {
                List<string> itemsLoaned = dh.GetItemsLoanedByUser(rfidCode);
                string items = "";
                if (itemsLoaned.Count() == 0)
                {
                    lbRfidStatus.Text = userName + " has nothing loaned ";
                    lbRfidStatus.ForeColor = Color.Green;
                    hasItemsLoaned = false;
                }
                else
                {
                    for (int i = 0; i < itemsLoaned.Count; i+=2)
                    {
                        items += itemsLoaned[i + 1] + " " + itemsLoaned[i] + "s ,";
                    }
                    int end = items.LastIndexOf(",");
                    string resultOfItemsLoaned = items.Substring(0, end);

                    lbRfidStatus.Text = userName + " has to return " + resultOfItemsLoaned;
                    lbRfidStatus.ForeColor = Color.Crimson;
                    hasItemsLoaned = true;
                }
            }
            else
            {
                lbRfidStatus.Text = rfidCode;
            }
            myRfid.Close();
        }

        private void pbCharger_Click(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            lbReceipt.Items.Add("Charger - " + dh.GetPrdouctPrice("Charger") + "$");
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
            totalPrice += dh.GetPrdouctPrice("Charger");
            lbPrice.Text = totalPrice.ToString() + "$";
            chargerQuantity--;
            lbChargerQuantity.Text = chargerQuantity + "LEFT";
            
        }

        private void pbCamera_Click(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            lbReceipt.Items.Add("Camera - " + dh.GetPrdouctPrice("Camera") + "$");
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
            totalPrice += dh.GetPrdouctPrice("Camera"); 
            lbPrice.Text = totalPrice.ToString() + "$";
            cameraQuantity--;
            lbCameraQuantity.Text = cameraQuantity + "LEFT";
         
        }

        private void pbBackpack_Click(object sender, EventArgs e)
        {
           List<string> temp = new List<string>();
           lbReceipt.Items.Add("Backpack - " + dh.GetPrdouctPrice("Backpack") + "$");
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
           totalPrice += dh.GetPrdouctPrice("Backpack"); 
           lbPrice.Text = totalPrice.ToString() + "$";
           backpackQuantity--;
           lbBackpackQuantity.Text = backpackQuantity + "LEFT";
            

        }

        private void pbStick_Click(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            lbReceipt.Items.Add("SelfieStick - " + dh.GetPrdouctPrice("SelfieStick") + "$");
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
            totalPrice += dh.GetPrdouctPrice("SelfieStick"); 
            lbPrice.Text = totalPrice.ToString() + "$";
            selfieStickQuantity--;
            lbSelfieStickQuantity.Text = selfieStickQuantity + "LEFT";
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

                dh = new Datahelper();
                if (lbReceipt.SelectedItem.ToString() == "Backpack - 10$")
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    if (backpackQuantity < 0 )
                    {
                        backpackQuantity = 1;
                    }
                    else
                    {
                        backpackQuantity++;
                    }
                    lbBackpackQuantity.Text = backpackQuantity + "LEFT";
                    totalPrice -= dh.GetPrdouctPrice("Backpack");
                    lbPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "SelfieStick - 10$")
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    if (selfieStickQuantity < 0)
                    {
                        selfieStickQuantity = 1;
                    }
                    else
                    {
                        selfieStickQuantity++;
                    }
                    lbSelfieStickQuantity.Text = selfieStickQuantity + "LEFT";
                    totalPrice -= dh.GetPrdouctPrice("SelfieStick"); ;
                    lbPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Camera - 20$")
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    if (cameraQuantity < 0)
                    {
                        cameraQuantity = 1;
                    }
                    else
                    {
                        cameraQuantity++;
                    }
                    lbCameraQuantity.Text = cameraQuantity + "LEFT";
                    totalPrice -= dh.GetPrdouctPrice("Camera"); ;
                    lbPrice.Text = totalPrice.ToString() + "$";
                }
                else if (lbReceipt.SelectedItem.ToString() == "Charger - 5$")
                {
                    lbReceipt.Items.Remove(lbReceipt.SelectedItem);
                    if (chargerQuantity < 0)
                    {
                        chargerQuantity = 1;
                    }
                    else
                    {
                        chargerQuantity++;
                    }
                    lbChargerQuantity.Text = chargerQuantity + "LEFT";
                    totalPrice -= dh.GetPrdouctPrice("Charger"); ;
                    lbPrice.Text = totalPrice.ToString() + "$";
                }
            }
            catch(NullReferenceException)
            {
                lbLoanStatus.Text = "Please first select the item you want to remove !";
                lbLoanStatus.ForeColor = Color.Red;
            }
        }

        private void btnDamagedYes_Click(object sender, EventArgs e)
        {
            gbProblemBox.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (hasItemsLoaned == true)
            {
                problem = tbProblem.Text;
                if (problem == "")
                {
                    problem = "no";
                }
                dh = new Datahelper();

                List<string> itemsToReturn = new List<string>();
                foreach (string item in lbReceipt.Items)
                {
                    itemsToReturn.Add(item);
                }


                string status = dh.ReturnItem(rfidCode, problem, itemsToReturn);
                if (status == "nouser")
                {
                    lbLoanStatus.Text = "Invalid User!";
                    lbLoanStatus.ForeColor = Color.Red;
                    lbReceipt.Items.Clear();
                }
                else if (status == "returned")
                {
                    lbLoanStatus.Text = "Returned Successfully!";
                    lbLoanStatus.ForeColor = Color.Green;
                    List<string> items = new List<string>();
                    foreach (string item in lbReceipt.Items)
                    {
                        items.Add(item);
                    }
                    foreach (string item in items)
                    {
                        lbReceipt.SelectedItem = item;
                        if (item.Contains("Charger"))
                        {
                            chargerQuantity++;
                        }
                        else if (item.Contains("Backpack"))
                        {
                            backpackQuantity++;
                        }
                        else if (item.Contains("SelfieStick"))
                        {
                            selfieStickQuantity++;
                        }
                        else if (item.Contains("Camera"))
                        {
                            cameraQuantity++;
                        }
                        btnRemove.PerformClick();
                    }
                }

                tbProblem.Text = "";
                gbProblemBox.Enabled = false;
                lbPrice.Text = "";
                lbRfidStatus.Text = "";
                totalPrice = 0;
            }
            else
            {
                lbLoanStatus.Text = "This user has nothing to return !";
                lbLoanStatus.ForeColor = Color.Red;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (chargerQuantity < 0 )
            {
                lbLoanStatus.Text = "Sorry this item is out of stock !";
                lbLoanStatus.ForeColor = Color.Red;
            }
            else if (cameraQuantity < 0)
            {
                lbLoanStatus.Text = "Sorry this item is out of stock !";
                lbLoanStatus.ForeColor = Color.Red;
            }
            else if (selfieStickQuantity < 0)
            {
                lbLoanStatus.Text = "Sorry this item is out of stock !";
                lbLoanStatus.ForeColor = Color.Red;
            }
            else if (backpackQuantity < 0)
            {
                lbLoanStatus.Text = "Sorry this item is out of stock !";
                lbLoanStatus.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    if (lbRfidStatus.Text != "")
                    {

                        dh = new Datahelper();

                        List<string> itemsToLoan = new List<string>();
                        foreach (string item in lbReceipt.Items)
                        {
                            itemsToLoan.Add(item);
                        }

                        string status = dh.LoanItemToVisitor(rfidCode, itemsToLoan, totalPrice);
                        if (status == "nobalance")
                        {
                            lbLoanStatus.Text = "Not enough balance !";
                            lbLoanStatus.ForeColor = Color.Red;
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
                        else if (status == "nouser")
                        {
                            lbLoanStatus.Text = "Invalid User !";
                            lbLoanStatus.ForeColor = Color.Red;
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
                        else if (status == "added")
                        {
                            lbLoanStatus.Text = "Successfully Loaned !";
                            lbLoanStatus.ForeColor = Color.Green;
                            lbReceipt.Items.Clear();
                        }
                        else
                        {
                            lbLoanStatus.Text = "Something happened , please try again !";
                            lbLoanStatus.ForeColor = Color.Red;
                        }
                        lbRfidStatus.Text = "";
                        totalPrice = 0;
                        lbPrice.Text = "";
                    }
                    else
                    {
                        lbLoanStatus.Text = "Please Scan the Visitor's RFID Chip first !";
                        lbLoanStatus.ForeColor = Color.Red;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbBackpack.Show();
            pbStick.Show();
            pbCharger.Show();
            pbCamera.Show();

            dh = new Datahelper();

            lbCameraPrice.Text = dh.GetPrdouctPrice("Camera").ToString() + "$";
            lbChargerPrice.Text = dh.GetPrdouctPrice("Charger").ToString() + "$";
            lbBackpackPrice.Text = dh.GetPrdouctPrice("Backpack").ToString() + "$";
            lbStickPrice.Text = dh.GetPrdouctPrice("SelfieStick").ToString() + "$";

            lbCameraPrice.Show();
            lbChargerPrice.Show();
            lbBackpackPrice.Show();
            lbStickPrice.Show();

            backpackQuantity = dh.GetStockQuantityOfBackpack();
            cameraQuantity = dh.GetStockQuantityOfCamera();
            selfieStickQuantity = dh.GetStockQuantityOfSelfieStick();
            chargerQuantity = dh.GetStockQuantityOfCharger();
             
            if (backpackQuantity < 1)
            {
                lbBackpackQuantity.Text = "OUT OF STOCK";
                backpackQuantity = 0;
            }
            else
            {
                lbBackpackQuantity.Text = backpackQuantity + " LEFT";
            }

            if (cameraQuantity < 1)
            {
                lbCameraQuantity.Text = "OUT OF STOCK";
                cameraQuantity = 0;
            }
            else
            {
                lbCameraQuantity.Text = cameraQuantity + " LEFT";
            }

            if (selfieStickQuantity < 1)
            {
                lbSelfieStickQuantity.Text = "OUT OF STOCK";
                selfieStickQuantity = 0;
            }
            else
            {
                lbSelfieStickQuantity.Text = selfieStickQuantity + " LEFT";
            }

            if (chargerQuantity < 1)
            {
                lbChargerQuantity.Text = "OUT OF STOCK";
                chargerQuantity = 0;
            }
            else
            {
                lbChargerQuantity.Text = chargerQuantity + " LEFT";
            }
            timer1.Stop();
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
