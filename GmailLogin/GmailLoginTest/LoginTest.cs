using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GmailLoginTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Launching to Gmail website and Signing in with Email and password
        [Test]
        public void LoginTest()
        {

            // Initilizing the new insatance of chrome browser
            // Creating referance of Chrome browser
            IWebDriver driver = new ChromeDriver();

            // Lauch the Gmail website
            driver.Url = "https://www.gmail.com";

            // Finding emailbox with By.Id
            IWebElement emailbox = driver.FindElement(By.Id("identifierId"));
            // Set email value in emailBox
            emailbox.SendKeys("nitikeshs58@gmail.com");

            // Finding nextButton By.Id
            IWebElement nextButton = driver.FindElement(By.Id("identifierNext"));
            // Clicking on Next button
            nextButton.Click();

            // Finding passwordbox with By.Id
            IWebElement passwdBox = driver.FindElement(By.ClassName("RveJvd snByac"));
            // Set password value in passwordBox
            passwdBox.SendKeys("abc123*");

            // Finding signInButton By.Id
            IWebElement signinButton = driver.FindElement(By.Id("signIn"));
            // Clicking on SignIn button
            signinButton.Click();
        
            
        }
    }
}