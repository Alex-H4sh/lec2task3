using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LecTask3
{
    [TestClass]
    public class UnitTest
    {
        static IWebDriver driver;

        [TestInitialize]
        public void init()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void Task1()
        {
            driver.Navigate().GoToUrl("google.com");
        }

        [TestCleanup]
        public void close()
        {
            driver.Close();
        }
    }
}
