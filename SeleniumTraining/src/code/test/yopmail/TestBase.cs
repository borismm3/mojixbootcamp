using SeleniumTraining.src.code.page.yopmail;
using SeleniumTraining.src.code.util;

namespace SeleniumTraining.src.code.test.yopmail
{
    [TestClass]
    public class TestBase
    {
        protected MainPage mainPage = new MainPage();
        protected AccountSection accountSection = new AccountSection();
        protected InboxHeaderSection inboxHeaderSection = new InboxHeaderSection();
        protected MailSection mailSection = new MailSection();
        protected InboxSection inboxSection = new InboxSection();
        protected string user = GetPropertiesYopMail.Instance.User;

        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance.GetBrowser().Navigate().GoToUrl(GetPropertiesYopMail.Instance.Host);
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance.CloseBrowser();
        }
    }
}
