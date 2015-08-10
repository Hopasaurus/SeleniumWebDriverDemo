using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUITestDemo
{
    abstract class WebPage : IWebPage
    {
        protected IWebDriver driver;
        protected static Dictionary<string, By> locators;

        public abstract void Load();

        public void ClickElement(string elementName)
        {
            driver.FindElement(locators[elementName]).Click();
        }

        public string GetElementValue(string elementName)
        {
            return driver.FindElement(locators[elementName]).GetAttribute("value");
        }

        public void SetElementValue(string elementName, string value)
        {
            driver.FindElement(locators[elementName]).Clear();
            driver.FindElement(locators[elementName]).SendKeys(value);
        }
    }
}
