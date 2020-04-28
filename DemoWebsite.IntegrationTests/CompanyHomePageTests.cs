using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebsite.IntegrationTests
{
    [TestClass]
    public class CompanyHomePageTests

    {
        [TestMethod]
        public void NameTest()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions))
            {
                driver.Url = "https://www.finastra.com/";
                Assert.IsTrue(driver.PageSource.Contains("Finastra"));

            }

        }
        [TestMethod]
        public void FooterTest()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions))
            {
                driver.Url = "https://www.finastra.com/";
                IWebElement Heading = driver.FindElementByXPath("/html/body/div[1]/footer/div/div/div/div/div[4]/div/p");
                Assert.IsTrue(Heading.Text.Contains("Finastra. All rights reserved"));
                ///html/body/div[1]/footer/div/div/div/div/div[4]/div/p //*[@id='infoHeading']
            }
        }
    }
}