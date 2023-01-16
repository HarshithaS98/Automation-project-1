using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project_1.Pages
{
    public class Educationpage
    {
        public void CreateEducation(IWebDriver driver)
        {

            //EDUCATION
            //click education button
            IWebElement educationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();
            Thread.Sleep(1500);
            //click add new button
            IWebElement addeducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]"));
            addeducation.Click();
            Thread.Sleep(1500);
            //add value to collge tool box as jntu college
            IWebElement entercollege = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            entercollege.SendKeys("Jawaharlal Nehru Techonological University");
            Thread.Sleep(1500);
            // choose inida from country dropdown box
            IWebElement countrydropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countrydropdown.Click();
            Thread.Sleep(1500);
            IWebElement chooseIndia = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            chooseIndia.Click();
            Thread.Sleep(1500);
            //choose title btech from title dropdown box
            IWebElement titlebox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titlebox.Click();
            Thread.Sleep(1500);
            IWebElement choosebtech = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
            choosebtech.Click();
            Thread.Sleep(1500);

            //add values as bachelors degree from degree tool box
            IWebElement degreebox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreebox.SendKeys("Bachelors ");
            Thread.Sleep(1500);
            //choose 2013 as year of graduation
            IWebElement yog = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yog.Click();
            Thread.Sleep(1500);
            IWebElement choose2013 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[12]"));
            choose2013.Click();
            Thread.Sleep(1500);
            // add values
            IWebElement adddetails = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            adddetails.Click();


        }

        public void EditEducation(IWebDriver driver)
        {

        }

        public void DelEducation(IWebDriver driver)
        {

        }
        public void ErrorEducation(IWebDriver driver)
        {

        }
    }
}
