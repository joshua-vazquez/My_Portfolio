using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace InvestInMe_Mini_Project
{
    public partial class ArticleViewer: Form
    {
        private string articleUrl;
        public ArticleViewer(string title, string source, DateTime date, string description, string url)
        {
            InitializeComponent();
            DisplayArticle(title, source, date, description);
            articleUrl = url;
            
        }
        private void DisplayArticle(string title, string source, DateTime date, string description)
        {
            lblTitle.Text = title;
            lblSource.Text = source;
            lblDate.Text = $"Published at: {date}";
            txtDescription.Text = description;

        }

        private void btnGoToArticle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(articleUrl))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = articleUrl,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Article URL is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSource_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
