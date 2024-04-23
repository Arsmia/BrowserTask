using OpenQA.Selenium;

namespace BrowserTask;
public class FoundPage(IWebDriver _driver)
{ 
    private IWebElement ActualHeader => _driver.FindElement(By.ClassName("banner-content"));
    public string GetPageResult()
    {
        return ActualHeader.Text;
    }
}