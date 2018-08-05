using OpenQA.Selenium;

namespace QATestTask.PageObject
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By loginButton = By.LinkText("Log in");
        By loginField = By.Id("email");
        By passwordField = By.Id("password");
        By loginInApp = By.LinkText("Log in");

        public HomePage clickLogin()
        {
            driver.FindElement(loginButton).Click();
            return this;
        }

        public HomePage enterLogin()
        {
            driver.FindElement(loginField).SendKeys("qwerty123@qwerty123.com");
            return this;
        }

        public HomePage enterPassword()
        {
            driver.FindElement(passwordField).SendKeys("qwerty123");
            return this;
        }

        public HomePage tapLoginInApp()
        {
            driver.FindElement(loginInApp).Click();
            return this;
        }

        public HomePage inFrameLogin()
        {
            driver.SwitchTo().Frame("GB_frame");
            return this;
        }

        public void openMainPage()
        {
            driver.Navigate().GoToUrl("https://en.todoist.com");
        }

    }
}
