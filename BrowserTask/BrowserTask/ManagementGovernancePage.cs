using System.Net.Mime;
using OpenQA.Selenium;

namespace BrowserTask;

public class ManagementGovernancePage

{
    protected IWebDriver driver;

    private By _webElement = By.CssSelector(".like-h1-xl-light");
    private WebElement _title;

    private By _searchElement = By.ClassName("search");
    private By _inputElement = By.ClassName("search-field");
    private By _inputElementTag = By.TagName("input");
    



    public ManagementGovernancePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public ManagementGovernancePage ChooseManagementGovernanceTitle()
    {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
        _title = (WebElement)driver.FindElement(_webElement);
        _title.Click();
        return this;
    }

    public ManagementGovernancePage CheckTitleOnPage()
    {
        Assert.Equal("Executive Board and Board of Directors", _title.Text);
        return this;
    }

    public ManagementGovernancePage ClickOnSearch()
    {
        driver.FindElement(_searchElement).Click();
        return this;
    }

    public ManagementGovernancePage EnterTextInSearchLine(string input)
    {
        var findElement = driver.FindElement(_inputElement).FindElement(_inputElementTag);
        findElement.SendKeys(input);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
        findElement.SendKeys(Keys.Enter);
        return this;
    }

}

