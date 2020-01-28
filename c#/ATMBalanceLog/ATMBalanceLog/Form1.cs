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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ATMBalanceLog
{
    public partial class Form1 : Form
    {
        Datahelper dh;
        string logPath = @"C:\Users\bobkata\Desktop\UNI\PROP\FinalApp\c#\log.txt";
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader r = File.OpenText(logPath))
            {
                DumpLog(r);
            }
        }

        public void DumpLog(StreamReader r)
        {
            listBox1.Items.Clear();
            string line;
            int numberOfTransactions = 0;
            while ((line = r.ReadLine()) != null)
            {
                numberOfTransactions++;
                listBox1.Items.Add(line);
            }
            listBox1.Items.Add("Number of transactions made : " + (numberOfTransactions - 1));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dh = new Datahelper();
            int userId = -1;
            int balance = -1;
            int atmLogId = -1;
            List<int> problems = new List<int>();
            List<int> wrongIds = new List<int>();
            foreach (string item in listBox1.Items)
            {
                if (item.Contains("#") == true)
                {
                    int start = item.LastIndexOf("#");
                    int end = item.Length - 1;
                    string productName = item.Substring(start + 1).Trim();
                    string date = item.Substring(0, start - 1);
                    string[] temp = productName.Split(' ');
                    userId = Convert.ToInt32(temp[0]);
                    atmLogId = Convert.ToInt32(temp[1]);
                    balance = Convert.ToInt32(temp[3]);
                    string check = dh.CheckUser(userId);
                    if (check == "ok")
                    {
                        string proccess = dh.AddBalanceToUser(balance, userId, atmLogId, date);
                        if (proccess != "added")
                        {
                            problems.Add(userId);
                        }
                    }
                    else
                    {
                        wrongIds.Add(userId);
                    }
                    var lines = File.ReadAllLines(logPath).Where(line => line.Trim() != item).ToArray();
                    File.WriteAllLines(logPath, lines);
                }
            }  
            if (wrongIds.Count() == 0 && problems.Count() == 0)
            {
                //MessageBox.Show("Successfully Updated !");
            }
            if (problems.Count() > 0)
            {
                string line = "";
                foreach (int item in problems)
                {
                    line += item.ToString() + ",";
                }
                int end = line.LastIndexOf(',');
                string output = line.Substring(0, end);
                MessageBox.Show("A problem occured updating ussers with these ID's : " + line);
            }
            if (wrongIds.Count() > 0)
            {
                string line = "";
                foreach (int item in wrongIds)
                {
                    line += item.ToString() + ",";
                }
                int end = line.LastIndexOf(',');
                string output = line.Substring(0, end);
                MessageBox.Show("There aren't any ussers with these ID's : " + line);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           button1.PerformClick();
           btnUpdate.PerformClick();
        }
    }
}
