using Ejercicio4.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;
using Ejercicio4.Tests;
using Ejercicio4;

public class Test1:BaseTest 
    {

    HomePage hp = new HomePage(DriverInstanceManager.Driver);
    SeleniumCPage sp = new SeleniumCPage(DriverInstanceManager.Driver);

    [Test]
        public void ValidateLink()
        {
        hp.clickSeleniumCLink();
        sp.CheckUrl("selenium");
        sp.CheckSignIn();
        sp.CheckHeader();
        sp.CheckVideo();
        }

     
    }

