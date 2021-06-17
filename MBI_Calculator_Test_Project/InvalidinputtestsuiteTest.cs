﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
namespace MBI_Calculator_Test_Project
{
    [TestFixture]
    public class InvalidInputTestSuiteChromeTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void heightInputEmptyTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: height_input_empty_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=kg | 
            driver.FindElement(By.Id("kg")).Click();
            // 4 | type | id=kg | 68
            driver.FindElement(By.Id("kg")).SendKeys("68");
            // 5 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 6 | click | css=#aimtxt > table > tbody > tr > td | 
            driver.FindElement(By.CssSelector("#aimtxt > table > tbody > tr > td")).Click();
            // 7 | click | css=.colcenter td | 
            driver.FindElement(By.CssSelector(".colcenter td")).Click();
            // 8 | assertAlert | Please enter your height. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter your height."));
            // 9 | close |  | 
            driver.Close();
        }
        [Test]
        public void heightInputLetterTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: height_input_letter_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 4 | type | id=htc | asd
            driver.FindElement(By.Id("htc")).SendKeys("asd");
            // 5 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 6 | assertAlert | Please enter a number for your height. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter a number for your height."));
            // 7 | close |  | 
            driver.Close();
        }
        [Test]
        public void heightInputZeroTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: height_input_zero_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 4 | type | id=htc | 0
            driver.FindElement(By.Id("htc")).SendKeys("0");
            // 5 | click | id=kg | 
            driver.FindElement(By.Id("kg")).Click();
            // 6 | type | id=kg | 66
            driver.FindElement(By.Id("kg")).SendKeys("66");
            // 7 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 8 | assertAlert | Please enter a number larger than 0 for your height. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter a number larger than 0 for your height."));
            // 9 | close |  | 
            driver.Close();
        }
        [Test]
        public void weightInputEmptyTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: weight_input_empty_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 4 | type | id=htc | 150
            driver.FindElement(By.Id("htc")).SendKeys("150");
            // 5 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 6 | assertAlert | Please enter your weight. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter your weight."));
            // 7 | close |  | 
            driver.Close();
        }
        [Test]
        public void weightInputLetterTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: weight_input_letter_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=kg | 
            driver.FindElement(By.Id("kg")).Click();
            // 4 | type | id=kg | abc
            driver.FindElement(By.Id("kg")).SendKeys("abc");
            // 5 | click | css=tr:nth-child(2) > td > b | 
            driver.FindElement(By.CssSelector("tr:nth-child(2) > td > b")).Click();
            // 6 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 7 | type | id=htc | 125
            driver.FindElement(By.Id("htc")).SendKeys("125");
            // 8 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 9 | assertAlert | Please enter a number for your weight. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter a number for your weight."));
            // 10 | close |  | 
            driver.Close();
        }
        [Test]
        public void weightInputZeroTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: weight_input_zero_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | css=tr:nth-child(2) > td > b | 
            driver.FindElement(By.CssSelector("tr:nth-child(2) > td > b")).Click();
            // 4 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 5 | type | id=htc | 165
            driver.FindElement(By.Id("htc")).SendKeys("165");
            // 6 | click | id=kg | 
            driver.FindElement(By.Id("kg")).Click();
            // 7 | type | id=kg | 0
            driver.FindElement(By.Id("kg")).SendKeys("0");
            // 8 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 9 | assertAlert | Please enter a number larger than 0 for your weight. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter a number larger than 0 for your weight."));
            // 10 | close |  | 
            driver.Close();
        }
    }


    [TestFixture]
    public class InvalidInputTestSuiteFirefoxTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void heightInputEmptyTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: height_input_empty_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=kg | 
            driver.FindElement(By.Id("kg")).Click();
            // 4 | type | id=kg | 68
            driver.FindElement(By.Id("kg")).SendKeys("68");
            // 5 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 6 | click | css=#aimtxt > table > tbody > tr > td | 
            driver.FindElement(By.CssSelector("#aimtxt > table > tbody > tr > td")).Click();
            // 7 | click | css=.colcenter td | 
            driver.FindElement(By.CssSelector(".colcenter td")).Click();
            // 8 | assertAlert | Please enter your height. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter your height."));
            // 9 | close |  | 
            driver.Close();
        }
        [Test]
        public void heightInputLetterTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: height_input_letter_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 4 | type | id=htc | asd
            driver.FindElement(By.Id("htc")).SendKeys("asd");
            // 5 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 6 | assertAlert | Please enter a number for your height. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter a number for your height."));
            // 7 | close |  | 
            driver.Close();
        }
        [Test]
        public void heightInputZeroTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: height_input_zero_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 4 | type | id=htc | 0
            driver.FindElement(By.Id("htc")).SendKeys("0");
            // 5 | click | id=kg | 
            driver.FindElement(By.Id("kg")).Click();
            // 6 | type | id=kg | 66
            driver.FindElement(By.Id("kg")).SendKeys("66");
            // 7 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 8 | assertAlert | Please enter a number larger than 0 for your height. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter a number larger than 0 for your height."));
            // 9 | close |  | 
            driver.Close();
        }
        [Test]
        public void weightInputEmptyTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: weight_input_empty_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 4 | type | id=htc | 150
            driver.FindElement(By.Id("htc")).SendKeys("150");
            // 5 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 6 | assertAlert | Please enter your weight. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter your weight."));
            // 7 | close |  | 
            driver.Close();
        }
        [Test]
        public void weightInputLetterTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: weight_input_letter_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | id=kg | 
            driver.FindElement(By.Id("kg")).Click();
            // 4 | type | id=kg | abc
            driver.FindElement(By.Id("kg")).SendKeys("abc");
            // 5 | click | css=tr:nth-child(2) > td > b | 
            driver.FindElement(By.CssSelector("tr:nth-child(2) > td > b")).Click();
            // 6 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 7 | type | id=htc | 125
            driver.FindElement(By.Id("htc")).SendKeys("125");
            // 8 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 9 | assertAlert | Please enter a number for your weight. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter a number for your weight."));
            // 10 | close |  | 
            driver.Close();
        }
        [Test]
        public void weightInputZeroTest()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // Test name: weight_input_zero_test
            // Step # | name | target | value
            // 1 | open | /health/educational/lose_wt/BMI/bmi-m.htm | 
            driver.Navigate().GoToUrl("https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm");
            // 2 | setWindowSize | 915x1030 | 
            driver.Manage().Window.Size = new System.Drawing.Size(915, 1030);
            // 3 | click | css=tr:nth-child(2) > td > b | 
            driver.FindElement(By.CssSelector("tr:nth-child(2) > td > b")).Click();
            // 4 | click | id=htc | 
            driver.FindElement(By.Id("htc")).Click();
            // 5 | type | id=htc | 165
            driver.FindElement(By.Id("htc")).SendKeys("165");
            // 6 | click | id=kg | 
            driver.FindElement(By.Id("kg")).Click();
            // 7 | type | id=kg | 0
            driver.FindElement(By.Id("kg")).SendKeys("0");
            // 8 | click | css=.colcenter > input | 
            driver.FindElement(By.CssSelector(".colcenter > input")).Click();
            // 9 | assertAlert | Please enter a number larger than 0 for your weight. | 
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Please enter a number larger than 0 for your weight."));
            // 10 | close |  | 
            driver.Close();
        }
    }

}
