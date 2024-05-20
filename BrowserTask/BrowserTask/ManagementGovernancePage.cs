using OpenQA.Selenium;

namespace BrowserTask;

public class ManagementGovernancePage(IWebDriver driver)
{
    private IWebElement ExpectedTitle => driver.FindElement(By.CssSelector(".like-h1-xl-light"));

    private IWebElement SearchElement => driver.FindElement(By.ClassName("search"));

    private IWebElement SearchInput =>
        driver.FindElement(By.ClassName("search-field")).FindElement(By.TagName("input"));

    public ManagementGovernancePage ChooseManagementGovernanceTitle()
    {
        ExpectedTitle.Click();

        return this;
    }

    public IWebElement GetExpectedTitle() => ExpectedTitle;

    public ManagementGovernancePage ClickOnSearch()
    {
        SearchElement.Click();

        return this;
    }

    public SearchResultPage TriggerSearchOnWebSiteLine(string input)
    {
        SearchInput.SendKeys(input);
        SearchInput.SendKeys(Keys.Enter);

        return new(driver);
    }
}