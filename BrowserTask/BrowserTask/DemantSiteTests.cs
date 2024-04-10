using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace BrowserTask;
public class DemantSiteTests : IDisposable
{
    IWebDriver driver;
    public DemantSiteTests()
    {
        var firefoxDriver = new FirefoxDriver();
        firefoxDriver.Manage().Window.Maximize();
        firefoxDriver.Url = "https://www.demant.com/";
        this.driver = firefoxDriver;
    }
    public void Dispose()
    {
        driver.Dispose();
    }
    [Fact]
 public void CorrectPageIsOpen()
     {
         //Arrange
         const string expectedHeader = "Latest news";
         const string title = "Executive Board and Board of Directors";
         var searchResultPage = new SearchResultPage(driver);
         var foundPage = new FoundPage(driver);
         var managementGovernancePage = new ManagementGovernancePage(driver);
         
         new MainPage(driver)
             .OpenFirstPage()
             .ClosePopUp()
             .OpenAboutMenu()
             .OpenManagementAndGovernancePage();
         
         //Act
         new ManagementGovernancePage(driver).ChooseManagementGovernanceTitle();
         
             //Assert
             Assert.Equal(title, managementGovernancePage.CheckTitleOnPage());
         
             //Act
             new ManagementGovernancePage(driver).ClickOnSearch()
             .EnterTextInSearchLine(expectedHeader);
         
         searchResultPage.SearchUrlClick();
         
             //Assert
             Assert.Equal(expectedHeader, foundPage.GetPageResult());
     }
}
