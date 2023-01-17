using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Automation_Project_1.Pages;

namespace MarsOnboardingProject.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;


        public void loginactions()
        {
            driver = new ChromeDriver();
            loginpPage loginPageObj = new loginpPage();
            loginPageObj.loginActions(driver);
        }

        public void CloseTestRun()
        {
            driver.Quit();
        }

    }

}