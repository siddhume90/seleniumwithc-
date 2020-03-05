using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Reflection;

namespace tutorial
{
    class Nunit1
    {
        IWebDriver driver;
       
        public void OpenGoogle()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");
           // driver.Url = "http://google.com";
            driver.Manage().Window.Maximize();
            driver.Close();


        }
    }
}
