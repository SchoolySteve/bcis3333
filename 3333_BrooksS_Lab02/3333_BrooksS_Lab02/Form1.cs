/*
Stephen Brooks
000571395
9/8/2017
9/12/2017
3 Card Monty without 3 cards... or Monty...
 */
using System;
using System.Windows.Forms;

namespace _3333_BrooksS_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Back_Club3_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Back_Dia3_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Back_Heart3_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Back_Spade3_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Back_Club4_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Front_Club3_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Front_Dia3_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Front_Heart3_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Front_Spade3_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void Front_Club4_Click(object sender, EventArgs e)
        {
            var picBox = (Control)sender;
            FlipCards(picBox.Name, this);
        }

        private void FlipCards(string clickedCard, Form1 theForm)
        {
            int indexLocation = clickedCard.IndexOf('_');
            string currentSide = clickedCard.Substring(0, indexLocation);
            string card = clickedCard.Substring((indexLocation + 1), (clickedCard.Length - indexLocation -1));

            foreach(Control c in theForm.Controls)
            {    
                //hide all faces
                if (c.Name.Contains("Front"))
                    c.Visible = false;
                //show all backs
                if (c.Name.Contains("Back"))
                    c.Visible = true;
                //flip clicked clard
                if (c.Name == clickedCard)
                    c.Visible = false;
                //flip anticard
                if (c.Name.Contains(card) && !c.Name.Contains(currentSide))
                    c.Visible = true;
            }

            var displayLabel = (Label)theForm.Controls.Find("DisplayedCard", true)[0];
            if (currentSide == "Front")
            {
                displayLabel.Text = "";
                return;
            }

            switch (card)
            {
                case ("Club3") :
                    displayLabel.Text = "Three (3) of Clubs";
                    break;
                case ("Dia3") :
                    displayLabel.Text = "Three (3) of Diamonds";
                    break;
                case ("Heart3") :
                    displayLabel.Text = "Three (3) of Hearts";
                    break;
                case ("Spade3") :
                    displayLabel.Text = "Three (3) of Spades";
                    break;
                case ("Club4") :
                    displayLabel.Text = "Four (4) of Clubs";
                    break;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
