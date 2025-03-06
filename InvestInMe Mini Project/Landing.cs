using System.Drawing;
using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace InvestInMe_Mini_Project
{
    public partial class Landing : Form
    {
        private StockMarketDataService newsService;
        public Landing()
        {
            InitializeComponent();

            string apiKey = Environment.GetEnvironmentVariable("ALPHAVANTAGE_API_KEY");
            newsService = new StockMarketDataService(apiKey);
            cmbSortBy.DataSource = Enum.GetValues(typeof(SortBy));

            AdjustLabelFont();
            DisplayInstructions();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTopics = txtTopics.Text;
            string searchTickers = txtTickers.Text;
            DateTime? timeFrom = dtpTimeFrom.Checked ? (DateTime?)dtpTimeFrom.Value : null;
            DateTime? timeTo = dtpTimeTo.Checked ? (DateTime?)dtpTimeTo.Value : null;
            string sort = cmbSortBy.SelectedItem.ToString();
            int limit = 20;

            if (string.IsNullOrWhiteSpace(searchTopics) && string.IsNullOrWhiteSpace(searchTickers))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }
            if(timeFrom.HasValue && timeTo.HasValue && timeFrom > timeTo)
            {
                MessageBox.Show("The 'From' date cannot be later than the 'To' date.");
                return;
            }

            try
            {
                JObject result = await newsService.GetNewsSentimentsAsync(searchTickers, searchTopics, timeFrom, timeTo, sort, limit);

                if (result != null && result["feed"] != null)
                {
                    gridNews.Rows.Clear();
                    foreach (var item in result["feed"])
                    {
                        var title = item["title"]?.ToString() ?? "N/A";
                        var source = item["source"]?.ToString() ?? "N/A";
                        var publishedAt = item["time_published"]?.ToString() ?? "N/A";
                        var description = item["summary"]?.ToString() ?? "N/A";
                        var url = item["url"].ToString() ?? "N/A";
                        var sentiment = item["overall_sentiment_label"]?.ToString() ?? "Uknown";

                        gridNews.Rows.Add(title, source, publishedAt, description, url, sentiment);
                    }
                }
                else
                {
                    MessageBox.Show("No results found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching news sentiments: {ex.Message}");
            }

            // clear input fields
            txtTopics.Text = string.Empty;
            txtTickers.Text = string.Empty;
            dtpTimeFrom.Value = DateTime.Now;
            dtpTimeFrom.Checked = false;
            dtpTimeTo.Value = DateTime.Now;
            dtpTimeTo.Checked = false;
            cmbSortBy.SelectedIndex = -1;
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            gridNews.ColumnCount = 6;
            gridNews.Columns[0].Name = "Title";
            gridNews.Columns[1].Name = "Source";
            gridNews.Columns[2].Name = "Published At";
            gridNews.Columns[3].Name = "Description";
            gridNews.Columns[4].Name = "Url";
            gridNews.Columns[5].Name = "Sentiment";

            gridNews.Columns[2].Visible = false;
            gridNews.Columns[3].Visible = false;
            gridNews.Columns[4].Visible = false;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (gridNews.SelectedRows.Count > 0)
            {
                var selectedRow = gridNews.SelectedRows[0];
                var title = selectedRow.Cells["Title"].Value.ToString();
                var source = selectedRow.Cells["Source"].Value.ToString();
                var dateStr = selectedRow.Cells["Published At"].Value.ToString();
                var description = selectedRow.Cells["Description"].Value.ToString();
                var url = selectedRow.Cells["Url"].Value.ToString();
                var sentiment = selectedRow.Cells["Sentiment"].Value?.ToString();

                DateTime date;
                if(!DateTime.TryParseExact(dateStr, "yyyyMMdd'T'HHmmss", null, System.Globalization.DateTimeStyles.None, out date))
                {
                    date = DateTime.MinValue;
                }

                ArticleViewer articleViewer = new ArticleViewer(title, source, date, description, url, sentiment);
                articleViewer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an article to read.");
            }
        }
        private void AdjustLabelFont()
        {
            lblHeader.StateNormal.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSearch.StateNormal.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }
        private void DisplayInstructions()
        {
            string instructions = "Utilize our search functionality powered by the Alpha Vantage API to access a wide range of articles from various sources. This tool allows you to stay informed about the latest trends and news in the investment world. Simply enter your search term related to the topic or ticker you're interested in and press the search button to retrieve relevant news articles. You can filter your search by specifying stock, crypto, or forex symbols (e.g., tickers=IBM) or by selecting specific news topics (e.g., topics=technology). Additionally, you have the option to set date ranges, sort order, and view the sentiment analysis done by Artificial Intelligence. Remember, doing your due diligence is key to becoming a savvy investor. By staying updated with the latest information, you can make more informed decisions and take charge of your financial future.";
            rtxtSearchInfo.Text = instructions;
        }

        private void btnStockMarketData_Click(object sender, EventArgs e)
        {
            StockMarketDataForm stockDataForm = new StockMarketDataForm();
            stockDataForm.Show();
        }

        private void btnGetCurrencyXRates_Click(object sender, EventArgs e)
        {
            CurrencyExchangeRatesForm currencyExchangeForm = new CurrencyExchangeRatesForm();
            currencyExchangeForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gridNews.Rows.Clear();
        }
    }
}
