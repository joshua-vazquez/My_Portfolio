namespace InvestInMe_Mini_Project
{
    partial class StockMarketDataForm
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
            this.rtbStockDataInfo = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.gridStockData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lblSymbol = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtSymbol = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTimeSeries = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbTimeSeries = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnDownloadStockData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGetStockData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimeSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbStockDataInfo
            // 
            this.rtbStockDataInfo.Location = new System.Drawing.Point(51, 66);
            this.rtbStockDataInfo.Name = "rtbStockDataInfo";
            this.rtbStockDataInfo.ReadOnly = true;
            this.rtbStockDataInfo.Size = new System.Drawing.Size(456, 142);
            this.rtbStockDataInfo.TabIndex = 0;
            this.rtbStockDataInfo.Text = "";
            // 
            // gridStockData
            // 
            this.gridStockData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStockData.Location = new System.Drawing.Point(565, 26);
            this.gridStockData.Name = "gridStockData";
            this.gridStockData.Size = new System.Drawing.Size(462, 552);
            this.gridStockData.TabIndex = 1;
            // 
            // lblSymbol
            // 
            this.lblSymbol.Location = new System.Drawing.Point(96, 317);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(105, 20);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.Values.Text = "Enter the symbol: ";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(207, 314);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(160, 23);
            this.txtSymbol.TabIndex = 3;
            // 
            // lblTimeSeries
            // 
            this.lblTimeSeries.Location = new System.Drawing.Point(57, 277);
            this.lblTimeSeries.Name = "lblTimeSeries";
            this.lblTimeSeries.Size = new System.Drawing.Size(144, 20);
            this.lblTimeSeries.TabIndex = 4;
            this.lblTimeSeries.Values.Text = "Choose your time series: ";
            // 
            // cmbTimeSeries
            // 
            this.cmbTimeSeries.DropDownWidth = 160;
            this.cmbTimeSeries.Location = new System.Drawing.Point(207, 277);
            this.cmbTimeSeries.Name = "cmbTimeSeries";
            this.cmbTimeSeries.Size = new System.Drawing.Size(160, 21);
            this.cmbTimeSeries.TabIndex = 5;
            this.cmbTimeSeries.Text = "TIME_SERIES";
            // 
            // btnDownloadStockData
            // 
            this.btnDownloadStockData.Location = new System.Drawing.Point(709, 601);
            this.btnDownloadStockData.Name = "btnDownloadStockData";
            this.btnDownloadStockData.Size = new System.Drawing.Size(197, 25);
            this.btnDownloadStockData.TabIndex = 6;
            this.btnDownloadStockData.Values.Text = "Download Data";
            this.btnDownloadStockData.Click += new System.EventHandler(this.btnDownloadStockData_Click);
            // 
            // btnGetStockData
            // 
            this.btnGetStockData.Location = new System.Drawing.Point(207, 359);
            this.btnGetStockData.Name = "btnGetStockData";
            this.btnGetStockData.Size = new System.Drawing.Size(160, 25);
            this.btnGetStockData.TabIndex = 7;
            this.btnGetStockData.Values.Text = "Get Stock Data";
            this.btnGetStockData.Click += new System.EventHandler(this.btnGetStockData_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.ForestGreen;
            this.progressBar1.Location = new System.Drawing.Point(119, 465);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(345, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(40, 468);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(60, 20);
            this.lblProgress.TabIndex = 9;
            this.lblProgress.Values.Text = "Progress:";
            // 
            // StockMarketDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1061, 655);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGetStockData);
            this.Controls.Add(this.btnDownloadStockData);
            this.Controls.Add(this.cmbTimeSeries);
            this.Controls.Add(this.lblTimeSeries);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.gridStockData);
            this.Controls.Add(this.rtbStockDataInfo);
            this.Name = "StockMarketDataForm";
            this.Text = "Stock Market Data";
            ((System.ComponentModel.ISupportInitialize)(this.gridStockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimeSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbStockDataInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridStockData;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSymbol;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSymbol;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTimeSeries;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbTimeSeries;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDownloadStockData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGetStockData;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProgress;
    }
}