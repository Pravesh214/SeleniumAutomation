using OpenQA.Selenium;

namespace Framework.UltimateQa.Application.UltimateQa.Pages
{
    public class BasePage
    {
        private IWebDriver driver;

        public BasePage(IWebDriver driver) { this.driver = driver; }

        public IWebElement GetElement(By by) {
            return driver.FindElement(by);
        }
    }
}