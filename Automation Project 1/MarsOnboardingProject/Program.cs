
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Login page

// open browser
IWebDriver driver = new ChromeDriver();
 driver.Manage().Window.Maximize();
Thread.Sleep(1000);
// launch local host:5000
driver.Navigate().GoToUrl("http://localhost:5000/Home");

// Identify signin button
IWebElement signinbutton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
signinbutton.Click();

// Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
usernameTextbox.SendKeys("harshi.s98@gmail.com");

// Identify password textbox and enter password 
IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
passwordTextbox.SendKeys("harshitha4");

//Identify login button
IWebElement loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
loginbutton.Click();
// check if user has logged in successfully

Thread.Sleep(1500);
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


