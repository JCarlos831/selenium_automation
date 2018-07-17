 using System;
 using OpenQA.Selenium;
 using SeleniumExtras.PageObjects;

 namespace selenium_automation
 {
     class EAPageObject
     {

         public EAPageObject()
         {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
         }

         [FindsBy(How = How.Id, Using = "TitleId")]
         public IWebElement DdlTitleID { get; set; }

         [FindsBy(How = How.Name, Using = "Initial")]
         public IWebElement TxtIntial { get; set; }

         [FindsBy(How = How.Name, Using = "Save")]
         public IWebElement BtnSave { get; set; }
     }
 }
