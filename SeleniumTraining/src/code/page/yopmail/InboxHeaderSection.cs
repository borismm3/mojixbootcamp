using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.yopmail
{
    public class InboxHeaderSection
    {
        public Button newMail = new Button(By.Id("newmail"));
        public Button refreshInbox = new Button(By.Id("refresh"));
    }
}
