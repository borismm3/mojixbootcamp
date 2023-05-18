using SeleniumTraining.src.code.page.todoly;

namespace SeleniumTraining.src.code.test.todoly
{
    [TestClass]
    public class ProjectTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();

        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("boris@gmail.com", "123456");

            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("Mojix909090");
            leftSite.addButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Mojix909090"), "ERROR! The project was not created");

            leftSite.ClickProjectName("Mojix909090");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("MojixUpdateddddd");
            leftSite.saveButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR! The project was not updated");

            leftSite.ClickProjectName("MojixUpdateddddd");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();
            session.Session.Instance.GetBrowser().SwitchTo().Alert().Accept();

            // add verificacion
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR! The project was not deleted");
        }
    }
}
