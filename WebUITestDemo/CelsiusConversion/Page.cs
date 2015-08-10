using OpenQA.Selenium;
using System.Collections.Generic;

namespace WebUITestDemo.CelsiusConversion
{
    class Page : WebPage
    {
        public Page(IWebDriver driver)
        {
            this.driver = driver;

            locators = new Dictionary<string, By>() {
                {"Celsius value", By.Id("c2fc")},
                {"Fahrenheit value", By.Id("c2ff")},
                {"Convert", By.Id("convertButton")},
            };
        }

        public override void Load()
        {
            driver.Navigate().GoToUrl("http://davidhoppe.com/cf.html");
        }
    }
}
