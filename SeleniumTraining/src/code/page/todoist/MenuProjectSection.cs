using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoist
{
    public class MenuProjectSection
    {
        public Button editProjectButton = new Button(By.XPath("//div[text()='Edit project']"));
        public Button deleteProjectButton = new Button(By.XPath("//div[text()='Delete project']"));
    }
}
