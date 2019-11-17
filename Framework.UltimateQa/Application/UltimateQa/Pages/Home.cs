using Framework.UltimateQa.Application.UltimateQa.Flow;
using Framework.UltimateQa.Application.UltimateQa.Locator;
using OpenQA.Selenium;

namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class Home : BasePage
    {        
        private readonly HomePageLocators _homepageLocator;
        private readonly CommonFlow _commonFlow;

        public Home(IWebDriver _driver) : base(_driver)
        {            
            _homepageLocator = new HomePageLocators();
            _commonFlow = new CommonFlow(_driver);
        }

        public void GoToAutomationExercisePage()
        {
            _commonFlow.LaunchApplication();
            GetElement(_homepageLocator.AutomationExerciseLink).Click();
        }
    }
}
