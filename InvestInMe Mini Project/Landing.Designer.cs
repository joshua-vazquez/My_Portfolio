namespace InvestInMe_Mini_Project
{
    partial class Landing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtTopics = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gridNews = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lblSearch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnRead = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblHeader = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rtxtSearchInfo = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.btnStockMarketData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGetCurrencyXRates = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbSortBy = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtTickers = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTickers = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpTimeFrom = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpTimeTo = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblTimeFrom = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTimeTo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSortBy = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSortBy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(967, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTopics
            // 
            this.txtTopics.Location = new System.Drawing.Point(861, 35);
            this.txtTopics.Name = "txtTopics";
            this.txtTopics.Size = new System.Drawing.Size(201, 23);
            this.txtTopics.TabIndex = 1;
            // 
            // gridNews
            // 
            this.gridNews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNews.Location = new System.Drawing.Point(580, 208);
            this.gridNews.Name = "gridNews";
            this.gridNews.Size = new System.Drawing.Size(573, 374);
            this.gridNews.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(861, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(113, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Values.Text = "Search topics here.";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(804, 602);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(129, 25);
            this.btnRead.TabIndex = 4;
            this.btnRead.Values.Text = "Read Article";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblHeader.Location = new System.Drawing.Point(73, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(257, 20);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Values.Text = "This is your first step to financial freedom!";
            // 
            // rtxtSearchInfo
            // 
            this.rtxtSearchInfo.Location = new System.Drawing.Point(27, 69);
            this.rtxtSearchInfo.Name = "rtxtSearchInfo";
            this.rtxtSearchInfo.ReadOnly = true;
            this.rtxtSearchInfo.Size = new System.Drawing.Size(473, 160);
            this.rtxtSearchInfo.TabIndex = 6;
            this.rtxtSearchInfo.Text = "";
            // 
            // btnStockMarketData
            // 
            this.btnStockMarketData.Location = new System.Drawing.Point(73, 502);
            this.btnStockMarketData.Name = "btnStockMarketData";
            this.btnStockMarketData.Size = new System.Drawing.Size(323, 25);
            this.btnStockMarketData.TabIndex = 7;
            this.btnStockMarketData.Values.Text = "Get Stock Market Data";
            this.btnStockMarketData.Click += new System.EventHandler(this.btnStockMarketData_Click);
            // 
            // btnGetCurrencyXRates
            // 
            this.btnGetCurrencyXRates.Location = new System.Drawing.Point(73, 557);
            this.btnGetCurrencyXRates.Name = "btnGetCurrencyXRates";
            this.btnGetCurrencyXRates.Size = new System.Drawing.Size(323, 25);
            this.btnGetCurrencyXRates.TabIndex = 8;
            this.btnGetCurrencyXRates.Values.Text = "Get Currency Exhange Rates";
            this.btnGetCurrencyXRates.Click += new System.EventHandler(this.btnGetCurrencyXRates_Click);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.DropDownWidth = 121;
            this.cmbSortBy.Location = new System.Drawing.Point(580, 168);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(121, 21);
            this.cmbSortBy.TabIndex = 9;
            this.cmbSortBy.Text = "kryptonComboBox1";
            // 
            // txtTickers
            // 
            this.txtTickers.Location = new System.Drawing.Point(580, 35);
            this.txtTickers.Name = "txtTickers";
            this.txtTickers.Size = new System.Drawing.Size(201, 23);
            this.txtTickers.TabIndex = 10;
            // 
            // lblTickers
            // 
            this.lblTickers.Location = new System.Drawing.Point(580, 9);
            this.lblTickers.Name = "lblTickers";
            this.lblTickers.Size = new System.Drawing.Size(116, 20);
            this.lblTickers.TabIndex = 11;
            this.lblTickers.Values.Text = "Search tickers here.";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Location = new System.Drawing.Point(580, 105);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Size = new System.Drawing.Size(156, 21);
            this.dtpTimeFrom.TabIndex = 12;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Location = new System.Drawing.Point(762, 105);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.Size = new System.Drawing.Size(156, 21);
            this.dtpTimeTo.TabIndex = 13;
            // 
            // lblTimeFrom
            // 
            this.lblTimeFrom.Location = new System.Drawing.Point(580, 79);
            this.lblTimeFrom.Name = "lblTimeFrom";
            this.lblTimeFrom.Size = new System.Drawing.Size(68, 20);
            this.lblTimeFrom.TabIndex = 14;
            this.lblTimeFrom.Values.Text = "Date from:";
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.Location = new System.Drawing.Point(762, 79);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(54, 20);
            this.lblTimeTo.TabIndex = 15;
            this.lblTimeTo.Values.Text = "Date to:";
            // 
            // lblSortBy
            // 
            this.lblSortBy.Location = new System.Drawing.Point(578, 142);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(52, 20);
            this.lblSortBy.TabIndex = 16;
            this.lblSortBy.Values.Text = "Sort by:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1063, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 25);
            this.btnClear.TabIndex = 17;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(73, 476);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(92, 20);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Other features:";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1200, 669);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.lblTimeTo);
            this.Controls.Add(this.lblTimeFrom);
            this.Controls.Add(this.dtpTimeTo);
            this.Controls.Add(this.dtpTimeFrom);
            this.Controls.Add(this.lblTickers);
            this.Controls.Add(this.txtTickers);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.btnGetCurrencyXRates);
            this.Controls.Add(this.btnStockMarketData);
            this.Controls.Add(this.rtxtSearchInfo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gridNews);
            this.Controls.Add(this.txtTopics);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Landing";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Landing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSortBy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTopics;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridNews;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRead;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtxtSearchInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStockMarketData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGetCurrencyXRates;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSortBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTickers;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTickers;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpTimeFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpTimeTo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTimeFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTimeTo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSortBy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}