using Framework.UltimateQa.Application.UltimateQa.Locator;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class Home
    {
        private readonly IWebDriver _driver;
        private readonly HomePageLocators _homepageLocator;
        public readonly string HomeUrl = "https://www.ultimateqa.com";

        public Home(IWebDriver driver)
        {
            _driver = driver;
            _homepageLocator = new HomePageLocators(_driver);
        }

        public Home LaunchApplication()
        {
            _driver?.Navigate().GoToUrl(HomeUrl);
            _driver?.Manage().Window.Maximize();
            return this;
        }

        public void GoToAutomationExercisePage() => _homepageLocator.AutomationExerciseLink.Click();
    }
}
