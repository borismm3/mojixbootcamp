using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void OpenBrowser()
        {
            Console.WriteLine("Setup");
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + "/src/resources/driver/chromedriver.exe");
            driver.Navigate().GoToUrl("https://todo.ly/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            Console.WriteLine("CleanUp");
            driver.Quit();
        }

        [TestMethod]
        public void verifyTheLoginIsSuccessfuly()
        {
            // click login button
            driver.FindElement(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]")).Click();
            // fill email txtbox
            driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail")).SendKeys("boris@gmail.com");
            // fill password txtbox
            driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword")).SendKeys("123456");
            // click login button
            driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin")).Click();
            // verify -> the logout button must be displayed
            Assert.IsTrue(driver.FindElement(By.Id("ctl00_HeaderTopControl1_LinkButtonLogout")).Displayed,
                "Error! The login was not successfully, review credentials please");
        }
    }
}