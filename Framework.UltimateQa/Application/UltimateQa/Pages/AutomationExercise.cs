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

        public void GoToFormSubmissionPage()
        {
            _practicePageLocators.FillOutFormsLink.Click();            
        }
    }
}