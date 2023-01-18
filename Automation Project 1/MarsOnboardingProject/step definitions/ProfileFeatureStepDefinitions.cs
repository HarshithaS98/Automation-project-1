using Automation_Project_1.Pages;
using MarsOnboardingProject.Utilities;
using Microsoft.Extensions.DependencyModel;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace MarsOnboardingProject.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        loginpPage loginPageObj = new loginpPage();
        LanguagePage LanguagePageObj = new LanguagePage();
        skillsPage skillsPageObj = new skillsPage();
        Certificationpage certificationObj = new Certificationpage();


        [Given(@"I logged into Mars page successfully")]
        public void GivenILoggedIntoMarsPageSuccessfully()
        {
            driver = new ChromeDriver();

            loginPageObj.loginActions();
                   
        }

        [When(@"I navigated to profile pages")]
        public void WhenINavigatedToProfilePages()
        {
            loginPageObj.loginActions();
        }
       
        [Given(@"Added '([^']*)' and '([^']*)' to the languages")]
        public void GivenAddedAndToTheLanguages(string language, string level)
        {
            LanguagePageObj.Createlanguage(language,level);
        }

        [Then(@"the '([^']*)' and '([^']*)' created  successfully")]
        public void ThenTheAndCreatedSuccessfully(string language, string level)
        {
            string createlanguage = LanguagePageObj.getlanguage();
            string createlanguagelevel = LanguagePageObj.getlanguage();

            Assert.That(createlanguage.Contains(language),"created language and expected language do NotFiniteNumberException match");
            Assert.That(createlanguagelevel.Contains(level), "chosen level and expected level do not match");
            driver.Quit();
        }
        [Given(@"edited '([^']*)' and '([^']*)' to the languages")]
        public void GivenEditedAndToTheLanguages(string language, string level)
        {
            LanguagePageObj.EditLanguage(language, level);
        }
        [Then(@"the '([^']*)' and '([^']*)'  edited successfully")]
        public void ThenTheAndEditedSuccessfully(string language, string level)
        {
            string editlanguage = LanguagePageObj.getlanguage();
            string editlanguagelevel = LanguagePageObj.getlanguage();

            Assert.That(editlanguage.Contains(language), "edited language and expected language do Not match");
            Assert.That(editlanguagelevel.Contains(level), "edited chosen level and expected level do not match");
            driver.Quit();
        }
    
        [Given(@"Deleted '([^']*)' and '([^']*)' in the language")]
        public void GivenDeletedAndInTheLanguage(string language, string level)
        {
            LanguagePageObj.DelLanguage();
        }
        [Then(@"the '([^']*)' and '([^']*)'  deleted successfully")]
        public void ThenTheAndDeletedSuccessfully(string language, string level)
        {
            string deletelanguage = LanguagePageObj.getlanguage();

            Assert.That(deletelanguage != "language", "edited language and expected language do Not match");


        }
        [Given(@"When Added '([^']*)' and '([^']*)' to the skills")]
        public void GivenWhenAddedAndToTheSkills(string p0, string skilllevel)
        {
            skillsPageObj.Createskill(p0, skilllevel);
        }
        [Then(@"'([^']*)' and '([^']*)'  created successfully")]
        public void ThenAndCreatedSuccessfully(string p0, string skilllevel)
        {
            string createskil = skillsPageObj.getskill();
            string createskillevel = skillsPageObj.getskill();

            Assert.That(createskil.Contains(p0), "created skill and expected skill do not match");
            Assert.That(createskillevel.Contains(skilllevel), "chosen skill level and expected level do not match");
            driver.Quit();
        }

        [Given(@"edited '([^']*)' and '([^']*)' to the skills")]
        public void GivenEditedAndToTheSkills(string skill, string skilllevel)
        {
            skillsPageObj.Editskill(skill, skilllevel);
        }
        [Then(@"'([^']*)' and '([^']*)'  edited successfully")]
        public void ThenAndEditedSuccessfully(string skill, string skilllevel)
        {
            string editskil = skillsPageObj.getskill();
            string editskillevel = skillsPageObj.getskill();

            Assert.That(editskil.Contains(skill), "edited skill and expected skill do not match");
            Assert.That(editskillevel.Contains(skilllevel), "chosen edited skill level and expected level");
            driver.Quit();
        }
        [Given(@"Deleted '([^']*)' and '([^']*)' in the skills")]
        public void GivenDeletedAndInTheSkills(string skill, string skilllevel)
        {
            skillsPageObj.Delskill();
        }
         [Then(@"'([^']*)' and '([^']*)'  deleted successfully")]
        public void ThenAndDeletedSuccessfully(string skill, string skilllevel)
        {
            string deleskil = skillsPageObj.getskill();
            Assert.That(deleskil != "skill", "edited skill and expected skill do Not match");
            driver.Quit();

        }

        [Given(@"When Added '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications")]
        public void GivenWhenAddedAndAndToTheCertifications(string p0, string p1, string p2)
        {
            certificationObj.CreateCertification(p0, p1, p2);
        }
           
        [Then(@"t '([^']*)' and '([^']*)' and '([^']*)'  created successfully")]
        public void ThenTAndAndCreatedSuccessfully(string p0, string p1, string p2)
        {
            string createcert = certificationObj.getCertificate();
            string createcerfrom = certificationObj.getCertificate();
            string createceryear = certificationObj.getCertificate();

            Assert.That(createcert.Contains(p0), "created certificate and expected skill do not match");
            Assert.That(createcerfrom.Contains(p1), "chosen certification from and expected value do not match");
            Assert.That(createceryear.Contains(p2), "chosen certification year  and expected value do not match");
            driver.Quit();
        }
    
        
        [Given(@"edited '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications")]
        public void GivenEditedAndAndToTheCertifications(string p0, string p1, string p2)
        {
            certificationObj.EditCertification(p0, p1, p2);
        }
        [Then(@"the '([^']*)' and '([^']*)' and '([^']*)'  to the Certifications edited successfully")]
        public void ThenTheAndAndToTheCertificationsEditedSuccessfully(string p0, string p1, string p2)
        {

            string editcert = certificationObj.getCertificate();
            string editcerfrom = certificationObj.getCertificate();
            string editceryear = certificationObj.getCertificate();

            Assert.That(editcert.Contains(p0), "edited certificate and expected skill do not match");
            Assert.That(editcerfrom.Contains(p1), "chosen edited certification from and expected value do not match");
            Assert.That(editceryear.Contains(p2), "chosen edited certification year  and expected value do not match");
            driver.Quit();
        }
        [Given(@"Deleted '([^']*)', '([^']*)' , '([^']*)'  to the Certifications")]
        public void GivenDeletedToTheCertifications(string certificate, string year, string from)
        {
            certificationObj.DelCertification();

        }
        [Then(@"the '([^']*)' , '([^']*)' , '([^']*)'  to the Certifications  deleted successfully")]
        public void ThenTheToTheCertificationsDeletedSuccessfully(string certificate, string year, string from)
        {
            string delcert = certificationObj.getCertificate();
            Assert.That(delcert != "skill", "edited skill and expected skill do Not match");
            driver.Quit();
        }

    }
}
//        [When(@"I navigated to profile page")]
//        public void WhenINavigatedToProfilePage()
//        {
//            driver = new ChromeDriver();

