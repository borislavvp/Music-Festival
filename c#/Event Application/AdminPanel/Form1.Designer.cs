namespace AdminPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbProductsSold = new System.Windows.Forms.Label();
            this.lbProfit = new System.Windows.Forms.Label();
            this.lbCampTaken = new System.Windows.Forms.Label();
            this.lbCurrVisitors = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVisitorsInfo = new System.Windows.Forms.Button();
            this.btnCampingInfo = new System.Windows.Forms.Button();
            this.btnFinanceInfo = new System.Windows.Forms.Button();
            this.btnProductsInfo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelOverview = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbProductsSold);
            this.groupBox1.Controls.Add(this.lbProfit);
            this.groupBox1.Controls.Add(this.lbCampTaken);
            this.groupBox1.Controls.Add(this.lbCurrVisitors);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Overview";
            // 
            // lbProductsSold
            // 
            this.lbProductsSold.AutoSize = true;
            this.lbProductsSold.Location = new System.Drawing.Point(309, 65);
            this.lbProductsSold.Name = "lbProductsSold";
            this.lbProductsSold.Size = new System.Drawing.Size(41, 19);
            this.lbProductsSold.TabIndex = 7;
            this.lbProductsSold.Text = "stat";
            // 
            // lbProfit
            // 
            this.lbProfit.AutoSize = true;
            this.lbProfit.Location = new System.Drawing.Point(119, 65);
            this.lbProfit.Name = "lbProfit";
            this.lbProfit.Size = new System.Drawing.Size(41, 19);
            this.lbProfit.TabIndex = 6;
            this.lbProfit.Text = "stat";
            // 
            // lbCampTaken
            // 
            this.lbCampTaken.AutoSize = true;
            this.lbCampTaken.Location = new System.Drawing.Point(309, 33);
            this.lbCampTaken.Name = "lbCampTaken";
            this.lbCampTaken.Size = new System.Drawing.Size(41, 19);
            this.lbCampTaken.TabIndex = 5;
            this.lbCampTaken.Text = "stat";
            // 
            // lbCurrVisitors
            // 
            this.lbCurrVisitors.AutoSize = true;
            this.lbCurrVisitors.Location = new System.Drawing.Point(119, 33);
            this.lbCurrVisitors.Name = "lbCurrVisitors";
            this.lbCurrVisitors.Size = new System.Drawing.Size(41, 19);
            this.lbCurrVisitors.TabIndex = 4;
            this.lbCurrVisitors.Text = "stat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Current profit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Products sold&&rent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Campings taken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Currently Visitors";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVisitorsInfo);
            this.groupBox2.Controls.Add(this.btnCampingInfo);
            this.groupBox2.Controls.Add(this.btnFinanceInfo);
            this.groupBox2.Controls.Add(this.btnProductsInfo);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 155);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Status Information";
            // 
            // btnVisitorsInfo
            // 
            this.btnVisitorsInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnVisitorsInfo.BackgroundImage = global::AdminPanel.Properties.Resources.button_visitors;
            this.btnVisitorsInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisitorsInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitorsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisitorsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitorsInfo.Location = new System.Drawing.Point(6, 35);
            this.btnVisitorsInfo.Name = "btnVisitorsInfo";
            this.btnVisitorsInfo.Size = new System.Drawing.Size(165, 45);
            this.btnVisitorsInfo.TabIndex = 1;
            this.btnVisitorsInfo.UseVisualStyleBackColor = false;
            this.btnVisitorsInfo.Click += new System.EventHandler(this.btnVisitorsInfo_Click);
            // 
            // btnCampingInfo
            // 
            this.btnCampingInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCampingInfo.BackgroundImage = global::AdminPanel.Properties.Resources.button_camping_sites;
            this.btnCampingInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCampingInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCampingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCampingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampingInfo.Location = new System.Drawing.Point(201, 35);
            this.btnCampingInfo.Name = "btnCampingInfo";
            this.btnCampingInfo.Size = new System.Drawing.Size(165, 45);
            this.btnCampingInfo.TabIndex = 2;
            this.btnCampingInfo.UseVisualStyleBackColor = false;
            this.btnCampingInfo.Click += new System.EventHandler(this.btnCampingInfo_Click);
            // 
            // btnFinanceInfo
            // 
            this.btnFinanceInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnFinanceInfo.BackgroundImage = global::AdminPanel.Properties.Resources.button_finance;
            this.btnFinanceInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinanceInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinanceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceInfo.Location = new System.Drawing.Point(201, 97);
            this.btnFinanceInfo.Name = "btnFinanceInfo";
            this.btnFinanceInfo.Size = new System.Drawing.Size(165, 45);
            this.btnFinanceInfo.TabIndex = 4;
            this.btnFinanceInfo.UseVisualStyleBackColor = false;
            this.btnFinanceInfo.Click += new System.EventHandler(this.btnFinanceInfo_Click);
            // 
            // btnProductsInfo
            // 
            this.btnProductsInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnProductsInfo.BackgroundImage = global::AdminPanel.Properties.Resources.button_products;
            this.btnProductsInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductsInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsInfo.Location = new System.Drawing.Point(6, 97);
            this.btnProductsInfo.Name = "btnProductsInfo";
            this.btnProductsInfo.Size = new System.Drawing.Size(165, 45);
            this.btnProductsInfo.TabIndex = 3;
            this.btnProductsInfo.UseVisualStyleBackColor = false;
            this.btnProductsInfo.Click += new System.EventHandler(this.btnProductsInfo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelOverview
            // 
            this.panelOverview.Location = new System.Drawing.Point(474, 12);
            this.panelOverview.Name = "panelOverview";
            this.panelOverview.Size = new System.Drawing.Size(436, 313);
            this.panelOverview.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(992, 522);
            this.Controls.Add(this.panelOverview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVisitorsInfo;
        private System.Windows.Forms.Button btnCampingInfo;
        private System.Windows.Forms.Button btnProductsInfo;
        private System.Windows.Forms.Button btnFinanceInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbProductsSold;
        private System.Windows.Forms.Label lbProfit;
        private System.Windows.Forms.Label lbCampTaken;
        private System.Windows.Forms.Label lbCurrVisitors;
        private System.Windows.Forms.Panel panelOverview;
    }
}

