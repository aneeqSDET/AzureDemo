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
    public class NoveraSite

    {
        [TestMethod]
        public void SloganTest()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions))
            {
                driver.Url = "http://www.novera.com/";
                Assert.IsTrue(driver.PageSource.Contains("The Future of Finance is Powered by Novera"));

            }

        }
        [TestMethod]
        public void HeadingTest()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions))
            {
                driver.Url = "http://www.novera.com/";
                IWebElement Heading = driver.FindElementByXPath("//*[@id='infoHeading']");
                Assert.AreEqual("Launching Soon", Heading.Text);
            }
        }
    }
}
