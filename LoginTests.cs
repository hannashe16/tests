using OnlinerTests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace DevByTests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        [DataRow(TestData.VALID_USERNAME_EMAIL, TestData.VALID_PASSWORD)]
        [DataRow(TestData.VALID_USERNAME_NICKNAME, TestData.VALID_PASSWORD)]
        
        public void IsUserLoggedInWithValidUsernameAndPassword(string inputUsername, string inputPassword)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://devby.io/";
            driver.Manage().Window.Maximize();
            ILogger logger = new FileLogger();
            HomePage homePage = new HomePage(driver, logger);     
            LoginPage loginPage = homePage.GoToLogin();
            loginPage.Login(inputUsername, inputPassword);          
            Assert.IsNotNull(XPaths.NAV_BAR_USER_AVATAR);
            driver.Close();
        }
    }
}