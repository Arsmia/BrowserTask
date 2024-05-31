using OpenQA.Selenium;

namespace BrowserTask;

public class SearchResultPage(IWebDriver driver)
{
    public IWebElement NotFirstElementOfTheList => driver.FindElement(By.CssSelector("li[data-number='3']>h3>a"));
    
    public FoundPage ClickNotFirstElementOfTheList()
    {
        NotFirstElementOfTheList.Click();

        return new(driver);
    }
    
}