using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoly
{
    public class TaskSection
    {
        public TextBox taskNameTextBox = new TextBox(By.Id("NewItemContentInput"));
        public Button menuTaskButton = new Button(By.XPath("//img[contains(@style,'inline')]"));
        public TextBox taskNameEditTextBox = new TextBox(By.XPath("//textarea[contains(@id,'ItemEditTextbox')]"));
        public Button setDateButton = new Button(By.XPath("//div[text()='Set Due Date']"));
        //public Label messageLabel = new Label(By.Id("InfoMessageText"));

        public bool TaskNameIsDisplayed(string nameValue)
        {
            Label taskName = new Label(By.XPath("//td/div[text()='" + nameValue + "']"));
            taskName.WaitControlIsNotInThePage();
            return taskName.IsControlDisplayed();
        }

        public bool TaskDeletedMessage()
        {
            Label messageLabel = new Label(By.Id("InfoMessageText"));
            messageLabel.WaitControlIsNotInThePage();
            return messageLabel.IsControlDisplayed();
        }

        public void hoverTaskName(string nameValue)
        {
            Label taskName = new Label(By.XPath("//div[text()='" + nameValue + "']"));
            taskName.HoverElement();
        }

        public void createTask()
        {
            taskNameTextBox.Enter();
        }

    }
}
