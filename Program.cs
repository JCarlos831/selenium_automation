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
            // Navigate to Execute Automation demo page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            // Inital
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            // Click
            SeleniumSetMethods.Click(driver, "Save", "Name");

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));
            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
        }

        // [Test]
        // public void NextTest()
        // {
        //     Console.WriteLine("Next method");
        // }

        [TearDown]
        public void CleanUp()
        {
            // Close browser
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
