namespace Harrods.Pages
{
    public static class PageFactory
    {
        private static HomePage homePage;

        public static HomePage HomePage
        {
            get
            {
                if (homePage == null)
                    homePage = new HomePage();

                return homePage;
            }
        }

        private static RegistrationStartPage registrationStartPage;

        public static RegistrationStartPage RegistrationStartPage
        {
            get
            {
                if (registrationStartPage == null)
                    registrationStartPage = new RegistrationStartPage();

                return registrationStartPage;
            }
        }

        private static RegistrationPage registrationPage;

        public static RegistrationPage RegistrationPage
        {
            get
            {
                if (registrationPage == null)
                    registrationPage = new RegistrationPage();

                return registrationPage;
            }
        }

        private static AccountPage accountPage;

        public static AccountPage AccountPage
        {
            get
            {
                if (accountPage == null)
                    accountPage = new AccountPage();

                return accountPage;
            }
        }
    }
}
