using Framework.UltimateQa.Application.UltimateQa.Flow;
using Framework.UltimateQa.Application.UltimateQa.Locator;
using OpenQA.Selenium;

namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class Home
    {
        private readonly IWebDriver _driver;
        private readonly HomePageLocators _homepageLocator;
        private readonly CommonFlow _commonFlow;

        public Home(IWebDriver driver)
        {
            _driver = driver;
            _homepageLocator = new HomePageLocators(_driver);
            _commonFlow = new CommonFlow(_driver);
        }

        public void GoToAutomationExercisePage()
        {
            _commonFlow.LaunchApplication();
            _homepageLocator.AutomationExerciseLink.Click();
        }
    }
}
