using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEOPage
{
    public partial class Main : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Analysis_Button_Click(object sender, EventArgs e)
        {
            string url = URL_TextBox.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch and analyze SEO data
            var (html, loadTime) = await FetchPageAsync(url);
            if (html == null)
            {
                MessageBox.Show("Failed to fetch the page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var seoData = AnalyzeSEO(html, url);

            // Display SEO data in labels
            lblTitle.Text = $"Title: {seoData["title"]}";
            lblTitleLength.Text = $"Title Length: {seoData["title_length"]}";
            lblTitleQuality.Text = $"Title Quality: {seoData["title_quality"]}";
            lblMetaDescription.Text = $"Meta Description: {seoData["meta_description"]}";
            lblMetaDescriptionLength.Text = $"Meta Description Length: {seoData["meta_description_length"]}";
            lblMetaDescriptionQuality.Text = $"Meta Description Quality: {seoData["meta_description_quality"]}";
            lblH1Count.Text = $"H1 Count: {seoData["h1_count"]}";
            lblH2Count.Text = $"H2 Count: {seoData["h2_count"]}";
            lblImageCount.Text = $"Image Count: {seoData["image_count"]}";
            lblImagesWithAlt.Text = $"Images with Alt: {seoData["images_with_alt"]}";
            lblImagesWithoutAlt.Text = $"Images without Alt: {seoData["images_without_alt"]}";
            lblLinkCount.Text = $"Link Count: {seoData["link_count"]}";
            lblInternalLinks.Text = $"Internal Links: {seoData["internal_links"]}";
            lblExternalLinks.Text = $"External Links: {seoData["external_links"]}";
            lblBrokenLinks.Text = $"Broken Links: {seoData["broken_links"]}";
            lblWordCount.Text = $"Word Count: {seoData["word_count"]}";
            lblLoadTime.Text = $"Page Load Time: {loadTime:F2} seconds";
        }
        private async Task<(string, double)> FetchPageAsync(string url)
        {
            try
            {
                var start = DateTime.UtcNow;
                var response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var end = DateTime.UtcNow;
                var loadTime = (end - start).TotalSeconds;
                var html = await response.Content.ReadAsStringAsync();
                return (html, loadTime);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching {url}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, 0);
            }
        }

        private Dictionary<string, object> AnalyzeSEO(string html, string url)
        {
            var seoData = new Dictionary<string, object> { { "url", url } };

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            // Title Tag
            var titleTag = doc.DocumentNode.SelectSingleNode("//title")?.InnerText;
            seoData["title"] = titleTag;
            seoData["title_length"] = titleTag?.Length ?? 0;
            seoData["title_quality"] = (titleTag != null && titleTag.Length >= 50 && titleTag.Length <= 60) ? "Good" : "Needs Improvement";

            // Meta Description
            var metaDescription = doc.DocumentNode.SelectSingleNode("//meta[@name='description']");
            var descriptionContent = metaDescription?.GetAttributeValue("content", null);
            seoData["meta_description"] = descriptionContent;
            seoData["meta_description_length"] = descriptionContent?.Length ?? 0;
            seoData["meta_description_quality"] = (descriptionContent != null && descriptionContent.Length >= 120 && descriptionContent.Length <= 160) ? "Good" : "Needs Improvement";

            // Headings (H1, H2)
            seoData["h1_count"] = doc.DocumentNode.SelectNodes("//h1")?.Count ?? 0;
            seoData["h2_count"] = doc.DocumentNode.SelectNodes("//h2")?.Count ?? 0;

            // Image Alt Tags
            var images = doc.DocumentNode.SelectNodes("//img");
            seoData["image_count"] = images?.Count ?? 0;
            seoData["images_with_alt"] = images?.Count(img => img.GetAttributeValue("alt", null) != null) ?? 0;
            seoData["images_without_alt"] = (seoData["image_count"] as int?) - (seoData["images_with_alt"] as int?);

            // Links
            var links = doc.DocumentNode.SelectNodes("//a[@href]");
            seoData["link_count"] = links?.Count ?? 0;
            seoData["internal_links"] = links?.Count(link => link.GetAttributeValue("href", "").Contains(url)) ?? 0;
            seoData["external_links"] = (seoData["link_count"] as int?) - (seoData["internal_links"] as int?);

            // Broken Links
            int brokenLinks = 0;
            if (links != null)
            {
                foreach (var link in links)
                {
                    try
                    {
                        var response = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, link.GetAttributeValue("href", ""))).Result;
                        if ((int)response.StatusCode >= 400)
                            brokenLinks++;
                    }
                    catch
                    {
                        brokenLinks++;
                    }
                }
            }
            seoData["broken_links"] = brokenLinks;

            // Content Analysis
            var bodyText = doc.DocumentNode.InnerText;
            var wordCount = bodyText.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            seoData["word_count"] = wordCount;

            return seoData;
        }
    }
}
}
