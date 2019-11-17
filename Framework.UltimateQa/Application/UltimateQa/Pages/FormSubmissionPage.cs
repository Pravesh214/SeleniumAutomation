using Framework.UltimateQa.Application.UltimateQa.Locator;
using OpenQA.Selenium;

namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class FormSubmissionPage : BasePage
    {
        private readonly FormSubmissionLocators _formSubmissionLocators;

        public FormSubmissionPage(IWebDriver driver) : base(driver) => 
            _formSubmissionLocators = new FormSubmissionLocators();

        public FormSubmissionPage FillFormDetails(string name, string message)
        {
            GetElement(_formSubmissionLocators.Name).SendKeys(name);
            GetElement(_formSubmissionLocators.Message).SendKeys(message);
            GetElement(_formSubmissionLocators.Submit).Click();
            return this;
        }
    }
}