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
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gridNews = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lblSearch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnRead = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblHeader = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rtxtSearchInfo = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridNews)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(787, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(580, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // gridNews
            // 
            this.gridNews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNews.Location = new System.Drawing.Point(580, 69);
            this.gridNews.Name = "gridNews";
            this.gridNews.Size = new System.Drawing.Size(583, 516);
            this.gridNews.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(580, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(113, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Values.Text = "Search topics here.";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(1034, 38);
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
            this.rtxtSearchInfo.Size = new System.Drawing.Size(528, 160);
            this.rtxtSearchInfo.TabIndex = 6;
            this.rtxtSearchInfo.Text = "";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.rtxtSearchInfo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gridNews);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Landing";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Landing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridNews;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRead;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtxtSearchInfo;
    }
}