using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using TechTalk.SpecFlow;

namespace WebUITestDemo
{
    [Binding]
    public class WebDriverHelper
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver driver;

        public WebDriverHelper(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void WebDriverSetup()
        {
            driver = new FirefoxDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void WebDriverTeardown() 
        {
            //Thread.Sleep(3000);
            if(null != driver)
                driver.Quit();
        }
    }
}
