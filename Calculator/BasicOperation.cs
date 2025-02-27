using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class BasicOperation : Operation
    {
        public override double PerformCalculation(double operand1, double operand2, OperatorType operation)
        {
            double result; 

            switch (operation)
            {
                case OperatorType.Add:
                    result = operand1 + operand2;
                    break;
                case OperatorType.Subtract:
                    result = operand1 - operand2;
                    break;
                case OperatorType.Multiply:
                    result = operand1 * operand2;
                    break;
                case OperatorType.Divide:
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK);
                        return double.NaN; // Return NaN to indicate an error
                    }
                    result = operand1 / operand2;
                    break;
                default:
                    throw new InvalidOperationException("Invalid Operator");
            }

            result = Math.Round(result, 10);

            return result;
        }
    }
}
