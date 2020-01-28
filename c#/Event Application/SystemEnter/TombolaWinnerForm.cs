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

namespace SystemEnter
{
    public partial class TombolaWinnerForm : Form
    {
        string logPath = @"C:\Users\bobkata\Desktop\UNI\PROP\FinalApp\c#\tombolaLog.txt";
        public TombolaWinnerForm()
        {
            InitializeComponent();
            pictureBox1.Show();
            label2.Text = "";
            label3.Hide();
            timer1.Start();
        }
        int TotalLines(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                int i = 0;
                while (r.ReadLine() != null) { i++; }
                return i;
            }
        }
        public void DumpLog(StreamReader r)
        {
            string line;
            Random rnd = new Random();
            int totalLines = TotalLines(@"C:\Users\bobkata\Desktop\UNI\PROP\FinalApp\c#\tombolaLog.txt");
            if (totalLines > 0)
            {
                int winningRow = rnd.Next(1, totalLines);
                int count = 0;
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                    if (count == winningRow)
                    {
                        int start = line.IndexOf(' ');
                        string userId = line.Substring(start).Trim();
                        string winningNumber = line.Substring(0, start).Trim();

                        Datahelper dh = new Datahelper();

                        string status = dh.registerWinner(Convert.ToInt32(userId));
                        if (status == "ok")
                        {
                            label2.Text = winningNumber;
                            label3.Show();
                        }
                        break;
                    }
                }
            }
        }
        public void HandleEvent(int winningNumber)
        {
            label2.Text = winningNumber.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (StreamReader r = File.OpenText(logPath))
            {
                DumpLog(r);
            }
            pictureBox1.Hide();
            timer1.Stop();
            File.WriteAllText(logPath, "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_hover_tombola;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_tombola;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void TombolaWinnerForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void TombolaWinnerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void TombolaWinnerForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        
    }
}
