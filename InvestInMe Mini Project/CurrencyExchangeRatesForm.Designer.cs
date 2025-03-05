namespace InvestInMe_Mini_Project
{
    partial class CurrencyExchangeRatesForm
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
            this.lblFromCurrency = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtFromCurrency = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gridForexData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnSearchCurrency = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExportToExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rtbExchangeRatesInfo = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblToCurrency = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtToCurrency = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridForexData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromCurrency
            // 
            this.lblFromCurrency.Location = new System.Drawing.Point(12, 256);
            this.lblFromCurrency.Name = "lblFromCurrency";
            this.lblFromCurrency.Size = new System.Drawing.Size(93, 20);
            this.lblFromCurrency.TabIndex = 0;
            this.lblFromCurrency.Values.Text = "From Currency:";
            // 
            // txtFromCurrency
            // 
            this.txtFromCurrency.Location = new System.Drawing.Point(102, 256);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.Size = new System.Drawing.Size(161, 23);
            this.txtFromCurrency.TabIndex = 1;
            // 
            // gridForexData
            // 
            this.gridForexData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridForexData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridForexData.Location = new System.Drawing.Point(359, 27);
            this.gridForexData.Name = "gridForexData";
            this.gridForexData.Size = new System.Drawing.Size(418, 337);
            this.gridForexData.TabIndex = 2;
            // 
            // btnSearchCurrency
            // 
            this.btnSearchCurrency.Location = new System.Drawing.Point(269, 270);
            this.btnSearchCurrency.Name = "btnSearchCurrency";
            this.btnSearchCurrency.Size = new System.Drawing.Size(71, 25);
            this.btnSearchCurrency.TabIndex = 3;
            this.btnSearchCurrency.Values.Text = "Search";
            this.btnSearchCurrency.Click += new System.EventHandler(this.btnSearchCurrency_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(482, 381);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(174, 25);
            this.btnExportToExcel.TabIndex = 4;
            this.btnExportToExcel.Values.Text = "Export To Excel";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // rtbExchangeRatesInfo
            // 
            this.rtbExchangeRatesInfo.Location = new System.Drawing.Point(12, 27);
            this.rtbExchangeRatesInfo.Name = "rtbExchangeRatesInfo";
            this.rtbExchangeRatesInfo.ReadOnly = true;
            this.rtbExchangeRatesInfo.Size = new System.Drawing.Size(328, 171);
            this.rtbExchangeRatesInfo.TabIndex = 5;
            this.rtbExchangeRatesInfo.Text = "";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(21, 341);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(308, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // lblToCurrency
            // 
            this.lblToCurrency.Location = new System.Drawing.Point(12, 285);
            this.lblToCurrency.Name = "lblToCurrency";
            this.lblToCurrency.Size = new System.Drawing.Size(79, 20);
            this.lblToCurrency.TabIndex = 7;
            this.lblToCurrency.Values.Text = "To Currency:";
            // 
            // txtToCurrency
            // 
            this.txtToCurrency.Location = new System.Drawing.Point(102, 285);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.Size = new System.Drawing.Size(161, 23);
            this.txtToCurrency.TabIndex = 8;
            // 
            // CurrencyExchangeRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtToCurrency);
            this.Controls.Add(this.lblToCurrency);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.rtbExchangeRatesInfo);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnSearchCurrency);
            this.Controls.Add(this.gridForexData);
            this.Controls.Add(this.txtFromCurrency);
            this.Controls.Add(this.lblFromCurrency);
            this.Name = "CurrencyExchangeRatesForm";
            this.Text = "Currency Exchange Rates";
            ((System.ComponentModel.ISupportInitialize)(this.gridForexData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFromCurrency;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFromCurrency;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridForexData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchCurrency;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExportToExcel;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbExchangeRatesInfo;
        private System.Windows.Forms.ProgressBar progressBar2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblToCurrency;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtToCurrency;
    }
}