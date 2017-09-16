/*
 Brooks, Stephen
 000571395
 9/16/2017
 9/26/2017
 Fenway Finances 
*/


using System;
using System.Linq;
using System.Windows.Forms;
using _3333_BrooksS_Lab03.Helpers;

namespace _3333_BrooksS_Lab03
{
    public partial class Form1 : Form
    {
        private int _sumRevenue;
        private int _sumTickets;
        private int _transactionCount;
        private const int ClassACost = 15;
        private const int ClassBCost = 12;
        private const int ClassCCost = 9;

        public Form1()
        {
            InitializeComponent();
            ClassASoldTextBox.Focus();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var soldSeats = new int[3];

            var validate = new InputValidator();
            var inputFields = new[]
            {
                ClassASoldTextBox,
                ClassBSoldTextBox,
                ClassCSoldTextBox
            };

            for(var x = 0; x < inputFields.Length; x++)
            {
                string parseError;
                int tempValue;
                if (validate.ParseInt(inputFields[x].Text, out tempValue, out parseError))
                {
                    if (tempValue < 0)
                    {
                        ThrowAlert("Please enter an value greater than zero using only whole numbers");
                        inputFields[x].Focus();
                        return;
                    }
                    soldSeats[x] = tempValue;
                }
                else
                {
                    ThrowAlert("Sigh... better ways to do this. \r\n" + parseError);
                    inputFields[x].Text = "";
                    inputFields[x].Focus();
                    return;
                }
            }

            Calculate(soldSeats);
            ClassASoldTextBox.Focus();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in TicketsSoldGroupBox.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            foreach (Control c in RevenueGeneratedGroupBox.Controls )
            {
                if (c is TextBox)
                    c.Text = "";
            }

            ClassASoldTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region ErrorMessaging
        private void ThrowAlert(string errorMessage)
        {
            MessageBox.Show(errorMessage,
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        #endregion

        #region Calculations
        private void Calculate(int[] seatsSold)
        {
            var totalTickets = seatsSold.Sum();

            var calculatedRevenue = new[]
            {
                seatsSold[0] * ClassACost,
                seatsSold[1] * ClassBCost,
                seatsSold[2] * ClassCCost
            };

            _sumTickets += totalTickets;
            SumTicketsTextBox.Text = _sumTickets.ToString("N0");
            _sumRevenue += calculatedRevenue.Sum();
            SumRevenueTextBox.Text = _sumRevenue.ToString("C");
            _transactionCount++;
            SumTransactionsTextBox.Text = _transactionCount.ToString();

            ClassARevTextBox.Text = calculatedRevenue[0].ToString("C");
            ClassBRevTextBox.Text = calculatedRevenue[1].ToString("C");
            ClassCRevTextBox.Text = calculatedRevenue[2].ToString("C");

            TotalTicketsSoldTextBox.Text = totalTickets.ToString("N0");
        }
        #endregion
    }
}
