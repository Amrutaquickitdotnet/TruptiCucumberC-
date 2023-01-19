using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowCreateSet.CreateSet;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowCreateSet.StepDefinitions
{
    [Binding]
    public class LoginIntoOrangHrmStepDefinitions
    {
        IWebDriver driver;
        [Given(@"Home Page URL")]
        public void GivenHomePageURL()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            Thread.Sleep(3000);

		}

        [When(@"User enters valid Credentials")]
        public void WhenUserEntersValidCredentials(Table table)
        {
         var credentials =   table.CreateSet<Credentials>();

             foreach(var userData in credentials)
            {

                driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(userData.Username);

				driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(userData.Password);
				

			}

		}

        [When(@"clicks on Login Button")]
        public void WhenClicksOnLoginButton()
		{
			driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(5000);
		}

        [Then(@"successful login message must displayed\.")]
        public void ThenSuccessfulLoginMessageMustDisplayed_()
        {
            Console.WriteLine("Success");
        }
    }
}
