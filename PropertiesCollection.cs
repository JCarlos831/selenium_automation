using System;
using OpenQA.Selenium;

namespace selenium_automation
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    class PropertiesCollection
    {
        // Auto-Implemented Property
        public static IWebDriver Driver { get; set; }
    }
}