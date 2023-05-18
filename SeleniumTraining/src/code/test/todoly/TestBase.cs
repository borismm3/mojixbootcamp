namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class TestBase
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance.GetBrowser().Navigate().GoToUrl("https://todo.ly/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance.CloseBrowser();
        }
    }
}
