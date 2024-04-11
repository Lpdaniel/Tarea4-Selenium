using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading.Tasks;

//Cuarta prueba para enviar mensajes y poder contactar con las personas
//Julio Daniel Lachapelle Pimentel - 2022-0966
namespace ProjectTarea4.UnitTests
{
    public class MensPruTests
    {
        public static void MensPrubTests(IWebDriver driver)
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

            screenshot.SaveAsFile(Credenciales.screenshotPath + "FailedLogin.png");
           
            Thread.Sleep(10000);

            IWebElement btnMens = driver.FindElement(By.XPath("//li[contains(@class, 'global-nav__primary-item')]"));
            btnMens.Click();

            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}

