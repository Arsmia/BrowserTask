using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace BrowserTask;

public class DemantSiteTests : IDisposable
{
    private readonly IWebDriver _driver;

    public DemantSiteTests()
    {
        _driver = new FirefoxDriver();
        _driver.Manage().Window.Maximize();
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
    }

    public void Dispose()
    {
        _driver.Dispose();
    }

    [Fact]
    public void LatestNewsPageIsOpen()
    {
        //Arrange
        var managementGovernancePage = new MainPage(_driver)
            .OpenMainPage()
            .ClosePopUp()
            .OpenAboutMenu()
            .OpenManagementAndGovernancePage()

            //Act
            .ChooseManagementGovernanceTitle();

        //Assert
        const string title = "Executive Board and Board of Directors";
        Assert.Equal(title, managementGovernancePage.GetExpectedTitle().Text);

        //Arrange
        const string expectedHeader = "Latest news";

        var actualResult = managementGovernancePage
            .ClickOnSearch()
            .TriggerSearchOnWebSiteLine(expectedHeader)
            .UrlClick()

            //Act
            .GetHeader();

        //Assert
        Assert.Equal(expectedHeader, actualResult.Text);
    }
}