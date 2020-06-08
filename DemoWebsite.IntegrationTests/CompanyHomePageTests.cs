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
                driver.Url = "https://www.abacusnext.com/";
                Assert.IsTrue(driver.PageSource.Contains("AbacusNext"));
            }

        }
        [TestMethod]
        public void FooterTest()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions))
            {
                driver.Url = "https://www.abacusnext.com/";
                IWebElement Footer = driver.FindElementByXPath("/html/body/footer/div/div[2]");
                Assert.IsTrue(Footer.Text.Contains("AbacusNext"));
                //Footer
            }
        }
    }
}