using System;
using OpenQA.Selenium;

namespace SeleniumTestPackage.Pages
{
    public class ScotlandorWales
    {
        private IWebDriver Driver;

        public ScotlandorWales(IWebDriver driver) => Driver = driver;

        IWebElement lnkRadio => Driver.FindElement(By.CssSelector("#label-no"));

        IWebElement nextButton => Driver.FindElement(By.CssSelector("#next-button"));

        public void ClickNextButton() => nextButton.Click();

        public void SelectCountry() => lnkRadio.Click();
    

    public ScotlandorWales()
        {
        }
    }
}
