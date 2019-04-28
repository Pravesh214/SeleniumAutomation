using Framework.UltimateQa.Application.UltimateQa.Pages;
using NUnit.Framework;
using NUnit.TestProject.TestApplication.UltimateQa.TestBaseSuite;

namespace NUnit.TestProject.TestApplication.UltimateQa.Tests
{
    [TestFixture]
    public class SmokeTests : TestBase
    {
        [Test]
        public void SmokeTestRun()
        {            
            Home homePage = new Home(Driver);            
            homePage.GoToAutomationExercisePage();             
        }       
    }
}