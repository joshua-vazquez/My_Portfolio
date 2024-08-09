using Spectre.Console.Cli;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static Spectre.Console.AnsiConsole;

namespace Mortgage_Calculator
{
    public class CalculateMortgageCommand : Command<CalculateMortgageCommand.Settings>
    {
        public class Settings : CommandSettings
        {
            [CommandArgument(0, "[amountLoaned]")]
            [Description("The total amount of the loan.")]
            public double AmountLoaned { get; set; }

            [CommandArgument(1, "[interestRate]")]
            [Description("The annual interest rate.")]
            public double InterestRate { get; set; }

            [CommandArgument(2, "[numberOfYears]")]
            [Description("The total number of years for the loan term.")]
            public double NumberOfYears { get; set; }

            [CommandArgument(3, "[loanStartDate]")]
            [Description("The start date of the loan (yyyy-MM-dd).")]
            public DateTime LoanStartDate { get; set; }
        }

        public override int Execute(CommandContext context, Settings settings)
        {
            var monthlyRate = settings.InterestRate / 12 / 100;
            var numberOfPayments = settings.NumberOfYears * 12;
            var monthlyPayment = settings.AmountLoaned * monthlyRate / (Math.Pow(1 + monthlyRate, numberOfPayments) - 1);
            var payoffDate = settings.LoanStartDate.AddYears((int)settings.NumberOfYears);

            MarkupLine($"[green]Amount Loaned:[/] {settings.AmountLoaned:C}");
            MarkupLine($"[green]Interest Rate:[/] {settings.InterestRate}%");
            MarkupLine($"[green]Monthly Payment:[/] {monthlyPayment:C}");
            MarkupLine($"[green]Start Date:[/] {settings.LoanStartDate:yyyy-MM-dd}");
            MarkupLine($"[green]Payoff Date:[/] {payoffDate:yyyy-MM-dd}");

            return 0;
        }
    }
}
