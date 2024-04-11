using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

//Segunda prubea para la busqueda de empleo
//Julio Daniel Lachapelle Pimentel - 2022-0966
namespace ProjectTarea4.UnitTests
{
    public class BuscarEmpTest
    {
        public static void BuscarEmpTesting(IWebDriver driver)
        {
          

            driver.Navigate().GoToUrl("https://www.linkedin.com/home");
            driver.Manage().Window.Maximize();


            IWebElement email = driver.FindElement(By.Id("session_key"));
            email.SendKeys(Credenciales.Email);

          
            IWebElement pass = driver.FindElement(By.Id("session_password"));
            pass.SendKeys(Credenciales.Password);

            Thread.Sleep(7000);

          
            IWebElement btnLogin = driver.FindElement(By.CssSelector("[data-id='sign-in-form__submit-btn']"));
            btnLogin.Click();

            Thread.Sleep(5000);

            // Haz clic en el enlace "Mi red"
            IWebElement btnEmpleos = driver.FindElement(By.CssSelector("div.ivm-view-attr__img-wrapper.display-flex"));
            btnEmpleos.Click();

            Thread.Sleep(5000);

      
            IWebElement inputBusqueda = driver.FindElement(By.Id("jobs-search-box-keyword-id-ember251"));
            inputBusqueda.SendKeys("Desarrollador de software");

            inputBusqueda.SendKeys(Keys.Enter);

            Thread.Sleep(8000);

            // Captura de pantalla
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(Credenciales.screenshotPath + "Searching.png");

        
            Thread.Sleep(8000);

            driver.Quit();
        }
    }
}
