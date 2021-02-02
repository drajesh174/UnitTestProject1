using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Pages
{
    class WebDriverContext
    {
        public  IWebDriver driver;
        public WebDriverContext()
        {
            driver = new ChromeDriver();
        }
    }
}
