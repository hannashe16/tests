using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://devby.io/";
            driver.Manage().Window.Maximize();
            HomePage homePage = new HomePage(driver);
            homePage.GoToLogin();
            LoginPage usernameField = new LoginPage(driver);
            usernameField.Login(inputUsername, inputPassword);          
            Assert.IsNotNull(XPaths.NAV_BAR_USER_AVATAR);
            driver.Close();
        }
    }
}