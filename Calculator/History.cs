using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class History : IDisplayable
    {
        private List<string> calculationHistory = new List<string>();

        public void UpdateDisplay(string text)
        {
            calculationHistory.Add(text);
        }

        public List <string> GetHistory()
        {
            return calculationHistory;
        }
    }
}
