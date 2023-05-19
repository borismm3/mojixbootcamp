using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoist
{
    public class DeleteSection
    {
        public Button confirmDeleteButton = new Button(By.XPath("//button[@data-autofocus='true']"));
    }
}
