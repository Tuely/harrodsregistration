using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Harrods.Core
{
    public class DriverManager : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        /// <summary>
        /// Different browsers- Based upon contect class needs to decide the browser
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="implicitWaitInSeconds"></param>
        public void Initialize(string browser, double implicitWaitInSeconds)
        {
            switch (browser)
            {
                case "IE":
                    Driver = new InternetExplorerDriver();
                    break;

                case "Firefox":
                    Driver = new FirefoxDriver();
                    break;

                default:
                    Driver = new ChromeDriver();
                    break;
            }

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSeconds);
        }

        public void Dispose()
        {
            Driver?.Close();
            Driver?.Quit();
            Driver = null;
        }
    }
}