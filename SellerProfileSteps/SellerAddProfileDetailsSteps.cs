using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ProjectMARS.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ProjectMARS.SellerProfileSteps
{
    [Binding]
    public class SellerAddProfileDetailsSteps
    {
        public IWebDriver driver;


        [Given(@"The URL")]
        public void GivenTheURL()
        {
            LoginPage loginPageObj = new LoginPage();
            driver = new ChromeDriver();
            loginPageObj.loginURL(driver);
        }

        [Given(@"I have entered the email address and password")]
        public void GivenIHaveEnteredTheEmailAddressAndPassword()
        {
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.loginSteps(driver);
        }
        [When(@"I login")]
        public void WhenILogin()
        {
            LoginPage loginPageObj = new LoginPage();

            loginPageObj.logIn(driver);
        }

        [Then(@"I should be able to see my profile name on Home Page")]
        public void ThenIShouldBeAbleToSeeMyProfileNameOnHomePage()
        {
            Thread.Sleep(3000);
            IWebElement profName = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            Assert.That(profName.Text == "Hi Harsha", "Sign In Failed");

        }



        [Given(@"Successfully logged into the Home Page")]
        public void GivenSuccessfullyLoggedIntoTheHomePage()
        {

            driver = new ChromeDriver();
            LoginPage loginPage = new LoginPage();
            loginPage.loginURL(driver);
            loginPage.loginSteps(driver);
            loginPage.logIn(driver);


        }

      
        [Given(@"I Clicked on the edit button and add Description")]
        public void GivenIClickedOnTheEditButtonAndAdd()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.addDescription(driver, "My hobbies are reading and crafting");
        }

        [Then(@"I should be able to create/add Description")]
        public void ThenIShouldBeAbleToCreateAdd()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.saveDescription(driver);

        }





        [Given(@"I clicked on add new on Language option")]
        public void GivenIClickedOnAddNewOnLanguageOption()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.selectLanguage(driver);

        }
        [When(@"The langauge and language level are chosen")]
        public void WhenTheLangaugeAndLanguageLevelAreChosen()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.addLanguage(driver, "Tamil");

        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.saveLanguage(driver);

        }

        [Given(@"I clicked on add new on Skills option")]
        public void GivenIClickedOnAddNewOnSkillsOption()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.selectSkill(driver);
                
        }

        [When(@"The skill and skill level are chosen")]
        public void WhenTheSkillAndSkillLevelAreChosen()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.addSkill(driver, "crafting");
        }

        [Then(@"the result must be ""(.*)""")]
        public void ThenTheResultMustBe(string p0)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.saveSkill(driver);
        }

        [Given(@"I clicked on add new on Education option")]
        public void GivenIClickedOnAddNewOnEducationOption()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.selectEducation(driver);

        }

        [When(@"The required fields/text boxes are filled")]
        public void WhenTheRequiredFieldsTextBoxesAreFilled()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.addEducation(driver,"College of Engineering","India","B.Tech","EEE","2011");
        }

        [Then(@"the result must show ""(.*)""")]
        public void ThenTheResultMustShow(string p0)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.saveEducation(driver);
        }

        [Given(@"I clicked on the add new on Certificaytions option")]
        public void GivenIClickedOnTheAddNewOnCertificaytionsOption()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.selectCertification(driver);
                
        }

        [When(@"The required fields/textboxes are filled")]
        public void WhenTheRequiredFieldsTextboxesAreFilled()
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.addCertification(driver, "internship", "abc", "2011");

        }

        [Then(@"The result will be ""(.*)""")]
        public void ThenTheResultWillBe(string p0)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.saveCertification(driver);
        }


    }
}
