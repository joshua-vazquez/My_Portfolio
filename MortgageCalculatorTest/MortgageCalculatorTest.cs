using NUnit.Framework;
using MortgageCalculatorLibrary;

namespace MortgageCalculatorTests
{
    [TestFixture]
    public class MortgageCalculatorTests
    {
        [Test]
        public void CalculateTotalMonthlyPayment_ShouldReturnCorrectValue()
        {
            // Arrange
            double amountLoaned = 100000;
            double interestRate = 5;
            double numberOfYears = 30;
            var calculator = new MortgageCalculator(amountLoaned, interestRate, numberOfYears);

            // Act
            calculator.CalculateTotalMonthlyPayment();

            // Assert
            Assert.AreEqual(536.82, calculator.TotalMonthlyPayment, 0.01);
        }


        [Test]
        public void CalculateInterestPayment_ShouldReturnCorrectValue()
        {
            // Arrange
            double amountLoaned = 100000;
            double interestRate = 5;
            int numberOfYears = 30;
            var calculator = new MortgageCalculator(amountLoaned, interestRate, numberOfYears);
            calculator.CalculateTotalMonthlyPayment();

            // Act
            calculator.CalculateInterestPayment();

            // Assert
            Assert.AreEqual(416.67, calculator.InterestPayment, 0.01);
        }

        [Test]
        public void CalculatePrincipalPayment_ShouldReturnCorrectValue()
        {
            // Arrange
            double amountLoaned = 100000;
            double interestRate = 5;
            int numberOfYears = 30;
            var calculator = new MortgageCalculator(amountLoaned, interestRate, numberOfYears);
            calculator.CalculateTotalMonthlyPayment();
            calculator.CalculateInterestPayment();

            // Act
            calculator.CalculatePrincipalPayment();

            // Assert
            Assert.AreEqual(120.15, calculator.PrincipalPayment, 0.01);
        }

        [Test]
        public void UpdateRemainingBalance_ShouldReturnCorrectValue()
        {
            // Arrange
            double amountLoaned = 100000;
            double interestRate = 5;
            int numberOfYears = 30;
            var calculator = new MortgageCalculator(amountLoaned, interestRate, numberOfYears);
            calculator.CalculateTotalMonthlyPayment();
            calculator.CalculateInterestPayment();
            calculator.CalculatePrincipalPayment();

            // Act
            calculator.UpdateRemainingBalance();

            // Assert
            Assert.AreEqual(99879.85, calculator.RemainingBalance, 0.01);
        }
    }
}