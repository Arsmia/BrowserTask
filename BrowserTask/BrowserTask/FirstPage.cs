using OpenQA.Selenium;

namespace BrowserTask;

public class FirstPage
{
    protected IWebDriver driver;

    public FirstPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    
    public string Url = "https://www.demant.com/";
    private By _acceptBox = By.CssSelector("[aria-label=\"I accept\"]");
    private By _aboutButton = By.CssSelector(".level1.item3.even.last");
    private By _manageAndGovern = By.CssSelector(".sub-menu a[title='Management and governance']");
    

    public FirstPage OpenFirstPage()
    {
        driver.Navigate().GoToUrl(Url);
        return this;
    }

    public FirstPage ClosePopUp()
    {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
        driver.FindElement(_acceptBox).Click();
        return this;
    }

    public FirstPage OpenAboutMenu()
    {
        driver.FindElement(_aboutButton).Click();
        return this;
    }

    public FirstPage OpenManagementAndGovernancePage()
    {
        driver.FindElement(_manageAndGovern).Click();
        return this;
    }


}