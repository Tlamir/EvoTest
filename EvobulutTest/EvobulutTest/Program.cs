using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace EvobulutTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string link = @"https://www.evobulut.com";
            driver.Navigate().GoToUrl(link);

            // Login
            driver.FindElement(By.CssSelector("a.btn:nth-child(2)")).Click();

            // Email
            driver.FindElement(By.Id("user_code")).SendKeys("mht9811@gmail.com");

            // Password
            driver.FindElement(By.Id("user_pass")).SendKeys("Evo123");

            // Click login button
            driver.FindElement(By.CssSelector("button.btn")).Click();

            // wait for element visible
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Click customer management button
            driver.FindElement(By.CssSelector("#menu-5 > a:nth-child(1) > span:nth-child(2)")).Click();

            // Click person management button
            driver.FindElement(By.CssSelector("#menu-58")).Click();

            // wait for element visible
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Click checkbox
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.CssSelector("#evo_guide1_evo_row_0 > td:nth-child(1) > label:nth-child(1) > i:nth-child(2)")), 2, 2).Click().Perform();
            


        }
    }
}
