using Ejercicio4.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ejercicio4.PageObject
{
    
    public class CoursesPage : BaseTest //Herencia para usar la misma instancia
                                        // del driver inicializada en base test
    {

        private IWebDriver driver;
        private Boolean flag;

        public CoursesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement searchBar => driver.FindElement(By.CssSelector("input[name=q]"));

        public void searchCoursesBar(string search)
        {
            searchBar.SendKeys(search + Keys.Enter);
        }

        public void CheckCoursesSearch(string search)
        {
            IList<IWebElement> lista = driver.FindElements(By.CssSelector("div.course-card__body"));


            foreach (IWebElement links in lista) //recorrer cada tarjeta y verificar titulo
            {
                String text = links.GetAttribute("innerText");

                if (text.Contains(search))
                {
                    flag = true;
                    break;
                }
                
            }
            Assert.True(flag); //assert fuera del for
        }
    }

    
}
