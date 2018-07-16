using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_automation
{
    class Program
    {
        // Create the reference for our browser
        IWebDriver driver = new ChromeDriver();
        // static void Main(string[] args)
        // {
        // }

        [SetUp]
        public void Initialize()
        {
            // Navigate to Google page
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            // Perform operation
            element.SendKeys("executeautomation" + Keys.Enter);

            Console.WriteLine("Executed Test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }

        [TearDown]
        public void CleanUp()
        {
            // Close browser
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
