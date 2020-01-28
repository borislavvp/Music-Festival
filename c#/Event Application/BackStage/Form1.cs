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

namespace BackStage
{
    public partial class Form1 : Form
    {
        
        RFID myRfid;
        string rfidCode;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        string selectedArtist;

        public Form1()
        {
            InitializeComponent();
            lblRfidSt.Text = "";
            lbMeetingStatus.Text = "";
            lbGoToStageStatus.Text = "";
            gbArtists.Hide();
            btnArrangeMeeting.Hide();
            btnGoToStage.Hide();
            btnRoll.Hide();
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

        private void pbRocky_Click(object sender, EventArgs e)
        {
            selectedArtist = "rocky";
            pbRocky.BackgroundImage = Properties.Resources.ROCKYFINALSELECTED;
            pbNina.BackgroundImage = Properties.Resources.ninakravizbtrr;
            pbBalvin.BackgroundImage = Properties.Resources.jbalvinbtrr;
            lbRocky.ForeColor = Color.Fuchsia;
            lbNina.ForeColor = Color.Black;
            lbBalvin.ForeColor = Color.Black;
        }

        private void pbNina_Click(object sender, EventArgs e)
        {
            selectedArtist = "nina";
            pbRocky.BackgroundImage = Properties.Resources.rockybtr;
            pbNina.BackgroundImage = Properties.Resources.NINAFINALSELECTED;
            pbBalvin.BackgroundImage = Properties.Resources.jbalvinbtrr;
            lbRocky.ForeColor = Color.Black;
            lbNina.ForeColor = Color.Fuchsia;
            lbBalvin.ForeColor = Color.Black;
        }

        private void pbBalvin_Click(object sender, EventArgs e)
        {
            selectedArtist = "balvin";
            pbRocky.BackgroundImage = Properties.Resources.rockybtr;
            pbNina.BackgroundImage = Properties.Resources.ninakravizbtrr;
            pbBalvin.BackgroundImage = Properties.Resources.JBALVINFINALSELECTED;
            lbRocky.ForeColor = Color.Black;
            lbNina.ForeColor = Color.Black;
            lbBalvin.ForeColor = Color.Fuchsia;
        }

        private void btnScanRfid_Click(object sender, EventArgs e)
        {
            try
            {
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
            lblRfidSt.Text = " Attached";
            lblRfidSt.ForeColor = Color.Indigo;
        }
        public void CheckUserRfid(object sender, RFIDTagEventArgs args)
        {
            rfidCode = args.Tag;
            Datahelper dh = new Datahelper();
            string userName = dh.GetWinnerFirstName(rfidCode);
            if (userName != "" && userName != "error")
            {
                lblRfidSt.Text = userName;
                lblRfidSt.ForeColor = Color.Indigo;
                lblRfidSt.Dock = DockStyle.Fill;
                btnScanRfid.Hide();
                gbArtists.Show();
                btnArrangeMeeting.Show();
                btnGoToStage.Show();
                btnRoll.Show();
            }
            else
            {
                lblRfidSt.Text = "This user is not the winner !";
                lblRfidSt.ForeColor = Color.Red;
            }
            myRfid.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_tombola;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_hover_tombola;
        }

        private void btnArrangeMeeting_Click(object sender, EventArgs e)
        {
            if (selectedArtist == "rocky")
            {
                lbMeetingStatus.Text = "A meeting with ASAP Rocky is arranged !";
            }
            else if (selectedArtist == "nina")
            {
                lbMeetingStatus.Text = "A meeting with Nina Kraviz is arranged !";
            }
            else
            {
                lbMeetingStatus.Text = "A meeting with J Balvin is arranged !";
            }
            gbArtists.Hide();
            btnArrangeMeeting.Hide();
        }

        private void btnGoToStage_Click(object sender, EventArgs e)
        {
            btnGoToStage.Hide();
            lbGoToStageStatus.Text = "ON STAGE !";
        }

        public void GetAward(int award)
        {
            MessageBox.Show(award.ToString());
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Datahelper dh = new Datahelper();
            int userId = dh.GetUserIdWithRfid(rfidCode);
            Wheel wheel = new Wheel();
            wheel.Show();
            wheel.SetUserId(userId);
        }
        
        public void HideLogo()
        {
            pictureBox1.Hide();
        }
        public void HideCloseBtn()
        {
            btnClose.Hide();
        }
    }
}
