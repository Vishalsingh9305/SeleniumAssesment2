using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumAssignment1
{
    public class UnitTest1
    {
        IWebDriver driver;
        public UnitTest1()
        {
            
            driver = new ChromeDriver(@"C:\Users\HP\Downloads\chromedriver-win64");
            
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }
        [Fact]
        public void Test1()
        {
            IWebElement lnkLogin = driver.FindElement(By.LinkText("Login"));
            Thread.Sleep(1000);
            lnkLogin.Click();
            
            var txtUserName = driver.FindElement(By.Name("UserName"));
            Assert.True(txtUserName.Displayed);

            txtUserName.SendKeys("admin");
            Thread.Sleep(2000);

            driver.FindElement(By.Name("Password")).SendKeys("password");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
            var lnkEmployeeDetails = driver.FindElement(By.LinkText("Employee Details"));
            Assert.True(lnkEmployeeDetails.Displayed);
            Thread.Sleep(1000);
            lnkEmployeeDetails.Click();

        }
    }
}