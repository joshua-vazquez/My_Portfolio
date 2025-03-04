using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestInMe_Mini_Project
{
    public partial class StockMarketDataForm: Form
    {
        private StockMarketDataService stockService;
        public StockMarketDataForm()
        {
            InitializeComponent();
            DisplayInstructions();
            string apiKey = Environment.GetEnvironmentVariable("ALPHAVANTAGE_API_KEY");
            stockService = new StockMarketDataService(apiKey);

            cmbTimeSeries.DataSource = Enum.GetValues(typeof(TimeSeries));

            gridStockData.ColumnCount = 6;
            gridStockData.Columns[0].Name = "Date";
            gridStockData.Columns[1].Name = "Open";
            gridStockData.Columns[2].Name = "Close";
            gridStockData.Columns[3].Name = "High";
            gridStockData.Columns[4].Name = "Low";
            gridStockData.Columns[5].Name = "Volume";
        }

        private async void btnGetStockData_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;


            string symbol = txtSymbol.Text;
            TimeSeries timeSeries = (TimeSeries)cmbTimeSeries.SelectedItem;

            // simulate progress before API call
            for (int i = 0; i < 30; i += 10)
            {
                progressBar1.Value = 1;
                await Task.Delay(100); // Simulates work being done
            }
            JObject stockData = await stockService.GetStockDataAsync(symbol, timeSeries);

            if (stockData != null)
            {
                //Log the entire JSON structure for debugging purposes
                Console.WriteLine(stockData.ToString());

                // Simulate progress during JSON processing
                progressBar1.Value = 50;

                // Construct the time series key based on the selected time series
                string timeSeriesKey;
                switch(timeSeries)
                {
                    case TimeSeries.TIME_SERIES_DAILY:
                        timeSeriesKey = "Time Series (Daily)";
                        break;
                    case TimeSeries.TIME_SERIES_WEEKLY:
                        timeSeriesKey = "Time Series (Weekly)";
                        break;
                    case TimeSeries.TIME_SERIES_MONTHLY:
                        timeSeriesKey = "Time Series (Monthly)";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(timeSeries), timeSeries, null);
                }
                
                Console.WriteLine("Expected Time Series Key: " + timeSeriesKey);
                
                //Check if the key exists in the JSON object
                if(stockData.ContainsKey(timeSeriesKey))
                {
                    var timeSeriesData = stockData[timeSeriesKey];

                    if(timeSeriesData != null)
                    {
                        gridStockData.Rows.Clear();

                        // simulate progress for data population
                        int rowCount = timeSeriesData.Children().Count();
                        int progressIncrement = 50 / rowCount;
                        int progressValue = 50;

                        foreach (var item in timeSeriesData.Children())
                        {
                            var date = ((JProperty)item).Name;
                            var data = ((JProperty)item).Value;

                            gridStockData.Rows.Add(
                                date,
                                data["1. open"].ToString(),
                                data["4. close"].ToString(),
                                data["2. high"].ToString(),
                                data["3. low"].ToString(),
                                data["5. volume"].ToString()
                            );

                            // Update progress bar incrementally
                            progressValue += progressIncrement;
                            progressBar1.Value = Math.Min(progressValue, 100);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data available for the selected time series.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The expected key was not found in the JSON response.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Set the progress bar to complete
            progressBar1.Value = 100;
        }
        private void DisplayInstructions()
        {
            string instructions = "Utilize our Stock Market Data functionality powered by the Alpha Vantage API to access detailed stock market information.This tool allows you to stay informed about the latest market trends and analyze stock performance over different time intervals. Simply select the desired time series (daily, weekly, or monthly) from the combo box and enter the stock symbol in the text box. Press the search button to retrieve the stock market data for the specified symbol.";
            rtbStockDataInfo.Text = instructions;
        }
        private void btnDownloadStockData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This funcionality will be coming soon... Come back later.", "Under Construction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
