using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace InvestInMe_Mini_Project
{
    public partial class ArticleViewer: Form
    {
        private string title;
        private string source;
        private DateTime date;
        private string description;
        private string url;
        private string sentiment;

        public ArticleViewer(string title, string source, DateTime date, string description, string url, string sentiment)
        {
            InitializeComponent();
            this.title = title;
            this.source = source;
            this.date = date;
            this.description = description;
            this.url = url;
            this.sentiment = sentiment;

            DisplayArticleDetails();
            
        }
        private void DisplayArticleDetails()
        {
            lblTitle.Text = $"Title: {title}";
            lblSource.Text = $"Source: {source}";
            lblDate.Text = $"Published at: {date.ToString("yyyy-MM-dd HH:mm")}";
            txtDescription.Text = description;
            lblSentiment.Text = $"Sentiment: {sentiment}";

        }

        private void btnGoToArticle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(url))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Article URL is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
