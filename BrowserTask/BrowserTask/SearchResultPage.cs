using OpenQA.Selenium;

namespace BrowserTask;

public class SearchResultPage(IWebDriver driver)
{
    public IWebElement ThirdElementOfSearchResults => driver.FindElement(By.CssSelector("li[data-number='3']>h3>a"));
    
    public void ClickNotFirstElementOfTheList()
    {
        ThirdElementOfSearchResults.Click();
    }
    
}