using OpenQA.Selenium;

namespace BrowserTask;

public class SearchResultPage
{
    protected IWebDriver driver;
    private By _searchResult = By.CssSelector("li[data-number='1'] a[class='search-url']");

    public SearchResultPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    
    public SearchResultPage SearchUrlClick()
    {
        driver.FindElement(_searchResult).Click();
        return this;
    }
}




//
// driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2000);
// var expectedHeader = driver.FindElement(By.CssSelector("[data-number='1']")).Text;
// var splitHeader = expectedHeader.Split(new char[] { '\r' })[0];
//
// driver.FindElement(By.CssSelector("li[data-number='1'] a[class='search-url']")).Click();
//

