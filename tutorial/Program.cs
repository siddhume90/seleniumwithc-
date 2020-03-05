using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;

namespace tutorial
{
    class Program
    {
      

        static void Main(string[] args)
        {

            // check the main page title
            PageObjectModel p = new PageObjectModel();
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://live.demoguru99.com/index.php/");
            string output= PageObjectModel.VerifyTitle(driver);
            string expectedTitle = "THIS IS DEMO SITE FOR   ";
            Assert.AreEqual(output, expectedTitle);
            Console.WriteLine(output);

            // check the mobile page title

            PageObjectModel.clickMobile(driver);
            string title=PageObjectModel.getTitleMobile(driver);
            string expTitle= "MOBILE";
            Assert.AreEqual(expTitle, title);
            
            // testing the order of products displayed on page

            PageObjectModel.ShowOptions(driver);
            PageObjectModel.clickName(driver);


            IList<IWebElement> list = driver.FindElements(By.XPath("//li[@class='item last']//h2"));

            // creating an array list of strings to add the webelements of the ILIST above
            ArrayList stringList = new ArrayList();


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Text);
                stringList.Add(list[i].Text);
                
            }

            //checking to see if stringList is populated
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine("****" +stringList[i]);

            }

            // populating expectedStringList
            ArrayList expectedStringList = new ArrayList();
            expectedStringList.Add("IPHONE");
            expectedStringList.Add("SAMSUNG GALAXY");
            expectedStringList.Add("SONY XPERIA");


            Assert.AreEqual(stringList, expectedStringList);








            //  driver.Close();
        }
    }
}