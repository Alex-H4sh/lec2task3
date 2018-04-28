using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test3
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
        public void lec2test3()
        {
            driver.Navigate().GoToUrl("https://localhost/litecart/admin");
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
            IWebElement success = driver.FindElement(By.CssSelector(".notice.success"));
            Assert.IsFalse(!success.Text.Equals("You are now logged in as admin"), "You are not admin");
        }

        [TestCleanup]
        public void end()
        {
            driver.Close();
        }
    }
}