//            loginpPage loginPageObj = new loginpPage();
//            loginPageObj.loginActions(driver);
//        }

//        [When(@"Added <language> and <level> to the languages")]
//        public void WhenAddedLanguageAndLevelToTheLanguages()
//        {
//            LanguagePage LanguagePageObj = new LanguagePage();
//            LanguagePageObj.Createlanguage(driver);
//        }

//        [Then(@"the <language> and <level> created successfully")]
//        public void ThenTheLanguageAndLevelCreatedSuccessfully()
//        {

//            LanguagePage LanguagePageObj = new LanguagePage();

//        }

//        [When(@"edited <language> and <level> to the languages")]
//        public void WhenEditedLanguageAndLevelToTheLanguages()
//        {
//            LanguagePage LanguagePageObj = new LanguagePage();
//            LanguagePageObj.EditLanguage(driver);
//        }

//        [Then(@"the <language> and <level> edited successfully")]
//        public void ThenTheLanguageAndLevelEditedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"Deleted <language> and <level> in the language")]
//        public void WhenDeletedLanguageAndLevelInTheLanguage()
//        {
//            LanguagePage LanguagePageObj = new LanguagePage();
//            LanguagePageObj.DelLanguage(driver);

//        }

//        [Then(@"the <language> and <level> deleted successfully")]
//        public void ThenTheLanguageAndLevelDeletedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        // [When(@"Lefted <language> field blank or <level> not choosen or when duplicate data exists")]
//        //public void WhenLeftedLanguageFieldBlankOrLevelNotChoosenOrWhenDuplicateDataExists()
//        //{
//        //    LanguagePage LanguagePageObj = new LanguagePage();
//        //   LanguagePageObj.Errorlanguage(driver);
//        //}

//        [Then(@"error message should be displayed")]
//        public void ThenErrorMessageShouldBeDisplayed()
//        {

//        }

//        [When(@"When Added Selenium using Java and <skilllevel> to the skills")]
//        public void WhenWhenAddedSeleniumUsingJavaAndSkilllevelToTheSkills()
//        {
//            skillsPage skillsPageObj = new skillsPage();
//            skillsPageObj.Createskill(driver);
//        }

//        [Then(@"the Selenium using Java and <skilllevel> created successfully")]
//        public void ThenTheSeleniumUsingJavaAndSkilllevelCreatedSuccessfully()
//        {

//        }

//        [When(@"edited <skill> and <skilllevel> to the languages")]
//        public void WhenEditedSkillAndSkilllevelToTheLanguages()
//        {
//            skillsPage skillsPageObj = new skillsPage();
//            skillsPageObj.Editskill(driver);
//        }
//        [Then(@"the <skill> and <skilllevel> edited successfully")]
//        public void ThenTheSkillAndSkilllevelEditedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"Deleted <skill> and <skilllevel> in the language")]
//        public void WhenDeletedSkillAndSkilllevelInTheLanguage()
//        {

