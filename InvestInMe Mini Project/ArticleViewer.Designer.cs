namespace InvestInMe_Mini_Project
{
    partial class ArticleViewer
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
            this.lblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSource = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnGoToArticle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDescription = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Values.Text = "kryptonLabel1";
            // 
            // lblSource
            // 
            this.lblSource.Location = new System.Drawing.Point(12, 47);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(88, 20);
            this.lblSource.TabIndex = 1;
            this.lblSource.Values.Text = "kryptonLabel2";
            this.lblSource.Paint += new System.Windows.Forms.PaintEventHandler(this.lblSource_Paint);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Values.Text = "kryptonLabel3";
            // 
            // btnGoToArticle
            // 
            this.btnGoToArticle.Location = new System.Drawing.Point(212, 223);
            this.btnGoToArticle.Name = "btnGoToArticle";
            this.btnGoToArticle.Size = new System.Drawing.Size(164, 54);
            this.btnGoToArticle.TabIndex = 4;
            this.btnGoToArticle.Values.Text = "Go To Article";
            this.btnGoToArticle.Click += new System.EventHandler(this.btnGoToArticle_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 135);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(577, 82);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Values.Text = "Description: ";
            // 
            // ArticleViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(602, 289);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnGoToArticle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblTitle);
            this.Name = "ArticleViewer";
            this.Text = "Article Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGoToArticle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDescription;
    }
}