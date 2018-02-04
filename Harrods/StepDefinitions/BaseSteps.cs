using Harrods.Pages;

namespace Harrods.StepDefinitions
{
    public abstract class BaseSteps
    {
        protected HomePage HomePage { get; private set; }
        protected RegistrationPage RegistrationPage { get; private set; }
        protected RegistrationStartPage RegistrationStartPage { get; private set; }
        protected AccountPage AccountPage { get; private set; }

        public BaseSteps()
        {
            HomePage = PageFactory.HomePage;
            RegistrationPage = PageFactory.RegistrationPage;
            RegistrationStartPage = PageFactory.RegistrationStartPage;
            AccountPage = PageFactory.AccountPage;
        }
    }
}
