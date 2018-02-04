using OpenQA.Selenium;

namespace Harrods.Pages
{
    public class AccountPage : BasePage
    {
        public IWebElement WelcomeGreetingsElement { get { return GetElement(Elements.WelcomeGreetingsElement); } }

        public IWebElement SignOutLink { get { return GetElement(Elements.SignOutLink); } }

        public void SignOut()
        {
            SignOutLink.Click();
            Pause(5);
        }

        private static class Elements
        {
            public static By WelcomeGreetingsElement = By.ClassName("portal-dashboard_header-title");
            public static By SignOutLink = By.ClassName("header-account_link--sign-out");
        }
    }
}
