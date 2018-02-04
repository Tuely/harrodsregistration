using System;
using System.Configuration;
using OpenQA.Selenium;

namespace Harrods.Core
{
    public static class Context
    {
        public static IWebDriver Driver { get { return mgr.Driver; } }
        public static string BaseURL { get; private set; }
        public static string Browser { get; private set; }
        public static double ImplicitWaitInSeconds { get; private set; }
        public static double ElementVisibilityWaitInSeconds { get; private set; }

        private static DriverManager mgr;

        /// <summary>
        /// Configure url, browser etc values in app.config 
        /// </summary>
        static Context()
        {
            mgr = new DriverManager();
            BaseURL = ConfigurationManager.AppSettings["BaseURL"];
            Browser = ConfigurationManager.AppSettings["Browser"] ?? "Chrome";
            ImplicitWaitInSeconds = Convert.ToDouble(ConfigurationManager.AppSettings["ImplicitWaitInSeconds"] ?? "120");
            ElementVisibilityWaitInSeconds = Convert.ToDouble(ConfigurationManager.AppSettings["ElementVisibilityWaitInSeconds"] ?? "120");

            mgr.Initialize(Browser, ImplicitWaitInSeconds);
        }

        public static void DisposeDriver()
        {
            mgr.Dispose();
        }
    }
}
