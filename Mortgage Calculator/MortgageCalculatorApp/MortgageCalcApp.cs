using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using Spectre.Console;
using Spectre.Console.Cli;
using static Spectre.Console.Color;
using static Spectre.Console.AnsiConsole;
using MortgageCalculatorLibrary;
using Mortgage_Calculator;


namespace MortgageCalculatorApp
{
    class MortgageCalcApp
    {
        public static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                // Interactive mode
                return InteractiveMode();
            }
            else
            {
                // Command-line mode
                var app = new CommandApp();
                app.Configure(config =>
                {
                    config.AddCommand<CalculateMortgageCommand>("calculate");
                });
                return app.Run(args);
            }
        }

        public static int InteractiveMode()
        { 
            // Display the application title
            Write(new FigletText("Mortgage Calculator").Centered().Color(Green));


            double amountLoaned;
            string formattedAmountLoaned;
            while (true)
            {
                string input = Ask<string>("Enter the [green] amount loaned[/]");

                if (!string.IsNullOrEmpty(input))
                {
                    input = Regex.Replace(input, @"[^\d.]", ""); // Remove any non-numeric characters

                    if (double.TryParse(input, out amountLoaned) && amountLoaned > 0)
                    {
                        formattedAmountLoaned = amountLoaned.ToString("C0", CultureInfo.CurrentCulture);
                        break;
                    }
                }
                MarkupLine("[red]Invalid amount. Please enter a valid number greater than zero.[/]");
            }

            double interestRate;
            string formattedInterestRate;
            while (true)
            {
                string input = Ask<string>("Enter the [green]interest rate[/]");

                if (!string.IsNullOrEmpty(input))
                {
                    input = Regex.Replace(input, @"[^\d.]", ""); // Remove any non-numeric characters

                    if (double.TryParse(input, out interestRate) && interestRate > 0 && interestRate <= 100)
                    {
                        formattedInterestRate = interestRate.ToString("0.0", CultureInfo.CurrentCulture) + "%";
                        break;
                    }
                }


                MarkupLine("[red]Invalid interest rate. Please enter a valid number between 0 and 100.[/]");
            }

            double numberOfYears;
            while (true)
            {
                string input = Ask<string>("Enter the [green]number of years[/]");

                if (!string.IsNullOrEmpty(input) && double.TryParse(input, out numberOfYears) && numberOfYears > 0)
                {
                    break;
                }
                MarkupLine("[red]Invalid number of years. Please enter a valid number greater than zero.[/]");
            }

            DateTime loanStartDate;
            while (true)
            {
                try
                {
                    string dateInput = Ask<string>("Enter the [green] loan start date (yyyy-MM-dd):[/] ");
                    if (!string.IsNullOrEmpty(dateInput))
                    {
                        loanStartDate = DateTime.Parse(dateInput);
                        if (loanStartDate > DateTime.Now)
                        {
                            throw new ArgumentOutOfRangeException(nameof(loanStartDate), "Loan start date cannot be in the future.");
                        }
                        break; // Exit the loop if the date is still valid
                    }
                    MarkupLine("[red]Invalid date format. Please enter a valid date in the format yyyy-MM-dd.[/]");

                }
                catch (FormatException)
                {
                    MarkupLine("[red]Invalid date format. Please enter a valid date in the format yyyy-MM-dd.[/]");
                }
                catch (ArgumentOutOfRangeException)
                {
                    MarkupLine("[red]The specified date does not exist. Please enter a valid date.[/]");
                }
            }
            try
            {
                var calculator = new MortgageCalculator(amountLoaned, interestRate, numberOfYears, loanStartDate);

                Progress()
                    .Start(ctx =>
                    {
                        var task = ctx.AddTask("[green]Calculating mortgage details...[/]");
                        for (int i = 0; i < 12; i++)
                        {
                            if (ctx.IsFinished)
                            {
                                break;
                            }

                            calculator.PerformMonthlyCalculations();
                            task.Increment(100 / 12); // Simulate progress
                            Thread.Sleep(100); // Simulate work
                        }

                        // Ensure the progress bar reaches 100%
                        task.Value = 100;
                    });

                var payoffDate = calculator.CalculatePayoffDate();

                // Create a table
                var table = new Table();
                table.AddColumn("Mortgage Details");
                table.AddColumn("Amount");

                // Add rows to the table
                table.AddRow("[bold yellow]Total Monthly Payment[/]", $"{calculator.TotalMonthlyPayment:C}");
                table.AddRow("[bold yellow]Interest Payment[/]", $"{calculator.InterestPayment:C}");
                table.AddRow("[bold yellow]Principal Payment[/]", $"{calculator.PrincipalPayment:C}");
                table.AddRow("[bold yellow]Remaining Balance[/]", $"{calculator.RemainingBalance:C}");
                table.AddRow("[bold yellow]Estimated Payoff Date[/]", $"{payoffDate:yyyy-MM-dd}");
                table.AddRow("[bold yellow]Amount Loaned[/]", formattedAmountLoaned);
                table.AddRow("[bold yellow]Annual Interest Rate[/]", formattedInterestRate);

                // Render the table
                Write(table);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MarkupLine($"[red]Error: {ex.Message}[/]");
            }

            return 0;
        }
    }           
}
