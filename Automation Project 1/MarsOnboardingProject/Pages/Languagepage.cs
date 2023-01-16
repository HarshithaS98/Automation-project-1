using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project_1.Pages
{
    public class LanguagePage
    {
        public void Createlanguage(IWebDriver driver)
        {
            // Profile page
            //LANGUAGES
            // Identifying languages button 
            IWebElement languagebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagebutton.Click();
            Thread.Sleep(1500);
            // Identifying add new button
            IWebElement addnewbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();
            Thread.Sleep(1500);
            // identifying add language tool box and enter values
            IWebElement addlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguage.SendKeys("English");
            Thread.Sleep(1500);
            // identifying choose language drop box
            IWebElement chooselanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooselanguage.Click();     //  //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select   
            Thread.Sleep(1500);
            //identifying fluent in dropbox
            IWebElement fluentdropbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            fluentdropbox.Click();
            Thread.Sleep(1500);
            // click add button
            IWebElement addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addbutton.Click();

           
        }
        public void EditLanguage(IWebDriver driver)
        {

        }
        public void DelLanguage(IWebDriver driver)
        {

        }
        public void Errorlanguage(IWebDriver driver)
        {

        }
    }
}
