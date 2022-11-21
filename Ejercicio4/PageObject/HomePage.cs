using Ejercicio4.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.PageObject
{

    public class HomePage : BasePage//Herencia para usar la misma instancia
                                    // del driver inicializada en base test
    {
        private IWebElement seleniumC => driver.FindElement(By.CssSelector("a[href*='selenium-with-c']"));
        public void clickSeleniumCLink()
        {
            seleniumC.Click();
        }
        private IWebElement courses => driver.FindElement(By.CssSelector("a[href^=\"https://courses\"]"));
        public void clickCoursesLink()
        {
            courses.Click();
        }
    }
}
