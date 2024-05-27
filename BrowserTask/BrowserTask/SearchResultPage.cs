using OpenQA.Selenium;

namespace BrowserTask;

public class SearchResultPage(IWebDriver driver)
{
    private IWebElement FirstElementOfTheList => driver.FindElement(By.CssSelector("li[data-number='1'] a[class='search-url']"));

    public FoundPage ClickFirstElementOfTheList()
    {
        FirstElementOfTheList.Click();

        return new(driver);
    }
}