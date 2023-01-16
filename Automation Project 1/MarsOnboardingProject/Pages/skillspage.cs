using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project_1.Pages
{
    public class skillsPage
    {
        public void Createskill(IWebDriver driver)
        {
            Thread.Sleep(1500);
            //SKILLS
            IWebElement skillsbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsbutton.Click();
            Thread.Sleep(1500);
            //click add new button
            IWebElement addnewskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewskill.Click();
            Thread.Sleep(1500);
            // click add skills button and enter skills
            IWebElement addskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addskill.SendKeys("Selenium using C#");
            Thread.Sleep(1500);
            // choose skill level and choose beginner
            IWebElement skilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skilllevel.Click();
            IWebElement choosebeginner = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            choosebeginner.Click();
            Thread.Sleep(1500);
            // click add new button
            IWebElement addskills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addskills.Click();

        }
    
         public void Editskill(IWebDriver driver)
         {

         }
        public void Delskill(IWebDriver driver)
        {

        }
        public void Errorskill(IWebDriver driver)
        {

        }
    
    }

}
