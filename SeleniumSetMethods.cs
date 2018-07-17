using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium_automation
{
    class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        // Click into a button, Checkbox, option, etc
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        // Selecting a drop down control
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}