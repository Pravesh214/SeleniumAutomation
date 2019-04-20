using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.UltimateQa.Application.UltimateQa.Locator
{
    public class FormSubmissionLocators
    {
        private readonly IWebDriver _driver;

        public FormSubmissionLocators(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public IWebElement Name => _driver.FindElement(By.Id("et_pb_contact_name_0"));

        public IWebElement Message => _driver.FindElement(By.Id("et_pb_contact_message_0"));

        public IWebElement Submit => _driver.FindElement(By.XPath("//*[@id=\"et_pb_contact_form_0\"]/div[2]/form/div/button"));
    }
}
