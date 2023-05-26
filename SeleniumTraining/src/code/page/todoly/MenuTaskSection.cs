using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoly
{
    public class MenuTaskSection
    {
        public Button editButton = new Button(By.XPath("//ul[@id='itemContextMenu']/li/a[text()='Edit']"));
        public Button deleteButton = new Button(By.XPath("//li[@class='delete separator']/a"));
        public Button colorRedButton = new Button(By.XPath("//span[contains(@style, '#FF3300')]"));
    }
}
