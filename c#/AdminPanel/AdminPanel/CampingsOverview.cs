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
    public partial class CampingsOverview : Form
    {
        Datahelper dh;
        public CampingsOverview()
        {
            dh = new Datahelper();
            InitializeComponent();
            lbFree.Text = dh.GetCampingsNotBooked().ToString();
            lbNoBooked.Text = dh.GetCampingsBooked().ToString();
            timer1.Start();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (dh.GetCampingInfo(Convert.ToInt32(tbCampNo.Text)).Count > 0)
            {
                foreach (string item in dh.GetCampingInfo(Convert.ToInt32(tbCampNo.Text)))
                {
                    listBox3.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("This Camping Spot is Free");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFree.Text = dh.GetCampingsNotBooked().ToString();
            lbNoBooked.Text = dh.GetCampingsBooked().ToString();
        }
    }
}
