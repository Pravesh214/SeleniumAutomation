using Framework.UltimateQa.WEbDriver;
using Framework.UltimateQa.Enums;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnit.TestProject.TestApplication.UltimateQa.TestBaseSuite
{
    [SetUpFixture]
    public class TestBase
    {
        public IWebDriver Driver;

        [SetUp]
        public void SetUp() => Driver = new WebDriver(DriverType.Chrome).Driver;

        [TearDown]
        public void TearDown() => Driver.Close();
    }
}
