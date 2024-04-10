using OpenQA.Selenium;

namespace BrowserTask;
public class ManagementGovernancePage
{
    IWebDriver driver;
    private By _webElement = By.CssSelector(".like-h1-xl-light");
    private By _searchElement = By.ClassName("search");
    private By _inputElement = By.ClassName("search-field");
    private By _inputElementTag = By.TagName("input");
    private WebElement _title;
    private string _titleNeeded;
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
    public string CheckTitleOnPage()
    {
        _titleNeeded = driver.FindElement(_webElement).Text;
        
        return _titleNeeded;
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

