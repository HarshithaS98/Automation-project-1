﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarsOnboardingProject.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;


        public void loginactions()
        {
            driver = new ChromeDriver();

        }

        public void CloseTestRun()
        {
            driver.Quit();
        }

    }

}