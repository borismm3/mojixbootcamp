using OpenQA.Selenium;
using SeleniumTraining.src.code.factoryBrowser;

namespace SeleniumTraining.src.code.session
{
    public class Session
    {
        private static Session instance = null;
        private IWebDriver browser;

        private Session()
        {
            browser = FactoryBrowser.Make("grid").Create();
        }

        public static Session Instance()
        {
            if (instance == null) { instance = new Session(); }
            return instance;
        }

        public void CloseBrowser()
        {
            browser.Quit();
            instance = null;
        }

        public IWebDriver GetBrowser()
        {
            return browser;
        }
    }
}
