/*000571395
 * Brooks,Stephen
 * 10/10/2017
 * 10/10/2017
 * Test 1 - An old timey calculator thing
 */

using System;
using System.Windows.Forms;

namespace _3333_BrooksS_Test01
{
    public partial class MainForm : Form
    {
        private const double StateSalesTax = .08;
        private const double LocalSalesTax = .04;
        private double _runningSales = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double saleAmount;
            if (!double.TryParse(tbSaleAmount.Text, out saleAmount))
            {
                MessageBox.Show("Please enter a dollar amount.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSaleAmount.Text = "";
                tbSaleAmount.Focus();
                return;
            }
            if (saleAmount < 0)
            {
                MessageBox.Show("Please enter a dollar amount greater tha or equal to zero.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSaleAmount.Text = "";
                tbSaleAmount.Focus();
                return;
            }
            else
            {
                var localTaxAmount = saleAmount * LocalSalesTax;
                tbCountyTaxAmount.Text = localTaxAmount.ToString("C");

                var stateTaxAmount = saleAmount * StateSalesTax;
                tbStateTaxAmount.Text = stateTaxAmount.ToString("C");

                var totalTax = localTaxAmount + stateTaxAmount;
                tbTotalTaxAmount.Text = totalTax.ToString("C");

                var totalSaleAmount = saleAmount + totalTax;
                tbTotalSalesAmount.Text = totalSaleAmount.ToString("C");

                _runningSales += totalSaleAmount;
                tbOverallSales.Text = _runningSales.ToString("C");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    c.Text = string.Empty;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}