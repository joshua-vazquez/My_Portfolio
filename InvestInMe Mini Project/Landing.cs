using System.Drawing;
using System;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System.Windows.Forms;

namespace InvestInMe_Mini_Project
{
    public partial class Landing : Form
    {
        private NewsApiClient newsApiClient;
        public Landing()
        {
            InitializeComponent();

            newsApiClient = new NewsApiClient("df332c4dfad1474bb74153588a5e714d");
            AdjustLabelFont();
            DisplayInstructions();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            var articlesResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
            {
                Q = searchTerm,
                Language = Languages.EN,
                SortBy = SortBys.Relevancy,
            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                gridNews.Rows.Clear();
                foreach (var article in articlesResponse.Articles)
                {
                    gridNews.Rows.Add(article.Title, article.Source.Name, article.PublishedAt, article.Description, article.Url);
                }
            }
            else
            {
                MessageBox.Show("Error fetching news articles.");
            }

        }

        private void Landing_Load(object sender, EventArgs e)
        {
            gridNews.ColumnCount = 5;
            gridNews.Columns[0].Name = "Title";
            gridNews.Columns[1].Name = "Source";
            gridNews.Columns[2].Name = "Published At";
            gridNews.Columns[3].Name = "Description";
            gridNews.Columns[4].Name = "Url";
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
                var date = (DateTime)selectedRow.Cells["Published At"].Value;
                var description = selectedRow.Cells["Description"].Value.ToString();
                var url = selectedRow.Cells["Url"].Value.ToString();

                ArticleViewer articleViewer = new ArticleViewer(title, source, date, description, url);
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
            string instructions = "Utilize our search functionality powered by the NewsAPI to access a wide range of articles from various sources. This tool allows you to stay informed about the latest trends and news in the investment world. Simply enter your search term related to the topic you're interested in, and press the search button to retrieve relevant news articles. Remember, doing your due diligence is key to becoming a savvy investor. By staying updated with the latest information, you can make more informed decisions and take charge of your financial future.";

            rtxtSearchInfo.Text = instructions;
        }
    }
}
