using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebUITestDemo
{
    public interface IWebPage
    {
        void Load();
        void ClickElement(string elementName);
        string GetElementValue(string elementName);
        void SetElementValue(string elementName, string value);
    }
}
