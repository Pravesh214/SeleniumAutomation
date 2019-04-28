using Framework.UltimateQa.Application.UltimateQa.Locator;
using NUnit.Framework;
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

        public void ValidateSprintOne(string firstname = "FirstName")
        {
            if (!_practicePageLocators.SprintOneHeading.Displayed)            
                Assert.Fail("Sprint 1 page not loaded");
            
            _practicePageLocators.FirstNameField.SendKeys(firstname);
            _practicePageLocators.SubmitButton.Click();
        }        
    }
}