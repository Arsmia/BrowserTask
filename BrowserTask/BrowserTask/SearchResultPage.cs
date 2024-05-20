using OpenQA.Selenium;

namespace BrowserTask;

public class SearchResultPage(IWebDriver driver)
{
    private IWebElement SearchResult => driver.FindElement(By.CssSelector("li[data-number='1'] a[class='search-url']"));

    public FoundPage UrlClick()
    {
        SearchResult.Click();

        return new(driver);
    }
}