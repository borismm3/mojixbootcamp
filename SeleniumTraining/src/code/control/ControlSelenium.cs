using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumTraining.src.code.session;

namespace SeleniumTraining.src.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;

        public ControlSelenium(By locator) => this.locator = locator;

        protected void FindControl() => 
            control = Session.Instance.GetBrowser().FindElement(locator);

        public void Click()
        {
            FindControl();
            control.Click();
        }

        public void Enter()
        {
            control.SendKeys(Keys.Enter);
        }

        public void HoverElement()
        {
            FindControl();
            Actions action = new Actions(Session.Instance.GetBrowser());
            action.MoveToElement(control).Perform();
        }

        public bool IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void WaitControlIsNotInThePage()
        {
            Thread.Sleep(500);
            WebDriverWait wait = new(Session.Instance.GetBrowser(), TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            }
            catch (Exception)
            {

            }
        }
    }
}
