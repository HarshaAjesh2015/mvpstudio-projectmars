using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectMARS.Pages
{
    public class LoginPage
    {
        public void loginURL(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
        }
        public void loginSteps(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement signInBtn = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[1]/div/a"));
            signInBtn.Click();

            try
            {
                IWebElement mailidTB = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                mailidTB.SendKeys("harshagopinathan@gmail.com");

                IWebElement pswdTB = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[1] / div / div[2] / input"));
                pswdTB.SendKeys("123123");
            }

            catch (Exception ex)
            {
                Assert.Fail("Invalid Email ID or Password", ex.Message);
            }
        }

        public void logIn(IWebDriver driver)
        {

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }



    }
}




