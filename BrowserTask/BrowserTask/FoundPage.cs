using OpenQA.Selenium;

namespace BrowserTask;
public class FoundPage
{
    IWebDriver driver;
    private By _actualHeader = By.ClassName("banner-content");
    private string _header;
    public FoundPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    public string GetPageResult()
    {
        _header = driver.FindElement(_actualHeader).Text;
        return _header;
    }
}