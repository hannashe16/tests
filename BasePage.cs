using OpenQA.Selenium;

namespace DevByTests
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
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
                    Console.WriteLine("Cannot find element, I'll try again");
                }
                if (element != null)
                    break;
                attemptsNumber++;
            }
            return element;
        }
    }
}
