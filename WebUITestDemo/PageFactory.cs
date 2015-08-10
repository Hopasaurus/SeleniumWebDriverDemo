using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebUITestDemo
{
    class PageFactory
    {
        internal static IWebPage GetPage(IWebDriver driver, string pageName)
        {
            //TODO: make this detect the kind of page desired.
            if (pageName == "Fahrenheit to Celsius")
                return new FahrenheitConversion.Page(driver);

            if (pageName == "Celsius to Fahrenheit")
                return new CelsiusConversion.Page(driver);

            throw new Exception("Unkown page name");
        }
    }
}
