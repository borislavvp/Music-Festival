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
    public partial class VisitorsOverview : Form
    {
        Datahelper db;
        public VisitorsOverview()
        {
            InitializeComponent();
            db = new Datahelper();
            label7.Text = db.GetVistorCount().ToString();
            label8.Text = db.GetPresentCount().ToString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Visitor Status:  " + db.GetUserStatus(textBox3.Text);
            List<string> resut = db.GetUserHistory(textBox3.Text);
            for (int i = 0; i < resut.Count; i++)
            {
                this.listBox1.Items.Add(resut[i].ToString());
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = db.GetVistorCount().ToString();
            label8.Text = db.GetPresentCount().ToString();
        }
    }
}
