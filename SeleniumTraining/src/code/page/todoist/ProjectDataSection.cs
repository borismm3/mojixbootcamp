using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.page.todoist
{
    public class ProjectDataSection
    {
        public TextBox nameProjectTextBox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button colorButton = new Button(By.XPath("//div[@class=\"form_field\"]/button"));
        public Button saveButton = new Button(By.XPath("//button[@type='submit']"));

        public Button selectColorButton(string color)
        {
            colorButton.Click();
            Button selectColor = new Button(By.XPath("//li[@data-value='" + color + "']"));
            selectColor.WaitControlIsNotInThePage();
            return selectColor;
        }
    }
}
