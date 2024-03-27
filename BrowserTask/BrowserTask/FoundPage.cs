using OpenQA.Selenium;

namespace BrowserTask;

public class FoundPage
{
    protected IWebDriver driver;
    
    private By _actualHeader = By.ClassName("banner-content");
    private string _header;

    public FoundPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public FoundPage FoundPageResult()
    {
        _header = driver.FindElement(_actualHeader).Text;
        return this;
    }

    public FoundPage CheckHeaderOnPage(string expectedHeader)
    {
        Assert.Equal(expectedHeader, _header);
        return this;
    }
}


// var actualHeader = driver.FindElement(By.ClassName("banner-content")).Text;
//
// Assert.Equal(splitHeader, actualHeader);