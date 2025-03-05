using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace InvestInMe_Mini_Project
{ 
    public enum TimeSeries
    {
        TIME_SERIES_DAILY = 1,
        TIME_SERIES_WEEKLY,
        TIME_SERIES_MONTHLY,
    }
    public enum SortBy
    {
        LATEST = 1,
        EARLIEST,
        RELEVANCE
    }
    class StockMarketDataService
    {
        private readonly string apiKey;

        public StockMarketDataService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<JObject> GetStockDataAsync(string symbol, TimeSeries timeSeries)
        {
            string url = $"https://www.alphavantage.co/query?function={timeSeries}&symbol={symbol}&apikey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                //log response body for debugging purposes
                Console.WriteLine(responseBody);

                return JObject.Parse(responseBody);
            }
        }
        public async Task<JObject> GetExchangeRatesAsync(string fromCurrency, string toCurrency)
        {
            string url = $"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={fromCurrency}&to_currency={toCurrency}&apikey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                //log response body for debugging purposes
                Console.WriteLine(responseBody);

                return JObject.Parse(responseBody);
            }
        }
        public async Task<JObject> GetNewsSentimentsAsync(string searchTicker, string searchTopic = null, DateTime? timeFrom = null, DateTime? timeTo = null, string sort ="latest", int limit = 10)
        {
            string timeFromStr = timeFrom.HasValue ? timeFrom.Value.ToString("yyyyMMdd'T'HHmm") : null;
            string timeToStr = timeTo.HasValue ? timeTo.Value.ToString("yyyyMMdd'T'HHmm") : null;

            string url = $"https://www.alphavantage.co/query?function=NEWS_SENTIMENT&tickers={searchTicker}&topics={searchTopic}&time_from={timeFromStr}&time_to={timeToStr}&sort={sort}&limit={limit}&apikey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);

                return JObject.Parse(responseBody);
            }
        }
    }
}
