﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining.src.code.factoryBrowser
{
    public class Chrome : IBrowser
    {
        public IWebDriver Create()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            IWebDriver driver = new ChromeDriver(path + "/resources/driver/chromedriver.exe");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
