using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Calculator
    {
        public decimal currentValue;
        private decimal operand1;
        public decimal operand2;
        private Operator op;

        public enum Operator { Addd, Subtract, Multiply, Divide, None };

        //Needed to be changed from private to public 
        public Calculator()
        {
            this.currentValue = 0;
            this.operand1 = 0;
            this.operand2 = 0;
            this.op = Operator.None;
        }

        public decimal CurrentValue
        {
            get { return this.currentValue; }
        }

        public void Clear()
        {
            this.currentValue = 0;
            this.operand1 = 0;
            this.operand2 = 0;
            this.op = Operator.None;
        }

        public void Add(decimal val)
        {
            this.operand1 = val;
            this.currentValue = val;
            this.op = Operator.Addd;

        }

        public void Subtract(decimal val)
        {
            this.operand1 = val;
            this.currentValue = val;
            this.op = Operator.Subtract;

        }

        public void Multiply(decimal val)
        {
            this.operand1 = val;
            this.currentValue = val;
            this.op = Operator.Multiply;

        }

        public void Divide(decimal val)
        {
            this.operand1 = val;
            this.currentValue = val;
            this.op = Operator.Divide;
        }


        public void Equals(decimal val)
        {
            operand2 = val;
            switch (this.op)
            {
                case Operator.Addd:
                    currentValue = operand1 + operand2;
                    break;
                case Operator.Subtract:
                    currentValue = operand1 - operand2;
                    break;
                case Operator.Multiply:
                    currentValue = operand1 * operand2;
                    break;
                case Operator.Divide:
                    //Try catch to prevent dividing by zero
                    try
                    {
                        currentValue = operand1 / operand2;
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("You cannot divide by zero", "Error!");
                    }

                    break;
                case Operator.None:
                    currentValue = operand2;
                    break;

            }
            operand1 = currentValue;
        }

        public void SquareRoot(decimal val)
        {
            this.operand1 = val;
            currentValue = (decimal)Math.Sqrt(Convert.ToDouble(operand1));
            op = Operator.None;
        }

        public void Reciprocal(decimal val)
        {
            this.operand1 = val;
            currentValue = 1 / operand1;
            op = Operator.None;
        }

    }
}