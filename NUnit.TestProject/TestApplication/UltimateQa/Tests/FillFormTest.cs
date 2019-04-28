using Framework.UltimateQa.Application.UltimateQa.Pages;
using NUnit.Framework;
using NUnit.TestProject.TestApplication.UltimateQa.TestBaseSuite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit.TestProject.TestApplication.UltimateQa.Tests
{
    [TestFixture]
    public class FillFormTest : TestBase
    {
        [Test]
        public void FillFormRun()
        {
            Home homePage = new Home(Driver);            
            homePage.GoToAutomationExercisePage();

            AutomationExercise automationExercise = new AutomationExercise(Driver);
            automationExercise.GoToFormSubmissionPage();

            FormSubmissionPage formSubmissionPage = new FormSubmissionPage(Driver);
            formSubmissionPage.FillFormDetails("name", "message");            
        }
    }
}
