using System.Drawing.Text;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Display display;
        private History history;
        private double operand1;
        private double operand2;
        private OperatorType operation;
        private bool isSecondOperand;
        private bool isNewCalculation;

        public Form1()
        {
            InitializeComponent();
            display = new Display();
            history = new History();
            isNewCalculation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCurrentExp.Text = display.GetCurrentText();
            txtResult.Text = string.Empty;
            UpdateHistoryListView();
        }
        private void HandleNumberButtonClick(object sender)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                if (isNewCalculation)
                {
                    display.ClearText();
                    isNewCalculation = false;
                }

                if (isSecondOperand)
                {
                    display.ClearCurrentText();
                    isSecondOperand = false;
                }
                display.AppendText(button.Text);
                txtCurrentExp.Text = display.GetFullExpression();
            }
        }
        private void HandleOperatorButtonClick(object sender)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                operand1 = double.Parse(display.GetCurrentText());
                
                Dictionary<string, OperatorType> operatorMap = new Dictionary<string, OperatorType>
                {
                    { "btnAdd", OperatorType.Add},
                    { "btnSubtract", OperatorType.Subtract},
                    { "btnMultiply", OperatorType.Multiply},
                    { "btnDivide", OperatorType.Divide},
                    { "btnPercentage", OperatorType.Percentage},
                    { "btnReciprocal", OperatorType.Reciprocal},
                    { "btnSqRoot", OperatorType.SquareRoot},
                    { "btnPower", OperatorType.Power}
                };

                if (operatorMap.ContainsKey(button.Name))
                {
                    operation = operatorMap[button.Name];
                    if (operation == OperatorType.Power)
                    {
                        if (!isSecondOperand)
                        {
                            display.AppendText($"^");
                            txtCurrentExp.Text = display.GetFullExpression();
                            isSecondOperand = true;
                        }
                    }
                    else if (operation == OperatorType.Reciprocal)
                    {
                        display.ClearText();
                        display.AppendText($"1/{operand1}");
                        txtCurrentExp.Text = display.GetFullExpression();
                    }
                    else
                    {
                        display.AppendText($" {button.Text} ");
                        txtCurrentExp.Text = display.GetFullExpression();
                        isSecondOperand = true;
                    }
                }
            }
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(sender);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Check if the current text already contains a decimal point
            if (!display.GetCurrentText().Contains("."))
            {
                // If entering the second operand after an operator
                if (isSecondOperand)
                {
                    display.ClearCurrentText(); // Clear the current text for the second operand
                    isSecondOperand = false; // Reset the flag
                }

                display.AppendText("."); // Append the decimal point
                txtCurrentExp.Text = display.GetFullExpression(); // Update the display
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            HandleOperatorButtonClick(sender);
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            display.NegateCurrentText();
            txtCurrentExp.Text = display.GetFullExpression();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            HandleOperatorButtonClick(sender);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            HandleOperatorButtonClick(sender);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            HandleOperatorButtonClick(sender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HandleOperatorButtonClick(sender);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double result;
            Operation operation;

            // Identify whether the operation is advanced
            bool isAdvancedOperation = this.operation == OperatorType.SquareRoot ||
                                       this.operation == OperatorType.Reciprocal ||
                                       this.operation == OperatorType.Percentage ||
                                       this.operation == OperatorType.Power;

            if (isAdvancedOperation)
            {
                // use AdvanceOperation for advanced operations
                if (this.operation == OperatorType.Power || this.operation == OperatorType.Percentage)
                {
                    operand2 = double.Parse(display.GetCurrentText());
                }
                operation = new AdvanceOperation();
                result = operation.PerformCalculation(operand1, operand2, this.operation);
            }
            else
            {
                // use BasicOperation class
                operand2 = double.Parse(display.GetCurrentText());
                operation = new BasicOperation();
                result = operation.PerformCalculation(operand1, operand2, this.operation);
            }

            if (double.IsNaN(result))
            {
                txtCurrentExp.Text = "Error: Division by zero";
                txtResult.Text = string.Empty;
                return;
            }

            string fullExpression = display.GetFullExpression();
            fullExpression += $" = {result}";
            txtCurrentExp.Text = fullExpression;

            display.UpdateExpression(result.ToString());
            txtResult.Text = result.ToString();

            history.UpdateDisplay(fullExpression);
            UpdateHistoryListView();

            isNewCalculation = true;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            HandleOperatorButtonClick(sender);
        }

        private void btnSqRoot_Click(object sender, EventArgs e)
        {
            HandleOperatorButtonClick(sender);
        }
        private void btnPower_Click(object sender, EventArgs e)
        {
            HandleOperatorButtonClick(sender);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            display.ClearText();
            txtCurrentExp.Text = display.GetFullExpression();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string currentText = display.GetCurrentText();
            string fullExpression = display.GetFullExpression();

            if (!string.IsNullOrEmpty(currentText))
            {
                // Remove the last character from currentText
                currentText = currentText.Substring(0, currentText.Length - 1);

                // Remove the last character from fullExpression
                fullExpression = fullExpression.Substring(0, fullExpression.Length - 1);

                // Update the display label with the new text
                display.ClearCurrentText();
                display.AppendText(currentText);

                // Update the full expression in the display
                display.ClearText();
                display.AppendText(fullExpression);

                txtCurrentExp.Text = display.GetFullExpression();

            }
        }

        private void UpdateHistoryListView()
        {
            historyList.Items.Clear();
            foreach (var item in history.GetHistory())
            {
                historyList.Items.Add(item);
            }
        }
    }
}
