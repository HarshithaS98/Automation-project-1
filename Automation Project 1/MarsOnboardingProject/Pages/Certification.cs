using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project_1.Pages
{
    public class Certification
    {
        public void CreateCertification(IWebDriver driver)
        {
            //Identify certification button
            IWebElement cerbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            cerbutton.Click();
            // identify add new button
            IWebElement addCer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addCer.Click();

            //identify certificate or award textbox and add Istqb Certification
            IWebElement certoolbox = driver.FindElement(By.Name("certificationName"));
            certoolbox.SendKeys("ISTQB");
            //Identify certify from toolbox and enter sgtqb
            IWebElement certifytoolbox = driver.FindElement(By.Name("certificationFrom"));
            certifytoolbox.SendKeys("Adobe");
            // identify year dropbox and choose 2022
            IWebElement yearCer = driver.FindElement(By.Name("certificationYear"));
            //choose2022
            yearCer.Click();
            IWebElement yearofcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[3]"));
            yearofcer.Click();
            //identify add and save details
            IWebElement addcertificate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addcertificate.Click();
        }
        public void editCertification(IWebDriver driver)
        {
            //identifycertification button
            IWebElement cereditbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            cereditbutton.Click();
            //identify edit button
            IWebElement editcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            editcer.Click();
            //edit cer tool box
            IWebElement cer = driver.FindElement(By.Name("certificationName"));
            cer.Clear();
            cer.SendKeys("ASTQB");
            // edi from details
            IWebElement from = driver.FindElement(By.Name("certificationFrom"));
            cer.Clear();
            from.SendKeys("US");
            // edit year details
            IWebElement year = driver.FindElement(By.Name("certificationYear"));
            year.Click();
            IWebElement yearcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[2]"));
            yearcer.Click();
            // click on update button
            IWebElement updatecer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updatecer.Click();
        }
        public void DelCertification(IWebDriver driver)
        {
            //identifycertification button
            IWebElement delcerbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            delcerbutton.Click();
            IWebElement delcer = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
            delcer.Click();
        }
    }
}
