using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
        private string displayString;
        private int displayValue;


        private bool newValue;
        private bool decimalEntered;

        private Calculator Calc = new Calculator();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            displayValue = 0;
            displayString = "";
            newValue = true;
            decimalEntered = false;
        }

      
        private void btnNumber_Click(object sender, System.EventArgs e)
        {
            if (newValue)
            {
                displayString = "";
                newValue = false;
            }
            displayString += ((Button)sender).Tag.ToString();
            displayValue = Convert.ToDecimal(displayString);
            txtDisplay.Text = displayString;
        }

     
        private void btnBackSpace_Click(object sender, System.EventArgs e)
        {
            if (!newValue)
            {
                if (displayString.Length > 1)
                {
                    displayString = displayString.Substring(0, displayString.Length - 1);
                    displayValue = Convert.ToDecimal(displayString);
                    txtDisplay.Text = displayString;
                }
                else if (displayString.Length == 1)
                {
                    displayValue = calc.CurrentValue;
                    displayString = displayValue.ToString();
                    txtDisplay.Text = displayString;
                    newValue = true;
                }
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            calc.Clear();
            displayString = "";
            displayValue = 0;
            txtDisplay.Text = displayValue.ToString();
            newValue = true;
            decimalEntered = false;
        }

     
        private void btnDecimal_Click(object sender, System.EventArgs e)
        {
        
                displayString += ".";
                displayValue = Convert.ToInt16(displayString);
                txtDisplay.Text = displayString;
                decimalEntered = true;
        
        }

        private void btnSign_Click(object sender, System.EventArgs e)
        {
            displayValue = -displayValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            calc.Add(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnSubtract_Click(object sender, System.EventArgs e)
        {
            calc.Subtract(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnMultiply_Click(object sender, System.EventArgs e)
        {
            calc.Multiply(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            calc.Divide(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnSqrt_Click(object sender, System.EventArgs e)
        {
            calc.SquareRoot(displayValue);
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnReciprocal_Click(object sender, System.EventArgs e)
        {
            try
            {
                calc.Reciprocal(displayValue);
                displayValue = calc.CurrentValue;
                txtDisplay.Text = displayValue.ToString();
            }
            catch (DivideByZeroException)
            {
                displayValue = 0;
                txtDisplay.Text = "Cannot divide by zero.";
                newValue = true;
                decimalEntered = false;
            }
        }

        private void btnEquals_Click(object sender, System.EventArgs e)
        {
           
                if (newValue)
                    calc.Equals();
                else
                    calc.Equals(displayValue);
                displayValue = calc.CurrentValue;
                txtDisplay.Text = displayValue.ToString();
                newValue = true;
                decimalEntered = false;
      
        }

    }
}