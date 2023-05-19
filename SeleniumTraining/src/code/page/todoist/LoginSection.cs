using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoist
{
    public class LoginSection
    {
        public TextBox emailTextBox = new TextBox(By.Id("element-0"));
        public TextBox pwdTextBox = new TextBox(By.Id("element-3"));
        public Button loginButton = new Button(By.XPath("//button[@type='submit']"));

        public void login(string email, string pwd)
        {
            emailTextBox.SetText(email);
            pwdTextBox.SetText(pwd);
            loginButton.Click();
        }
    }
}
