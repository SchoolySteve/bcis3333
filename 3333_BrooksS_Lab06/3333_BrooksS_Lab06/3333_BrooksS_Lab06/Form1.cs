/*
 Brooks, Stephen
 000571395
 11/5/2017
 11/07/2017
 Hospital StayCalculator 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_BrooksS_Lab06
{
    public enum InputType
    {
        Int,
        Double
    }

    public partial class Main : Form
    {
        private const int DailyRate = 350;
        private List<string> outputTextBoxes = new List<string>
        {
            "tbStayCharge",
            "tbMiscCharge",
            "tbTotal"
        };

        public Main()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var inputCollection = ValidateInputs();
            if (inputCollection == null)
                return;
            tbStayCharge.Text = CalcStayCharges((int)inputCollection[0]);
            tbMiscCharge.Text = CalcMiscCharges(inputCollection);
            tbTotal.Text = CalcTotalCharges(inputCollection);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    ((TextBox) control).Text = string.Empty;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string CalcStayCharges(int days)
        {
            return (DailyRate * days).ToString("C");
        }

        private string CalcMiscCharges(double[] values)
        {
            var totalCharge = 0.0;

            for (int x = 1; x < values.Length; x++)
            {
                totalCharge = totalCharge + values[x];
            }

            return totalCharge.ToString("C");
        }

        private string CalcTotalCharges(double[] values)
        {
            values[0] *= DailyRate;
            return values.Sum().ToString("C");
        }

        private double[] ValidateInputs()
        {
            var  inputValueCollection = new double[5];

            foreach (var control in Controls)
            {
                //clear output tetboxes
                if (control.GetType() == typeof(TextBox)
                    && outputTextBoxes.Contains(((TextBox) control).Name))
                {
                    ((TextBox) control).Text = string.Empty;
                }

                else if (control.GetType() == typeof(TextBox) 
                    && !outputTextBoxes.Contains(((TextBox)control).Name))
                {
                    var input = (TextBox) control;

                    switch (input.Name)
                    {
                        case "tbDaysSpent":
                            int temp;
                            if (int.TryParse(input.Text, out temp))
                            {
                                if (temp < 0)
                                {
                                    CallInputErrorDialog();
                                    input.Text = "";
                                    input.Focus();
                                    return null;
                                }
                                inputValueCollection[0] = temp;
                            }
                            else
                            {
                                CallParserError(InputType.Int);
                                input.Text = "";
                                input.Focus();
                                return null;
                            }
                            break;
                        case "tbMedCharges":
                            if (double.TryParse(input.Text, out inputValueCollection[1]))
                            {
                                if (inputValueCollection[1] < 0)
                                {
                                    CallInputErrorDialog();
                                    input.Text = "";
                                    input.Focus();
                                    return null;
                                }
                            }
                            else
                            {
                                CallParserError(InputType.Double);
                                input.Text = "";
                                input.Focus();
                                return null;
                            }
                            break;
                        case "tbSurgCharges":
                            if (double.TryParse(input.Text, out inputValueCollection[2]))
                            {
                                if (inputValueCollection[2] < 0)
                                {
                                    CallInputErrorDialog();
                                    input.Text = "";
                                    input.Focus();
                                    return null;
                                }
                            }
                            else
                            {
                                CallParserError(InputType.Double);
                                input.Text = "";
                                input.Focus();
                                return null;
                            }
                            break;
                        case "tbLabFees":
                            if (double.TryParse(input.Text, out inputValueCollection[3]))
                            {
                                if (inputValueCollection[3] < 0)
                                {
                                    CallInputErrorDialog();
                                    input.Text = "";
                                    input.Focus();
                                    return null;
                                }
                            }
                            else
                            {
                                CallParserError(InputType.Double);
                                input.Text = "";
                                input.Focus();
                                return null;
                            }
                            break;
                        case "tbPhysTher":
                            if (double.TryParse(input.Text, out inputValueCollection[4]))
                            {
                                if (inputValueCollection[4] < 0)
                                {
                                    CallInputErrorDialog();
                                    input.Text = "";
                                    input.Focus();
                                    return null;
                                }
                            }
                            else
                            {
                                CallParserError(InputType.Double);
                                input.Text = "";
                                input.Focus();
                                return null;
                            }
                            break;
                    }
                } 
                
            }

            return inputValueCollection;
        }

        private void CallInputErrorDialog()
        {
            MessageBox.Show("Please enter a value greater than or equal to zero", "Input value error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void CallParserError(InputType seekingType)
        {
            var errorDialog = "";

            errorDialog = seekingType == InputType.Int ? "Please enter a whole number" : "Please enter a number";

            MessageBox.Show(errorDialog, "Input value error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
