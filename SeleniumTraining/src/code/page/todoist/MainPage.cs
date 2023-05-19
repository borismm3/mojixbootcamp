using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoist
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//li/a[@href='/auth/login']"));
    }
}
