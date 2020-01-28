using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackStage
{
    public partial class Wheel : Form
    {
        Random rnd;
        private PictureBox[] pbs;
        private Dictionary<Image, object> dic;
        object award;
        int userId;
        int startC = 5;
        int endC = 0;
        int j = 0;
        int howeverLongYouWantTheLoopToLast = 0;
        
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Wheel()
        {

            InitializeComponent();

            label2.Text = "";
            label1.Text = "";
            pbPointer.BackgroundImage = null;
            dic = new Dictionary<Image, object>();
            dic.Add(pb1.BackgroundImage, 5);
            dic.Add(pb2.BackgroundImage, 10);
            dic.Add(pb3.BackgroundImage, 20);
            dic.Add(pb4.BackgroundImage, 50);
            dic.Add(pb5.BackgroundImage, 100);
            dic.Add(pb6.BackgroundImage, "T-Shirt");
            dic.Add(pb7.BackgroundImage, "Again");
            dic.Add(pb8.BackgroundImage, 150);
            dic.Add(pb9.BackgroundImage, "Sorry");
            rnd = new Random();
            howeverLongYouWantTheLoopToLast = rnd.Next(60, 80);
        }
        

        private void Wheel_Load(object sender, EventArgs e)
        {
            timer3.Start();
        }
        
        public void SetUserId(int id)
        {
            this.userId = id;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (startC > endC)
            {
                label2.Text = "00:0" + startC.ToString();
                startC--;
            }
            else
            {
                timer3.Stop();
                label2.Text = "";
                pbPointer.BackgroundImage = Properties.Resources.pointer;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j < howeverLongYouWantTheLoopToLast)
            {
                pbs = new PictureBox[] { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9 };
                Image[] bgs = new Image[] { pb1.BackgroundImage, pb2.BackgroundImage, pb3.BackgroundImage, pb4.BackgroundImage, pb5.BackgroundImage, pb6.BackgroundImage,
                pb7.BackgroundImage, pb8.BackgroundImage, pb9.BackgroundImage };

                for (int i = 0; i < pbs.Length; i++)
                {
                    if (i != pbs.Length - 1)
                    {
                        pbs[i].BackgroundImage = bgs[i + 1];
                    }
                    else
                    {
                        pbs[i].BackgroundImage = bgs[0];
                    }
                }

                label1.Text = dic[pb1.BackgroundImage].ToString();
                j++;
            }
            else
            {
                j = 0;
                howeverLongYouWantTheLoopToLast = rnd.Next(6,12) ;
                timer2.Start();
                timer1.Stop();
            }
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (j < howeverLongYouWantTheLoopToLast)
            {
                pbs = new PictureBox[] { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9 };
                Image[] bgs = new Image[] { pb1.BackgroundImage, pb2.BackgroundImage, pb3.BackgroundImage, pb4.BackgroundImage, pb5.BackgroundImage, pb6.BackgroundImage,
                pb7.BackgroundImage, pb8.BackgroundImage, pb9.BackgroundImage };

                for (int i = 0; i < pbs.Length; i++)
                {
                    if (i != pbs.Length - 1)
                    {
                        pbs[i].BackgroundImage = bgs[i + 1];
                    }
                    else
                    {
                        pbs[i].BackgroundImage = bgs[0];
                    }
                    label1.Text = dic[pb1.BackgroundImage].ToString();
                }
                j++;
                if (j == howeverLongYouWantTheLoopToLast)
                {
                    pb1.BorderStyle = BorderStyle.Fixed3D;
                }
                timer2.Interval += 50;
            }
            else
            {
                timer2.Stop();
                foreach (Image item in dic.Keys)
                {
                    if (item == pb1.BackgroundImage)
                    {
                        award = dic[item];
                        if (award is int a)
                        {
                            pbPointer.BackgroundImage = null;

                            Datahelper dh = new Datahelper();

                            string status = dh.UpdateUserBalance(a, userId);
                            if (status == "updated")
                            {
                                label2.Text = "Congratulations !";
                                label2.Location = new Point(76, 9);
                            }
                            else
                            {
                                label2.Text = "Error !";
                                label2.ForeColor = Color.Red;
                            }
                        }
                        else if(award is string b)
                        {
                            if (b == "Again")
                            {
                                pbPointer.BackgroundImage = null;
                                j = 0;
                                howeverLongYouWantTheLoopToLast = rnd.Next(60, 70);
                                timer2.Interval = 100;
                                startC = 5;
                                pb1.BorderStyle = BorderStyle.None;
                                timer3.Start();
                            }
                            else if (b == "T-Shirt")
                            {
                                pbPointer.BackgroundImage = null;
                                label2.Text = "Congratulations !";
                                label2.Location = new Point(76, 9);
                            }
                        }
                    }
                }
            }
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

        private void Wheel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Wheel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Wheel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
}
