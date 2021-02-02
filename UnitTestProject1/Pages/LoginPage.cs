using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver driver)
        {
            WebDriver = driver;
        }

        public IWebElement loginButton => WebDriver.FindElement(By.XPath("//*[@id='login']"));

        public IWebElement newUserButton => WebDriver.FindElement(By.XPath("//*[@id='newUser']"));

        public IWebElement username_textbox => WebDriver.FindElement(By.XPath("//*[@id='userName']"));
        public IWebElement password_textbox => WebDriver.FindElement(By.XPath("//*[@id='password']"));

        public IWebElement login_button => WebDriver.FindElement(By.XPath("//*[@id='login']"));
        public void login()
        {
            loginButton.Click();
            Task.Delay(5000).Wait();
          
        }

        public void enter_username(String user_name)
        {

            username_textbox.SendKeys(user_name);
        }

        public void enter_password(String password)
        {

            password_textbox.SendKeys(password);
        }

        public void clickLogin()
        {
            login_button.Click();
        }
    }
}
