using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class SeleniumTest
    {
        String testURL = "https://www.google.com";

        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            driver.Url = testURL;

            IWebElement sClass = driver.FindElements(By.TagName("button"));

            //searchText.SendKeys("LambdaTest");

            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));

            searchButton.Click();


            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumTesingFindElements
{
    public class NameDemo
        {
            public static void main(String[] args)
            {
                System.setProperty("webdriver.chrome.driver", "D:\\3rdparty\\chrome\\chromedriver.exe");
                WebDriver driver = new ChromeDriver();
                driver.manage().window().maximize();

                driver.get("http://demo.guru99.com/test/ajax.html");

                driver.findElement(By.id("no")).click();

                driver.findElement(By.id("buttoncheck")).click();

            }

    }
}

*/