using Framework.UltimateQa.Application.UltimateQa.Locator;
using OpenQA.Selenium;

namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class FormSubmissionPage
    {
        private readonly FormSubmissionLocators _formSubmissionLocators;

        public FormSubmissionPage(IWebDriver driver) => 
            _formSubmissionLocators = new FormSubmissionLocators(driver);

        public FormSubmissionPage FillFormDetails(string name, string message)
        {
            _formSubmissionLocators.Name.SendKeys(name);
            _formSubmissionLocators.Message.SendKeys(message);
            _formSubmissionLocators.Submit.Click();
            return this;
        }
    }
}