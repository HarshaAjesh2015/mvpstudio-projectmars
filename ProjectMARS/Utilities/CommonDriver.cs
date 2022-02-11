using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMARS.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMARS.Utilities
{
    public class CommonDriver
    {

        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();
            LoginPage loginPage = new LoginPage();
            loginPage.loginSteps(driver);
            
        
        }

        [OneTimeTearDown]
        public void CloseTestRun()

        {
            driver.Quit();
        }



    }
}
