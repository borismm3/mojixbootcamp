namespace SeleniumTraining.src.code.test.yopmail
{
    [TestClass]
    public class SendMailTest : TestBase
    {
        [TestMethod]
        public void VerifySendMail()
        {
            string subjectCreated = "Subject" + DateTime.Now.Ticks.ToString();
            string bodyCreated = "Body" + DateTime.Now.Ticks.ToString();

            // Login with a username
            mainPage.usernameTextBox.SetText(user);
            mainPage.loginButton.Click();
            // Add verification
            Assert.IsTrue(accountSection.addressLabel(user).IsControlDisplayed(), "ERROR! You have not login into the page.");

            // Send e-mail
            inboxHeaderSection.newMail.Click();
            // Switch to Iframe e-mail
            session.Session.Instance.SwitchIFrameMail();
            mailSection.mailToTextBox.SetText(user);
            mailSection.subjectMailTextBox.SetText(subjectCreated);
            mailSection.bodyMailTextBox.SetText(bodyCreated);
            mailSection.sendMailButton.Click();
            // Add verification
            Assert.IsTrue(mailSection.mailDispatchedLabel().IsControlDisplayed(), "ERROR! The email was not sent.");

            // Check if the email arrived
            // Switch to default content
            session.Session.Instance.SwitchToParent();
            inboxHeaderSection.refreshInbox.Click();
            // Switch to Iframe inbox
            session.Session.Instance.SwitchIFrameInbox();
            // Add verification
            Assert.IsTrue(inboxSection.recivedMailLabel(subjectCreated).IsControlDisplayed(), "Error! The email was not received.");
        }
    }
}
