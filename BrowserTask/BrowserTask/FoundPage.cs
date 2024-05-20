using OpenQA.Selenium;

namespace BrowserTask;

public class FoundPage(IWebDriver driver)
{
    private IWebElement Header => driver.FindElement(By.ClassName("banner-content"));

    public IWebElement GetHeader() => Header;
}