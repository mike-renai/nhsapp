using System;
using OpenQA.Selenium;

namespace SeleniumTestPackage.Pages
{
    public class DoB
    {
        private IWebDriver Driver;

        public DoB(IWebDriver driver) => Driver = driver;

        //public int day = 01;
        //public int month = 01;
        //public int year = 1990;

        IWebElement Day => Driver.FindElement(By.CssSelector("#dob-day"));

        IWebElement Month => Driver.FindElement(By.CssSelector("#dob-month"));

        IWebElement Year => Driver.FindElement(By.CssSelector("#dob-year"));

        IWebElement nextButton => Driver.FindElement(By.CssSelector("#next-button"));

        public void ClickNextButton() => nextButton.Click();

        public void EnterDob()
        {
            Day.SendKeys("01");
            Month.SendKeys("11");
            Year.SendKeys("1990");
        }
    }
}
