using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ToolsQATest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Initilizing the new insatance of chrome browser
            // Creating referance of Chrome browser
            IWebDriver driver = new ChromeDriver();

            // Launch the ToolsQA Website
            driver.Url = "https://www.demoqa.com";

            // Storing title name in string variable
            String Title = driver.Title;

            // Storing Title length in int variable
            int TitleLength = driver.Title.Length;

            // Printing title name and length on conslole
            Console.WriteLine("Title of the page is :" + Title);
            Console.WriteLine("Length of the Title is :" + TitleLength);

            // Storing URL in a string variable
            String PageURL = driver.Url;

            // Storing URL Length in Int variable
            int URLLength = PageURL.Length;

            // Printing URL and its Length on Console
            Console.WriteLine("URL of the page is :" + PageURL);
            Console.WriteLine("Length of the URL is :" + URLLength);

            // Storing Page Source in String variable
            String PageSource = driver.PageSource;

            // Stroing Page Source Length in Int variable
            int PageSourceLength = PageSource.Length;

            // Printing Page Source and its Length on Console
            Console.WriteLine("Page Source of the page is :" + PageSource);
            Console.WriteLine("Length of the Page Source is:" + PageSourceLength);

            // Closing Browser
            driver.Quit();
        }
    }
}