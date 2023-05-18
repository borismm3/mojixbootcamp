using OpenQA.Selenium;
using SeleniumTraining.src.code.factoryBrowser;
using SeleniumTraining.src.code.util;

namespace SeleniumTraining.src.code.session
{
    public class Session
    {
        private static readonly Lazy<Session> lazyInstance = new Lazy<Session>(() => new Session());
        private IWebDriver browser;

        private Session()
        {
            browser = FactoryBrowser.Make(GetPropertiesYopMail.Instance.Browser).Create();
        }

        public static Session Instance => lazyInstance.Value;

        public void CloseBrowser()
        {
            browser.Quit();
        }

        public IWebDriver GetBrowser()
        {
            return browser;
        }

        public void SwitchIFrameMail()
        {
            browser.SwitchTo().Frame("ifmail");
        }

        public void SwitchIFrameInbox()
        {
            browser.SwitchTo().Frame("ifinbox");
        }

        public void SwitchToParent()
        {
            browser.SwitchTo().DefaultContent();
        }
    }
}
