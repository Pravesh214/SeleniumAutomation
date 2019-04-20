﻿using Framework.UltimateQa.Application.UltimateQa.Pages;
using NUnit.Framework;
using NUnit.TestProject.TestApplication.UltimateQa.TestBaseSuite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit.TestProject.TestApplication.UltimateQa.Tests
{
    [TestFixture]
    internal class FillFormTest : TestBase
    {
        [Test]
        public void FillForm()
        {
            Home homePage = new Home(Driver);
            homePage.LaunchApplication();
            homePage.GoToAutomationExercisePage();

            AutomationExercise automationExercise = new AutomationExercise(Driver);
            automationExercise.GoToFormSubmissionPage();

            FormSubmissionPage formSubmissionPage = new FormSubmissionPage(Driver);
            formSubmissionPage.FillFormDetails();            
        }
    }
}
