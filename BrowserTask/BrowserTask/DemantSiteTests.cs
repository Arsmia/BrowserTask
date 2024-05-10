using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace BrowserTask;

public class DemantSiteTests : IDisposable
{
    private readonly IWebDriver driver;

    public DemantSiteTests()
    {
        driver = new FirefoxDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
    }

    public void Dispose()
    {
        driver.Dispose();
    }

    [Fact]
    public void LatestNewsPageIsOpen()
    {
        //Arrange
        var managementGovernancePage = new MainPage(driver)
            .OpenFirstPage()
            .ClosePopUp()
            .OpenAboutMenu()
            .OpenManagementAndGovernancePage()

            //Act
            .ChooseManagementGovernanceTitle();

        //Assert
        const string title = "Executive Board and Board of Directors";
        Assert.Equal(title, managementGovernancePage.CheckTitleOnPage());

        //Arrange
        const string expectedHeader = "Latest news";

        var actualResult = managementGovernancePage.ClickOnSearch()
            .EnterTextInSearchLine(expectedHeader)

            //Act
            .SearchUrlClick()
            .GetPageResult();

        //Assert
        Assert.Equal(expectedHeader, actualResult);
    }
}