using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UnitTestProject1.Pages;

namespace UnitTestProject1.StepBindings
{
    [Binding]
    class LoginSteps 
    {
        
        LoginPage loginpage = null;
        public static IWebDriver driver;

      

    [Given(@"User Launch the DemoQA application")]
        public void GivenUserLaunchTheDemoQAApplication()
        {
           /*
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/books");
            loginpage = new LoginPage(driver);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           */
        }

        [When(@"User click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            
            loginpage.login();
        }

        [When(@"User enter '(.*)' and '(.*)'")]
        public void WhenUserEnterAnd(string p0, string p1)
        {

            loginpage.enter_username(p0);
            loginpage.enter_password(p1);
            loginpage.clickLogin();

        }


        [BeforeScenario]
        public void initiateBrowser()
        {

             driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/books");
            loginpage = new LoginPage(driver);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    
        [AfterScenario]

        public void tearDown()
        {
            driver.Quit();
        }

    }
}
