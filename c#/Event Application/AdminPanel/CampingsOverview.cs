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

            List<string> campings = dh.GetCampingsNo();
            foreach (string item in campings)
            {
                cbCampNoS.Items.Add(item);
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if (dh.GetCampingInfo(Convert.ToInt32(cbCampNoS.SelectedItem.ToString())).Count > 0)
            {
                foreach (string item in dh.GetCampingInfo(Convert.ToInt32(cbCampNoS.SelectedItem.ToString())))
                {
                    listBox3.Items.Add(item);
                }
            }
            else
            {
                listBox3.Items.Add("This camping spot is Free");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFree.Text = dh.GetCampingsNotBooked().ToString();
            lbNoBooked.Text = dh.GetCampingsBooked().ToString();
        }
    }
}
