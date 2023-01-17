using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            addskill.SendKeys("Selenium using java");
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
            Thread.Sleep(1000);

        }
    
         public void Editskill(IWebDriver driver)
         {
            //Identify skill edit button and click
            IWebElement EditskillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            EditskillButton.Click();
            Thread.Sleep(1000);

            // Identify skill textbox and update test analyst
            IWebElement editSkill = driver.FindElement(By.Name("name"));
            editSkill.Clear();
            editSkill.SendKeys("Selenium uding C#");
            Thread.Sleep(1000);

            // Identify skill level dropdown 
            IWebElement ClickSkillDropdown = driver.FindElement(By.Name("level"));
            ClickSkillDropdown.Click();
            Thread.Sleep(1000);

            // Select expert from skill dropdown
            IWebElement SkillExpert = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
            SkillExpert.Click();
            Thread.Sleep(1000);

            // Identify update button and click
            IWebElement ClickSkillUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            ClickSkillUpdate.Click();
            Thread.Sleep(1000);
            // Check if user is able to update the skill succesfully 

        }
        public void Delskill(IWebDriver driver)
        {
            // Identify delete button and click
            IWebElement SkillDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            SkillDelete.Click();
            Thread.Sleep(1000);
            // Check if user is able to delete the skill succesfully 
        }
       
    
    }

}
