using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProjectTarea4.UnitTests;


//Julio Daniel Lachapelle Pimentel - 2022-0966
namespace ProjectTarea4
{
    public class LinkedlnUnitTestingcs
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //Primera prueba unitaria Login de usuario para el logeo en Linkedln
            LoginPruTests.loginTest(driver);

            Thread.Sleep(8000);

            //Segunda prueba unitaria Busqueda de empleos en linkedln
            driver = new ChromeDriver();
            BuscarEmpTest.BuscarEmpTesting(driver);

            Thread.Sleep(8000);

            //Tercera prueba unitaria para reportar la recuperacion de una cuenta a la cual se le olvido la contraseña
            driver = new ChromeDriver();
            PasswordErrorTests.PasswordErrorTest(driver);

            Thread.Sleep(8000);

            //Cuarta prueba unitaria para entrar al area donde se puede mensajear con las personas
            driver = new ChromeDriver();
            MensPruTests.MensPrubTests(driver);

            Thread.Sleep(8000);

            //Quinta prueba unitaria donde se puede ingresar a la red social para poder ver tus contactos y las personas con las que estas conectada
            driver = new ChromeDriver();
            SocialRed.lookSocialRed(driver);
        }
    }
}
