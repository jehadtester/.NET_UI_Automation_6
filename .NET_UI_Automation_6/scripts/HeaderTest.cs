using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace _NET_UI_Automation_6.scripts
{
	[TestFixture]
	public class HeaderTest
	{
		[Test]
        public void validateLogo()
        {
            // Set up driver
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            // Navigate to url
            driver.Navigate().GoToUrl("https://techglobal-training.com/");

            // Locate web elements using 8 different locators
            IWebElement logo = driver.FindElement(By.Id("logo"));

            // Assertions
            Assert.That(logo.Displayed);
            Thread.Sleep(3000);

            // Quit driver
            driver.Quit();
        }

        
         
        [Test]
        public void ValidateThePracticesDropdown()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            driver.Navigate().GoToUrl("https://techglobal-training.com/");

            IWebElement practicesElement = driver.FindElement(By.Id("dropdown-button"));

            Assert.That(practicesElement.Displayed);



        }




    }
}

