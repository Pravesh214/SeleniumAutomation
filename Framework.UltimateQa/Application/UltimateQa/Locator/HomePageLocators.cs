using OpenQA.Selenium;

namespace Framework.UltimateQa.Application.UltimateQa.Locator
{
    class HomePageLocators
    {
        protected readonly IWebDriver _driver;

        public HomePageLocators(IWebDriver webDriver) => _driver = webDriver;

        public IWebElement AutomationExerciseLink => _driver.FindElement(By.LinkText("Automation Exercises"));

        public IWebElement GetMenuLink(string linkText) => _driver.FindElement(By.LinkText(linkText));
    }
}
