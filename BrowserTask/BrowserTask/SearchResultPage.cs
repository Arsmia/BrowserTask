using OpenQA.Selenium;

namespace BrowserTask;

public class SearchResultPage(IWebDriver driver)
{
    private IWebElement RelevantLinkResult => driver.FindElement(By.CssSelector("li[data-number='1'] a[class='search-url']"));

    public FoundPage ClickRelevantLinkResult()
    {
        RelevantLinkResult.Click();

        return new(driver);
    }
}