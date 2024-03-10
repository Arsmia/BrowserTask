using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace BrowserTask; 
public class UnitTest1
{
    [Fact]
    private static void DemantGetStarted()
    {
        IWebDriver driver = new FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.demant.com/");
        
        var title = driver.Title; // information about browser
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500); //Waiting Stategies based on page load
        
        var acceptBox = driver.FindElement(By.CssSelector("[aria-label=\"I accept\"]"));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
        acceptBox.Click();
        
        var aboutButton = driver.FindElement(By.CssSelector(".level1.item3.even.last"));
        aboutButton.Click();
        
        var managAndGovern = driver.FindElement(By.CssSelector(".sub-menu a[title='Management and governance']"));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        //driver.ExecuteScript("window.scrollIntoView(".level2.item5.even"));
        //actions.MoveToElement(".level2.item5.even").Perform();
        managAndGovern.Click();
        
        var webElement = driver.FindElement(By.CssSelector(".like-h1-xl-light"));
        Assert.Equal("Executive Board and Board of Directors", webElement.Text);
        
        var searchElement = driver.FindElement(By.ClassName("search"));
        searchElement.Click();
        
        searchElement = driver.FindElement(By.ClassName("search-field")).FindElement(By.TagName("input"));
        searchElement.SendKeys("News and media");
               
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        
        //Actions builder = new Actions(driver);
        //builder.SendKeys(Keys.Enter);
        //builder.Perform();
        
        searchElement.SendKeys(Keys.Enter);
        
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2000);
        var expectedHeader = driver.FindElement(By.CssSelector("[data-number='1']")).Text;
        var splitHeader = expectedHeader.Split(new char[] { '\r' })[0];
        
        driver.FindElement(By.CssSelector("li[data-number='1'] a[class='search-url']")).Click();
        
        var actualHeader = driver.FindElement(By.ClassName("banner-content")).Text;
        
        Assert.Equal(splitHeader, actualHeader);

    }
}
    


