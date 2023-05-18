using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System.Net;

namespace SeleniumTraining.src.code.page.yopmail
{
    public class AccountSection
    {
        public Label addressLabel(string user)
        {
            Label label = new Label(By.XPath("//div[text()='" + user + "@yopmail.com']"));
            label.WaitControlIsNotInThePage();
            return label;
        }
    }
}
