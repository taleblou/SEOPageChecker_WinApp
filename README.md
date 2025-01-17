# **SEO Page Analyzer**

## **Overview**

The **SEO Page Analyzer** is a Windows Forms application written in C\#. It allows users to analyze the SEO attributes of a given URL, providing detailed insights such as title tag quality, meta description effectiveness, heading counts, image optimization, link analysis, and more. This application leverages the `HttpClient` class for fetching web pages and the HtmlAgilityPack library for parsing HTML content.

## **Features**

* Fetch and display the title tag and its quality.  
* Analyze meta descriptions for length and quality.  
* Count headings (`<h1>` and `<h2>`) on the page.  
* Count and analyze images with and without `alt` attributes.  
* Perform internal and external link analysis.  
* Detect broken links.  
* Count total words on the page.  
* Measure page load time.

## **Prerequisites**

* **.NET Framework**: Ensure you have the required version of the .NET Framework installed to run Windows Forms applications.

**HtmlAgilityPack Library**: Install the HtmlAgilityPack NuGet package for HTML parsing. You can install it using the NuGet Package Manager Console:  
bash  
Copy code  
`Install-Package HtmlAgilityPack`

*   
* **Visual Studio**: Use Visual Studio for building and running the application.

## **Installation**

1. Clone or download the repository to your local machine.  
2. Open the project in Visual Studio.  
3. Restore NuGet packages to ensure all dependencies are installed.  
4. Build the solution and run the application.

## **How to Use**

1. Launch the application.  
2. Enter the URL of the page you want to analyze into the text box.  
3. Click the **Analyze** button.  
4. The application will display the following SEO metrics:  
   * **Title**: The page's title tag, its length, and quality.  
   * **Meta Description**: Content, length, and quality of the meta description.  
   * **Headings**: The count of `<h1>` and `<h2>` tags.  
   * **Images**: Total images, those with `alt` attributes, and those without.  
   * **Links**: Total links, internal links, external links, and broken links.  
   * **Word Count**: Total number of words on the page.  
   * **Page Load Time**: Time taken to fetch the page content.

## **Code Structure**

* **Main Form**:  
  * Initializes the UI and handles user interactions.  
  * Manages SEO data display after analysis.  
* **FetchPageAsync**:  
  * Fetches the page content and calculates load time.  
* **AnalyzeSEO**:  
  * Analyzes the HTML content for SEO metrics using the HtmlAgilityPack library.  
* **HttpClient**:  
  * Makes HTTP requests to fetch page data and verify links.

## **Error Handling**

* Displays error messages for invalid or empty URLs.  
* Handles HTTP request errors and parsing errors gracefully.

## **Future Enhancements**

* Add more detailed analysis for advanced SEO metrics (e.g., mobile-friendliness, structured data).  
* Export analysis results to a file (CSV, PDF, etc.).  
* Implement a dashboard for comparing multiple URLs.

## **Technologies Used**

* **C\#**  
* **Windows Forms**  
* **HtmlAgilityPack**  
* **HttpClient**

## **License**

This project is licensed under the MIT License. Feel free to modify and distribute it.

## **Contributing**

Contributions are welcome\! Feel free to fork this repository and submit a pull request with improvements or bug fixes.

