using System;
using OpenQA.Selenium;

namespace SeleniumTestPackage.Pages
{
    public class WhereYouLive
    {
        private IWebDriver Driver;

        public WhereYouLive(IWebDriver driver) => Driver = driver;

        IWebElement lnkRadio => Driver.FindElement(By.CssSelector("#label-england"));

        IWebElement nextButton => Driver.FindElement(By.CssSelector("#next-button"));

        public void ClickNextButton() => nextButton.Click();

        public void SelectCountry() => lnkRadio.Click();
    }
}
