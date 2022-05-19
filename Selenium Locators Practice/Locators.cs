using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Selenium_Locators_Practice
{
    [TestClass]
    public class Locators
    {
        [TestMethod]
        public void Locate()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.ankpro.com";

            //driver.FindElement(By.Name("domain_name")).SendKeys("hats");

            //driver.FindElement(By.Id("hdv3HeaderSearchButtonID")).Click();

            //string s1=driver.FindElement(By.CssSelector("span[class$='title green']")).Text;
            //Console.WriteLine(s1);

            //string s1=driver.FindElement(By.XPath("//span[contains(@class, 'bn')]/child::span[1]")).Text;
            //Console.WriteLine(s1);

            //driver.FindElement(By.LinkText("See details")).Click();

            //driver.FindElement(By.PartialLinkText("information private")).Click();

            //driver.Url = "http://www.hugedomains.com/about.cfm";
            //string s1=driver.FindElement(By.XPath("//span[contains(text(),'Domains names available')]")).Text;
            //Console.WriteLine(s1);

            //int count=driver.FindElements(By.CssSelector(".content")).Count;
            //Console.WriteLine(count);

            //driver.Url = "https://www.hugedomains.com/about.cfm";
            //string s1 = driver.FindElement(By.XPath("//ul[contains(@class, 'side')]/li[@class='active'][position()=1]/a")).Text;
            //Console.WriteLine(s1);

            //string s1 = driver.FindElement(By.XPath("//ul[contains(@class, 'side')]/li[last()-2]/a")).Text; //Poslednja dva samo radi ilustracije last() i position(), inace mogu mnogo jednostavnije a[text()='...']
            //Console.WriteLine(s1);

            //driver.FindElement(By.XPath(".//input[@type='chekbox' and not(@checked='checked')]")).Click();

            //int count=driver.FindElements(By.XPath(".//div[@class='crediti ']/descendant::li")).Count;
            //Console.WriteLine(count);

            //int count = driver.FindElements(By.XPath(".//div[@class='crediti ']/ancestor::div")).Count;
            //Console.WriteLine(count); 

            //int count = driver.FindElements(By.XPath(".//div[@class='crediti ']/ul/li/following-sibling::li")).Count;
            //Console.WriteLine(count);

            //int count = driver.FindElements(By.XPath(".//div[@class='crediti ']/ul/li/following::*")).Count;
            //Console.WriteLine(count);

            //int count = driver.FindElements(By.XPath(".//div[@class='crediti ']/preceding-sibling::div")).Count;
            //Console.WriteLine(count);

            //int count = driver.FindElements(By.XPath(".//div[@class='crediti ']/preceding::*")).Count;
            //Console.WriteLine(count);

            int count = driver.FindElements(By.ClassName("content")).Count;
            Console.WriteLine(count);

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void WebElements()
        {
            IWebDriver driver = new FirefoxDriver();
            //driver.Url = "https://www.hugedomains.com/about.cfm";

            //bool displayed=driver.FindElement(By.CssSelector("img[src$='text-image-abaut-1.jpg']")).Displayed;
            //Console.WriteLine(displayed);

            //driver.Url = "https://www.hugedomains.com/contact.cfm";
            //bool enabled=driver.FindElement(By.Id("contactFormHdv3MessageID")).Enabled;
            //Console.WriteLine(enabled);

            //driver.Url = "http://www.ankpro.com";
            //bool selected=driver.FindElement(By.Id("hdv3ProductFavoriteHeartID")).Selected;
            //Console.WriteLine(selected);

            //Point point=driver.FindElement(By.XPath(".//h2[text()='FAQs']")).Location;
            //Console.WriteLine(point.X);
            //Console.WriteLine(point.Y);

            //Size size=driver.FindElement(By.XPath(".//div[@class='crediti ']/ul/li[2]/descendant::img")).Size;
            //Console.WriteLine(size);

            //string tagname=driver.FindElement(By.XPath("//span[text()='$2,995']")).TagName;
            //Console.WriteLine(tagname);

            //string text=driver.FindElement(By.XPath("//p[contains(text(), 'expertise')]")).Text;
            //Console.WriteLine(text);

            //driver.FindElement(By.Id("contactFormHdv3KaptchaID")).SendKeys("virago");
            //driver.FindElement(By.Id("contactFormHdv3KaptchaID")).Clear();

            //driver.FindElement(By.XPath("//div[@class='shop-links']/descendant::a[2]")).Click();

            //int count=driver.FindElements(By.XPath("//div[@class='cart-icon']/preceding-sibling::div")).Count;
            //Console.WriteLine(count);

            //string s1=driver.FindElement(By.CssSelector("img[src$='contact-phone-ico.png']")).GetAttribute("src");
            //Console.WriteLine(s1);

            //string s1 = driver.FindElement(By.XPath("//div[1][@class='meta-item']/child::span[1]")).GetCssValue("font-size");
            //Console.WriteLine(s1);

            driver.Url = "https://www.hugedomains.com/payment-plan-login.cfm";
            driver.FindElement(By.XPath(".//button[1][@type='submit']")).Submit();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void DropdownAndMultiselectDropdown()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/";
            driver.FindElement(By.LinkText("Select")).Click();
            //IWebElement element = driver.FindElement(By.Id("countriesSingle"));
            //SelectElement selectElement = new SelectElement(element);

            //IList <IWebElement> options= selectElement.Options;
            //Console.WriteLine(options.Count);
            //foreach (var item in options)
            //{
            //Console.WriteLine(item.Text);
            //}

            IWebElement element = driver.FindElement(By.Id("countriesMultiple"));
            SelectElement selectElement = new SelectElement(element);
            //bool isMultiple=selectElement.IsMultiple;
            //Console.WriteLine(isMultiple);

            //selectElement.SelectByText("England");
            //Thread.Sleep(2000);
            //selectElement.DeselectByText("England");

            //selectElement.SelectByIndex(0);
            //Thread.Sleep(2000);
            //selectElement.DeselectByIndex(0);

            //selectElement.SelectByValue("usa");
            //Thread.Sleep(2000);
            //selectElement.DeselectByValue("usa");
                        
            //IWebElement selectedOption=selectElement.SelectedOption;
            //Console.WriteLine(selectedOption.Text);
            //Thread.Sleep(2000);

            selectElement.SelectByIndex(2);
            selectElement.SelectByIndex(3);
            IList<IWebElement> selectedOptions = selectElement.AllSelectedOptions;
            Console.WriteLine(selectedOptions.Count);
            foreach (var item in selectedOptions)
            {
                Console.WriteLine(item.Text);
            }
            Thread.Sleep(2000);
            selectElement.DeselectAll();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsDragAndDrop()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/";
            Actions actions = new Actions(driver);
            actions.DragAndDrop(driver.FindElement(By.Id("draggable")), driver.FindElement(By.Id("droppable")))

                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();

        }

        [TestMethod]
        public void ImplicitWait()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.wikipedia.org/";
            driver.FindElement(By.Id("searchInput")).SendKeys("Srbija");
            driver.FindElement(By.CssSelector("button[class$='progressive']")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void ExplicitWait()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.wikipedia.org/";
            driver.FindElement(By.Id("searchInput")).SendKeys("Srbija");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button[class$='progressive']")));
            driver.FindElement(By.CssSelector("button[class$='progressive']")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
