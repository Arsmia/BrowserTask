using OpenQA.Selenium;

namespace BrowserTask;

public class ManagementGovernancePage(IWebDriver driver)
{
    public IWebElement Title => driver.FindElement(By.CssSelector(".like-h1-xl-light"));

    private IWebElement SearchIcon => driver.FindElement(By.ClassName("search"));

    private IWebElement SearchInput => driver.FindElement(By.ClassName("search-field")).FindElement(By.TagName("input"));

    public ManagementGovernancePage ClickManagementGovernanceTitle()
    {
        Title.Click();

        return this;
    }

    public ManagementGovernancePage ClickOnSearchIcon()
    {
        SearchIcon.Click();

        return this;
    }

    public ManagementGovernancePage EnterSearchPhrase(string input)
    {
        SearchInput.SendKeys(input);

        return this;
    }

    public SearchResultPage TriggerSearch()
    {
        SearchInput.SendKeys(Keys.Enter);

        return new(driver);
    }
}