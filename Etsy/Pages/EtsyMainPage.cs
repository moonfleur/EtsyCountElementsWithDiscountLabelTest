using OpenQA.Selenium;
using System.Collections.Generic;

namespace Etsy.Pages
{
    public  class EtsyMainPage : EtsyBasePage
    {
        public EtsyMainPage(IWebDriver driver) : base(driver) {}

        #region WebElements
        public IWebElement ClothingAndShoesMenuItem => driver.FindElement(By.CssSelector("li.top-nav-item[data-node-id='10923']"));
        public IWebElement BootsSubMenu => driver.FindElement(By.Id("catnav-l4-10935"));
        public IList<IWebElement> DiscountedItems => driver.FindElements(By.CssSelector(".wt-text-caption.search-collage-promotion-price.wt-text-slime.wt-text-truncate.wt-no-wrap"));

        #endregion
    }
}
