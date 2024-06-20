using OpenQA.Selenium;

namespace BrowserTask;

internal class SearchResultPage(IWebDriver driver)
{
    internal IWebElement LinkOfThirdElementOfSearchResults => driver.FindElement(By.CssSelector("li[data-number='3']>h3>a"));

    internal void ClickNotFirstElementOfTheList() => LinkOfThirdElementOfSearchResults.Click();
}