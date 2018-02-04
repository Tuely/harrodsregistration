using OpenQA.Selenium;

namespace Harrods.Pages
{
    public class RegistrationStartPage : BasePage
    {
        public IWebElement EmailAddressTextBox { get { return GetElement(Elements.EmailAddressTextBox); } }

        public IWebElement ContinueRegistrationButton { get { return GetElement(Elements.ContinueRegistrationButton); } }

        public IWebElement EmailValidationErrorLabel { get { return GetElement(Elements.EmailValidationErrorLabel); } }
        public void ContinueRegistration()
        {
            ContinueRegistrationButton.Click();
        }

        private static class Elements
        {
            public static By EmailAddressTextBox = By.Id("EmailAddress");
            public static By ContinueRegistrationButton = By.ClassName("button--action");
            public static By EmailValidationErrorLabel = By.ClassName("validation-summary-messages");
        }
    }
}
