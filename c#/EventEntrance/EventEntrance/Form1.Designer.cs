namespace EventEntrance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTombola = new System.Windows.Forms.Button();
            this.returnMoney = new System.Windows.Forms.Button();
            this.lbCheckStatus = new System.Windows.Forms.Label();
            this.lblRfidSt = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnSetRfid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRegisterStatus = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfirstName = new System.Windows.Forms.TextBox();
            this.registerTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTombola);
            this.groupBox1.Controls.Add(this.returnMoney);
            this.groupBox1.Controls.Add(this.lbCheckStatus);
            this.groupBox1.Controls.Add(this.lblRfidSt);
            this.groupBox1.Controls.Add(this.btnCheckOut);
            this.groupBox1.Controls.Add(this.btnSetRfid);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbBarcode);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 10);
            this.label2.TabIndex = 11;
            // 
            // btnTombola
            // 
            this.btnTombola.BackgroundImage = global::EventEntrance.Properties.Resources.tombolaFinal;
            this.btnTombola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTombola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTombola.Location = new System.Drawing.Point(9, 76);
            this.btnTombola.Name = "btnTombola";
            this.btnTombola.Size = new System.Drawing.Size(101, 98);
            this.btnTombola.TabIndex = 7;
            this.btnTombola.UseVisualStyleBackColor = true;
            this.btnTombola.Click += new System.EventHandler(this.btnTombola_Click);
            // 
            // returnMoney
            // 
            this.returnMoney.BackgroundImage = global::EventEntrance.Properties.Resources.returnMoneyFinal;
            this.returnMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnMoney.Location = new System.Drawing.Point(338, 75);
            this.returnMoney.Name = "returnMoney";
            this.returnMoney.Size = new System.Drawing.Size(101, 98);
            this.returnMoney.TabIndex = 6;
            this.returnMoney.UseVisualStyleBackColor = true;
            this.returnMoney.Click += new System.EventHandler(this.returnMoney_Click);
            // 
            // lbCheckStatus
            // 
            this.lbCheckStatus.BackColor = System.Drawing.Color.MintCream;
            this.lbCheckStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckStatus.Location = new System.Drawing.Point(3, 191);
            this.lbCheckStatus.Name = "lbCheckStatus";
            this.lbCheckStatus.Size = new System.Drawing.Size(441, 36);
            this.lbCheckStatus.TabIndex = 5;
            this.lbCheckStatus.Text = "CheckinStatus";
            this.lbCheckStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRfidSt
            // 
            this.lblRfidSt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRfidSt.AutoSize = true;
            this.lblRfidSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfidSt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRfidSt.Location = new System.Drawing.Point(184, 76);
            this.lblRfidSt.Name = "lblRfidSt";
            this.lblRfidSt.Size = new System.Drawing.Size(126, 20);
            this.lblRfidSt.TabIndex = 0;
            this.lblRfidSt.Text = "RFID STATUS";
            this.lblRfidSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.BackgroundImage = global::EventEntrance.Properties.Resources.check_out_512;
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(268, 114);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(64, 59);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnSetRfid
            // 
            this.btnSetRfid.BackColor = System.Drawing.Color.White;
            this.btnSetRfid.BackgroundImage = global::EventEntrance.Properties.Resources.rfidp;
            this.btnSetRfid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetRfid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetRfid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetRfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetRfid.ForeColor = System.Drawing.Color.White;
            this.btnSetRfid.Location = new System.Drawing.Point(188, 114);
            this.btnSetRfid.Name = "btnSetRfid";
            this.btnSetRfid.Size = new System.Drawing.Size(74, 60);
            this.btnSetRfid.TabIndex = 3;
            this.btnSetRfid.UseVisualStyleBackColor = false;
            this.btnSetRfid.Click += new System.EventHandler(this.btnSetRfid_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::EventEntrance.Properties.Resources.kisspng_computer_icons_login_download_login_button_5ac42ddd1a06f4_5245172115228062371066;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 60);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor Barcode";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(125, 43);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(194, 26);
            this.tbBarcode.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbRegisterStatus);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.tbphone);
            this.groupBox2.Controls.Add(this.tbpass);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.tbNationality);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbfirstName);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(93, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 311);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 13);
            this.label8.TabIndex = 12;
            // 
            // lbRegisterStatus
            // 
            this.lbRegisterStatus.BackColor = System.Drawing.Color.MintCream;
            this.lbRegisterStatus.Location = new System.Drawing.Point(6, 216);
            this.lbRegisterStatus.Name = "lbRegisterStatus";
            this.lbRegisterStatus.Size = new System.Drawing.Size(332, 20);
            this.lbRegisterStatus.TabIndex = 14;
            this.lbRegisterStatus.Text = "RegisterStatus";
            this.lbRegisterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::EventEntrance.Properties.Resources.register_button;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(344, 72);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(144, 180);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(192, 26);
            this.tbphone.TabIndex = 11;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(144, 144);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(192, 26);
            this.tbpass.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 110);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(192, 26);
            this.tbEmail.TabIndex = 9;
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(144, 74);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(192, 26);
            this.tbNationality.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // tbfirstName
            // 
            this.tbfirstName.BackColor = System.Drawing.SystemColors.Window;
            this.tbfirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbfirstName.Location = new System.Drawing.Point(144, 36);
            this.tbfirstName.Name = "tbfirstName";
            this.tbfirstName.Size = new System.Drawing.Size(192, 26);
            this.tbfirstName.TabIndex = 2;
            // 
            // registerTimer
            // 
            this.registerTimer.Interval = 4000;
            this.registerTimer.Tick += new System.EventHandler(this.registerTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EventEntrance.Properties.Resources.z7Layers_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::EventEntrance.Properties.Resources.close_hover;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(499, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::EventEntrance.Properties.Resources.z7Layers_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnSetRfid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbfirstName;
        private System.Windows.Forms.Label lblRfidSt;
        private System.Windows.Forms.Timer registerTimer;
        private System.Windows.Forms.Label lbCheckStatus;
        private System.Windows.Forms.Label lbRegisterStatus;
        private System.Windows.Forms.Button returnMoney;
        private System.Windows.Forms.Button btnTombola;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}

