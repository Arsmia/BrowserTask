using OpenQA.Selenium;

namespace BrowserTask;
public class MainPage
{
    IWebDriver driver;
    internal string Url = "https://www.demant.com/";
    internal IWebElement AcceptBox => driver.FindElement(By.CssSelector("[aria-label=\"I accept\"]"));
    internal IWebElement AboutButton => driver.FindElement(By.CssSelector(".level1.item3.even.last"));
    internal IWebElement ManageAndGovern =>
        driver.FindElement(By.CssSelector(".sub-menu a[title='Management and governance']"));
    public MainPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    public MainPage OpenFirstPage()
    {
        driver.Navigate().GoToUrl(Url);
        
        return this;
    }
    public MainPage ClosePopUp()
    {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
        AcceptBox.Click();
        
        return this;
    }
    public MainPage OpenAboutMenu()
    {
        AboutButton.Click();
        
        return this;
    } 
    public MainPage OpenManagementAndGovernancePage()
    {
        ManageAndGovern.Click();
        
        return this;
    }
}