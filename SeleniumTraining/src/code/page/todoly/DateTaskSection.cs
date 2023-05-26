using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoly
{
    public class DateTaskSection
    {
        public Button saveButton = new Button(By.XPath("//div[contains(@style, 'left')]/div/div/input[@value='Save']"));
        public TextBox dateTextBox = new TextBox(By.XPath("//div[contains(@style, 'left')]/div/div/div/input"));
    }
}
