using OpenQA.Selenium;

namespace DevByTests
{
    public class HomePage : BasePage
    {     
        public HomePage(IWebDriver driver): base(driver)
        { }
        public void GoToLogin()
        {
            IWebElement element = null;
            element = FindElementByXPath(XPaths.LOGIN_BUTTON_HOME_SCREEN_XPATH);
            element?.Click();
        }
    }
}
