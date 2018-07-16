using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium_automation
{
    class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == PropertyType.Name)
                PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);
        }

        // Click into a button, Checkbox, option, etc
        public static void Click(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                PropertiesCollection.Driver.FindElement(By.Name(element)).Click();
        }

        // Selecting a drop down control
        public static void SelectDropDown(string element, string value, PropertyType elementType)
        {
            
            if (elementType == PropertyType.Id)
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}