using Framework.UltimateQa;
using Framework.UltimateQa.Application.UltimateQa.Pages;
using Framework.UltimateQa.Driver;
using Framework.UltimateQa.Enums;
using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;

namespace Tests
{
    public class SmokeTests
    {
        [Test]
        public void SmokeTest()
        {
            IWebDriver driver = new WebDriver(DriverType.CHROME).Driver;
            Home homePage = new Home(driver);

            homePage.LaunchApplication();
            homePage.GoToAutomationExercisePage();

            driver.Close();
        }       
    }
}