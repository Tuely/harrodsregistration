using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Harrods.Pages
{
    public class RegistrationPage : BasePage
    {
        public SelectElement TitleDropDown { get { return new SelectElement(GetElement(Elements.TitleDropDown)); } }

        public IWebElement FirstNameTextBox { get { return GetElement(Elements.FirstNameTextBox); } }

        public IWebElement LastNameTextBox { get { return GetElement(Elements.LastNameTextBox); } }

        public IWebElement ContactNumberTextBox { get { return GetElement(Elements.ContactNumberTextBox); } }

        public SelectElement BirthdayDayDropDown { get { return new SelectElement(GetElement(Elements.BirthdayDayDropDown)); } }

        public SelectElement BirthdayMonthDropDown { get { return new SelectElement(GetElement(Elements.BirthdayMonthDropDown)); } }

        public SelectElement CountryDropDown { get { return new SelectElement(GetElement(Elements.CountryDropDown)); } }

        public IWebElement AddressFinderTextBox { get { return GetElement(Elements.AddressFinderTextBox); } }

        public SelectElement AddressDropDown { get { return new SelectElement(GetElement(Elements.AddressDropDown)); } }

        public IWebElement CreatePasswordTextBox { get { return GetElement(Elements.CreatePasswordTextBox); } }

        public IWebElement ConfirmPasswordTextBox { get { return GetElement(Elements.ConfirmPasswordTextBox); } }

        public IWebElement CompleteRegistrationButton { get { return GetElement(Elements.CompleteRegistrationButton); } }

        public void CompleteRegistration()
        {
            CompleteRegistrationButton.Click();
        }

        public void WaitForAddressLookup()
        {
            GetElement(Elements.AddressDropDown, 120);
            Pause(5);
        }

        private static class Elements
        {
            public static By TitleDropDown = By.Id("Title");
            public static By FirstNameTextBox = By.Id("FirstName");
            public static By LastNameTextBox = By.Id("LastName");
            public static By ContactNumberTextBox = By.Id("TelephoneNumber");
            public static By BirthdayDayDropDown = By.Id("BirthdayDay");
            public static By BirthdayMonthDropDown = By.Id("BirthdayMonth");
            public static By CountryDropDown = By.Id("Address_CountryCode");
            public static By AddressFinderTextBox = By.Id("Address_addressSearch");
            public static By AddressDropDown = By.ClassName("address-search_results");
            public static By CreatePasswordTextBox = By.Id("NewPassword");
            public static By ConfirmPasswordTextBox = By.Id("ConfirmNewPassword");
            public static By CompleteRegistrationButton = By.ClassName("js-form-submit");
        }
    }
}
