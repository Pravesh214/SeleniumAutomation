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

        public IWebElement ApplicationEvolveLink => _driver.FindElement(By.PartialLinkText("evolves"));

        public IWebElement SprintOneHeading => _driver.FindElement(By.XPath("//*[@id=\"post-927\"]/h1"));

        public IWebElement FirstNameField => _driver.FindElement(By.Name("firstname"));

        public IWebElement SubmitButton => _driver.FindElement(By.Id("submitForm"));
    }
}
