using System;
using OpenQA.Selenium;

namespace SeleniumTestPackage.Pages
{
    public class NhsHome
    {
        private IWebDriver Driver;

        public NhsHome(IWebDriver driver) => Driver = driver;

        IWebElement lnkLogin => Driver.FindElement(By.CssSelector("#next-button"));

        public void ClickLogin() => lnkLogin.Click();

    }
}
