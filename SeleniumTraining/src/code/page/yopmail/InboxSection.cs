using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page.yopmail
{
    public class InboxSection
    {
        public Label recivedMailLabel(string subjectMail)
        {
            Label recivedMail = new Label(By.XPath("//div[text()='" + subjectMail + "']"));
            recivedMail.WaitControlIsNotInThePage();
            return recivedMail;
        }
    }
}
