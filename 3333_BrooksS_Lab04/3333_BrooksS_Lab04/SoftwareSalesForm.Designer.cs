namespace _3333_BrooksS_Lab04
{
    partial class SoftwareSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareSalesForm));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderQuantity = new System.Windows.Forms.TextBox();
            this.tbPreDiscountAmount = new System.Windows.Forms.TextBox();
            this.tbDiscountRate = new System.Windows.Forms.TextBox();
            this.tbDiscountAmount = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 169);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(123, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(238, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discount Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pre-Discount:";
            // 
            // tbOrderQuantity
            // 
            this.tbOrderQuantity.Location = new System.Drawing.Point(111, 9);
            this.tbOrderQuantity.Name = "tbOrderQuantity";
            this.tbOrderQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbOrderQuantity.TabIndex = 1;
            // 
            // tbPreDiscountAmount
            // 
            this.tbPreDiscountAmount.Location = new System.Drawing.Point(111, 35);
            this.tbPreDiscountAmount.Name = "tbPreDiscountAmount";
            this.tbPreDiscountAmount.ReadOnly = true;
            this.tbPreDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.tbPreDiscountAmount.TabIndex = 9;
            this.tbPreDiscountAmount.TabStop = false;
            // 
            // tbDiscountRate
            // 
            this.tbDiscountRate.Location = new System.Drawing.Point(111, 61);
            this.tbDiscountRate.Name = "tbDiscountRate";
            this.tbDiscountRate.ReadOnly = true;
            this.tbDiscountRate.Size = new System.Drawing.Size(100, 20);
            this.tbDiscountRate.TabIndex = 10;
            this.tbDiscountRate.TabStop = false;
            // 
            // tbDiscountAmount
            // 
            this.tbDiscountAmount.Location = new System.Drawing.Point(111, 88);
            this.tbDiscountAmount.Name = "tbDiscountAmount";
            this.tbDiscountAmount.ReadOnly = true;
            this.tbDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.tbDiscountAmount.TabIndex = 11;
            this.tbDiscountAmount.TabStop = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(111, 115);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 12;
            this.tbTotal.TabStop = false;
            // 
            // SoftwareSalesForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(325, 205);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbDiscountAmount);
            this.Controls.Add(this.tbDiscountRate);
            this.Controls.Add(this.tbPreDiscountAmount);
            this.Controls.Add(this.tbOrderQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoftwareSalesForm";
            this.Text = "Software Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrderQuantity;
        private System.Windows.Forms.TextBox tbPreDiscountAmount;
        private System.Windows.Forms.TextBox tbDiscountRate;
        private System.Windows.Forms.TextBox tbDiscountAmount;
        private System.Windows.Forms.TextBox tbTotal;
    }
}

