using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoSquare_Maintenance
{
    class Program
    {
        IWebDriver driver;
        public IWebDriver SetUpDriver()
        {
            //Adding my local path
            driver = new ChromeDriver(@"C:\Webdrivers\");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            return driver;
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void SendText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        #region Google Locators
        By GoogleSearchBar = By.XPath("//input[@name='q']");
        By GoogleSearIcon = By.XPath("//div[@class='tfB0Bf']//input[@name='btnK']");
        By UnoSquareGoogleResult = By.CssSelector("div > a[href='https://www.unosquare.com/']");
        #endregion

        #region UnoSquare Locators
        By UnoSquareServicesMenu = By.CssSelector("li > a[href='/Services']");
        By PracticeAreas = By.CssSelector("li > a[href='/PracticeAreas']");
        By ContactUs = By.CssSelector("li > a[href='/ContactUs']");
        #endregion 
        static void Main(string[] args)
        {
            IWebDriver Browser;
            IWebElement element;
            Program program = new Program();
            Browser = program.SetUpDriver();
            Browser.Url = "https://www.google.com";

            element = Browser.FindElement(program.GoogleSearchBar);

            program.SendText(element, "Unosquare");

            element = Browser.FindElement(program.GoogleSearIcon);

            program.Click(element);

            element = Browser.FindElement(program.UnoSquareGoogleResult);

            program.Click(element);

            element = Browser.FindElement(program.UnoSquareServicesMenu);

            program.Click(element);

            element = Browser.FindElement(program.PracticeAreas);

            program.Click(element);

            element = Browser.FindElement(program.ContactUs);

            program.Click(element);





        }
    }
}
