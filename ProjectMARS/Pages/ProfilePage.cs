using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectMARS.Pages
{
    public class ProfilePage
    {
        public void addDescription(IWebDriver driver, string description)
        {
            Thread.Sleep(2000);
            IWebElement writeBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            writeBtn.Click();
            Thread.Sleep(2000);

            var textBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            textBox.Clear();
            textBox.SendKeys(description);

            
        }
        public void saveDescription(IWebDriver driver)
        {
            var saveBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveBtn.Click();

        }
    }
}
