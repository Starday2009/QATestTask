using System;
using OpenQA.Selenium;
using PageObjects.WebDriver;
namespace QATestTask.PageObject
{
    class todoPage
    {
        private IWebDriver driver;
        private IWebElement element;


        public todoPage(IWebDriver driver)
        {
            this.driver = driver;            
        }

        //Add task button
        By addTaskButton = By.XPath("//*[@id='agenda_view']/div/ul/li[2]/a");
        By taskField = By.XPath("//*[@id='agenda_view']/div/ul/li[2]/form/table[1]/tbody/tr/td/table/tbody/tr/td[1]/div");
        By addFillTaskButton = By.XPath("//*[@id='agenda_view']/div/ul/li[2]/form/table[2]/tbody/tr/td[1]/a[1]/span");
        By checkBoxForTask = By.ClassName("ist_checkbox");
        By loader = By.ClassName("loading_screen fade_out");
        private IWebElement cbft;
        private IWebElement atb;

        public todoPage waitForTodoPage()
        {
            Waiter.WaitForInvisibility(loader, TimeSpan.FromSeconds(int.Parse("20")));
            atb = driver.FindElement(addTaskButton);
            Waiter.UntilVisible(atb, TimeSpan.FromSeconds(int.Parse("20")));
            return this;
        }
        public todoPage checkAddedTask()
        {
            cbft = driver.FindElement(checkBoxForTask);
            Waiter.UntilVisible(cbft, TimeSpan.FromSeconds(int.Parse("10")));

            return this;
        }
        public todoPage checkAddedTaskDeleted()
        {
            Waiter.WaitForInvisibility(checkBoxForTask, TimeSpan.FromSeconds(int.Parse("10")));
            return this;
        }
        public todoPage clickAddTaskButton()
        {
            driver.FindElement(addTaskButton).Click();
            return this;
        }
        public todoPage inputTodoInField(String todoText)
        {
            driver.FindElement(taskField).SendKeys(todoText);
            return this;
        }
        public todoPage clickAddFillTaskButton()
        {
            driver.FindElement(addFillTaskButton).Click();
            return this;
        }
        public todoPage clickCheckBoxForTask()
        {
            driver.FindElement(checkBoxForTask).Click();
            return this;
        }
    }
}
