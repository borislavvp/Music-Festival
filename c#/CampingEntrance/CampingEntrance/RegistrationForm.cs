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

namespace CampingEntrance
{
    public partial class RegistrationForm : Form
    {
        private RFID myRfid;
        Datahelper dh;
        string rfidCode = "";

        int spotNo = 0;
        int visitor1Id = 0;
        int visitor2Id = 0;
        int visitor3Id = 0;
        int visitor4Id = 0;
        int visitor5Id = 0;
        int visitor6Id = 0;
        

        Size pbSize = new Size(68, 50);
        public RegistrationForm()
        {
            InitializeComponent();

            lbRegistrationStatus.Text = "";

            lbVisitor1Name.Text = "";
            lbVisitor2Name.Text = "";
            lbVisitor3Name.Text = "";
            lbVisitor4Name.Text = "";
            lbVisitor5Name.Text = "";
            lbVisitor6Name.Text = "";
        }

        private void btnScanForRegister_Click(object sender, EventArgs e)
        {
            lbRegistrationStatus.Text = "";
            myRfid = new RFID();

            myRfid.Attach += new AttachEventHandler(myRfidAttachMethod);
            myRfid.Tag += new RFIDTagEventHandler(CheckUserForRegister);

            myRfid.Open();
        }

        public void myRfidAttachMethod(object sender, AttachEventArgs args)
        {
            lbRfidStatus.Text = "ATTACHED";
        }

        public void CheckUserForRegister(object sender, RFIDTagEventArgs args)
        {
            rfidCode = args.Tag;

            dh = new Datahelper();
            string userName = dh.GetUserFirstNameWithRfid(rfidCode);
            if (userName != "")
            {
                if (lbVisitor1Name.Text != "")
                {
                    if (lbVisitor2Name.Text != "")
                    {
                        if (lbVisitor3Name.Text != "")
                        {
                            if (lbVisitor4Name.Text != "")
                            {
                                if (lbVisitor5Name.Text != "")
                                {
                                    if (lbVisitor6Name.Text != "")
                                    {
                                        lbRegistrationStatus.Text = "All visitors are checked ! Proceed to registration !";
                                        lbRegistrationStatus.ForeColor = Color.Purple;
                                    }
                                    else
                                    {
                                        lbVisitor6Name.Text = userName;
                                        visitor6Id = dh.GetUserIdWithRfid(rfidCode);
                                    }
                                }
                                else
                                {
                                    lbVisitor5Name.Text = userName;
                                    visitor5Id = dh.GetUserIdWithRfid(rfidCode);
                                }
                            }
                            else
                            {
                                lbVisitor4Name.Text = userName;
                                visitor4Id = dh.GetUserIdWithRfid(rfidCode);
                            }
                        }
                        else
                        {
                            lbVisitor3Name.Text = userName;
                            visitor3Id = dh.GetUserIdWithRfid(rfidCode);
                        }
                    }
                    else
                    {
                        lbVisitor2Name.Text = userName;
                        visitor2Id = dh.GetUserIdWithRfid(rfidCode);
                    }
                }
                else
                {
                    lbVisitor1Name.Text = userName;
                    visitor1Id = dh.GetUserIdWithRfid(rfidCode);
                }
            }
            else
            {
                lbRfidStatus.Text = "No user with that RFID";
            }
            myRfid.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dh = new Datahelper();
            dh.CheckAvailableCampingSpots();
            if (dh.spots.Count == 0)
            {
                lbRegistrationStatus.Text = "No Camping Spots Left !";
                lbRegistrationStatus.ForeColor = Color.Red;
            }
            if (!dh.spots.Contains("1"))
            {
                pb1.Hide();
            }
            else
            {
                pb1.Show();
            }

            if (!dh.spots.Contains("2"))
            {
                pb2.Hide();
            }
            else
            {
                pb2.Show();
            }

            if (!dh.spots.Contains("3"))
            {
                pb3.Hide();
            }
            else
            {
                pb3.Show();
            }

            if (!dh.spots.Contains("4"))
            {
                pb4.Hide();
            }
            else
            {
                pb4.Show();
            }

            if (!dh.spots.Contains("5"))
            {
                pb5.Hide();
            }
            else
            {
                pb5.Show();
            }

            if (!dh.spots.Contains("6"))
            {
                pb6.Hide();
            }
            else
            {
                pb6.Show();
            }

            if (!dh.spots.Contains("7"))
            {
                pb7.Hide();
            }
            else
            {
                pb7.Show();
            }

            if (!dh.spots.Contains("8"))
            {
                pb8.Hide();
            }
            else
            {
                pb8.Show();
            }
        }

