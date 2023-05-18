using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.yopmail
{
    public  class MailSection
    {
        public TextBox mailToTextBox = new TextBox(By.Id("msgto"));
        public TextBox subjectMailTextBox = new TextBox(By.Id("msgsubject"));
        public TextBox bodyMailTextBox = new TextBox(By.Id("msgbody"));
        public Button sendMailButton = new Button(By.Id("msgsend"));

        public Label mailDispatchedLabel()
        {
            Label mailDispatched = new Label(By.Id("msgpopmsg"));
            mailDispatched.WaitControlIsNotInThePage();
            return mailDispatched;
        }
    }
}
