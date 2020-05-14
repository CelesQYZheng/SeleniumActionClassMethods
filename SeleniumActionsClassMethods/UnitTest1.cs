using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;
namespace SeleniumActionsClassMethods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActionsMoveToElement()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            //actions.MoveToElement(driver.FindElement(By.Id("div2")))
            //    .ContextClick()
            //    .Build()
            //    .Perform();

            //actions.MoveToElement(driver.FindElement(By.Id("div2")),20, 20);

            actions.MoveToElement(driver.FindElement(By.Id("div2")), 20, 20, MoveToElementOffsetOrigin.TopLeft)
                .ContextClick()
                .Build()
                .Perform();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void ClickA()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);
            //IWebElement clickbutton = driver.FindElement(By.Name("click"));
            //actions.MoveToElement(driver.FindElement(By.Name("click")))
            //    .Click()
            //    .Build()
            //    .Perform();

            actions.Click(driver.FindElement(By.Name("click")))
                .Build()
                .Perform();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void DoubleClick()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            //actions.MoveToElement(driver.FindElement(By.Name("dblClick")))
            //    .DoubleClick()
            //    .Build()
            //    .Perform();

            actions.DoubleClick(driver.FindElement(By.Name("dblClick")))
                .Build()
                .Perform();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void ClickAndHold()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            //actions.MoveToElement(driver.FindElement(By.Name("one")))
            //    .ClickAndHold()
            //    .Build()
            //    .Perform();
            //Thread.Sleep(3000);

            //actions.ClickAndHold()
            //    .MoveToElement(driver.FindElement(By.Name("twelve")))
            //    .Release()
            //    .Build()
            //    .Perform();
            //Thread.Sleep(3000);

            
           //MoveToElement(driver.FindElement(By.Name("twelve")))
           //     .Release()
           //     .Build()
           //     .Perform();

            actions.ClickAndHold(driver.FindElement(By.Name("one")))
                .Release(driver.FindElement(By.Name("twelve")))
                .Build()
                .Perform();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void Click()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            //actions.MoveToElement(driver.FindElement(By.Id("draggable")))
            //    .ContextClick();
            //Thread.Sleep(3000);

            //actions.ContextClick(driver.FindElement(By.Name("four")))
            //    .Build()
            //    .Perform();

            actions.Click(driver.FindElement(By.Name("four")))
                .Build()
                .Perform();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void DandD()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);
            IWebElement drag = driver.FindElement(By.Id("draggable"));
            IWebElement drop = driver.FindElement(By.Id("droppable"));

            //actions.DragAndDrop(drag, drop).Build().Perform();
            actions.DragAndDropToOffset(drag,200,300).Build().Perform();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void Keydown()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            //actions.KeyDown(Keys.Command)
            //    .Click(driver.FindElement(By.Name("one")))
            //    .Click(driver.FindElement(By.Name("five")))
            //    .Click(driver.FindElement(By.Name("four")))
            //    .KeyUp(Keys.Command)
            //    .Build()
            //    .Perform();

            actions.KeyDown(driver.FindElement(By.Name("one")), Keys.Command)
                .KeyDown(driver.FindElement(By.Name("six")), Keys.Command)
                .KeyUp(driver.FindElement(By.Name("eleven")), Keys.Command)
                .Build()
                .Perform();
            Thread.Sleep(3000);
            driver.Quit();
        }

     }
 }