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

namespace SystemEnter
{
    public partial class Form1 : Form
    {
        RFID myRfid;
        string rfidCode;
        Datahelper dh;
        string job_id = "";
        public Form1()
        {
            InitializeComponent();
            dh = new Datahelper();
            lbStatus.Text= "";
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
               myRfid = new RFID();

               myRfid.Attach += new AttachEventHandler(myRfidAttachMethod);
               myRfid.Tag += new RFIDTagEventHandler(CheckRfid);

               myRfid.Open();

            }
            catch (PhidgetException ex)
            {
                throw ex;
            }
        }
        public void myRfidAttachMethod(object sender, AttachEventArgs args)
        {
            lbStatus.Text = " Attached";
            lbStatus.ForeColor = Color.Black;
        }
        public void CheckRfid(object sender, RFIDTagEventArgs args)
        {
            rfidCode = args.Tag;
            myRfid.Close();
            string employeeName = dh.GetEmployeeName(rfidCode);
            job_id = dh.GetEmployeeJobId(rfidCode);

            if (job_id != "no" && job_id != "error")
            {
                if (job_id == "AD")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else if (job_id == "CE")
                {
                    CampingEntrance.Form1 campEntrForm = new CampingEntrance.Form1();
                    campEntrForm.Show();
                }
                else if (job_id == "EE")
                {
                    EventEntrance.Form1 eventEntrForm = new EventEntrance.Form1();
                    eventEntrForm.Show();
                }
                else if (job_id == "FS")
                {
                    FoodShop.Form1 foodShopForm = new FoodShop.Form1();
                    foodShopForm.Show();
                }
                else if (job_id == "LS")
                {
                    LoanStandApp.Form1 loanStandForm = new LoanStandApp.Form1();
                    loanStandForm.Show();
                }
                MessageBox.Show("Hello , " + employeeName + " !");
                lbStatus.Text = "Hello, " + employeeName + " !";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = "No employee with that RFID Chip !";
                lbStatus.ForeColor = Color.Red;
            }
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
            btnClose.BackgroundImage = Properties.Resources.close_greenB;
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

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightGreen;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
