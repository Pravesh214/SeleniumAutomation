using Framework.UltimateQa.Application.UltimateQa.Pages;
using NUnit.Framework;
using NUnit.TestProject.TestApplication.UltimateQa.TestBaseSuite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit.TestProject.TestApplication.UltimateQa.Tests
{
    [TestFixture]
    public class SprintOneTest : TestBase
    {
        [Test]
        public void SprintOneTestRun()
        {
            Home homePage = new Home(Driver);
            homePage.GoToAutomationExercisePage();

            AutomationExercise automationExercise = new AutomationExercise(Driver);
            automationExercise.GoToEvolveApplicationPage();
            Assert.IsTrue(automationExercise.ValidateSprintOneHeading(), "Sprint 1 page not loaded");            
        }
    }
}
