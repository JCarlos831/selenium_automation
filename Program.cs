using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_automation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            // Navigate to Google page
            driver.Navigate().GoToUrl("https://www.google.com");
            
            // Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            // Perform operation
            element.SendKeys("executeautomation" + Keys.Enter);

            // Close browser
            driver.Close();
        }
    }
}
