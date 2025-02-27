using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Display : IDisplayable
    {
        private string currentText;
        private string fullExpression;
       

        public void UpdateDisplay(string text)
        {
            currentText = string.Empty;
            fullExpression = string.Empty;
        }

        public string GetCurrentText()
        {
            return currentText;
        }
        public string GetFullExpression()
        {
            return fullExpression;
        }

        public void AppendText(string text)
        {
            currentText += text;
            fullExpression += text;
        }
        public void ClearText()
        {
            currentText = string.Empty;
            fullExpression = string.Empty;
            
        }
        public void ClearCurrentText()
        {
            currentText = string.Empty;
        }
        public void UpdateExpression(string result)
        {
            fullExpression += $" = {result}";
            currentText = result;
        }
        public void NegateCurrentText()
        {
            if (double.TryParse(currentText, out double number))
            {
                number = -number;
                currentText = number.ToString();

                fullExpression = fullExpression.Substring(0, fullExpression.LastIndexOf(' ') + 1);
                fullExpression += $"({currentText})";
            }
        }
    }
}
