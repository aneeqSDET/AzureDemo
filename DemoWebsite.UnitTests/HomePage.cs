using System;
using Xunit;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoWebsite.Models;
using DemoWebsite.Controllers;

namespace DemoWebsite.UnitTests
{
    public class HomePage
    {
        [Fact]
        public void IndexUnitTest()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.Equal("Index", result.ViewName);


        }
        [Fact]
        public void PrivacyUnitTest()
        {
            var controller = new HomeController();
            var result = controller.Privacy() as ViewResult;
            Assert.Equal("Privacy", result.ViewName);

        }
    }
}
