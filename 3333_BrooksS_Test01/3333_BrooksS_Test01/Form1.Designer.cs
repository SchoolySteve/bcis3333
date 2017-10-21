namespace _3333_BrooksS_Test01
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSaleAmount = new System.Windows.Forms.TextBox();
            this.tbCountyTaxAmount = new System.Windows.Forms.TextBox();
            this.tbTotalTaxAmount = new System.Windows.Forms.TextBox();
            this.tbTotalSalesAmount = new System.Windows.Forms.TextBox();
            this.tbOverallSales = new System.Windows.Forms.TextBox();
            this.tbStateTaxAmount = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbOverallSales = new System.Windows.Forms.PictureBox();
            this.pbTotalSale = new System.Windows.Forms.PictureBox();
            this.pbTotalTax = new System.Windows.Forms.PictureBox();
            this.pbStateTax = new System.Windows.Forms.PictureBox();
            this.pbCountyTax = new System.Windows.Forms.PictureBox();
            this.pbSaleAmount = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverallSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStateTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountyTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaleAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "County Tax Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "State Tax Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Sale Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Overall Sales:";
            // 
            // tbSaleAmount
            // 
            this.tbSaleAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaleAmount.Location = new System.Drawing.Point(247, 13);
            this.tbSaleAmount.Name = "tbSaleAmount";
            this.tbSaleAmount.Size = new System.Drawing.Size(196, 29);
            this.tbSaleAmount.TabIndex = 1;
            // 
            // tbCountyTaxAmount
            // 
            this.tbCountyTaxAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountyTaxAmount.Location = new System.Drawing.Point(247, 52);
            this.tbCountyTaxAmount.Name = "tbCountyTaxAmount";
            this.tbCountyTaxAmount.ReadOnly = true;
            this.tbCountyTaxAmount.Size = new System.Drawing.Size(196, 29);
            this.tbCountyTaxAmount.TabIndex = 7;
            this.tbCountyTaxAmount.TabStop = false;
            // 
            // tbTotalTaxAmount
            // 
            this.tbTotalTaxAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalTaxAmount.Location = new System.Drawing.Point(247, 122);
            this.tbTotalTaxAmount.Name = "tbTotalTaxAmount";
            this.tbTotalTaxAmount.ReadOnly = true;
            this.tbTotalTaxAmount.Size = new System.Drawing.Size(196, 29);
            this.tbTotalTaxAmount.TabIndex = 8;
            this.tbTotalTaxAmount.TabStop = false;
            // 
            // tbTotalSalesAmount
            // 
            this.tbTotalSalesAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalSalesAmount.Location = new System.Drawing.Point(247, 157);
            this.tbTotalSalesAmount.Name = "tbTotalSalesAmount";
            this.tbTotalSalesAmount.ReadOnly = true;
            this.tbTotalSalesAmount.Size = new System.Drawing.Size(196, 29);
            this.tbTotalSalesAmount.TabIndex = 9;
            this.tbTotalSalesAmount.TabStop = false;
            // 
            // tbOverallSales
            // 
            this.tbOverallSales.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOverallSales.Location = new System.Drawing.Point(247, 192);
            this.tbOverallSales.Name = "tbOverallSales";
            this.tbOverallSales.ReadOnly = true;
            this.tbOverallSales.Size = new System.Drawing.Size(196, 29);
            this.tbOverallSales.TabIndex = 10;
            this.tbOverallSales.TabStop = false;
            // 
            // tbStateTaxAmount
            // 
            this.tbStateTaxAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStateTaxAmount.Location = new System.Drawing.Point(247, 87);
            this.tbStateTaxAmount.Name = "tbStateTaxAmount";
            this.tbStateTaxAmount.ReadOnly = true;
            this.tbStateTaxAmount.Size = new System.Drawing.Size(196, 29);
            this.tbStateTaxAmount.TabIndex = 11;
            this.tbStateTaxAmount.TabStop = false;
            // 
            // btnCalc
            // 
            this.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(16, 244);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(111, 32);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(173, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(332, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbOverallSales
            // 
            this.pbOverallSales.Image = ((System.Drawing.Image)(resources.GetObject("pbOverallSales.Image")));
            this.pbOverallSales.Location = new System.Drawing.Point(226, 195);
            this.pbOverallSales.Name = "pbOverallSales";
            this.pbOverallSales.Size = new System.Drawing.Size(15, 26);
            this.pbOverallSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOverallSales.TabIndex = 15;
            this.pbOverallSales.TabStop = false;
            // 
            // pbTotalSale
            // 
            this.pbTotalSale.Image = ((System.Drawing.Image)(resources.GetObject("pbTotalSale.Image")));
            this.pbTotalSale.Location = new System.Drawing.Point(226, 160);
            this.pbTotalSale.Name = "pbTotalSale";
            this.pbTotalSale.Size = new System.Drawing.Size(15, 26);
            this.pbTotalSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTotalSale.TabIndex = 16;
            this.pbTotalSale.TabStop = false;
            // 
            // pbTotalTax
            // 
            this.pbTotalTax.Image = ((System.Drawing.Image)(resources.GetObject("pbTotalTax.Image")));
            this.pbTotalTax.Location = new System.Drawing.Point(226, 125);
            this.pbTotalTax.Name = "pbTotalTax";
            this.pbTotalTax.Size = new System.Drawing.Size(15, 26);
            this.pbTotalTax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTotalTax.TabIndex = 17;
            this.pbTotalTax.TabStop = false;
            // 
            // pbStateTax
            // 
            this.pbStateTax.Image = ((System.Drawing.Image)(resources.GetObject("pbStateTax.Image")));
            this.pbStateTax.Location = new System.Drawing.Point(226, 90);
            this.pbStateTax.Name = "pbStateTax";
            this.pbStateTax.Size = new System.Drawing.Size(15, 26);
            this.pbStateTax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStateTax.TabIndex = 18;
            this.pbStateTax.TabStop = false;
            // 
            // pbCountyTax
            // 
            this.pbCountyTax.Image = ((System.Drawing.Image)(resources.GetObject("pbCountyTax.Image")));
            this.pbCountyTax.Location = new System.Drawing.Point(226, 55);
            this.pbCountyTax.Name = "pbCountyTax";
            this.pbCountyTax.Size = new System.Drawing.Size(15, 26);
            this.pbCountyTax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCountyTax.TabIndex = 19;
            this.pbCountyTax.TabStop = false;
            // 
            // pbSaleAmount
            // 
            this.pbSaleAmount.Image = ((System.Drawing.Image)(resources.GetObject("pbSaleAmount.Image")));
            this.pbSaleAmount.Location = new System.Drawing.Point(226, 13);
            this.pbSaleAmount.Name = "pbSaleAmount";
            this.pbSaleAmount.Size = new System.Drawing.Size(15, 26);
            this.pbSaleAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSaleAmount.TabIndex = 20;
            this.pbSaleAmount.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(458, 288);
            this.Controls.Add(this.pbSaleAmount);
            this.Controls.Add(this.pbCountyTax);
            this.Controls.Add(this.pbStateTax);
            this.Controls.Add(this.pbTotalTax);
            this.Controls.Add(this.pbTotalSale);
            this.Controls.Add(this.pbOverallSales);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbStateTaxAmount);
            this.Controls.Add(this.tbOverallSales);
            this.Controls.Add(this.tbTotalSalesAmount);
            this.Controls.Add(this.tbTotalTaxAmount);
            this.Controls.Add(this.tbCountyTaxAmount);
            this.Controls.Add(this.tbSaleAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Old Timey Register";
            ((System.ComponentModel.ISupportInitialize)(this.pbOverallSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStateTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountyTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaleAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSaleAmount;
        private System.Windows.Forms.TextBox tbCountyTaxAmount;
        private System.Windows.Forms.TextBox tbTotalTaxAmount;
        private System.Windows.Forms.TextBox tbTotalSalesAmount;
        private System.Windows.Forms.TextBox tbOverallSales;
        private System.Windows.Forms.TextBox tbStateTaxAmount;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbOverallSales;
        private System.Windows.Forms.PictureBox pbTotalSale;
        private System.Windows.Forms.PictureBox pbTotalTax;
        private System.Windows.Forms.PictureBox pbStateTax;
        private System.Windows.Forms.PictureBox pbCountyTax;
        private System.Windows.Forms.PictureBox pbSaleAmount;
    }
}

