using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class AdvanceOperation : Operation
    {
        public override double PerformCalculation(double operand1, double operand2, OperatorType operation)
        {
            double result;

            switch (operation)
            {
                case OperatorType.SquareRoot:
                    result = Math.Sqrt(operand1);
                    break;
                case OperatorType.Power:
                    result = Math.Pow(operand1, operand2);
                    break;
                case OperatorType.Percentage:
                    result = operand1 * (operand2 / 100);
                    break;
                case OperatorType.Reciprocal:
                    if (operand1 == 0)
                    { 
                        MessageBox.Show("Cannot find the reciprocal of zero.", "Error", MessageBoxButtons.OK);
                        return double.NaN; // Return NaN to indicate an error
                    }
                    result = 1 / operand1;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation");
            }

            return result;
        }
    }
}
