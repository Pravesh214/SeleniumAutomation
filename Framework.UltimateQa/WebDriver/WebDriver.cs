using Framework.UltimateQa.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Framework.UltimateQa.WEbDriver
{
    public class WebDriver
    {
        public IWebDriver Driver { get; set; }        

        public WebDriver(string driverType = DriverType.Chrome)
        {
            Driver = GetChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10.00);
        }

        public static IWebDriver GetChromeDriver() => 
            new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        public void Close() => Driver.Close();
    }
}
