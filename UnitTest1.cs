using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestPackage.Pages;
using System;

namespace SeleniumTestPackage
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }


        [Test]
        public void LoginTest()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Driver.Navigate().GoToUrl("https://services.nhsbsa.nhs.uk/check-for-help-paying-nhs-costs/start");

            NhsHome nhsHome = new NhsHome(Driver);
            nhsHome.ClickLogin();

            WhereYouLive whereYouLive = new WhereYouLive(Driver);
            whereYouLive.SelectCountry();
            whereYouLive.ClickNextButton();

            ScotlandorWales scotlandorWales = new ScotlandorWales(Driver);
            scotlandorWales.SelectCountry();
            scotlandorWales.ClickNextButton();

            DoB doB = new DoB(Driver);
            doB.EnterDob();
            doB.ClickNextButton();

            LiveWithPartner liveWithPartner = new LiveWithPartner(Driver);
            liveWithPartner.SelectYesNo();
            liveWithPartner.ClickNextButton();



            Assert.Pass();
        }

        [TearDown]
        public void close_Browser()
        {
            Driver.Quit(); 
        }

    }
}