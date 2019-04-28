using Framework.UltimateQa.Application.UltimateQa.Locator;
using OpenQA.Selenium;
namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class AutomationExercise
    {
        private readonly AutomationPracticePageLocators _practicePageLocators;

        public AutomationExercise(IWebDriver driver)
        {
            _practicePageLocators = new AutomationPracticePageLocators(driver);
        }

        public void GoToFormSubmissionPage() => _practicePageLocators.FillOutFormsLink.Click();

        public void GoToEvolveApplicationPage() => _practicePageLocators.ApplicationEvolveLink.Click();

        public bool ValidateSprintOneHeading() => (_practicePageLocators.SprintOneHeading.Displayed);
    }
}