using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LaunchTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // test method to Launch Bridgelabzwebsite
        [Test]
        public void VerifyWebsiteLaunch()
        {
            // Initializing web driver
            IWebDriver driver = new ChromeDriver();

            // Launching Bridgelabz website
            driver.Url = "https://www.bridgelabz.com/";

            // Expected page Title
            String ExpectedPageTitle = "IT Jobs in Mumbai | Software Engineer Jobs in Bangalore | BridgeLabz";

            // Actual page Title recoverd from browser
            String ActualPageTitle = driver.Title;

            // Closing Browser
            driver.Quit();

            // Verifying Page title
            Assert.AreEqual(ExpectedPageTitle, ActualPageTitle);
        }
    }
}