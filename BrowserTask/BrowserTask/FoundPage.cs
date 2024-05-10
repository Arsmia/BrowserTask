using OpenQA.Selenium;

namespace BrowserTask;

public class FoundPage(IWebDriver driver)
{
    private IWebElement ActualHeader => driver.FindElement(By.ClassName("banner-content"));

    public string GetPageResult() => ActualHeader.Text;
}