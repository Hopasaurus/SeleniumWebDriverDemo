using OpenQA.Selenium;
using System.Collections.Generic;

namespace WebUITestDemo.FahrenheitConversion
{
    class Page : WebPage
    {
        public Page(IWebDriver driver)
        {
            this.driver = driver;

            locators = new Dictionary<string, By>() {
                {"Fahrenheit value", By.Id("f2cf")},
                {"Celsius value", By.Id("f2cc")},
                {"Convert", By.Id("convertButton")},
            };
        }

        public override void Load()
        {
            driver.Navigate().GoToUrl("http://davidhoppe.com/fc.html");
        }
    }
}
