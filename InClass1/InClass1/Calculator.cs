using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InClass1
{
    /* Calculator.cs
     * A simple calculator built with Windows Forms App
     * 
     * Revision History:
     *      Rafi Miah & Danial Tossel, 2024.05.15: Created
     */

    public partial class Calculator : Form
    {
        double x; // first operand
        double y; // second operand
        string pendingOperation; // operation to apply between 'x' and 'y'
        bool isNewNumber = false; // true when '=' gives result, false when digit is clicked
        bool hasDecimal = false; // true if decimal has already been clicked

        public Calculator()
        {
            InitializeComponent();
        }

        // event handler for number buttons
        private void digitBtn_Click(object sender, EventArgs e)
        {
            // resets label, textbox and isNewNumber
            if (isNewNumber)
            {
                calcEnterTxt.Text = "";
                equationLbl.Text = "";
                isNewNumber = false;
            }

            string digit = ((Button)sender).Text; // variable to store the value from the digit buttons

            // ignores decimals if one exists
            if (hasDecimal && (digit == "."))
            {
                digit = "";
            }

            // sets hasDecimal to true if one exists
            if (digit == ".")
            {
                hasDecimal = true;
            }            

            // appends the digit value to textbox
            calcEnterTxt.Text += digit;
        }

        // event handler for operation buttons
        private void operationBtn_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(calcEnterTxt.Text); // converts textbox value to double
            calcEnterTxt.Text = ""; // resets textbox value
            pendingOperation = ((Button)sender).Text; // sets pendingOperation to operation buttons value

            equationLbl.Text += $"{x} {pendingOperation} "; // formatted string to append to label
        }

        // event handler for equals button
        private void equalsBtn_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(calcEnterTxt.Text); // converts textbox value to double

            double result = 0;

            // switch case for handling all possible operations
            switch (pendingOperation)
            {
                case "+":
                    result = x + y;              
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
            }

            calcEnterTxt.Text = result.ToString(); // converts result to string and sets textbox value to result
            equationLbl.Text += $"{y} = {result}"; // appends y value and result to label

            x = 0; // resets x
            pendingOperation = ""; // resets pendingOperation
            isNewNumber = true; // sets inNewNumber to true
        }

        // event handler for clear buttons
        private void clearBtn_Click (object sender, EventArgs e)
        {
            // checks to see if button was specifically 'C'
            if (((Button)sender).Text == "C")
            { 
                equationLbl.Text = ""; // resets label
                x = 0; // resets x
                pendingOperation = ""; // resets pendingOperation
                isNewNumber = true; // sets inNewNumber to true
            }

            calcEnterTxt.Text = ""; // clears textbox on clear button press
        }
    }
}
