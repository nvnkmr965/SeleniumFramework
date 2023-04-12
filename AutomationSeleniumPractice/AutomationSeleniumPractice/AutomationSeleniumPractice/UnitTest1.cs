using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver("C:\\ChromeDriver");

         
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}