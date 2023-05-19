namespace SeleniumTraining.src.code.test.todoist
{
    [TestClass]
    public class CRUDProjectTest : TestBase
    {
        [TestMethod]
        public void VerifyCRUDProject()
        {
            string projectName = "Mojix" + DateTime.Now.Ticks.ToString();
            string projectNameUpdated = "Updated" + DateTime.Now.Ticks.ToString();

            // Login
            mainPage.loginButton.Click();
            loginSection.login(user + "@gmail.com", pwd);
            // Add verification
            Assert.IsTrue(headerSection.accountButton(user).IsControlDisplayed(), "ERROR! You have not logged in.");

            // Create project
            projectSection.addProjectButton.Click();
            projectDataSection.nameProjectTextBox.SetText(projectName);
            projectDataSection.selectColorButton("green").Click();
            projectDataSection.saveButton.Click();
            // Add verification
            Assert.IsTrue(projectSection.projectNameLabel(projectName).IsControlDisplayed(), "ERROR! The project was not created.");

            // Update project
            projectSection.menuButton.Click();
            menuProjectSection.editProjectButton.Click();
            projectDataSection.nameProjectTextBox.SetText(projectNameUpdated);
            projectDataSection.selectColorButton("red").Click();
            projectDataSection.saveButton.Click();
            // Add verification
            Assert.IsTrue(projectSection.projectNameLabel(projectNameUpdated).IsControlDisplayed(), "ERROR! The project was not updated.");

            // Delete project
            projectSection.menuButton.Click();
            menuProjectSection.deleteProjectButton.Click();
            deleteSection.confirmDeleteButton.Click();
            // Add verification
            Assert.IsFalse(projectSection.projectDeletedLabel(projectNameUpdated).IsControlDisplayed(), "ERROR! The project was not deleted.");
        }
    }
}
