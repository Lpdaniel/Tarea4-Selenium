using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

//Quinta prueba para entrar a la red social de las personas con las que estamos conectadas
//Julio Daniel Lachapelle Pimentel - 2022-0966
namespace ProjectTarea4.UnitTests
{
    public class SocialRed
    {
        public static void lookSocialRed(IWebDriver driver)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            driver.Navigate().GoToUrl("https://www.linkedin.com/home");
            driver.Manage().Window.Maximize();

            IWebElement email = driver.FindElement(By.Id("session_key"));
            email.SendKeys(Credenciales.Email);

            IWebElement pass = driver.FindElement(By.Id("session_password"));
            pass.SendKeys(Credenciales.Password);

            System.Threading.Thread.Sleep(7000);

            IWebElement btnLogin = driver.FindElement(By.CssSelector("[data-id='sign-in-form__submit-btn']"));
            btnLogin.Click();

            System.Threading.Thread.Sleep(10000);

            // Entrar a la red = Lista de amigos
            IWebElement enlaceContactos = driver.FindElement(By.Id("ember111"));
            enlaceContactos.Click();

            Thread.Sleep(10000);

            IWebElement enlaceRed = driver.FindElement(By.Id("ember111"));
            enlaceRed.Click();

            driver.Quit();
        }
    }
}
