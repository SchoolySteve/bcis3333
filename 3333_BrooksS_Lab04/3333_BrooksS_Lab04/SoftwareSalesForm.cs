/*
 Brooks, Stephen
 000571395
 10/7/2017
 10/12/2017
 Software Sales
*/
using System;
using System.Windows.Forms;

namespace _3333_BrooksS_Lab04
{
    public partial class SoftwareSalesForm : Form
    {
        private const int unitPrice = 99;

        public SoftwareSalesForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int orderAmount;
            if(!int.TryParse(tbOrderQuantity.Text, out orderAmount))
            {
                MessageBox.Show("Please enter a whole number.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbOrderQuantity.Text = "";
                tbOrderQuantity.Focus();
                return;
            }
            if (orderAmount < 0)
            {
                MessageBox.Show("Please enter a value greater than zero.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbOrderQuantity.Text = "";
                tbOrderQuantity.Focus();
                return;
            }

            tbPreDiscountAmount.Text =
                (orderAmount * unitPrice).ToString("C");

            if (orderAmount < 10)
                CalculateMe(orderAmount, 0);
            else if (orderAmount >= 10 && orderAmount < 20)
                CalculateMe(orderAmount, .2);
            else if(orderAmount >= 20 && orderAmount < 50)
                CalculateMe(orderAmount, .3);
            else if(orderAmount >= 50 && orderAmount < 100)
                CalculateMe(orderAmount, .4);
            else if(orderAmount >= 100)
                CalculateMe(orderAmount, .5);
        }

        private void CalculateMe(int orderAmount, double discountRate)
        {
            var discountAmount = (orderAmount * unitPrice) * discountRate;
            var totalSale = (orderAmount * unitPrice) - discountAmount;

            tbDiscountRate.Text = discountRate.ToString("P");
            tbDiscountAmount.Text = discountAmount.ToString("C");
            tbTotal.Text = totalSale.ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)       
            {
                if(c is TextBox)
                    c.Text = string.Empty;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
