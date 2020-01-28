namespace ATM
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
            this.lbVisitor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnAddOther = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd100 = new System.Windows.Forms.Button();
            this.btnAdd50 = new System.Windows.Forms.Button();
            this.btnAdd20 = new System.Windows.Forms.Button();
            this.btnAdd10 = new System.Windows.Forms.Button();
            this.lbAtmStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVisitor
            // 
            this.lbVisitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisitor.ForeColor = System.Drawing.Color.Black;
            this.lbVisitor.Location = new System.Drawing.Point(3, 25);
            this.lbVisitor.Name = "lbVisitor";
            this.lbVisitor.Size = new System.Drawing.Size(394, 24);
            this.lbVisitor.TabIndex = 0;
            this.lbVisitor.Text = "Visitor RFID";
            this.lbVisitor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.Controls.Add(this.lbVisitor);
            this.groupBox1.Controls.Add(this.btnAddOther);
            this.groupBox1.Controls.Add(this.tbAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd100);
            this.groupBox1.Controls.Add(this.btnAdd50);
            this.groupBox1.Controls.Add(this.btnAdd20);
            this.groupBox1.Controls.Add(this.btnAdd10);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ATM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "SCAN";
            // 
            // btnScan
            // 
            this.btnScan.BackgroundImage = global::ATM.Properties.Resources.rfidp;
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScan.Location = new System.Drawing.Point(158, 128);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 53);
            this.btnScan.TabIndex = 3;
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnAddOther
            // 
            this.btnAddOther.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOther.Location = new System.Drawing.Point(291, 225);
            this.btnAddOther.Name = "btnAddOther";
            this.btnAddOther.Size = new System.Drawing.Size(92, 31);
            this.btnAddOther.TabIndex = 4;
            this.btnAddOther.Text = "Add";
            this.btnAddOther.UseVisualStyleBackColor = true;
            this.btnAddOther.Click += new System.EventHandler(this.btnAddOther_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(146, 225);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(101, 29);
            this.tbAmount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Other amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "How much you want to add in to your account?";
            // 
            // btnAdd100
            // 
            this.btnAdd100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd100.Location = new System.Drawing.Point(291, 162);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Size = new System.Drawing.Size(92, 38);
            this.btnAdd100.TabIndex = 3;
            this.btnAdd100.Text = "100 $";
            this.btnAdd100.UseVisualStyleBackColor = true;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd100_Click);
            // 
            // btnAdd50
            // 
            this.btnAdd50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd50.Location = new System.Drawing.Point(6, 162);
            this.btnAdd50.Name = "btnAdd50";
            this.btnAdd50.Size = new System.Drawing.Size(98, 38);
            this.btnAdd50.TabIndex = 2;
            this.btnAdd50.Text = "50 $";
            this.btnAdd50.UseVisualStyleBackColor = true;
            this.btnAdd50.Click += new System.EventHandler(this.btnAdd50_Click);
            // 
            // btnAdd20
            // 
            this.btnAdd20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd20.Location = new System.Drawing.Point(291, 105);
            this.btnAdd20.Name = "btnAdd20";
            this.btnAdd20.Size = new System.Drawing.Size(92, 38);
            this.btnAdd20.TabIndex = 1;
            this.btnAdd20.Text = "20 $";
            this.btnAdd20.UseVisualStyleBackColor = true;
            this.btnAdd20.Click += new System.EventHandler(this.btnAdd20_Click);
            // 
            // btnAdd10
            // 
            this.btnAdd10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd10.Location = new System.Drawing.Point(6, 105);
            this.btnAdd10.Name = "btnAdd10";
            this.btnAdd10.Size = new System.Drawing.Size(98, 38);
            this.btnAdd10.TabIndex = 0;
            this.btnAdd10.Text = "10 $";
            this.btnAdd10.UseVisualStyleBackColor = true;
            this.btnAdd10.Click += new System.EventHandler(this.btnAdd10_Click);
            // 
            // lbAtmStatus
            // 
            this.lbAtmStatus.BackColor = System.Drawing.Color.MintCream;
            this.lbAtmStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbAtmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtmStatus.Location = new System.Drawing.Point(0, 356);
            this.lbAtmStatus.Name = "lbAtmStatus";
            this.lbAtmStatus.Size = new System.Drawing.Size(557, 31);
            this.lbAtmStatus.TabIndex = 6;
            this.lbAtmStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 387);
            this.Controls.Add(this.lbAtmStatus);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbVisitor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddOther;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd100;
        private System.Windows.Forms.Button btnAdd50;
        private System.Windows.Forms.Button btnAdd20;
        private System.Windows.Forms.Button btnAdd10;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAtmStatus;
    }
}

