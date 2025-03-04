using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace InvestInMe_Mini_Project
{
    public partial class CurrencyExchangeRatesForm: Form
    {
        private StockMarketDataService currencyService;
        public CurrencyExchangeRatesForm()
        {
            InitializeComponent();
            DisplayInstructions();
            string apiKey = Environment.GetEnvironmentVariable("ALPHAVANTAGE_API_KEY");
            currencyService = new StockMarketDataService(apiKey);

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

                if (exchangeRateData != null && exchangeRateData.HasValues)
                {
                    gridForexData.Rows.Add(
                        exchangeRateData["1. From_Currency Code"].ToString(),
                        exchangeRateData["3. To_Currency Code"].ToString(),
                        exchangeRateData["5. Exchange Rate"].ToString()
                        );

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

        private void btnDownloadForex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality will be operational soon.", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void DisplayInstructions()
        {
            string instructions = "Utilize our Currency Exchange Rates functionality powered by the Alpha Vantage API to access real-time currency conversion information. This tool allows you to stay informed about the latest exchange rates between two currencies. Simply enter the \"from\" currency and the \"to\" currency in the respective fields and press the search button to retrieve the current exchange rate. This feature provides you with accurate and up-to-date currency conversion data, helping you make informed financial decisions.";
            rtbExchangeRatesInfo.Text = instructions;
        }
    }
}
