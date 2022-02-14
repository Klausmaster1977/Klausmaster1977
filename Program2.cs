using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99Demo
{
    class CSS
    {
        IWebDriver m_driver;

        [Test]
        public void cssDemo()
        {
            m_driver = new ChromeDriver("D:\\3rdparty\\chrome");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();
            IWebElement link = m_driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
            m_driver.Close();
        }
    }
}