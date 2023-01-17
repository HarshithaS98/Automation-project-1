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
            Thread.Sleep(1000);
            // Identify language button
            IWebElement languageeditbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageeditbutton.Click();
            Thread.Sleep(1500);
            // Identify edit button
            IWebElement editlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editlanguage.Click();
            // clear the previous details for language
            IWebElement Clearlanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            Clearlanguage.Clear();
            Clearlanguage.SendKeys("Telugu");
            Thread.Sleep(700);

            // change the choose language dropbox
            IWebElement editchooselanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[5]"));
            editchooselanguage.Click();
            Thread.Sleep(1500);
            // save the edited values
            IWebElement updatelanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updatelanguage.Click();

        }
        public void DelLanguage(IWebDriver driver)
        {
            //Identify language button
            Thread.Sleep(1000);
            IWebElement languagedelbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagedelbutton.Click();

            // identify x button
            IWebElement Dellanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            Dellanguage.Click();
        }
    }
}
