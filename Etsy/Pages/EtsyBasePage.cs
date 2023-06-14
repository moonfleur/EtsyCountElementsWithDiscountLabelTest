using OpenQA.Selenium;

namespace Etsy.Pages
{
    public  class EtsyBasePage
    {
        protected IWebDriver driver;
        public EtsyBasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
