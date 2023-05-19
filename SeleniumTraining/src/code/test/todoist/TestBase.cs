using SeleniumTraining.src.code.page.todoist;
using SeleniumTraining.src.code.util;

namespace SeleniumTraining.src.code.test.todoist
{
    [TestClass]
    public class TestBase
    {
        protected MainPage mainPage = new MainPage();
        protected LoginSection loginSection = new LoginSection();
        protected HeaderSection headerSection = new HeaderSection();
        protected ProjectSection projectSection = new ProjectSection();
        protected ProjectDataSection projectDataSection = new ProjectDataSection();
        protected MenuProjectSection menuProjectSection = new MenuProjectSection();
        protected DeleteSection deleteSection = new DeleteSection();
        protected string user = GetPropertiesTodoist.Instance.User;
        protected string pwd = GetPropertiesTodoist.Instance.Password;

        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance.GetBrowser().Navigate().GoToUrl(GetPropertiesTodoist.Instance.Host);
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance.CloseBrowser();
        }
    }
}
