using OpenQA.Selenium;

namespace BrowserTask;

internal class ManagementGovernancePage(IWebDriver driver)
{
    internal IWebElement Title => driver.FindElement(By.CssSelector(".like-h1-xl-light"));

    private IWebElement SearchIcon => driver.FindElement(By.ClassName("search"));

    private IWebElement SearchInput => driver.FindElement(By.ClassName("search-field")).FindElement(By.TagName("input"));

    internal ManagementGovernancePage ClickManagementGovernanceTitle()
    {
        Title.Click();

        return this;
    }

    internal ManagementGovernancePage ClickSearchIcon()
    {
        SearchIcon.Click();

        return this;
    }

    internal ManagementGovernancePage EnterSearchPhrase(string input)
    {
        SearchInput.SendKeys(input);

        return this;
    }

    internal SearchResultPage TriggerSearch()
    {
        SearchInput.SendKeys(Keys.Enter);

        return new(driver);
    }
}