namespace CampingEntrance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCheckStatus = new System.Windows.Forms.Label();
            this.btnScanVisitor = new System.Windows.Forms.Button();
            this.lbVisitorStatus = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lbVisitorName = new System.Windows.Forms.Label();
            this.btnOpenRegistrationForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbCheckStatus);
            this.groupBox1.Controls.Add(this.btnScanVisitor);
            this.groupBox1.Controls.Add(this.lbVisitorStatus);
            this.groupBox1.Controls.Add(this.btnCheckOut);
            this.groupBox1.Controls.Add(this.btnCheckIn);
            this.groupBox1.Controls.Add(this.lbVisitorName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 10);
            this.label2.TabIndex = 15;
            // 
            // lbCheckStatus
            // 
            this.lbCheckStatus.BackColor = System.Drawing.Color.Honeydew;
            this.lbCheckStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckStatus.Location = new System.Drawing.Point(3, 150);
            this.lbCheckStatus.Name = "lbCheckStatus";
            this.lbCheckStatus.Size = new System.Drawing.Size(369, 26);
            this.lbCheckStatus.TabIndex = 8;
            this.lbCheckStatus.Text = "Status";
            this.lbCheckStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnScanVisitor
            // 
            this.btnScanVisitor.BackColor = System.Drawing.Color.Transparent;
            this.btnScanVisitor.BackgroundImage = global::CampingEntrance.Properties.Resources.rfidp;
            this.btnScanVisitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScanVisitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScanVisitor.Location = new System.Drawing.Point(141, 65);
            this.btnScanVisitor.Name = "btnScanVisitor";
            this.btnScanVisitor.Size = new System.Drawing.Size(84, 63);
            this.btnScanVisitor.TabIndex = 7;
            this.btnScanVisitor.UseVisualStyleBackColor = false;
            this.btnScanVisitor.Click += new System.EventHandler(this.btnScanVisitor_Click);
            // 
            // lbVisitorStatus
            // 
            this.lbVisitorStatus.AutoSize = true;
            this.lbVisitorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisitorStatus.Location = new System.Drawing.Point(138, 35);
            this.lbVisitorStatus.Name = "lbVisitorStatus";
            this.lbVisitorStatus.Size = new System.Drawing.Size(56, 18);
            this.lbVisitorStatus.TabIndex = 6;
            this.lbVisitorStatus.Text = "Status";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.BackgroundImage = global::CampingEntrance.Properties.Resources.check_out_512;
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(260, 65);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(84, 63);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.BackgroundImage = global::CampingEntrance.Properties.Resources.kisspng_computer_icons_login_download_login_button_5ac42ddd1a06f4_5245172115228062371066;
            this.btnCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(23, 65);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(84, 63);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lbVisitorName
            // 
            this.lbVisitorName.AutoSize = true;
            this.lbVisitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisitorName.Location = new System.Drawing.Point(46, 35);
            this.lbVisitorName.Name = "lbVisitorName";
            this.lbVisitorName.Size = new System.Drawing.Size(52, 18);
            this.lbVisitorName.TabIndex = 0;
            this.lbVisitorName.Text = "Name";
            // 
            // btnOpenRegistrationForm
            // 
            this.btnOpenRegistrationForm.BackColor = System.Drawing.Color.White;
            this.btnOpenRegistrationForm.BackgroundImage = global::CampingEntrance.Properties.Resources.registerF;
            this.btnOpenRegistrationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenRegistrationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRegistrationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenRegistrationForm.Location = new System.Drawing.Point(97, 246);
            this.btnOpenRegistrationForm.Name = "btnOpenRegistrationForm";
            this.btnOpenRegistrationForm.Size = new System.Drawing.Size(375, 99);
            this.btnOpenRegistrationForm.TabIndex = 8;
            this.btnOpenRegistrationForm.UseVisualStyleBackColor = false;
            this.btnOpenRegistrationForm.Click += new System.EventHandler(this.btnOpenRegistrationForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CampingEntrance.Properties.Resources.z7LayersLogoTr;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::CampingEntrance.Properties.Resources.close_greenBTR;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(514, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 32);
            this.btnClose.TabIndex = 51;
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(553, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenRegistrationForm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lbVisitorName;
        private System.Windows.Forms.Label lbVisitorStatus;
        private System.Windows.Forms.Button btnScanVisitor;
        private System.Windows.Forms.Button btnOpenRegistrationForm;
        private System.Windows.Forms.Label lbCheckStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label2;
    }
}

