using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace tutorial
{
    class PageObjectModel
    {

        public static string VerifyTitle(IWebDriver driver)
        {
            IWebElement title=driver.FindElement(By.ClassName("page-title"));
            string output = title.Text;
            return output;


        }
        public static void clickMobile(IWebDriver driver)
        {
            IWebElement mobileTab = driver.FindElement(By.XPath("//a[@href='http://live.demoguru99.com/index.php/mobile.html']"));

            mobileTab.Click();

        }

        public static string getTitleMobile(IWebDriver driver)
        {
            IWebElement title = driver.FindElement(By.ClassName("page-title"));
            String output = title.Text;
            return output;

        }

        public static void ShowOptions(IWebDriver driver)
        {
            IWebElement showOptions = driver
                    .FindElement(By.XPath("//select[@onchange='setLocation(this.value)' and @title='Sort By']"));
            showOptions.Click();
        }

        public static void clickName(IWebDriver driver)
        {
            IWebElement byName = driver.FindElement(
                    By.XPath("//option[@value='http://live.demoguru99.com/index.php/mobile.html?dir=asc&order=name']"));
            byName.Click();
        }
        public static void SendSearchString(IWebDriver driver, string SearchItem)
        {
            driver.Navigate().GoToUrl("http://google.com");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys(SearchItem);

        }


    }
}
