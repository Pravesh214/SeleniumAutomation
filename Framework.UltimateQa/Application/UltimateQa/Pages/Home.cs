using Framework.UltimateQa.Application.UltimateQa.Locator;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class Home
    {
        private IWebDriver Driver;

        public Home(IWebDriver driver)
        {
            Driver = driver;
        }

        public Home LaunchApplication()
        {
            Driver?.Navigate().GoToUrl("https://www.ultimateqa.com");
            Driver.Manage().Window.Maximize();
            return this;
        }

        public void GoToAutomationExercisePage()
        {
            Driver.FindElement(By.LinkText("Automation Exercises")).Click();
        }
    }
}
