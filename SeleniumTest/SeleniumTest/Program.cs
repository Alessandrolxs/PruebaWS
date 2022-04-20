using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            //Abriendo la pagian web en Mozilla Firefox
            driver.Navigate().GoToUrl("file:///E:/Html/Proyecto%20tienda/index.html");
            driver.Manage().Window.Maximize();

            //Dando click en el boton para logearse
            IWebElement btnlogin = driver.FindElement(By.Id("item-login"));
            btnlogin.Click();

            //Ir a la opcion para registrarse
            IWebElement btnaqui = driver.FindElement(By.Id("login"));
            btnaqui.Click();

            //Insertando nuestro nombre
            IWebElement txtname = driver.FindElement(By.Id("nombre"));
            txtname.SendKeys("Alessandro");

            //Insertando nuestro apellido
            IWebElement txtape = driver.FindElement(By.Id("apellido"));
            txtape.SendKeys("Legua");

            //Insertando un correo
            IWebElement txtemail = driver.FindElement(By.Id("email"));
            txtemail.SendKeys("legua24@gmail.com");

            //Insertando una contrasena
            IWebElement txtcontra = driver.FindElement(By.Id("contra"));
            txtcontra.SendKeys("123456");

            //Codigo para cerrar el navegador
            //driver.Close();
        }
    }
}
