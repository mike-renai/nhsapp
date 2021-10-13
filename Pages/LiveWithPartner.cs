using System;
using OpenQA.Selenium;

namespace SeleniumTestPackage.Pages
{
    public class LiveWithPartner
    {
        private IWebDriver Driver;

        public LiveWithPartner(IWebDriver driver) => Driver = driver;

        IWebElement lnkRadio => Driver.FindElement(By.CssSelector("#label-no"));

        IWebElement nextButton => Driver.FindElement(By.CssSelector("#next-button"));

        public void ClickNextButton() => nextButton.Click();

        public void SelectYesNo() => lnkRadio.Click();

    }
}
