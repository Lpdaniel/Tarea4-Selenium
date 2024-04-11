using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

//Tercera prueba para mostrar la recuperacion de una cuenta
//Julio Daniel Lachapelle Pimentel - 2022-0966
namespace ProjectTarea4.UnitTests
{
    class PasswordErrorTests
    {
        public static void PasswordErrorTest(IWebDriver driver)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            
            driver.Navigate().GoToUrl("https://www.linkedin.com/home");
            driver.Manage().Window.Maximize();

            IWebElement btnForgottenPassword = driver.FindElement(By.CssSelector("a[data-id='sign-in-form__forgot-password']"));
            btnForgottenPassword.Click();

            Thread.Sleep(9000);

            IWebElement btnIdentifyEmail = driver.FindElement(By.CssSelector("input#username"));
            btnIdentifyEmail.SendKeys(Credenciales.Email);

            Thread.Sleep(10000);

            IWebElement btnNext = driver.FindElement(By.Id("reset-password-submit-button"));
            btnNext.Click();

            Thread.Sleep(10000);

            screenshot.SaveAsFile(Credenciales.screenshotPath + "PasswordError.png");

            Thread.Sleep(8000);
            driver.Quit();
        }
    }
}