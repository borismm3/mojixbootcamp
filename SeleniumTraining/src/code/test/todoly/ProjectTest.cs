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
            string projectName = "Mojix" + DateTime.Now.Ticks.ToString();
            string projectNameUpdated = "Updated" + DateTime.Now.Ticks.ToString();

            // Login
            mainPage.loginButton.Click();
            loginSection.Login("boris@gmail.com", "123456");

            // New project
            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText(projectName);
            leftSite.addButton.Click();
            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Mojix909090"), "ERROR! The project was not created");

            // Update project
            leftSite.ClickProjectName(projectName);
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText(projectNameUpdated);
            leftSite.saveButton.Click();
            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR! The project was not updated");

            // Create task

            // Update task name, color, date

            // Delete task

            // Delete project
            leftSite.ClickProjectName(projectNameUpdated);
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();
            session.Session.Instance.GetBrowser().SwitchTo().Alert().Accept();
            // add verificacion
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed(projectNameUpdated), "ERROR! The project was not deleted");
        }
    }
}
