using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using Framework.UltimateQa.Enums;
using System.IO;
using System.Reflection;

namespace Framework.UltimateQa.Driver
{
    public class WebDriver
    {
        public WebDriver(string DriverType = DriverType.CHROME)
        {
            Driver = GetChromeDriver();            
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10.00);
        }

        public static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        public IWebDriver Driver { get; set; }

    }
}
