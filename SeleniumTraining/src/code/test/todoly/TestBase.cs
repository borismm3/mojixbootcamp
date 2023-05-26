using SeleniumTraining.src.code.page.todoly;
using SeleniumTraining.src.code.util;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class TestBase
    {
        protected MainPage mainPage = new MainPage();
        protected LoginSection loginSection = new LoginSection();
        protected LeftSite leftSite = new LeftSite();
        protected TaskSection taskSection = new TaskSection();
        protected MenuTaskSection menuTaskSection = new MenuTaskSection();
        protected DateTaskSection dateTaskSection = new DateTaskSection();
        protected string user = GetPropertiesTodoly.Instance.User;
        protected string pwd = GetPropertiesTodoly.Instance.Password;

        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance.GetBrowser().Navigate().GoToUrl(GetPropertiesTodoly.Instance.Host);
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance.CloseBrowser();
        }
    }
}
