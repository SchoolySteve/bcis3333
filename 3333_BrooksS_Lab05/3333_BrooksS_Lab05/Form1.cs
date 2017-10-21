/*
 Brooks, Stephen
 000571395
 10/20/2017
 10/24/2017
 Need for Speed Calculator 
*/

using System;
using System.Windows.Forms;

namespace _3333_BrooksS_Lab05
{
    public partial class DistanceForm : Form
    {
        public DistanceForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int speed;
            int time;

            if (int.TryParse(tbSpeedIn.Text, out speed))
            {
                if (speed < 0 || speed > 180)
                {
                    MessageBox.Show("Please enter a speed greater than zero and less than 180.", "Input value error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbSpeedIn.Focus();
                    tbSpeedIn.Text = "";
                    return;
                }
            }
            else
            {
                ShowParserError();
                tbSpeedIn.Focus();
                tbSpeedIn.Text = "";
                return;
            }
            if (int.TryParse(tbTimeIn.Text, out time))
            {
                if (time < 0 || time > 50)
                {
                    MessageBox.Show("Please enter a time greater than zero and less than 50.", "Input value error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbTimeIn.Focus();
                    tbTimeIn.Text = "";
                    return;
                }
            }
            else
            {
                ShowParserError();
                tbTimeIn.Focus();
                tbTimeIn.Text = "";
                return;
            }

            PrintOutput(speed, time);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowParserError()
        {
            MessageBox.Show("Please enter a whole number", "Input value error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    c.Text = string.Empty;
            }

            tbSpeedIn.Focus();
        }

        private void PrintOutput(int speed, int time)
        {
            tbOutput.Text = "";

            for (int i = 0; i < time; i++)
            {
                tbOutput.Text += $"After hour {i + 1} the distance is {(i + 1) * speed}. \r\n";
            }
        }
    }
}