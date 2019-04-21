using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.UltimateQa.Application.UltimateQa.Flow
{
    public class CommonFlow
    {
        private readonly IWebDriver _driver;

        public string HomeUrl => "https://www.ultimateqa.com";

        public CommonFlow(IWebDriver driver)
        {
            _driver = driver;
        }

        public void LaunchApplication()
        {
            _driver?.Navigate().GoToUrl(HomeUrl);
            _driver?.Manage().Window.Maximize();
        }
    }
}
