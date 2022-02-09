using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POMBDDGoogleSearch.Pages
{
    public class BasePage
    {

        public IWebDriver driver = null;
        public static BasePage basePage = null;
        public static BasePage GetInstance { 
            get
            {

                if (basePage is null)
                {
                    basePage = new BasePage();
                }
                return basePage;
            }
        }
        private BasePage()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

        }
    }
}