        private void btnRegisterCampGroup_Click(object sender, EventArgs e)
        {
            if (visitor1Id != 0 && visitor2Id != 0 && visitor3Id != 0 && visitor4Id != 0 && visitor5Id != 0 && visitor6Id != 0 && spotNo != 0)
            {
                string status = dh.RegisterCampingGroup(visitor1Id, visitor2Id, visitor3Id, visitor4Id, visitor5Id, visitor6Id, spotNo);
                if (status == "registered")
                {
                    lbRegistrationStatus.Text = "Regirestered Successfully";
                    lbRegistrationStatus.ForeColor = Color.Green;
                }
                else if (status == "Error")
                {
                    lbRegistrationStatus.Text = "Something happened . Try again !";
                    lbRegistrationStatus.ForeColor = Color.Red;
                    
                }
                else
                {
                    lbRegistrationStatus.Text = status;
                    lbRegistrationStatus.ForeColor = Color.Red;
                }
                lbVisitor1Name.Text = "";
                lbVisitor2Name.Text = "";
                lbVisitor3Name.Text = "";
                lbVisitor4Name.Text = "";
                lbVisitor5Name.Text = "";
                lbVisitor6Name.Text = "";
            }
            else
            {
                if (spotNo == 0)
                {
                    lbRegistrationStatus.Text = "Choose a Camping Spot !";
                    lbRegistrationStatus.ForeColor = Color.Red;
                }
                if (visitor1Id == 0 || visitor2Id == 0 || visitor3Id == 0 || visitor4Id == 0 || visitor5Id == 0 || visitor6Id == 0)
                {
                    lbRegistrationStatus.Text = "Correct the User Data !";
                    lbRegistrationStatus.ForeColor = Color.Red;

                    lbVisitor1Name.Text = "";
                    lbVisitor2Name.Text = "";
                    lbVisitor3Name.Text = "";
                    lbVisitor4Name.Text = "";
                    lbVisitor5Name.Text = "";
                    lbVisitor6Name.Text = "";
                }
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            spotNo = 1;
            pb1.Image = CampingEntrance.Properties.Resources.button1Y1;
            pb2.Image = CampingEntrance.Properties.Resources.button_2_;
            pb3.Image = CampingEntrance.Properties.Resources.button_3_;
            pb4.Image = CampingEntrance.Properties.Resources.button_4_;
            pb5.Image = CampingEntrance.Properties.Resources.button_5_;
            pb6.Image = CampingEntrance.Properties.Resources.button_6_;
            pb7.Image = CampingEntrance.Properties.Resources.button_7_;
            pb8.Image = CampingEntrance.Properties.Resources.button_8_;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            spotNo = 2;
            pb1.Image = CampingEntrance.Properties.Resources.button;
            pb2.Image = CampingEntrance.Properties.Resources.buttonY2;
            pb3.Image = CampingEntrance.Properties.Resources.button_3_;
            pb4.Image = CampingEntrance.Properties.Resources.button_4_;
            pb5.Image = CampingEntrance.Properties.Resources.button_5_;
            pb6.Image = CampingEntrance.Properties.Resources.button_6_;
            pb7.Image = CampingEntrance.Properties.Resources.button_7_;
            pb8.Image = CampingEntrance.Properties.Resources.button_8_;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            spotNo = 3;
            pb3.Image = CampingEntrance.Properties.Resources.buttonY3;
            pb2.Image = CampingEntrance.Properties.Resources.button_2_;
            pb1.Image = CampingEntrance.Properties.Resources.button;
            pb4.Image = CampingEntrance.Properties.Resources.button_4_;
            pb5.Image = CampingEntrance.Properties.Resources.button_5_;
            pb6.Image = CampingEntrance.Properties.Resources.button_6_;
            pb7.Image = CampingEntrance.Properties.Resources.button_7_;
            pb8.Image = CampingEntrance.Properties.Resources.button_8_;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            spotNo = 4;
            pb4.Image = CampingEntrance.Properties.Resources.buttonY4;
            pb2.Image = CampingEntrance.Properties.Resources.button_2_;
            pb3.Image = CampingEntrance.Properties.Resources.button_3_;
            pb1.Image = CampingEntrance.Properties.Resources.button;
            pb5.Image = CampingEntrance.Properties.Resources.button_5_;
            pb6.Image = CampingEntrance.Properties.Resources.button_6_;
            pb7.Image = CampingEntrance.Properties.Resources.button_7_;
            pb8.Image = CampingEntrance.Properties.Resources.button_8_;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            spotNo = 5;
            pb5.Image = CampingEntrance.Properties.Resources.buttonY5;
            pb2.Image = CampingEntrance.Properties.Resources.button_2_;
            pb3.Image = CampingEntrance.Properties.Resources.button_3_;
            pb4.Image = CampingEntrance.Properties.Resources.button_4_;
            pb1.Image = CampingEntrance.Properties.Resources.button;
            pb6.Image = CampingEntrance.Properties.Resources.button_6_;
            pb7.Image = CampingEntrance.Properties.Resources.button_7_;
            pb8.Image = CampingEntrance.Properties.Resources.button_8_;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            spotNo = 6;
            pb6.Image = CampingEntrance.Properties.Resources.buttonY6;
            pb2.Image = CampingEntrance.Properties.Resources.button_2_;
            pb3.Image = CampingEntrance.Properties.Resources.button_3_;
            pb4.Image = CampingEntrance.Properties.Resources.button_4_;
            pb5.Image = CampingEntrance.Properties.Resources.button_5_;
            pb1.Image = CampingEntrance.Properties.Resources.button;
            pb7.Image = CampingEntrance.Properties.Resources.button_7_;
            pb8.Image = CampingEntrance.Properties.Resources.button_8_;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            spotNo = 7;
            pb7.Image = CampingEntrance.Properties.Resources.buttonY7;
            pb2.Image = CampingEntrance.Properties.Resources.button_2_;
            pb3.Image = CampingEntrance.Properties.Resources.button_3_;
            pb4.Image = CampingEntrance.Properties.Resources.button_4_;
            pb5.Image = CampingEntrance.Properties.Resources.button_5_;
            pb6.Image = CampingEntrance.Properties.Resources.button_6_;
            pb1.Image = CampingEntrance.Properties.Resources.button;
            pb8.Image = CampingEntrance.Properties.Resources.button_8_;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            spotNo = 8;
            pb8.Image = CampingEntrance.Properties.Resources.buttonY8;
            pb2.Image = CampingEntrance.Properties.Resources.button_2_;
            pb3.Image = CampingEntrance.Properties.Resources.button_3_;
            pb4.Image = CampingEntrance.Properties.Resources.button_4_;
            pb5.Image = CampingEntrance.Properties.Resources.button_5_;
            pb6.Image = CampingEntrance.Properties.Resources.button_6_;
            pb7.Image = CampingEntrance.Properties.Resources.button_7_;
            pb1.Image = CampingEntrance.Properties.Resources.button;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void RegistrationForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
