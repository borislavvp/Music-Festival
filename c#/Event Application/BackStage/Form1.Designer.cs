namespace BackStage
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
            this.lblRfidSt = new System.Windows.Forms.Label();
            this.btnScanRfid = new System.Windows.Forms.Button();
            this.gbArtists = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBalvin = new System.Windows.Forms.Label();
            this.lbNina = new System.Windows.Forms.Label();
            this.lbRocky = new System.Windows.Forms.Label();
            this.pbBalvin = new System.Windows.Forms.PictureBox();
            this.pbNina = new System.Windows.Forms.PictureBox();
            this.pbRocky = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGoToStageStatus = new System.Windows.Forms.Label();
            this.lbMeetingStatus = new System.Windows.Forms.Label();
            this.btnGoToStage = new System.Windows.Forms.Button();
            this.btnArrangeMeeting = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbArtists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalvin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRocky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblRfidSt);
            this.groupBox1.Controls.Add(this.btnScanRfid);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(121, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 72);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblRfidSt
            // 
            this.lblRfidSt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRfidSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfidSt.ForeColor = System.Drawing.Color.Indigo;
            this.lblRfidSt.Location = new System.Drawing.Point(3, 16);
            this.lblRfidSt.Name = "lblRfidSt";
            this.lblRfidSt.Size = new System.Drawing.Size(213, 53);
            this.lblRfidSt.TabIndex = 5;
            this.lblRfidSt.Text = "RFID STATUS";
            this.lblRfidSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnScanRfid
            // 
            this.btnScanRfid.BackColor = System.Drawing.Color.Transparent;
            this.btnScanRfid.BackgroundImage = global::BackStage.Properties.Resources.rfidPurpleTransparent;
            this.btnScanRfid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScanRfid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanRfid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScanRfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanRfid.ForeColor = System.Drawing.Color.White;
            this.btnScanRfid.Location = new System.Drawing.Point(222, 5);
            this.btnScanRfid.Name = "btnScanRfid";
            this.btnScanRfid.Size = new System.Drawing.Size(84, 67);
            this.btnScanRfid.TabIndex = 4;
            this.btnScanRfid.UseVisualStyleBackColor = false;
            this.btnScanRfid.Click += new System.EventHandler(this.btnScanRfid_Click);
            // 
            // gbArtists
            // 
            this.gbArtists.BackColor = System.Drawing.Color.Transparent;
            this.gbArtists.Controls.Add(this.label3);
            this.gbArtists.Controls.Add(this.lbBalvin);
            this.gbArtists.Controls.Add(this.lbNina);
            this.gbArtists.Controls.Add(this.lbRocky);
            this.gbArtists.Controls.Add(this.pbBalvin);
            this.gbArtists.Controls.Add(this.pbNina);
            this.gbArtists.Controls.Add(this.pbRocky);
            this.gbArtists.Controls.Add(this.label1);
            this.gbArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbArtists.Location = new System.Drawing.Point(5, 140);
            this.gbArtists.Name = "gbArtists";
            this.gbArtists.Size = new System.Drawing.Size(529, 202);
            this.gbArtists.TabIndex = 14;
            this.gbArtists.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 15);
            this.label3.TabIndex = 19;
            // 
            // lbBalvin
            // 
            this.lbBalvin.AutoSize = true;
            this.lbBalvin.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalvin.Location = new System.Drawing.Point(408, 16);
            this.lbBalvin.Name = "lbBalvin";
            this.lbBalvin.Size = new System.Drawing.Size(82, 26);
            this.lbBalvin.TabIndex = 18;
            this.lbBalvin.Text = "J BALVIN";
            // 
            // lbNina
            // 
            this.lbNina.AutoSize = true;
            this.lbNina.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNina.ForeColor = System.Drawing.Color.Black;
            this.lbNina.Location = new System.Drawing.Point(227, 16);
            this.lbNina.Name = "lbNina";
            this.lbNina.Size = new System.Drawing.Size(115, 26);
            this.lbNina.TabIndex = 17;
            this.lbNina.Text = "NINA KRAVIZ";
            // 
            // lbRocky
            // 
            this.lbRocky.AutoSize = true;
            this.lbRocky.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRocky.Location = new System.Drawing.Point(40, 16);
            this.lbRocky.Name = "lbRocky";
            this.lbRocky.Size = new System.Drawing.Size(109, 26);
            this.lbRocky.TabIndex = 16;
            this.lbRocky.Text = "ASAP ROCKY";
            // 
            // pbBalvin
            // 
            this.pbBalvin.BackgroundImage = global::BackStage.Properties.Resources.jbalvinbtrr;
            this.pbBalvin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBalvin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBalvin.Location = new System.Drawing.Point(370, 45);
            this.pbBalvin.Name = "pbBalvin";
            this.pbBalvin.Size = new System.Drawing.Size(153, 151);
            this.pbBalvin.TabIndex = 15;
            this.pbBalvin.TabStop = false;
            this.pbBalvin.Click += new System.EventHandler(this.pbBalvin_Click);
            // 
            // pbNina
            // 
            this.pbNina.BackgroundImage = global::BackStage.Properties.Resources.ninakravizbtrr;
            this.pbNina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNina.Location = new System.Drawing.Point(185, 45);
            this.pbNina.Name = "pbNina";
            this.pbNina.Size = new System.Drawing.Size(170, 151);
            this.pbNina.TabIndex = 14;
            this.pbNina.TabStop = false;
            this.pbNina.Click += new System.EventHandler(this.pbNina_Click);
            // 
            // pbRocky
            // 
            this.pbRocky.BackgroundImage = global::BackStage.Properties.Resources.rockybtr;
            this.pbRocky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRocky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRocky.Location = new System.Drawing.Point(7, 45);
            this.pbRocky.Name = "pbRocky";
            this.pbRocky.Size = new System.Drawing.Size(159, 151);
            this.pbRocky.TabIndex = 13;
            this.pbRocky.TabStop = false;
            this.pbRocky.Click += new System.EventHandler(this.pbRocky_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 15);
            this.label1.TabIndex = 12;
            // 
            // lbGoToStageStatus
            // 
            this.lbGoToStageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGoToStageStatus.AutoSize = true;
            this.lbGoToStageStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbGoToStageStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoToStageStatus.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbGoToStageStatus.Location = new System.Drawing.Point(356, 404);
            this.lbGoToStageStatus.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbGoToStageStatus.Name = "lbGoToStageStatus";
            this.lbGoToStageStatus.Size = new System.Drawing.Size(78, 20);
            this.lbGoToStageStatus.TabIndex = 19;
            this.lbGoToStageStatus.Text = "STATUS";
            this.lbGoToStageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMeetingStatus
            // 
            this.lbMeetingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMeetingStatus.AutoSize = true;
            this.lbMeetingStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbMeetingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMeetingStatus.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbMeetingStatus.Location = new System.Drawing.Point(4, 404);
            this.lbMeetingStatus.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbMeetingStatus.Name = "lbMeetingStatus";
            this.lbMeetingStatus.Size = new System.Drawing.Size(78, 20);
            this.lbMeetingStatus.TabIndex = 20;
            this.lbMeetingStatus.Text = "STATUS";
            this.lbMeetingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoToStage
            // 
            this.btnGoToStage.BackgroundImage = global::BackStage.Properties.Resources.button_go_to_the_stage;
            this.btnGoToStage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToStage.FlatAppearance.BorderSize = 0;
            this.btnGoToStage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToStage.Location = new System.Drawing.Point(360, 345);
            this.btnGoToStage.Name = "btnGoToStage";
            this.btnGoToStage.Size = new System.Drawing.Size(174, 43);
            this.btnGoToStage.TabIndex = 16;
            this.btnGoToStage.UseVisualStyleBackColor = true;
            this.btnGoToStage.Click += new System.EventHandler(this.btnGoToStage_Click);
            // 
            // btnArrangeMeeting
            // 
            this.btnArrangeMeeting.BackgroundImage = global::BackStage.Properties.Resources.button_arrange_meetingB;
            this.btnArrangeMeeting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArrangeMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArrangeMeeting.Location = new System.Drawing.Point(5, 345);
            this.btnArrangeMeeting.Name = "btnArrangeMeeting";
            this.btnArrangeMeeting.Size = new System.Drawing.Size(174, 43);
            this.btnArrangeMeeting.TabIndex = 15;
            this.btnArrangeMeeting.UseVisualStyleBackColor = true;
            this.btnArrangeMeeting.Click += new System.EventHandler(this.btnArrangeMeeting_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::BackStage.Properties.Resources.close_hover_tombola;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(501, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BackStage.Properties.Resources.z7LayersLogoTr;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.BackgroundImage = global::BackStage.Properties.Resources.button_roll;
            this.btnRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoll.FlatAppearance.BorderSize = 0;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoll.Location = new System.Drawing.Point(226, 345);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(87, 43);
            this.btnRoll.TabIndex = 22;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BackStage.Properties.Resources.backstagebg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 478);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lbMeetingStatus);
            this.Controls.Add(this.lbGoToStageStatus);
            this.Controls.Add(this.btnGoToStage);
            this.Controls.Add(this.btnArrangeMeeting);
            this.Controls.Add(this.gbArtists);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.gbArtists.ResumeLayout(false);
            this.gbArtists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalvin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRocky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScanRfid;
        private System.Windows.Forms.Label lblRfidSt;
        private System.Windows.Forms.GroupBox gbArtists;
        private System.Windows.Forms.PictureBox pbBalvin;
        private System.Windows.Forms.PictureBox pbNina;
        private System.Windows.Forms.PictureBox pbRocky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBalvin;
        private System.Windows.Forms.Label lbNina;
        private System.Windows.Forms.Label lbRocky;
        private System.Windows.Forms.Button btnArrangeMeeting;
        private System.Windows.Forms.Button btnGoToStage;
        private System.Windows.Forms.Label lbMeetingStatus;
        private System.Windows.Forms.Label lbGoToStageStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRoll;
    }
}

