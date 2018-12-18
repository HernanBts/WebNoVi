using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99Demo
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Usuario\\Desktop\\Info\\Calidad\\Automation\\CSharp VS\\ToolsQA\\ToolsQA\\bin\\Debug\\netcoreapp2.1");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void LoginLogout()
        {
            driver.Url = "http://localhost:51406/";
            IWebElement loginButton =driver.FindElement(By.Id("loginBtn"));
            loginButton.Click();
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys("superuser@admin.com");
            IWebElement psswField = driver.FindElement(By.Id("Password"));
            psswField.SendKeys("Super123.");
            IWebElement aceptLoginButton = driver.FindElement(By.XPath("//section[@id='loginForm']/form[@role='form']//input[@value='Iniciar Sesion']"));
            aceptLoginButton.Click();
            IWebElement messagesButton = driver.FindElement(By.XPath("//a[@id='msjBtn']/i"));
            messagesButton.Click();
            IWebElement inicio = driver.FindElement(By.Id("CeNoVii"));
            inicio.Click();
            IWebElement logOutButton = driver.FindElement(By.Id("logout"));
            logOutButton.Click();
            Assert.IsFalse(driver.PageSource.Contains("Panel administrador:"));
        }
        public void AddAndDeleteMessage(){
            driver.Url = "http://localhost:51406/";
            IWebElement msgNameField= driver.FindElement(By.Id("QueryTextName"));
            msgNameField.SendKeys("Marcos Testeo");
            IWebElement msgEmailField= driver.FindElement(By.Id("QueryTextMail"));
            msgNameField.SendKeys("marcos@Test.com");
            IWebElement msgSubjectField = driver.FindElement(By.Id("QueryTextSubject"));
            msgNameField.SendKeys("Estoy testeando");
            IWebElement msgMessageField = driver.FindElement(By.Id("QueryTextMessage"));
            msgNameField.SendKeys("Este es un texto que servira a modo de automatizacion de texto");
            IWebElement sendMessageBtn = driver.FindElement(By.Id("btnAddQuery"));
            IWebElement loginButton = driver.FindElement(By.Id("loginBtn"));
            loginButton.Click();
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys("superuser@admin.com");
            IWebElement psswField = driver.FindElement(By.Id("Password"));
            psswField.SendKeys("Super123.");
            IWebElement aceptLoginButton = driver.FindElement(By.XPath("//section[@id='loginForm']/form[@role='form']//input[@value='Iniciar Sesion']"));
            aceptLoginButton.Click();

            IWebElement messagesButton = driver.FindElement(By.XPath("//a[@id='msjBtn']/i"));
            messagesButton.Click();

        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}