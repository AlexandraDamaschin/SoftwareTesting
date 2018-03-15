using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class Working
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void Selenium_Test()
        {
            driver.Navigate().GoToUrl("http://localhost:51355/Default");
            driver.FindElement(By.Name("Age")).Clear();
            driver.FindElement(By.Name("Age")).SendKeys("20");
            driver.FindElement(By.Name("Gender")).Click();
            driver.FindElement(By.Name("Gender")).Clear();
            driver.FindElement(By.Name("Gender")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("customWrap")).Click();

            driver.FindElement(By.Name("Age")).Clear();
            driver.FindElement(By.Name("Age")).SendKeys("57");
            driver.FindElement(By.Name("Gender")).Click();
            driver.FindElement(By.Name("Gender")).Clear();
            driver.FindElement(By.Name("Gender")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("customWrap")).Click();

            driver.FindElement(By.Name("Age")).Clear();
            driver.FindElement(By.Name("Age")).SendKeys("16");
            driver.FindElement(By.Name("Gender")).Click();
            driver.FindElement(By.Name("Gender")).Clear();
            driver.FindElement(By.Name("Gender")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("customWrap")).Click();

            driver.FindElement(By.Name("Age")).Clear();
            driver.FindElement(By.Name("Age")).SendKeys("16");
            driver.FindElement(By.Name("Gender")).Click();
            driver.FindElement(By.Name("Gender")).Clear();
            driver.FindElement(By.Name("Gender")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("customWrap")).Click();

            driver.FindElement(By.Name("Age")).Clear();
            driver.FindElement(By.Name("Age")).SendKeys("20");
            driver.FindElement(By.Name("Gender")).Click();
            driver.FindElement(By.Name("Gender")).Clear();
            driver.FindElement(By.Name("Gender")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("customWrap")).Click();

            driver.FindElement(By.Name("Age")).Clear();
            driver.FindElement(By.Name("Age")).SendKeys("57");
            driver.FindElement(By.Name("Gender")).Click();
            driver.FindElement(By.Name("Gender")).Clear();
            driver.FindElement(By.Name("Gender")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("customWrap")).Click();

            driver.FindElement(By.Name("Age")).Clear();
            driver.FindElement(By.Name("Age")).SendKeys("45");
            driver.FindElement(By.Name("Gender")).Click();
            driver.FindElement(By.Name("Gender")).Clear();
            driver.FindElement(By.Name("Gender")).SendKeys("nogender");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("customWrap")).Click();

            driver.FindElement(By.Name("Age")).Clear();
            driver.FindElement(By.Name("Age")).SendKeys("55");
            driver.FindElement(By.Name("Gender")).Click();
            driver.FindElement(By.Name("Gender")).Clear();
            driver.FindElement(By.Name("Gender")).SendKeys("nogender");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("customWrap")).Click();


            try
            {
                Assert.AreEqual("Home Page - My ASP.NET Application", driver.Title);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
