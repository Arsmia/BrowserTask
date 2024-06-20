using OpenQA.Selenium;

namespace BrowserTask;

internal class MainPage(IWebDriver driver)
{
    private const string Url = "https://www.demant.com/";

    private IWebElement AcceptBox => driver.FindElement(By.CssSelector("[aria-label=\"I accept\"]"));

    private IWebElement AboutButton => driver.FindElement(By.CssSelector(".level1.item3.even.last"));

    private IWebElement ManagementAndGovernanceSubMenuButton => driver.FindElement(By.CssSelector(".sub-menu a[title='Management and governance']"));

    internal MainPage OpenMainPage()
    {
        driver.Navigate().GoToUrl(Url);

        return this;
    }

    internal MainPage ClosePopUp()
    {
        AcceptBox.Click();

        return this;
    }

    internal MainPage OpenAboutMenu()
    {
        AboutButton.Click();

        return this;
    }

    internal ManagementGovernancePage OpenManagementAndGovernancePage()
    {
        ManagementAndGovernanceSubMenuButton.Click();

        return new(driver);
    }
}