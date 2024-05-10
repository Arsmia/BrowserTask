using OpenQA.Selenium;

namespace BrowserTask;

public class ManagementGovernancePage(IWebDriver driver)
{
    private IWebElement WebElement => driver.FindElement(By.CssSelector(".like-h1-xl-light"));
    private IWebElement SearchElement => driver.FindElement(By.ClassName("search"));

    private IWebElement InputElement =>
        driver.FindElement(By.ClassName("search-field")).FindElement(By.TagName("input"));

    public ManagementGovernancePage ChooseManagementGovernanceTitle()
    {
        WebElement.Click();

        return this;
    }

    public string CheckTitleOnPage() => WebElement.Text;

    public ManagementGovernancePage ClickOnSearch()
    {
        SearchElement.Click();

        return this;
    }

    public SearchResultPage EnterTextInSearchLine(string input)
    {
        InputElement.SendKeys(input);
        InputElement.SendKeys(Keys.Enter);

        return new(driver);
    }
}