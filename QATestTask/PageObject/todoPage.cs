using System;
using OpenQA.Selenium;
namespace QATestTask.PageObject
{
    class todoPage
    {
        private IWebDriver driver;

        public todoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //Add task button
        By addTaskButton = By.XPath("//*[@id='agenda_view']/div/ul/li[2]/a");
        By taskField = By.XPath("//*[@id='agenda_view']/div/ul/li[2]/form/table[1]/tbody/tr/td/table/tbody/tr/td[1]/div");
        By addFillTaskButton = By.XPath("//*[@id='agenda_view']/div/ul/li[2]/form/table[2]/tbody/tr/td[1]/a[1]/span");
        By checkBoxForTask = By.ClassName("ist_checkbox");

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
