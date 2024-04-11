using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using ProjectTarea4;
using ProjectTarea4.UnitTests;

//Primera prueba para el testeo de lo que es el inicio de sesion o login
//Julio Daniel Lachapelle Pimentel - 2022-0966c
class LoginPruTests
{
    public static void loginTest(IWebDriver driver)
    {
        Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();


        driver.Navigate().GoToUrl("https://www.linkedin.com/home");
        driver.Manage().Window.Maximize();

        IWebElement email = driver.FindElement(By.Id("session_key"));
        email.SendKeys(Credenciales.Email);

        IWebElement pass = driver.FindElement(By.Id("session_password"));
        pass.SendKeys(Credenciales.Password);

        Thread.Sleep(7000);

        IWebElement btnLogin = driver.FindElement(By.CssSelector("[data-id='sign-in-form__submit-btn']"));
        btnLogin.Click();

        screenshot.SaveAsFile(Credenciales.screenshotPath + "LoginImage.png");

        Thread.Sleep(10000);
        driver.Quit();
    }
}

