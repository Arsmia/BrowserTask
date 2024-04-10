using OpenQA.Selenium;

namespace BrowserTask;

public class SearchResultPage
{
    IWebDriver driver;
    internal IWebElement SearchResult => driver.FindElement(By.CssSelector("li[data-number='1'] a[class='search-url']"));

    public SearchResultPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    public SearchResultPage SearchUrlClick()
    {
        SearchResult.Click();
        
        return this;
    }
}