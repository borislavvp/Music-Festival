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

namespace CampingEntrance
{
    public partial class Form1 : Form
    {
        private RFID myRfid;
        Datahelper dh;
        RegistrationForm regFrom;
        string rfidCode = "";
       
        
        public Form1()
        {
            InitializeComponent();
            lbVisitorStatus.Text = "";
            lbVisitorName.Text = "";
            lbCheckStatus.Text = "";


        }
        

        public void myRfidAttachMethod(object sender, AttachEventArgs args)
        {
            lbVisitorName.Text = " Attached";
        }

        private void btnScanVisitor_Click(object sender, EventArgs e)
        {

            lbCheckStatus.Text = "";
            lbVisitorStatus.Text = "";
            lbVisitorName.Text = "";
            myRfid = new RFID();

            myRfid.Attach += new AttachEventHandler(myRfidAttachMethod);
            myRfid.Tag += new RFIDTagEventHandler(CheckUserStatus);

            myRfid.Open();
        }
        

        public void CheckUserStatus(object sender, RFIDTagEventArgs args)
        {
            rfidCode = args.Tag;
            dh = new Datahelper();
            string userName = dh.GetUserFirstNameWithRfid(rfidCode);
           
            if (userName != "")
            {
                lbVisitorName.Text = userName +" :";
                string status = dh.GetCampingStatusWithRfid(rfidCode);
                if (status == "in")
                {
                    lbVisitorStatus.Text = "is in the camping area";
                }
                else if (status == "out")
                {
                    lbVisitorStatus.Text = "is not in the camping area";
                }
                else if (status == "nocamp")
                {
                    lbVisitorStatus.Text = "No camping spot";
                }
                else if (status == "error")
                {
                    lbVisitorStatus.Text = "Error";
                }
                else
                {
                    lbVisitorStatus.Text = status;
                }
            }
            else
            {
                lbVisitorStatus.Text = "";
                lbVisitorName.Text = "No user with that RFID";
            }
            myRfid.Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                string status = dh.CheckInVisitor();
                if (status == "in")
                {
                    lbCheckStatus.Text = "This visitor is already at the Camping Area";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                else if (status == "Checked")
                {
                    lbCheckStatus.Text = "Checked In !";
                    lbCheckStatus.ForeColor = Color.Green;
                }
                else if (status == "Erorr")
                {
                    lbCheckStatus.Text = "Something happened ! Try again !";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                else if (status == "nocamp")
                {
                    lbCheckStatus.Text = "This visitor doesnt have a Camping Spot Purchased !";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                else if (status == "nouser")
                {
                    lbCheckStatus.Text = "Error !";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                else if (status == "notatevent")
                {
                    lbCheckStatus.Text = "This visitor is not at the event";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                lbVisitorStatus.Text = "";
                lbVisitorName.Text = "";
            }
            catch (NullReferenceException ex)
            {
                lbCheckStatus.Text = "Database error !";
                lbCheckStatus.ForeColor = Color.Red;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                string status = dh.CheckOutVisitor();
                if (status == "out")
                {
                    lbCheckStatus.Text = "This visitor is not at the Camping Area";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                else if (status == "Checked")
                {
                    lbCheckStatus.Text = "Checked Out !";
                    lbCheckStatus.ForeColor = Color.Green;
                }
                else if (status == "Erorr")
                {
                    lbCheckStatus.Text = "Something happened ! Try again !";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                else if (status == "nocamp")
                {
                    lbCheckStatus.Text = "This visitor doesnt have a Camping Spot Purchased !";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                else if (status == "nouser")
                {
                    lbCheckStatus.Text = "Error !";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                else if (status == "notatevent")
                {
                    lbCheckStatus.Text = "This visitor is not at the event";
                    lbCheckStatus.ForeColor = Color.Red;
                }
                lbVisitorStatus.Text = "";
                lbVisitorName.Text = "";
            }
            catch (NullReferenceException ex)
            { 
                lbCheckStatus.Text = "Database error !";
                lbCheckStatus.ForeColor = Color.Red;
            }
        }

        private void btnOpenRegistrationForm_Click(object sender, EventArgs e)
        {
            regFrom = new RegistrationForm();
            regFrom.Show();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
