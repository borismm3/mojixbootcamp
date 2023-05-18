using SeleniumTraining.src.code.page.todoly;

namespace SeleniumTraining.src.code.test.todoly
{
    [TestClass]
    public class LoginTest : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        MenuSection menuSection = new MenuSection();

        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly2()
        {
            mainPage.loginButton.Click();
            loginSection.emailTxtBox.SetText("boris@gmail.com");
            loginSection.pwdTxtBox.SetText("123456");
            loginSection.loginButton.Click();

            Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
                "ERROR !! the login was not successfully, review credentials please");
        }
    }
}
