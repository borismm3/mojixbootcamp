using SeleniumTraining.src.code.page.todoly;

namespace SeleniumTraining.src.code.test.todoly
{
    [TestClass]
    public class ProjectTest : TestBase
    {
        [TestMethod]
        public void VerifyCRUDProject()
        {
            string projectName = "Mojix" + DateTime.Now.Ticks.ToString();
            string projectNameUpdated = "Updated" + DateTime.Now.Ticks.ToString();
            string taskName = "Task" + DateTime.Now.Ticks.ToString();
            string taskNameUpdated = "Updated" + DateTime.Now.Ticks.ToString();

            // Login
            mainPage.loginButton.Click();
            loginSection.Login(user, pwd);

            // New project
            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText(projectName);
            leftSite.addButton.Click();
            // add verification
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(projectName), "ERROR! The project was not created");

            // Update project
            leftSite.ClickProjectName(projectName);
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText(projectNameUpdated);
            leftSite.saveButton.Click();
            // add verification
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(projectNameUpdated), "ERROR! The project was not updated");

            // Create task
            taskSection.taskNameTextBox.Click();
            taskSection.taskNameTextBox.SetText(taskName);
            taskSection.createTask();
            // add verification
            Assert.IsTrue(taskSection.TaskNameIsDisplayed(taskName), "ERROR! The was not created");

            // Update task name, color, date
            // task
            taskSection.hoverTaskName(taskName);
            taskSection.menuTaskButton.Click();
            menuTaskSection.editButton.Click();
            taskSection.taskNameEditTextBox.SetText(taskNameUpdated);
            taskSection.createTask();
            // add verification
            Assert.IsTrue(taskSection.TaskNameIsDisplayed(taskNameUpdated), "ERROR! The was not created");
            // color
            taskSection.hoverTaskName(taskNameUpdated);
            taskSection.menuTaskButton.Click();
            menuTaskSection.colorRedButton.Click();
            // date
            taskSection.hoverTaskName(taskNameUpdated);
            taskSection.setDateButton.Click();
            dateTaskSection.dateTextBox.SetText("29 May, 23:59 AM");
            dateTaskSection.saveButton.Click();

            // Delete task
            taskSection.hoverTaskName(taskNameUpdated);
            taskSection.menuTaskButton.Click();
            menuTaskSection.deleteButton.Click();
            // add verification
            Assert.IsTrue(taskSection.TaskDeletedMessage(), "ERROR! The task was not deleted");

            // Delete project
            leftSite.ClickProjectName(projectNameUpdated);
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();
            session.Session.Instance.GetBrowser().SwitchTo().Alert().Accept();
            // add verification
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed(projectNameUpdated), "ERROR! The project was not deleted");
        }
    }
}
