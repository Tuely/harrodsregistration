using Harrods.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Harrods.StepDefinitions
{
    [Binding]
    public class UserRegistrationSteps : BaseSteps
    {
        [Given(@"I am a new user and visits the registration page")]
        public void GivenIAmANewUserAndVisitsTheRegistrationPage()
        {
            HomePage.Navigate();
            HomePage.StartRegistration();
        }

        [When(@"I enter email address '(.*)'")]
        public void WhenIEnterEmailAddress(string emailAddress)
        {
            RegistrationStartPage.EmailAddressTextBox.SendKeys(emailAddress);
        }

        [When(@"I continue with the registration")]
        public void WhenIContinueWithTheRegistration()
        {
            RegistrationStartPage.ContinueRegistrationButton.Click();
        }

        [When(@"I enter the following registration details")]
        public void WhenIEnterTheFollowingRegistrationDetails(Table data)
        {
            var registrationData = data.AsDictionary();

            if (registrationData.ContainsKey("Title"))
                RegistrationPage.TitleDropDown.SelectByText(registrationData["Title"]);

            if (registrationData.ContainsKey("FirstName"))
                RegistrationPage.FirstNameTextBox.SendKeys(registrationData["FirstName"]);

            if (registrationData.ContainsKey("LastName"))
                RegistrationPage.LastNameTextBox.SendKeys(registrationData["LastName"]);

            if (registrationData.ContainsKey("ContactNumber"))
                RegistrationPage.ContactNumberTextBox.SendKeys(registrationData["ContactNumber"]);

            if (registrationData.ContainsKey("BirthDay"))
                RegistrationPage.BirthdayDayDropDown.SelectByText(registrationData["BirthDay"]);

            if (registrationData.ContainsKey("BirthMonth"))
                RegistrationPage.BirthdayMonthDropDown.SelectByText(registrationData["BirthMonth"]);

            if (registrationData.ContainsKey("Country"))
                RegistrationPage.CountryDropDown.SelectByText(registrationData["Country"]);

            if (registrationData.ContainsKey("AddressKey"))
            {
                RegistrationPage.AddressFinderTextBox.SendKeys(registrationData["AddressKey"]);
                RegistrationPage.WaitForAddressLookup();
                if (registrationData.ContainsKey("Address"))
                    RegistrationPage.AddressDropDown.SelectByText(registrationData["Address"]);
            }
            if (registrationData.ContainsKey("Password"))
                RegistrationPage.CreatePasswordTextBox.SendKeys(registrationData["Password"]);

            if (registrationData.ContainsKey("ConfirmPassword"))
                RegistrationPage.ConfirmPasswordTextBox.SendKeys(registrationData["ConfirmPassword"]);
        }

        [When(@"I complete registration")]
        public void WhenICompleteRegistration()
        {
            RegistrationPage.CompleteRegistration();
        }

        [Then(@"I should see the greeting '(.*)'")]
        public void ThenIShouldSeeTheGreeting(string greetingMessage)
        {
            Assert.AreEqual(greetingMessage, AccountPage.WelcomeGreetingsElement.Text);
        }

        [Then(@"I should see error message '(.*)'")]
        public void ThenIShouldSeeErrorMessage(string errorMessage)
        {
            Assert.AreEqual(errorMessage, RegistrationPage.FieldValidationErrorLabel.Text);
        }

        [Then(@"I should see Email Validation error message '(.*)'")]
        public void ThenIShouldSeeEmailValidationErrorMessage(string errorMessage)
        {
            Assert.AreEqual(errorMessage, RegistrationStartPage.EmailValidationErrorLabel.Text);

        }


        [When(@"I enter the registration details '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)'")]
        public void WhenIEnterTheRegistrationDetails(string Title, string FirstName, string LastName, string ContactNumber, string BirthDay, string BirthMonth, string Country, string AddressKey, int Address, string Password, string ConfirmPassword)
        {
            RegistrationPage.TitleDropDown.SelectByText(Title);
            RegistrationPage.FirstNameTextBox.SendKeys(FirstName);
            RegistrationPage.LastNameTextBox.SendKeys(LastName);
            RegistrationPage.ContactNumberTextBox.SendKeys(ContactNumber);
            RegistrationPage.BirthdayDayDropDown.SelectByText(BirthDay);
            RegistrationPage.BirthdayMonthDropDown.SelectByText(BirthMonth);
            RegistrationPage.CountryDropDown.SelectByText(Country);
            RegistrationPage.AddressFinderTextBox.SendKeys(AddressKey);
            RegistrationPage.AddressDropDown.SelectByIndex(Address);
            RegistrationPage.CreatePasswordTextBox.SendKeys(Password);
            RegistrationPage.ConfirmPasswordTextBox.SendKeys(ConfirmPassword);

        }

       


    }
}
