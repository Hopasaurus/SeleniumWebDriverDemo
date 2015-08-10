using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WebUITestDemo
{
    [Binding]
    public class StepDefinitions
    {
        private IWebDriver driver;
        private IWebPage page;

        public StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I have loaded the ""(.*)"" page")]
        public void GivenIHaveLoadedThePage(string pageName)
        {
            page = PageFactory.GetPage(driver, pageName);
            page.Load();
        }

        [Given(@"I have entered ""(.*)"" in the ""(.*)""")]
        public void GivenIHaveEnteredInThe(string value, string elementName)
        {
            page.SetElementValue(elementName, value);
        }

        [When(@"I click ""(.*)""")]
        public void WhenIClickTheButton(string elementName)
        {
            page.ClickElement(elementName);
        }

        [Then(@"""(.*)"" should be ""(.*)""")]
        public void ThenShouldBe(string elementName, string value)
        {
            System.Threading.Thread.Sleep(300);
            var actual = page.GetElementValue(elementName);
            Assert.AreEqual(value, actual);
        }

    }
}
