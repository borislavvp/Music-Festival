using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemEnter
{
    public partial class AdminForm : Form
    {
        AdminPanel.Form1 adminP;
        EventEntrance.Form1 eventEntrance;
        CampingEntrance.Form1 campEntrance;
        LoanStandApp.Form1 loanStand;
        FoodShop.Form1 foodShop;
        ATMBalanceLog.Form1 atmLogReader;
        ATM.Form1 atm;
        EmployeeRegistration registerEmp;
        BackStage.Form1 backStage;
        TombolaWinnerForm tombola;

        int gbHeight = 0;
        public AdminForm()
        {
            InitializeComponent();
            adminP = new AdminPanel.Form1();
            campEntrance = new CampingEntrance.Form1();
            eventEntrance = new EventEntrance.Form1();
            loanStand = new LoanStandApp.Form1();
            foodShop = new FoodShop.Form1();
            atmLogReader = new ATMBalanceLog.Form1();
            atm = new ATM.Form1();
            registerEmp = new EmployeeRegistration();
            backStage = new BackStage.Form1();

            gbHeight = groupBox2.Size.Height;
        }

        public void FormSizeChange(GroupBox g,Panel p)
        {
            if (g.Size.Height >= p.Size.Height)
            {
                if (p.Size.Height > gbHeight)
                {
                    g.Size = new Size(g.Size.Width, p.Size.Height);
                }
                else
                {
                    g.Size = new Size(g.Size.Width, gbHeight);
                }
                this.Size = new Size(g.Size.Width + p.Size.Width, g.Size.Height + 50);
            }
            else
            {
                g.Size = new Size(g.Size.Width, p.Size.Height);
                this.Size = new Size(g.Size.Width + p.Size.Width , p.Size.Height + 50);
            }
            btnClose.Location = new Point(this.Width - 50, -2);
            pbMinimize.Location = new Point(this.Width - 75, 17);
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeee;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panelY;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entrance;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entrance;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_stand;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shop;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_log;
            btnAtm.BackgroundImage = Properties.Resources.button_atm;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageB;

            StretchBackgroundImage();

            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();
            registerEmp.Hide();
            backStage.Hide();

            adminP = new AdminPanel.Form1();
            adminP.TopLevel = false;
            adminP.FormBorderStyle = FormBorderStyle.None;
            adminP.Dock = DockStyle.Fill;
            tbOverview.Size = adminP.Size;
            tbOverview.Controls.Add(adminP);
            adminP.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        private void btnCampingEntrance_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeee;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panel;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entranceY;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entrance;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_stand;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shop;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_log;
            btnAtm.BackgroundImage = Properties.Resources.button_atm;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageB;

            StretchBackgroundImage();

            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();
            registerEmp.Hide();
            backStage.Hide();

            campEntrance = new CampingEntrance.Form1();
            campEntrance.TopLevel = false;
            campEntrance.FormBorderStyle = FormBorderStyle.None;
            campEntrance.Dock = DockStyle.Fill;
            campEntrance.HideCloseBtn();
            campEntrance.HideLogo();
            tbOverview.Size = campEntrance.Size;
            tbOverview.Controls.Add(campEntrance);
            campEntrance.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        private void btnEventEntrance_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeee;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panel;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entrance;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entranceY;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_stand;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shop;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_log;
            btnAtm.BackgroundImage = Properties.Resources.button_atm;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageB;

            StretchBackgroundImage();

            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();
            registerEmp.Hide();
            backStage.Hide();

            eventEntrance = new EventEntrance.Form1();
            eventEntrance.TopLevel = false;
            eventEntrance.FormBorderStyle = FormBorderStyle.None;
            eventEntrance.Dock = DockStyle.None;
            eventEntrance.HideCloseBtn();
            eventEntrance.HideLogo();
            tbOverview.Size = eventEntrance.Size;
            tbOverview.Controls.Add(eventEntrance);
            eventEntrance.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        private void btnLoanStand_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeee;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panel;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entrance;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entrance;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_standY;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shop;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_log;
            btnAtm.BackgroundImage = Properties.Resources.button_atm;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageB;

            StretchBackgroundImage();

            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();
            registerEmp.Hide();
            backStage.Hide();

            loanStand = new LoanStandApp.Form1();
            loanStand.TopLevel = false;
            loanStand.FormBorderStyle = FormBorderStyle.None;
            loanStand.Dock = DockStyle.None;
            loanStand.HideCloseBtn();
            loanStand.HideLogo();
            tbOverview.Size = loanStand.Size;
            tbOverview.Controls.Add(loanStand);
            loanStand.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        private void btnFoodShop_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeee;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panel;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entrance;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entrance;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_stand;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shopY;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_log;
            btnAtm.BackgroundImage = Properties.Resources.button_atm;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageB;

            StretchBackgroundImage();

            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();
            registerEmp.Hide();
            backStage.Hide();

            foodShop = new FoodShop.Form1();
            foodShop.TopLevel = false;
            foodShop.FormBorderStyle = FormBorderStyle.None;
            foodShop.Dock = DockStyle.Fill;
            foodShop.HideCloseBtn();
            foodShop.HideLogo();
            tbOverview.Size = foodShop.Size;
            tbOverview.Controls.Add(foodShop);
            foodShop.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        private void btnAtmLog_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeee;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panel;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entrance;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entrance;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_stand;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shop;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_logY;
            btnAtm.BackgroundImage = Properties.Resources.button_atm;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageB;

            StretchBackgroundImage();

            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();
            registerEmp.Hide();
            backStage.Hide();

            atmLogReader = new ATMBalanceLog.Form1();
            atmLogReader.TopLevel = false;
            atmLogReader.FormBorderStyle = FormBorderStyle.None;
            atmLogReader.Dock = DockStyle.Fill;
            tbOverview.Size = atmLogReader.Size;
            tbOverview.Controls.Add(atmLogReader);
            atmLogReader.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        private void btnAtm_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeee;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panel;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entrance;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entrance;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_stand;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shop;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_log;
            btnAtm.BackgroundImage = Properties.Resources.button_atmY;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageB;

            StretchBackgroundImage();

            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();
            registerEmp.Hide();
            backStage.Hide();

            atm = new ATM.Form1();
            atm.TopLevel = false;
            atm.FormBorderStyle = FormBorderStyle.None;
            atm.Dock = DockStyle.Fill;
            tbOverview.Size = atm.Size;
            tbOverview.Controls.Add(atm);
            atm.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeeY;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panel;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entrance;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entrance;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_stand;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shop;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_log;
            btnAtm.BackgroundImage = Properties.Resources.button_atm;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageB;

            StretchBackgroundImage();

            registerEmp.Hide();
            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();
            backStage.Hide();

            registerEmp = new EmployeeRegistration();
            registerEmp.TopLevel = false;
            registerEmp.FormBorderStyle = FormBorderStyle.None;
            registerEmp.Dock = DockStyle.Fill;
            tbOverview.Size = registerEmp.Size;
            tbOverview.Controls.Add(registerEmp);
            registerEmp.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        private void btnBackStage_Click(object sender, EventArgs e)
        {
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeeY;
            btnAdminPanel.BackgroundImage = Properties.Resources.button_overview_panel;
            btnCampingEntrance.BackgroundImage = Properties.Resources.button_camping_entrance;
            btnEventEntrance.BackgroundImage = Properties.Resources.button_event_entrance;
            btnLoanStand.BackgroundImage = Properties.Resources.button_loan_stand;
            btnFoodShop.BackgroundImage = Properties.Resources.button_food_shop;
            btnAtmLog.BackgroundImage = Properties.Resources.button_atm_log;
            btnAtm.BackgroundImage = Properties.Resources.button_atm;
            btnRegisterEmployee.BackgroundImage = Properties.Resources.button_register_employeee;
            btnBackStage.BackgroundImage = Properties.Resources.button_backstageYB;

            StretchBackgroundImage();

            backStage.Hide();
            registerEmp.Hide();
            adminP.Hide();
            eventEntrance.Hide();
            campEntrance.Hide();
            loanStand.Hide();
            foodShop.Hide();
            atmLogReader.Hide();
            atm.Hide();

            backStage = new BackStage.Form1();
            backStage.TopLevel = false;
            backStage.FormBorderStyle = FormBorderStyle.None;
            backStage.Dock = DockStyle.Fill;
            backStage.HideCloseBtn();
            backStage.HideLogo();
            tbOverview.Size = backStage.Size;
            tbOverview.Controls.Add(backStage);
            backStage.Show();
            FormSizeChange(groupBox2, tbOverview);
        }

        public void StretchBackgroundImage()
        {
            btnRegisterEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdminPanel.BackgroundImageLayout = ImageLayout.Stretch;
            btnCampingEntrance.BackgroundImageLayout = ImageLayout.Stretch;
            btnEventEntrance.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoanStand.BackgroundImageLayout = ImageLayout.Stretch;
            btnFoodShop.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtmLog.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtm.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button_choose_winnerYB;
            tombola = new TombolaWinnerForm();
            tombola.FormClosed += new FormClosedEventHandler(CloseTOmbolaFomr);
            tombola.Show();
        }

        private void CloseTOmbolaFomr(object a, FormClosedEventArgs args)
        {
            button1.BackgroundImage = Properties.Resources.button_choose_winnerB;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.btnClose_Hover_tr;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_greenBTR;
        }

        private void pbMinimize_MouseHover(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.LightGreen;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.Transparent;
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
    }
}
