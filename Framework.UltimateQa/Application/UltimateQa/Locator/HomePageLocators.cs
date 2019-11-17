using OpenQA.Selenium;

namespace Framework.UltimateQa.Application.UltimateQa.Locator
{
    class HomePageLocators
    {
        public By AutomationExerciseLink => By.LinkText("Automation Exercises");

        public By GetMenuLink(string linkText) => By.LinkText(linkText);
    }
}
