namespace SEOPage
{
    partial class Main
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
            this.URL_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Analysis_Button = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleLength = new System.Windows.Forms.Label();
            this.lblTitleQuality = new System.Windows.Forms.Label();
            this.lblMetaDescription = new System.Windows.Forms.Label();
            this.lblMetaDescriptionLength = new System.Windows.Forms.Label();
            this.lblMetaDescriptionQuality = new System.Windows.Forms.Label();
            this.lblH1Count = new System.Windows.Forms.Label();
            this.lblH2Count = new System.Windows.Forms.Label();
            this.lblImageCount = new System.Windows.Forms.Label();
            this.lblImagesWithAlt = new System.Windows.Forms.Label();
            this.lblImagesWithoutAlt = new System.Windows.Forms.Label();
            this.lblLinkCount = new System.Windows.Forms.Label();
            this.lblInternalLinks = new System.Windows.Forms.Label();
            this.lblExternalLinks = new System.Windows.Forms.Label();
            this.lblBrokenLinks = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblLoadTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URL_TextBox
            // 
            this.URL_TextBox.Location = new System.Drawing.Point(117, 61);
            this.URL_TextBox.Name = "URL_TextBox";
            this.URL_TextBox.Size = new System.Drawing.Size(580, 26);
            this.URL_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL :";
            // 
            // Analysis_Button
            // 
            this.Analysis_Button.Location = new System.Drawing.Point(723, 54);
            this.Analysis_Button.Name = "Analysis_Button";
            this.Analysis_Button.Size = new System.Drawing.Size(90, 40);
            this.Analysis_Button.TabIndex = 2;
            this.Analysis_Button.Text = "Analysis";
            this.Analysis_Button.UseVisualStyleBackColor = true;
            this.Analysis_Button.Click += new System.EventHandler(this.Analysis_Button_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(43, 104);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title :";
            // 
            // lblTitleLength
            // 
            this.lblTitleLength.AutoSize = true;
            this.lblTitleLength.Location = new System.Drawing.Point(43, 142);
            this.lblTitleLength.Name = "lblTitleLength";
            this.lblTitleLength.Size = new System.Drawing.Size(100, 20);
            this.lblTitleLength.TabIndex = 3;
            this.lblTitleLength.Text = "Title Length :";
            // 
            // lblTitleQuality
            // 
            this.lblTitleQuality.AutoSize = true;
            this.lblTitleQuality.Location = new System.Drawing.Point(43, 180);
            this.lblTitleQuality.Name = "lblTitleQuality";
            this.lblTitleQuality.Size = new System.Drawing.Size(102, 20);
            this.lblTitleQuality.TabIndex = 3;
            this.lblTitleQuality.Text = "Title Quality: :";
            // 
            // lblMetaDescription
            // 
            this.lblMetaDescription.AutoSize = true;
            this.lblMetaDescription.Location = new System.Drawing.Point(43, 215);
            this.lblMetaDescription.Name = "lblMetaDescription";
            this.lblMetaDescription.Size = new System.Drawing.Size(137, 20);
            this.lblMetaDescription.TabIndex = 3;
            this.lblMetaDescription.Text = "Meta Description :";
            // 
            // lblMetaDescriptionLength
            // 
            this.lblMetaDescriptionLength.AutoSize = true;
            this.lblMetaDescriptionLength.Location = new System.Drawing.Point(43, 254);
            this.lblMetaDescriptionLength.Name = "lblMetaDescriptionLength";
            this.lblMetaDescriptionLength.Size = new System.Drawing.Size(191, 20);
            this.lblMetaDescriptionLength.TabIndex = 3;
            this.lblMetaDescriptionLength.Text = "Meta Description Length :";
            // 
            // lblMetaDescriptionQuality
            // 
            this.lblMetaDescriptionQuality.AutoSize = true;
            this.lblMetaDescriptionQuality.Location = new System.Drawing.Point(43, 297);
            this.lblMetaDescriptionQuality.Name = "lblMetaDescriptionQuality";
            this.lblMetaDescriptionQuality.Size = new System.Drawing.Size(189, 20);
            this.lblMetaDescriptionQuality.TabIndex = 3;
            this.lblMetaDescriptionQuality.Text = "Meta Description Quality :";
            // 
            // lblH1Count
            // 
            this.lblH1Count.AutoSize = true;
            this.lblH1Count.Location = new System.Drawing.Point(43, 333);
            this.lblH1Count.Name = "lblH1Count";
            this.lblH1Count.Size = new System.Drawing.Size(85, 20);
            this.lblH1Count.TabIndex = 3;
            this.lblH1Count.Text = "H1 Count :";
            // 
            // lblH2Count
            // 
            this.lblH2Count.AutoSize = true;
            this.lblH2Count.Location = new System.Drawing.Point(43, 367);
            this.lblH2Count.Name = "lblH2Count";
            this.lblH2Count.Size = new System.Drawing.Size(89, 20);
            this.lblH2Count.TabIndex = 3;
            this.lblH2Count.Text = "H2 Count: :";
            // 
            // lblImageCount
            // 
            this.lblImageCount.AutoSize = true;
            this.lblImageCount.Location = new System.Drawing.Point(43, 404);
            this.lblImageCount.Name = "lblImageCount";
            this.lblImageCount.Size = new System.Drawing.Size(109, 20);
            this.lblImageCount.TabIndex = 3;
            this.lblImageCount.Text = "Image Count :";
            // 
            // lblImagesWithAlt
            // 
            this.lblImagesWithAlt.AutoSize = true;
            this.lblImagesWithAlt.Location = new System.Drawing.Point(43, 444);
            this.lblImagesWithAlt.Name = "lblImagesWithAlt";
            this.lblImagesWithAlt.Size = new System.Drawing.Size(125, 20);
            this.lblImagesWithAlt.TabIndex = 3;
            this.lblImagesWithAlt.Text = "Images with Alt :";
            // 
            // lblImagesWithoutAlt
            // 
            this.lblImagesWithoutAlt.AutoSize = true;
            this.lblImagesWithoutAlt.Location = new System.Drawing.Point(43, 492);
            this.lblImagesWithoutAlt.Name = "lblImagesWithoutAlt";
            this.lblImagesWithoutAlt.Size = new System.Drawing.Size(148, 20);
            this.lblImagesWithoutAlt.TabIndex = 3;
            this.lblImagesWithoutAlt.Text = "Images without Alt :";
            // 
            // lblLinkCount
            // 
            this.lblLinkCount.AutoSize = true;
            this.lblLinkCount.Location = new System.Drawing.Point(43, 544);
            this.lblLinkCount.Name = "lblLinkCount";
            this.lblLinkCount.Size = new System.Drawing.Size(97, 20);
            this.lblLinkCount.TabIndex = 3;
            this.lblLinkCount.Text = "Link Count: :";
            // 
            // lblInternalLinks
            // 
            this.lblInternalLinks.AutoSize = true;
            this.lblInternalLinks.Location = new System.Drawing.Point(43, 602);
            this.lblInternalLinks.Name = "lblInternalLinks";
            this.lblInternalLinks.Size = new System.Drawing.Size(112, 20);
            this.lblInternalLinks.TabIndex = 3;
            this.lblInternalLinks.Text = "Internal Links :";
            // 
            // lblExternalLinks
            // 
            this.lblExternalLinks.AutoSize = true;
            this.lblExternalLinks.Location = new System.Drawing.Point(43, 659);
            this.lblExternalLinks.Name = "lblExternalLinks";
            this.lblExternalLinks.Size = new System.Drawing.Size(116, 20);
            this.lblExternalLinks.TabIndex = 3;
            this.lblExternalLinks.Text = "External Links :";
            // 
            // lblBrokenLinks
            // 
            this.lblBrokenLinks.AutoSize = true;
            this.lblBrokenLinks.Location = new System.Drawing.Point(43, 708);
            this.lblBrokenLinks.Name = "lblBrokenLinks";
            this.lblBrokenLinks.Size = new System.Drawing.Size(109, 20);
            this.lblBrokenLinks.TabIndex = 3;
            this.lblBrokenLinks.Text = "Broken Links :";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(43, 759);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(102, 20);
            this.lblWordCount.TabIndex = 3;
            this.lblWordCount.Text = "Word Count :";
            // 
            // lblLoadTime
            // 
            this.lblLoadTime.AutoSize = true;
            this.lblLoadTime.Location = new System.Drawing.Point(43, 810);
            this.lblLoadTime.Name = "lblLoadTime";
            this.lblLoadTime.Size = new System.Drawing.Size(132, 20);
            this.lblLoadTime.TabIndex = 3;
            this.lblLoadTime.Text = "Page Load Time :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 871);
            this.Controls.Add(this.lblLoadTime);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblBrokenLinks);
            this.Controls.Add(this.lblExternalLinks);
            this.Controls.Add(this.lblInternalLinks);
            this.Controls.Add(this.lblLinkCount);
            this.Controls.Add(this.lblImagesWithoutAlt);
            this.Controls.Add(this.lblImagesWithAlt);
            this.Controls.Add(this.lblImageCount);
            this.Controls.Add(this.lblH2Count);
            this.Controls.Add(this.lblH1Count);
            this.Controls.Add(this.lblMetaDescriptionQuality);
            this.Controls.Add(this.lblMetaDescriptionLength);
            this.Controls.Add(this.lblMetaDescription);
            this.Controls.Add(this.lblTitleQuality);
            this.Controls.Add(this.lblTitleLength);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Analysis_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL_TextBox);
            this.Name = "Main";
            this.Text = "SEO Analysis";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Analysis_Button;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleLength;
        private System.Windows.Forms.Label lblTitleQuality;
        private System.Windows.Forms.Label lblMetaDescription;
        private System.Windows.Forms.Label lblMetaDescriptionLength;
        private System.Windows.Forms.Label lblMetaDescriptionQuality;
        private System.Windows.Forms.Label lblH1Count;
        private System.Windows.Forms.Label lblH2Count;
        private System.Windows.Forms.Label lblImageCount;
        private System.Windows.Forms.Label lblImagesWithAlt;
        private System.Windows.Forms.Label lblImagesWithoutAlt;
        private System.Windows.Forms.Label lblLinkCount;
        private System.Windows.Forms.Label lblInternalLinks;
        private System.Windows.Forms.Label lblExternalLinks;
        private System.Windows.Forms.Label lblBrokenLinks;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblLoadTime;
    }
}

