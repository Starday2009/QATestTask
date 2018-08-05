using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.WebDriver;
using PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.ObjectModel;
using QATestTask.PageObject;

namespace QATestTask
{
    [TestClass]
    public class Tests
    {
        private IWebDriver driver;

        public static void Main(string[] args)
        {
            Tests Test = new Tests();
            Test.SetUp();
            Test.login();
            Test.createTodo();
            Test.deleteTodo();
            Test.TearDown();
        }
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void login()
        {
            HomePage home = new HomePage(driver);
            home.openMainPage();
            home.clickLogin();
            home.inFrameLogin();
            home.inFrameLogin();
            home.enterLogin("qwerty123@qwerty123.com");
            home.enterPassword("qwerty123");
            home.tapLoginInApp();
           
        }
        public void createTodo()
        {
            todoPage todoPage = new todoPage(driver);
            todoPage.waitForTodoPage();
            todoPage.clickAddTaskButton();
            todoPage.inputTodoInField("Todo me");
            todoPage.clickAddFillTaskButton();
            todoPage.checkAddedTask();

        }

        public void deleteTodo()
        {
            todoPage todoPage = new todoPage(driver);
            todoPage.clickCheckBoxForTask();
            todoPage.checkAddedTaskDeleted(); 

        }
        public void TearDown()
        {
            driver.Close();
        }
    }
}