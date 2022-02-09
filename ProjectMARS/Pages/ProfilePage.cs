using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        public void selectLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement langBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            langBtn.Click();
            IWebElement addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addBtn.Click();

        }

        public void addLanguage(IWebDriver driver, string language)
        {
            Thread.Sleep(2000);
            var langTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            langTextBox.SendKeys(language);

            var langDrpdwn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langDrpdwn.Click();
            Thread.Sleep(1000);

            var choseLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            choseLevel.Click();


        }

        public void saveLanguage(IWebDriver driver)
        {
            Thread.Sleep(1000);
            var addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addBtn.Click();

        }
        public void selectSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement skillBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillBtn.Click();
            IWebElement addnewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewBtn.Click();
        }
        public void addSkill(IWebDriver driver, string skill)
        {
            Thread.Sleep(2000);
            var skillTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillTextBox.SendKeys(skill);

            var skillDrpdwn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillDrpdwn.Click();
            Thread.Sleep(1000);

            var skillLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            skillLevel.Click();

        }

        public void saveSkill(IWebDriver driver)
        {
            Thread.Sleep(1000);
            var addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addBtn.Click();

        }

        public void selectEducation(IWebDriver driver)
        {
            Thread.Sleep(2000);
            var eduBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            eduBtn.Click();
            var addnewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addnewBtn.Click();
        }
        public void addEducation(IWebDriver driver, string college, string country, string title, string degree, string year)
        {
            Thread.Sleep(2000);
            var collegeBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            collegeBox.SendKeys(college);

            var countrydrpdwn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countrydrpdwn.Click();
            Thread.Sleep(2000);

            SelectElement selectCountry = new SelectElement(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")));
            selectCountry.SelectByText(country);

            var titledrpdwn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titledrpdwn.Click();

            SelectElement selectTitle = new SelectElement(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")));
            selectTitle.SelectByText(title);

            var degreeBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeBox.SendKeys(degree);

            var yearSelect = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearSelect.Click();

            SelectElement yeardrpdwn = new SelectElement(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")));
            yeardrpdwn.SelectByText(year);

        }

        public void saveEducation(IWebDriver driver)
        {
            Thread.Sleep(1000);
            var addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addBtn.Click();
        }


        public void selectCertification(IWebDriver driver)
        {
            Thread.Sleep(2000);
            var certifcateBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certifcateBtn.Click();
            var addnewBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addnewBtn.Click();
        }
        public void addCertification(IWebDriver driver, string certificate, string certifiedfrom, string year)
        {
            Thread.Sleep(2000);
            var certificateBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateBox.SendKeys(certificate);

            var certificateFrom = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificateFrom.SendKeys(certifiedfrom);

            SelectElement yeardrpdwn = new SelectElement(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
            yeardrpdwn.SelectByText(year);

        }

        public void saveCertification(IWebDriver driver)
        {
            Thread.Sleep(2000);
            var addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addBtn.Click();
        }
    }
}
