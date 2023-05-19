using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoist
{
    public class HeaderSection
    {
        //Button accountButton = new Button(By.XPath("//img[@alt='boris2023']"));
        public Button accountButton(string user)
        {
            Button account = new Button(By.XPath("//img[@alt='" + user + "']"));
            account.WaitControlIsNotInThePage();
            return account;
        }
    }
}
