using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AddAdvertToSlando
{
    public static class ObjectExtension
    {
        public static IWebElement GetProperty<TI>(this TI input, string propertyName)
        {
            return input.GetType().GetProperty(propertyName).GetValue(input) as IWebElement;
        }
    }
}
