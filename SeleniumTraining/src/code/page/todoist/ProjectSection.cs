using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoist
{
    public class ProjectSection
    {
        public Button addProjectButton = new Button(By.XPath("//button[@aria-label='Add project']"));
        public Button menuButton = new Button(By.XPath("//button[contains(@aria-label, 'actions')]"));

        public Label projectNameLabel(string nameValue)
        {
            Label projectName = new Label(By.XPath("//h1/span[contains(text(), '" + nameValue + "')]"));
            projectName.WaitControlIsNotInThePage();
            return projectName;
        }

        public Label projectDeletedLabel(string nameValue)
        { 
            return new Label(By.XPath("//h1/span[contains(text(), '" + nameValue + "')]"));
        }
    }
}
