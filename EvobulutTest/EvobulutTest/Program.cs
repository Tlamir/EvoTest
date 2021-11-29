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

            //Update user surname Test
            string name = "yi";
            string newSurname = "Guven";

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


            //Search Text
           // driver.FindElement(By.CssSelector("html body.desktop-detected div#main div#content div#myTabContent1.tab-content.padding-10 div#s1.tab-pane.fade.in.active div.row div#maintabl.col-xs-12.col-sm-12.col-md-12.col-lg-12 div#mod0001_wid-id-2.jarviswidget.jarviswidget-color-blueDark div div.widget-body.no-padding div#evo_guide1 div.table-responsive.evomobile-responsive div#evo_guide1_Ust_Baslik1.dt-toolbar-footer div.row div.col-lg-6.col-md-6.col-sm-12.col-xs-12 div#datatable_fixed_column_filter.dataTables_filter label input#evo_guide1_Full_Text.form-control")).SendKeys(name);


            // Click Search button
            //driver.FindElement(By.CssSelector("#evo_guide1_Full_Bul > i:nth-child(1)")).Click();


            // Click checkbox
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.CssSelector("#evo_guide1_evo_row_0 > td:nth-child(1) > label:nth-child(1) > i:nth-child(2)")), 2, 2).Click().Perform();

            //Click change
            driver.FindElement(By.CssSelector("#But_Guncelle_mod1 > span:nth-child(2)")).Click();


            //Change SurName
            driver.FindElement(By.CssSelector("html body.desktop-detected div#main div#content div#myTabContent1.tab-content.padding-10 div#s2_mod0001.tab-pane.fade.active.in div.row section#widget-grid article.col-xs-12.col-sm-6.col-md-6.col-lg-6.sortable-grid.ui-sortable div#mod0001_wid-id-1.jarviswidget.jarviswidget-sortable div div.widget-body.no-padding form.smart-form fieldset div.row section.col.col-6 label.input input#a_soy.l_veri")).SendKeys(newSurname);

            //Click save
            driver.FindElement(By.CssSelector(".col-md-8 > ul:nth-child(1) > li:nth-child(2) > a:nth-child(1) > span:nth-child(2)")).Click();





            //Close browser after test

           //driver.Close();
           //driver.Quit();
        }
    }
}
