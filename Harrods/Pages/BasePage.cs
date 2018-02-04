using System;
using Harrods.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Harrods.Pages
{
    public abstract class BasePage
    {
        public IWebDriver Driver { get; private set; }
        public double ElementVisibilityWaitInSeconds { get; private set; }

        public BasePage()
        {
            Driver = Context.Driver;
            ElementVisibilityWaitInSeconds = Context.ElementVisibilityWaitInSeconds;
        }

        public string Title { get { return Driver?.Title; } }

        public IWebElement FieldValidationErrorLabel { get { return GetElement(Elements.FieldValidationErrorLabel); } }

        protected IWebElement GetElement(By elementIdentifier)
        {
            return GetElement(elementIdentifier, ElementVisibilityWaitInSeconds);
        }

        /// <summary>
        /// Explicit wait for each individual element in a page
        /// </summary>
        /// <param name="elementIdentifier"></param>
        /// <param name="elementVisibilityWaitInSeconds"></param>
        /// <returns></returns>
        protected IWebElement GetElement(By elementIdentifier, double elementVisibilityWaitInSeconds)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(elementVisibilityWaitInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(elementIdentifier));
        }

        public void Pause(double timeOutInSeconds)
        {
            System.Threading.Thread.Sleep((int)timeOutInSeconds * 1000);
        }

        private static class Elements
        {
            public static By FieldValidationErrorLabel = By.ClassName("field-validation-error");
        }
    }
}
