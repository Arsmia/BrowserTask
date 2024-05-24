using OpenQA.Selenium;

namespace BrowserTask;

public class FoundPage(IWebDriver driver)
{
    public IWebElement Header => driver.FindElement(By.ClassName("banner-content"));
    
}