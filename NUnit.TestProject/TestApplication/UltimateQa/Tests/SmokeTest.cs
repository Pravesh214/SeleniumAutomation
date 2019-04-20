using Framework.UltimateQa.Application.UltimateQa.Pages;
using NUnit.Framework;
using NUnit.TestProject.TestApplication.UltimateQa.TestBaseSuite;

namespace NUnit.TestProject.TestApplication.UltimateQa.Tests
{
    [TestFixture]
    public class SmokeTests : TestBase
    {
        [Test]
        public void SmokeTest()
        {           
            Home homePage = new Home(Driver);
            homePage.LaunchApplication();
            homePage.GoToAutomationExercisePage();            
        }       
    }
}