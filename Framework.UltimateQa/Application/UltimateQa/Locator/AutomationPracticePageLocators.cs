using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.UltimateQa.Application.UltimateQa.Locator
{
    class AutomationPracticePageLocators
    {
        public By FillOutFormsLink => By.LinkText("Fill out forms");

        public By ApplicationEvolveLink => By.PartialLinkText("evolves");

        public By SprintOneHeading => By.XPath("//*[@id=\"post-927\"]/h1");

        public By FirstNameField => By.Name("firstname");

        public By SubmitButton => By.Id("submitForm");
    }
}
