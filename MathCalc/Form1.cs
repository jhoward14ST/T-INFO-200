///////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer ---- Description
// 2022-01-28 - Charles Costarella - All code has been created by Charles Costarella. Subsequent changes list my name: Jared Howard
// to show the timeline of changes while creating the calculator per my professor's instruction.
// 2022-01-28 - Jared Howard - Project created, buttons built and named
// 2022-01-29 - Jared Howard - Functionality added to buttons 0 - 9
// 2022-01-30 - Jared Howard - Functionality added to remaining buttons.
// 2022-01-30 - Jared Howard - COMPLETED and built
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalc
{
    ///////////////////////////////////////////////////////////////////////////
    // TINFO 200 B, Winter 2022
    // UWTacoma SET, Jared Howard
    // 2022-01-30 - L4calc - This application creates a functional calculator that allows the user to perform basic operations
    //
    public partial class Form1 : Form
    {
        private string mathOperation = string.Empty;
        private double leftOperand = 0.0;
        private bool beginningMathOp = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void numBtn_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" || beginningMathOp == true && display.Text != ".")
            {
                display.Clear();
            }

            /*Button btn = (Button)sender;
            string numberString = btn.Text;
            display.Text = display.Text + numberString;*/

            beginningMathOp = false;
            display.Text += ((Button)sender).Text;
        }
        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            // Completely clears user input and displays 0
            display.Text = "0";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Completely clears user input and displays 0
            display.Text = "0";
            // Clears calculation including left operand value
            leftOperand = 0.0;
        }
        private void posNegBtn_Click(object sender, EventArgs e)
        {
            // Turns user input into negative 
            display.Text = (-double.Parse(display.Text)).ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Removes the last number input by the user
            display.Text = display.Text.Remove(display.Text.Length - 1);
        }

        private void decimalPtBtn_Click(object sender, EventArgs e)
        {
            // If text already contains a decimal point, do not add point
            // If text does not contain a decimal point, add point
            display.Text = (display.Text.Contains(".")) ? display.Text : display.Text + ".";
        }


        private void equalsBtn_Click(object sender, EventArgs e)
        {
            // Controls which operation is performed in the calculator
            switch (mathOperation)
            {
                case "+":
                    display.Text = (leftOperand + double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (leftOperand - double.Parse(display.Text)).ToString();
                    break;
                case "x":
                    display.Text = (leftOperand * double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (leftOperand / double.Parse(display.Text)).ToString();
                    break;
                default:
                    Console.WriteLine("DEFAULT should not occur");
                    break;
            }
        }

        private void mathOpBtn_Click(object sender, EventArgs e)
        {
            // starting a new math operation, so flip the flag
            beginningMathOp = true;

            leftOperand = double.Parse(display.Text);

            mathOperation = ((Button)sender).Text;

        }
    }
}
