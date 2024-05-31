using OpenQA.Selenium;

namespace BrowserTask;

public class FoundPage(IWebDriver driver)
{
    public IWebElement Header => driver.FindElement(By.CssSelector("h1 [class='like-h1-light']"));
}