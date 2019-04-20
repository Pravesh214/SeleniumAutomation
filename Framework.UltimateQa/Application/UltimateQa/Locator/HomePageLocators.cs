using OpenQA.Selenium;

namespace Framework.UltimateQa.Application.UltimateQa.Locator
{
    class HomePageLocators
    {
        private readonly IWebDriver _driver;

        public HomePageLocators(IWebDriver webDriver) => _driver = webDriver;

        public IWebElement AutomationExerciseLink => _driver.FindElement(By.LinkText("Automation Exercises"));


    }
}
