using Framework.UltimateQa.Application.UltimateQa.Locator;
using NUnit.Framework;
using OpenQA.Selenium;
namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class AutomationExercise : BasePage
    {
        private readonly AutomationPracticePageLocators _practicePageLocators;

        public AutomationExercise(IWebDriver driver) : base(driver)
        {
            _practicePageLocators = new AutomationPracticePageLocators();
        }

        public void GoToFormSubmissionPage() => GetElement(_practicePageLocators.FillOutFormsLink).Click();

        public void GoToEvolveApplicationPage() => GetElement(_practicePageLocators.ApplicationEvolveLink).Click();

        public void ValidateSprintOne(string firstname = "FirstName")
        {
            if (!GetElement(_practicePageLocators.SprintOneHeading).Displayed)            
                Assert.Fail("Sprint 1 page not loaded");
            
            GetElement(_practicePageLocators.FirstNameField).SendKeys(firstname);
            GetElement(_practicePageLocators.SubmitButton).Click();
        }        
    }
}