using OnlinerTests;
using OpenQA.Selenium;

namespace DevByTests
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        protected ILogger _logger;
        public BasePage(IWebDriver driver, ILogger logger)
        {
            _driver = driver;
            _logger = logger;
        }

        public IWebElement FindElementByXPath(string xPath)
        {
            IWebElement element = null;
            int attemptsNumber = 0;
            while (attemptsNumber < 5)
            {
                try
                {
                    element = _driver.FindElement(By.XPath(xPath));
                }
                catch (Exception exp)
                {
                    Thread.Sleep(1000);
                    _logger.Log("Cant's find element");
                }
                if (element != null)
                    break;
                attemptsNumber++;
            }
            return element;
        }
    }
}
