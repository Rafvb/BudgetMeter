namespace BudgetMeter.Web.CodedUITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium.IE;

    [TestClass]
    public class HomePageTests
    {
        [TestMethod]
        public void HasCorrectTitle()
        {
            var driver = new InternetExplorerDriver();

            driver.Navigate().GoToUrl("http://localhost:50765/");

            Assert.AreEqual("BudgetMeter - Home", driver.Title);

            driver.Quit();
        }
    }
}
