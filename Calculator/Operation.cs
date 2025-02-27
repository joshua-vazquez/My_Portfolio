using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal abstract class Operation : ICalculation
    {
        public abstract double PerformCalculation(double operand1, double operand2, OperatorType operation);
    }
}
