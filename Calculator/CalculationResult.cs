using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal struct CalculationResult
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public double Result { get; set; }
        public OperatorType Operation { get; set; }
        public DateTime CalculationTime { get; set; }

        public CalculationResult(double operand1, double operand2, double result, OperatorType operation)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            Result = result;
            Operation = operation;
            CalculationTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Operand1} {GetOperationSymbol(Operation)} {Operand2} = {Result}";
        }

        private string GetOperationSymbol(OperatorType operation)
        {
            return operation switch
            {
                OperatorType.Add => "+",
                OperatorType.Subtract => "-",
                OperatorType.Multiply => "*",
                OperatorType.Divide => "/",
                OperatorType.Percentage => "%",
                OperatorType.Reciprocal => "1/",
                OperatorType.Power => "^",
                OperatorType.SquareRoot => "sqrt",
                _ => string.Empty
            };
        }
    }
}
