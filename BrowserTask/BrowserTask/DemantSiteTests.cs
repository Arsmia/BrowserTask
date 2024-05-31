using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Xunit.Abstractions;

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
            .ClickManagementGovernanceTitle();

        //Assert
        const string title = "Executive Board and Board of Directors";
        Assert.Equal(title, managementGovernancePage.Title.Text);

        //Arrange
        const string searchText = "News and media";
        const string expectedHeader = "Oticon releases new premium hearing aids Oticon Real TM";
        
        var expectedLink = managementGovernancePage
            .ClickSearchIcon()
            .EnterSearchPhrase(searchText)
            .TriggerSearch()
            .NotFirstElementOfTheList.GetAttribute("href");

        //Act
        var actualResult = new SearchResultPage(_driver)
            .ClickNotFirstElementOfTheList();

        //Assert
        Assert.Equal(expectedLink, _driver.Url );
        Assert.Equal(expectedHeader, actualResult.Header.Text);
    }
}