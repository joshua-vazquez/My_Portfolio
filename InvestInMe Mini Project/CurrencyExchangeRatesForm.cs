using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace InvestInMe_Mini_Project
{
    public partial class CurrencyExchangeRatesForm: Form
    {
        private StockMarketDataService currencyService;
        private ExcelExporter excelExporter;
        private DataTable currencyDataTable;
        public CurrencyExchangeRatesForm()
        {
            InitializeComponent();
            DisplayInstructions();
            string apiKey = Environment.GetEnvironmentVariable("ALPHAVANTAGE_API_KEY");
            currencyService = new StockMarketDataService(apiKey);
            excelExporter = new ExcelExporter();

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Value = 0;

            gridForexData.ColumnCount = 3;
            gridForexData.Columns[0].Name = "From Currency";
            gridForexData.Columns[1].Name = "To Currency";
            gridForexData.Columns[2].Name = "Exchange Rate";

        }

        private async void btnSearchCurrency_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 0;

            string fromCurrency = txtFromCurrency.Text;
            string toCurrency = txtToCurrency.Text;

            for (int i = 0; i < 30; i += 10)
            {
                progressBar2.Value = i;
                await Task.Delay(100);
            }

            JObject exchangeRates = await currencyService.GetExchangeRatesAsync(fromCurrency, toCurrency);

            if (exchangeRates != null)
            {
                progressBar2.Value = 50;

                var exchangeRateData = exchangeRates["Realtime Currency Exchange Rate"];
                currencyDataTable = new DataTable();

                currencyDataTable.Columns.Add("From Currency");
                currencyDataTable.Columns.Add("To Currency");
                currencyDataTable.Columns.Add("Exchange Rate");

                if (exchangeRateData != null && exchangeRateData.HasValues)
                {
                    gridForexData.Rows.Add(
                        exchangeRateData["1. From_Currency Code"].ToString(),
                        exchangeRateData["3. To_Currency Code"].ToString(),
                        exchangeRateData["5. Exchange Rate"].ToString()
                        );

                    var row = currencyDataTable.NewRow();
                    row["From Currency"] = exchangeRateData["1. From_Currency Code"].ToString();
                    row["To Currency"] = exchangeRateData["3. To_Currency Code"].ToString();
                    row["Exchange Rate"] = exchangeRateData["5. Exchange Rate"].ToString();
                    currencyDataTable.Rows.Add(row);

                    progressBar2.Value = 100;
                }
                else
                {
                    MessageBox.Show("No exchange rate data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve exchange rates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBar2.Value = 100;

            txtFromCurrency.Text = string.Empty;
            txtToCurrency.Text = string.Empty;
        }
        private void DisplayInstructions()
        {
            string instructions = "Utilize our Currency Exchange Rates functionality powered by the Alpha Vantage API to access real-time currency conversion information. This tool allows you to stay informed about the latest exchange rates between two currencies. Simply enter the \"from\" currency and the \"to\" currency in the respective fields and press the search button to retrieve the current exchange rate. This feature provides you with accurate and up-to-date currency conversion data, helping you make informed financial decisions.";
            rtbExchangeRatesInfo.Text = instructions;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            var directoryPath = @"C:\Files";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            var specificFilePath = Path.Combine(directoryPath, "currencyData.xlsx");
            excelExporter.ExportToExcel(currencyDataTable, specificFilePath);
            MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
