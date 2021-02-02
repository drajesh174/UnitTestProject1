/*
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UnitTestProject1.Pages;
using UnitTestProject1.StepBindings;

namespace UnitTestProject1
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver driver;
        LoginPage loginpage = null;


        [BeforeScenario]
        public void BeforeScenario()
        {
            
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/books");
            loginpage = new LoginPage(driver);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            LoginSteps loginstep = new LoginSteps(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();

        }
    }
}
*/