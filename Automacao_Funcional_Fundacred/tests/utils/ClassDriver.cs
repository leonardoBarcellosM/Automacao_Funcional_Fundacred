using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Automacao_Funcional_Fundacred.tests.steps
{
    class ClassDriver
    {
        private static ClassDriver classDriver;
        private IWebDriver driver;

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }

        private ClassDriver()
        {

        }

        public static ClassDriver GetInstance()
        {
            if (classDriver == null)
            {
                classDriver = new ClassDriver();
            }
            return classDriver;
        }

        public void StartDriver()
        {
            var currentPath = Directory.GetCurrentDirectory();
            string path = "webdriver";

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                //WINDOWS
                path = $"{currentPath}\\..\\..\\..\\WebDriverWindows";
            }
            else
            {
                //LINUX
                path = "/usr/bin/";
            }

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--no-sandbox"); // Bypass OS security model
            options.AddArguments("--disable-gpu"); // applicable to windows os only
            options.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
            options.AddArguments("--headless");
            driver = new ChromeDriver(path, options);

            Driver.Manage().Window.Maximize();
        }

        public void QuitDriver()
        {
            Driver.Quit();
        }
    }
}
