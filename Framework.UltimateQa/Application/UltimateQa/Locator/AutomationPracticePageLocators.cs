using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.UltimateQa.Application.UltimateQa.Locator
{
    class AutomationPracticePageLocators
    {
        private readonly IWebDriver _driver;

        public AutomationPracticePageLocators(IWebDriver webDriver) => _driver = webDriver;

        public IWebElement FillOutFormsLink => _driver.FindElement(By.LinkText("Fill out forms"));
    }
}
