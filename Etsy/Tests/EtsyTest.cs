using Etsy.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Etsy
{
    public class EtsyTest
    {
        private IWebDriver _driver;
        private Actions _actions;
        private WebDriverWait _wait;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CountItemsWithDiscountOnWomensBootsPageonEtsy()
        {
            //Arrange
            _driver.Url = "https://www.etsy.com/";

            //Act
            EtsyMainPage etsyMainPage = new EtsyMainPage(_driver);
          
            //Assert
            _actions = new Actions(_driver);
            _actions.MoveToElement(etsyMainPage.ClothingAndShoesMenuItem).Perform();
            etsyMainPage.BootsSubMenu.Click();

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            Console.WriteLine("Кількість елементів зі знижкою: " + etsyMainPage.DiscountedItems.Count);
        }

        [TearDown] 
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
