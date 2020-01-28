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
using MySql.Data.MySqlClient;

namespace SystemEnter
{
    public partial class EmployeeRegistration : Form
    {
        Datahelper dh;
        RFID myRfid;
        string rfidCode;
        List<string> jobIds;
        bool readyForRfid = false;

        public EmployeeRegistration()
        {
            InitializeComponent();
            dh = new Datahelper();
            jobIds = dh.GetJobIDs();

            foreach (string item in jobIds)
            {
                cbJobIds.Items.Add(item);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string first_name = tbfirstName.Text;
                string email = tbEmail.Text;
                string phoneNo = tbphone.Text;
                int salary = Convert.ToInt32(tbSalary.Text);
                string job_id = cbJobIds.SelectedItem.ToString();

                if (first_name != "" && email != "" && phoneNo != "" && salary != 0 && job_id != "")
                {
                    string status = dh.RegisterEmployee(first_name, job_id, email, salary, phoneNo);
                    if (status == "registered")
                    {
                        lbStatus.Text = "Give a RFID Chip to the Employee !";
                        lbStatus.ForeColor = Color.Green;
                        readyForRfid = true;
                    }
                    else
                    {
                        lbStatus.Text = "Something happened,please try again !";
                        lbStatus.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbStatus.Text = "Invalid input !";
                    lbStatus.ForeColor = Color.Red;
                }
            }
            catch (FormatException)
            {
                lbStatus.Text = "Invalid input !";
                lbStatus.ForeColor = Color.Red;
            }
        }

        private void btnGiveRfid_Click(object sender, EventArgs e)
        {
            try
            {
                if (readyForRfid == true)
                {
                    myRfid = new RFID();

                    myRfid.Attach += new AttachEventHandler(myRfidAttachMethod);
                    myRfid.Tag += new RFIDTagEventHandler(SetRfidToEmployee);

                    myRfid.Open();
                }
                else
                {
                    lbStatus.Text = "Error !";
                    lbStatus.ForeColor = Color.Red;
                }

            }
            catch (PhidgetException ex)
            {
                throw ex;
            }
        }
        public void myRfidAttachMethod(object sender, AttachEventArgs args)
        {
            lbStatus.Text = " Attached";
        }
        public void SetRfidToEmployee(object sender, RFIDTagEventArgs args)
        {
            rfidCode = args.Tag;
            myRfid.Close();
            string status = dh.GiveRfidToEmployee(rfidCode);
            if (status == "ok")
            {
               lbStatus.Text = "Given Successfully !";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = "Something happened,please try again !";
                lbStatus.ForeColor = Color.Red;
            }
            tbEmail.Text = "";
            tbfirstName.Text = "";
            tbphone.Text = "";
            cbJobIds.Text = "Job ID";
            tbSalary.Text = "";
        }
        
    }
}
