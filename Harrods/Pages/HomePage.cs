using Harrods.Core;
using OpenQA.Selenium;

namespace Harrods.Pages
{
    public class HomePage : BasePage
    {
        public IWebElement RegisterLink { get { return GetElement(Elements.RegisterLink); } }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl($"{Context.BaseURL}");
        }

        public void StartRegistration()
        {
            RegisterLink.Click();
        }

        private static class Elements
        {
            public static By RegisterLink = By.ClassName("header-account_link--register");
        }
    }
}
