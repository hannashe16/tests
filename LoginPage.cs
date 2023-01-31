using OpenQA.Selenium;

namespace DevByTests
{
    public class LoginPage : BasePage
    {        
        public LoginPage(IWebDriver driver): base(driver)
        { }
        public void Login(string username, string password)
        {          
            IWebElement element = FindElementByXPath(XPaths.USERNAME_FIELD_XPATH);              
            element?.Click();
            element?.SendKeys(username);
            element?.Clear();
            element = FindElementByXPath(XPaths.PASSWORD_FIELD_XPATH);
            element?.Click();
            element?.SendKeys(password);
            element?.Clear();
            element = FindElementByXPath(XPaths.LOGIN_BUTTON_XPATH);
            element?.Click();         
        }
    }
}
