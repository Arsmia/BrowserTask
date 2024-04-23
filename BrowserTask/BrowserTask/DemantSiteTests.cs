using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace BrowserTask;

public class DemantSiteTests : IDisposable
{
    private IWebDriver _driver;

    public DemantSiteTests()
    {
        var firefoxDriver = new FirefoxDriver();
        firefoxDriver.Manage().Window.Maximize();
        _driver = firefoxDriver;
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
        const string title = "Executive Board and Board of Directors";
        var managementGovernancePage = new MainPage(_driver)
            .OpenFirstPage()
            .ClosePopUp()
            .OpenAboutMenu()
            .OpenManagementAndGovernancePage()

            //Act
            .ChooseManagementGovernanceTitle();

        //Assert
        Assert.Equal(title, managementGovernancePage.CheckTitleOnPage());

        //Arrange
        const string expectedHeader = "Latest news";
        var foundPage = new ManagementGovernancePage(_driver)
            .ClickOnSearch()
            .EnterTextInSearchLine(expectedHeader)

            //Act
            .SearchUrlClick();

        //Assert
        Assert.Equal(expectedHeader, foundPage.GetPageResult());
    }
}