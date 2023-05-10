using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace DemooQA_JavaScript
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new EdgeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Manage().Window.Maximize();

            driver.Url = "https://demoqa.com/";

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(3000);

            js.ExecuteScript("document.querySelector('#app > div > div > div.home-body > div > div:nth-child(1) > div').click()");
            js.ExecuteScript("document.getElementById('item-0').click()");


            //For Text Box Section
            js.ExecuteScript("document.getElementById('userName').value='Mujahid'");
            js.ExecuteScript("document.getElementById('userEmail').value='mujahidakberali@gmail.com'");
            js.ExecuteScript("document.getElementById('currentAddress').value='Karachi, Pakistan'");
            js.ExecuteScript("document.getElementById('permanentAddress').value='Karachi, Pakistan'");
            js.ExecuteScript("document.getElementById('submit').click()");
          
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,100)");
            Thread.Sleep(1000);

            //For Check Box
            js.ExecuteScript("document.getElementById('item-1').click()");
            Thread.Sleep(3000);
            js.ExecuteScript("document.querySelector('#tree-node > div > button.rct-option.rct-option-expand-all').click()");

            Thread.Sleep(2000);

            js.ExecuteScript("document.querySelector('#tree-node > ol > li > ol > li:nth-child(1) > span > label').click()");
            js.ExecuteScript("document.querySelector('#tree-node > ol > li > ol > li:nth-child(2) > span > label').click()");
            js.ExecuteScript("document.querySelector('#tree-node > ol > li > ol > li:nth-child(3) > span > label').click()");
            Thread.Sleep(1000);
            js.ExecuteScript("document.querySelector('#tree-node > div > button.rct-option.rct-option-collapse-all').click()");
            Thread.Sleep(3000);

            //For Radio Button
            js.ExecuteScript("document.getElementById('item-2').click()");
            Thread.Sleep(3000);
            js.ExecuteScript("document.getElementById('yesRadio').click()");
            Thread.Sleep(3000);

            //For Webtables
            js.ExecuteScript("document.getElementById('item-3').click()");
            Thread.Sleep(3000);
            js.ExecuteScript("document.getElementById('addNewRecordButton').click()");
            js.ExecuteScript("document.getElementById('firstName').value='Mujahid'");
            js.ExecuteScript("document.getElementById('lastName').value='Akber Ali'");
            js.ExecuteScript("document.getElementById('userEmail').value='mujahidakberali@gmail.com'");
            js.ExecuteScript("document.getElementById('age').value='23'");
            js.ExecuteScript("document.getElementById('salary').value='23,000'");
            js.ExecuteScript("document.getElementById('department').value='QA Intern'");
            js.ExecuteScript("document.getElementById('submit').click()");
            Thread.Sleep(3000);
            js.ExecuteScript("document.querySelector('body > div.fade.modal.show > div > div > div.modal-header > button').click()");


            //For Opening form and filling practice form
            js.ExecuteScript("document.querySelector('#app > div > div > div.row > div:nth-child(1) > div > div > div:nth-child(2) > span > div').click()");
            Thread.Sleep(2000);
            //js.ExecuteScript("document.querySelector('#item-0').click()");
            //js.ExecuteScript("document.querySelector('document.querySelector('#app > div > div > div.row > div:nth-child(1) > div > div > div:nth-child(2) > div > ul').click()");
            //Thread.Sleep(3000);
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            // For PracticeForm
            js.ExecuteScript("document.getElementById('firstName').value='Mujahid'");
            js.ExecuteScript("document.getElementById('lastName').value='Akber Ali'");
            js.ExecuteScript("document.getElementById('userEmail').value='mujahidakberali@gmail.com'");
            js.ExecuteScript("document.querySelector('#genterWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label').click()");
            js.ExecuteScript("document.getElementById('userNumber').value='12345678'");


            js.ExecuteScript("document.getElementById('dateOfBirthInput').value='03 July 1998'");
            driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Tab);


            driver.FindElement(By.Id("subjectsInput")).SendKeys("math");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Tab);

            js.ExecuteScript("document.querySelector('#hobbiesWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label').click()");
            driver.FindElement(By.Id("uploadPicture")).SendKeys(@"C:\Users\aadil\Desktop\02.png");
            js.ExecuteScript("document.getElementById('currentAddress').value='Karachi,Pakistan'");


            driver.FindElement(By.Id("react-select-3-input")).SendKeys("NCR");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(Keys.Enter);

            driver.FindElement(By.Id("react-select-4-input")).SendKeys("Delhi");
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Enter);
            js.ExecuteScript("document.getElementById('submit').click()");

        }
    }
}
