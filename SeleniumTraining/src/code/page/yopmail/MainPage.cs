using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.yopmail
{
    public class MainPage
    {
        public TextBox usernameTextBox = new TextBox(By.Id("login"));
        public Button loginButton = new Button(By.XPath("//button[contains(@style,'border-radius')]"));

        public void login(String username)
        {
            usernameTextBox.SetText(username);
            loginButton.Click();
        }
    }
}
