using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace BrowserTask;

public class DemantSiteTests
{

    [Fact]

 private static void GetFirstPage()
     {
         IWebDriver driver = new FirefoxDriver();
         string expectedHeader = "News and media";
         
         //Arrange():
         new FirstPage(driver).OpenFirstPage()
             .ClosePopUp()
             .OpenAboutMenu()
             .OpenManagementAndGovernancePage();

         //Act();
         new ManagementGovernancePage(driver).ChooseManagementGovernanceTitle()

             //Assert();
             .CheckTitleOnPage()

             //Act():
             .ClickOnSearch()
             .EnterTextInSearchLine(expectedHeader);

         new SearchResultPage(driver).SearchUrlClick();

         new FoundPage(driver).FoundPageResult()
             
             //Assert();
             .CheckHeaderOnPage(expectedHeader);

     }
}