//            skillsPage skillsPageObj = new skillsPage();
//            skillsPageObj.Delskill(driver);
//        }

//        [Then(@"the <skill> and <skilllevel> deleted successfully")]
//        public void ThenTheSkillAndSkilllevelDeletedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        // [When(@"Lefted <skill> field blank or <skilllevel> not choosen or when duplicate data exists")]
//        // public void WhenLeftedSkillFieldBlankOrSkilllevelNotChoosenOrWhenDuplicateDataExists()
//        // {
//        //    skillsPage skillsPageObj = new skillsPage();
//        //  skillsPageObj.Errorskill(driver);
//        // }

//        [When(@"When Added India and JNTU and Btech Bachelors (.*) to the education")]
//        public void WhenWhenAddedIndiaAndJNTUAndBtechBachelorsToTheEducation(int p0)
//        {
//            Educationpage EducationPageObj = new Educationpage();
//            EducationPageObj.CreateEducation(driver);
//        }

//        [Then(@"the India and JNTU and Btech Bachelors (.*) created successfully")]
//        public void ThenTheIndiaAndJNTUAndBtechBachelorsCreatedSuccessfully(int p0)
//        {
//            throw new PendingStepException();
//        }

//        [When(@"editedSingapore and National University and MS Masters (.*) to the education")]
//        public void WhenEditedSingaporeAndNationalUniversityAndMSMastersToTheEducation(int p0)
//        {

//            Educationpage EducationPageObj = new Educationpage();
//            EducationPageObj.EditEducation(driver);
//        }

//        [Then(@"theSingapore National University  MS Masters (.*)  edited successfully")]
//        public void ThenTheSingaporeNationalUniversityMSMastersEditedSuccessfully(int p0)
//        {
//            throw new PendingStepException();
//        }

//        [When(@"Deleted <country> and <University> and <Title> <Degree> <Graduation year> to the education")]
//        public void WhenDeletedCountryAndUniversityAndTitleDegreeGraduationYearToTheEducation()
//        {
//            Educationpage EducationPageObj = new Educationpage();
//            EducationPageObj.DelEducation(driver);
//        }
//        [Then(@"the <country> <University> <Title> <Degree> <Graduation year>  deleted successfully")]
//        public void ThenTheCountryUniversityTitleDegreeGraduationYearDeletedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        // [When(@"Lefted <country> and <University> and <Title> <Degree> <Graduation year> not choosen or when duplicate data exists")]
//        //public void WhenLeftedCountryAndUniversityAndTitleDegreeGraduationYearNotChoosenOrWhenDuplicateDataExists()
//        //{

//        //  Educationpage EducationPageObj = new Educationpage();
//        //EducationPageObj.ErrorEducation(driver);
//        //   }
//    }
//}


//        [When(@"When Added Manual Tester and (.*) and Times Institue  to the Certifications")]
//        public void WhenWhenAddedManualTesterAndAndTimesInstitueToTheCertifications(int p0)
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"the Manual Tester and (.*) and Times Institue  created successfully")]
//        public void ThenTheManualTesterAndAndTimesInstitueCreatedSuccessfully(int p0)
//        {
//            throw new PendingStepException();
//        }

//        [When(@"editedTest Analyst and (.*) and Industry Connect  to the Certifications")]
//        public void WhenEditedTestAnalystAndAndIndustryConnectToTheCertifications(int p0)
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"theTest Analyst and (.*) and Industry Connect  to the Certifications edited successfully")]
//        public void ThenTheTestAnalystAndAndIndustryConnectToTheCertificationsEditedSuccessfully(int p0)
//        {
//            throw new PendingStepException();
//        }

//        [When(@"Deleted<certificate> and <Year> and <From>  to the Certifications")]
//        public void WhenDeletedCertificateAndYearAndFromToTheCertifications()
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"the <certificate> and <Year> and <From>  to the Certifications  deleted successfully")]
//        public void ThenTheCertificateAndYearAndFromToTheCertificationsDeletedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"Lefted <certificate> and <Year> and <From>  to the Certificationsnot choosen or when duplicate data exists")]
//        public void WhenLeftedCertificateAndYearAndFromToTheCertificationsnotChoosenOrWhenDuplicateDataExists()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"When Added <description>  to the description")]
//        public void WhenWhenAddedDescriptionToTheDescription()
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"the <description>   created successfully")]
//        public void ThenTheDescriptionCreatedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"edited<description>  to the description")]
//        public void WhenEditedDescriptionToTheDescription()
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"the<description>  to the description edited successfully")]
//        public void ThenTheDescriptionToTheDescriptionEditedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"Deleted <description>  to the description")]
//        public void WhenDeletedDescriptionToTheDescription()
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"the <description>  to the description deleted successfully")]
//        public void ThenTheDescriptionToTheDescriptionDeletedSuccessfully()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"Lefted  <description> not choosen or when duplicate data exists")]
//        public void WhenLeftedDescriptionNotChoosenOrWhenDuplicateDataExists()
//        {
//            throw new PendingStepException();
//        }
//    }
//}
