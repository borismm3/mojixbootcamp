using OpenQA.Selenium;

namespace SeleniumTraining.src.code.factoryBrowser
{
    public interface IBrowser
    {
        IWebDriver Create();
    }
}
