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
            if (isNewNumber)
            {
                calcEnterTxt.Text = "";
                equationLbl.Text = "";
                isNewNumber = false;
            }

            string digit = ((Button)sender).Text;

            if (hasDecimal && digit == ".")
            {
                digit = "";
            }

            if (digit == ".")
            {
                hasDecimal = true;
            }            

            calcEnterTxt.Text += digit;
        }

        // event handler for operation buttons
        private void operationBtn_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(calcEnterTxt.Text);
            calcEnterTxt.Text = "";
            pendingOperation = ((Button)sender).Text;

            equationLbl.Text += $"{x} {pendingOperation} ";
        }

        // event handler for equals button
        private void equalsBtn_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(calcEnterTxt.Text);

            double result;

            switch (pendingOperation)
            {
                case "+":
                    result = x + y;
                    calcEnterTxt.Text = result.ToString();
                    equationLbl.Text += $"{y} = {result}";
                    break;
                case "-":
                    result = x - y;
                    calcEnterTxt.Text = result.ToString();
                    equationLbl.Text += $"{y} = {result}";
                    break;
                case "*":
                    result = x * y;
                    calcEnterTxt.Text = result.ToString();
                    equationLbl.Text += $"{y} = {result}";
                    break;
                case "/":
                    result = x / y;
                    calcEnterTxt.Text = result.ToString();
                    equationLbl.Text += $"{y} = {result}";
                    break;
            }

            x = 0;
            pendingOperation = "";
            isNewNumber = true;
        }

        private void clearBtn_Click (object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            { 
                equationLbl.Text = "";
                x = 0;
                pendingOperation = "";
                isNewNumber = true;
            }

            calcEnterTxt.Text = "";
        }
    }
}
