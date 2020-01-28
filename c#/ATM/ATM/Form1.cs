using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ATM
{
    public partial class Form1 : Form
    {
        Datahelper dh;
        private RFID myRfid;
        int moneyToAdd = 0;
        int atmLogID = -1;
        string rfidCode = "";
        string logPath = @"C:\Users\bobkata\Desktop\UNI\PROP\FinalApp\c#\log.txt";
        public Form1()
        {
            InitializeComponent();
            lbVisitor.Text = "";
            File.WriteAllText(logPath, "");
            using (StreamWriter w = File.AppendText(logPath))
            {
                w.WriteLine("The bank number of the organizations is : NL91ABNA0417164300");
            }
        }
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  # {0}", logMessage);
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                lbAtmStatus.Text = "";
                lbVisitor.Text = "";
                myRfid = new RFID();

                myRfid.Attach += new AttachEventHandler(myRfidAttachMethod);
                myRfid.Tag += new RFIDTagEventHandler(CheckUserStatus);

                myRfid.Open();
            }
            catch (PhidgetException ex)
            {
                throw ex;
            }
        }

        public void myRfidAttachMethod(object sender, AttachEventArgs args)
        {
            lbVisitor.Text = " Attached";
            lbVisitor.ForeColor = Color.Black;
        }

        public void CheckUserStatus(object sender, RFIDTagEventArgs args)
        {
            rfidCode = args.Tag;
            dh = new Datahelper();
            string userName = dh.GetUserFirstNameWithRfid(rfidCode);
            if (userName != "")
            {
                atmLogID = dh.GetOrAssignAtmLogId(rfidCode);
                lbVisitor.Text = userName;
                lbVisitor.ForeColor = Color.Green;
            }
            else
            {
                lbVisitor.Text = "No user with that RFID";
                lbVisitor.ForeColor = Color.Red;
            }
            myRfid.Close();
        }

        private void btnAdd10_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbVisitor.Text != "" && lbVisitor.Text != "No user with that RFID")
                {
                    moneyToAdd = 10;
                    string VisitorName = lbVisitor.Text.Trim();
                    int userID = dh.userId;
                    if (atmLogID != -1)
                    {
                        using (StreamWriter w = File.AppendText(logPath))
                        {
                            Log(userID + " " + atmLogID + " " + VisitorName + " " + moneyToAdd, w);
                        }
                        lbAtmStatus.Text = "Successfully Added !";
                        lbAtmStatus.ForeColor = Color.Green;
                        lbVisitor.Text = "";
                    }
                    else
                    {
                        lbAtmStatus.Text = "Something happened, Please try again !";
                        lbAtmStatus.ForeColor = Color.Red;
                        lbVisitor.Text = "";
                    }
                }
                else
                {
                    lbAtmStatus.Text = "Please scan your RFID Chip First";
                    lbAtmStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAdd20_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbVisitor.Text != "" && lbVisitor.Text != "No user with that RFID")
                {
                    moneyToAdd = 20;
                    string VisitorName = lbVisitor.Text.Trim();
                    int userID = dh.userId;
                    if (atmLogID != -1)
                    {
                        using (StreamWriter w = File.AppendText(logPath))
                        {
                            Log(userID + " " + atmLogID + " " + VisitorName + " " + moneyToAdd, w);
                        }
                        lbAtmStatus.Text = "Successfully Added !";
                        lbAtmStatus.ForeColor = Color.Green;
                        lbVisitor.Text = "";
                    }
                    else
                    {
                        lbAtmStatus.Text = "Something happened, Please try again !";
                        lbAtmStatus.ForeColor = Color.Red;
                        lbVisitor.Text = "";
                    }
                }
                else
                {
                    lbAtmStatus.Text = "Please scan your RFID Chip First";
                    lbAtmStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAdd50_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbVisitor.Text != "" && lbVisitor.Text != "No user with that RFID")
                {
                    moneyToAdd = 50;
                    string VisitorName = lbVisitor.Text.Trim();
                    int userID = dh.userId;
                    if (atmLogID != -1)
                    {
                        using (StreamWriter w = File.AppendText(logPath))
                        {
                            Log(userID + " " + atmLogID + " " + VisitorName + " " + moneyToAdd, w);
                        }
                        lbAtmStatus.Text = "Successfully Added !";
                        lbAtmStatus.ForeColor = Color.Green;
                        lbVisitor.Text = "";
                    }
                    else
                    {
                        lbAtmStatus.Text = "Something happened, Please try again !";
                        lbAtmStatus.ForeColor = Color.Red;
                        lbVisitor.Text = "";
                    }
                }
                else
                {
                    lbAtmStatus.Text = "Please scan your RFID Chip First";
                    lbAtmStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbVisitor.Text != "" && lbVisitor.Text != "No user with that RFID")
                {
                    moneyToAdd = 100;
                    string VisitorName = lbVisitor.Text.Trim();
                    int userID = dh.userId;
                    if (atmLogID != -1)
                    {
                        using (StreamWriter w = File.AppendText(logPath))
                        {
                            Log(userID + " " + atmLogID + " " + VisitorName + " " + moneyToAdd, w);
                        }
                        lbAtmStatus.Text = "Successfully Added !";
                        lbAtmStatus.ForeColor = Color.Green;
                        lbVisitor.Text = "";
                    }
                    else
                    {
                        lbAtmStatus.Text = "Something happened, Please try again !";
                        lbAtmStatus.ForeColor = Color.Red;
                        lbVisitor.Text = "";
                    }
                }
                else
                {
                    lbAtmStatus.Text = "Please scan your RFID Chip First";
                    lbAtmStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAddOther_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbVisitor.Text != "" && lbVisitor.Text != "No user with that RFID")
                {
                    moneyToAdd = Convert.ToInt32(tbAmount.Text);
                    string VisitorName = lbVisitor.Text.Trim();
                    int userID = dh.userId;
                    if (atmLogID != -1)
                    {
                        using (StreamWriter w = File.AppendText(logPath))
                        {
                            Log(userID + " " + atmLogID + " " + VisitorName + " " + moneyToAdd, w);
                        }
                        lbAtmStatus.Text = "Successfully Added !";
                        lbAtmStatus.ForeColor = Color.Green;
                        lbVisitor.Text = "";
                    }
                    else
                    {
                        lbAtmStatus.Text = "Something happened, Please try again !";
                        lbAtmStatus.ForeColor = Color.Red;
                        lbVisitor.Text = "";
                    }
                    lbVisitor.Text = "";
                    tbAmount.Text = "";
                }
                else
                {
                    lbAtmStatus.Text = "Please scan your RFID Chip First";
                    lbAtmStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                lbAtmStatus.Text = "Invalid Amount !";
                lbAtmStatus.ForeColor = Color.Red;
            }
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
    }
}
