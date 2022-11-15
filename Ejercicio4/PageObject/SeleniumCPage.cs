using Ejercicio4.Tests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ejercicio4.PageObject
{

 
    public  class SeleniumCPage: BaseTest //Herencia para usar la misma instancia
                                         // del driver inicializada en base test
    {
        private IWebDriver driver;

        public SeleniumCPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        IWebElement signIn => driver.FindElement(By.CssSelector("a[href*='/users/sign_in']"));
        IWebElement headerWrapper => driver.FindElement(By.CssSelector("div.header__wrapper"));
        IWebElement video => driver.FindElement(By.CssSelector("div.section__video__wrapper"));

        public void CheckUrl(string url)
        {
            Assert.Contains(url, driver.Url);
        }
        public void CheckSignIn()
        {
            Assert.True(signIn.Displayed, "SignIn Not Displayed");
        }

        public void CheckHeader()
        {
            Assert.True(headerWrapper.Displayed, "Header Not Displayed");
        }

        public void CheckVideo()
        {
            Assert.True(video.Displayed, "Video Not Displayed");
        }

        public void CheckVideoF()
        {
            Assert.False(video.Displayed, "Video Not Displayed");
        }
    }
}
