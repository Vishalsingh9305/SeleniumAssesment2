using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumAssignment1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAssignment1.Tests
{
    public class LoginTest
    {
        IWebDriver driver;
        public LoginTest()
        {
            driver = new ChromeDriver(@"C:\Users\HP\Downloads\chromedriver-win64");

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            Console.WriteLine("exe first");
        }

        [Fact]
        public void TestCase()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "password");
            Assert.True(homePage.IsEmployeeDetailsExists());
            Console.WriteLine("exec later");
        }
    }
}
