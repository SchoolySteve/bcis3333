namespace _3333_BrooksS_Lab06
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDaysSpent = new System.Windows.Forms.TextBox();
            this.tbMedCharges = new System.Windows.Forms.TextBox();
            this.tbSurgCharges = new System.Windows.Forms.TextBox();
            this.tbLabFees = new System.Windows.Forms.TextBox();
            this.tbPhysTher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbStayCharge = new System.Windows.Forms.TextBox();
            this.tbMiscCharge = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days Spent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medication Charges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surgical Charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lab Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phys. Therapy: ";
            // 
            // tbDaysSpent
            // 
            this.tbDaysSpent.Location = new System.Drawing.Point(141, 18);
            this.tbDaysSpent.Name = "tbDaysSpent";
            this.tbDaysSpent.Size = new System.Drawing.Size(100, 20);
            this.tbDaysSpent.TabIndex = 1;
            // 
            // tbMedCharges
            // 
            this.tbMedCharges.Location = new System.Drawing.Point(141, 44);
            this.tbMedCharges.Name = "tbMedCharges";
            this.tbMedCharges.Size = new System.Drawing.Size(100, 20);
            this.tbMedCharges.TabIndex = 2;
            // 
            // tbSurgCharges
            // 
            this.tbSurgCharges.Location = new System.Drawing.Point(141, 70);
            this.tbSurgCharges.Name = "tbSurgCharges";
            this.tbSurgCharges.Size = new System.Drawing.Size(100, 20);
            this.tbSurgCharges.TabIndex = 3;
            // 
            // tbLabFees
            // 
            this.tbLabFees.Location = new System.Drawing.Point(141, 96);
            this.tbLabFees.Name = "tbLabFees";
            this.tbLabFees.Size = new System.Drawing.Size(100, 20);
            this.tbLabFees.TabIndex = 4;
            // 
            // tbPhysTher
            // 
            this.tbPhysTher.Location = new System.Drawing.Point(141, 124);
            this.tbPhysTher.Name = "tbPhysTher";
            this.tbPhysTher.Size = new System.Drawing.Size(100, 20);
            this.tbPhysTher.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hospital Stay Charges:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Miscellaneous Charges:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Charges:";
            // 
            // tbStayCharge
            // 
            this.tbStayCharge.Location = new System.Drawing.Point(141, 167);
            this.tbStayCharge.Name = "tbStayCharge";
            this.tbStayCharge.ReadOnly = true;
            this.tbStayCharge.Size = new System.Drawing.Size(100, 20);
            this.tbStayCharge.TabIndex = 9;
            this.tbStayCharge.TabStop = false;
            // 
            // tbMiscCharge
            // 
            this.tbMiscCharge.Location = new System.Drawing.Point(141, 194);
            this.tbMiscCharge.Name = "tbMiscCharge";
            this.tbMiscCharge.ReadOnly = true;
            this.tbMiscCharge.Size = new System.Drawing.Size(100, 20);
            this.tbMiscCharge.TabIndex = 10;
            this.tbMiscCharge.TabStop = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(141, 221);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 11;
            this.tbTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 264);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 298);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbMiscCharge);
            this.Controls.Add(this.tbStayCharge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPhysTher);
            this.Controls.Add(this.tbLabFees);
            this.Controls.Add(this.tbSurgCharges);
            this.Controls.Add(this.tbMedCharges);
            this.Controls.Add(this.tbDaysSpent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDaysSpent;
        private System.Windows.Forms.TextBox tbMedCharges;
        private System.Windows.Forms.TextBox tbSurgCharges;
        private System.Windows.Forms.TextBox tbLabFees;
        private System.Windows.Forms.TextBox tbPhysTher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbStayCharge;
        private System.Windows.Forms.TextBox tbMiscCharge;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

