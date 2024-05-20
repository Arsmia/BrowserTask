using OpenQA.Selenium;

namespace BrowserTask;

public class MainPage(IWebDriver driver)
{
    private const string Url = "https://www.demant.com/";
    
    private IWebElement AcceptBox => driver.FindElement(By.CssSelector("[aria-label=\"I accept\"]"));
    
    private IWebElement AboutButton => driver.FindElement(By.CssSelector(".level1.item3.even.last"));
    
    private IWebElement ManageAndGovern => driver.FindElement(By.CssSelector(".sub-menu a[title='Management and governance']"));

    public MainPage OpenMainPage()
    {
        driver.Navigate().GoToUrl(Url);

        return this;
    }

    public MainPage ClosePopUp()
    {
        AcceptBox.Click();

        return this;
    }

    public MainPage OpenAboutMenu()
    {
        AboutButton.Click();

        return this;
    }

    public ManagementGovernancePage OpenManagementAndGovernancePage()
    {
        ManageAndGovern.Click();

        return new(driver);
    }
}