using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculation
    {
        double PerformCalculation(double operand1, double operand2, OperatorType operation);
    }
}
