using Automation_Project_1.Pages;
using MarsOnboardingProject.Utilities;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsOnboardingProject.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        [When(@"I navigated to profile page")]
        public void WhenINavigatedToProfilePage()
        {
            driver = new ChromeDriver();

            loginpPage loginPageObj = new loginpPage();
            loginPageObj.loginActions(driver);
        }

        [When(@"Added <language> and <level> to the languages")]
        public void WhenAddedLanguageAndLevelToTheLanguages()
        {
            LanguagePage LanguagePageObj = new LanguagePage();
            LanguagePageObj.Createlanguage(driver);
        }

        [Then(@"the <language> and <level> created successfully")]
        public void ThenTheLanguageAndLevelCreatedSuccessfully()
        {

            LanguagePage LanguagePageObj = new LanguagePage();

        }

        [When(@"edited <language> and <level> to the languages")]
        public void WhenEditedLanguageAndLevelToTheLanguages()
        {
            LanguagePage LanguagePageObj = new LanguagePage();
            LanguagePageObj.EditLanguage(driver);
        }

        [Then(@"the <language> and <level> edited successfully")]
        public void ThenTheLanguageAndLevelEditedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"Deleted <language> and <level> in the language")]
        public void WhenDeletedLanguageAndLevelInTheLanguage()
        {
            LanguagePage LanguagePageObj = new LanguagePage();
            LanguagePageObj.DelLanguage(driver);

        }

        [Then(@"the <language> and <level> deleted successfully")]
        public void ThenTheLanguageAndLevelDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"Lefted <language> field blank or <level> not choosen or when duplicate data exists")]
        public void WhenLeftedLanguageFieldBlankOrLevelNotChoosenOrWhenDuplicateDataExists()
        {
            LanguagePage LanguagePageObj = new LanguagePage();
            LanguagePageObj.Errorlanguage(driver);
        }

        [Then(@"error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {

        }

        [When(@"When Added Selenium using Java and <skilllevel> to the skills")]
        public void WhenWhenAddedSeleniumUsingJavaAndSkilllevelToTheSkills()
        {
            skillsPage skillsPageObj = new skillsPage();
            skillsPageObj.Createskill(driver);
        }

        [Then(@"the Selenium using Java and <skilllevel> created successfully")]
        public void ThenTheSeleniumUsingJavaAndSkilllevelCreatedSuccessfully()
        {

        }

        [When(@"edited <skill> and <skilllevel> to the languages")]
        public void WhenEditedSkillAndSkilllevelToTheLanguages()
        {
            skillsPage skillsPageObj = new skillsPage();
            skillsPageObj.Editskill(driver);
        }
        [Then(@"the <skill> and <skilllevel> edited successfully")]
        public void ThenTheSkillAndSkilllevelEditedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"Deleted <skill> and <skilllevel> in the language")]
        public void WhenDeletedSkillAndSkilllevelInTheLanguage()
        {

            skillsPage skillsPageObj = new skillsPage();
            skillsPageObj.Delskill(driver);
        }

        [Then(@"the <skill> and <skilllevel> deleted successfully")]
        public void ThenTheSkillAndSkilllevelDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"Lefted <skill> field blank or <skilllevel> not choosen or when duplicate data exists")]
        public void WhenLeftedSkillFieldBlankOrSkilllevelNotChoosenOrWhenDuplicateDataExists()
        {
            skillsPage skillsPageObj = new skillsPage();
            skillsPageObj.Errorskill(driver);
        }

        [When(@"When Added India and JNTU and Btech Bachelors (.*) to the education")]
        public void WhenWhenAddedIndiaAndJNTUAndBtechBachelorsToTheEducation(int p0)
        {
            Educationpage EducationPageObj = new Educationpage();
            EducationPageObj.CreateEducation(driver);
        }

        [Then(@"the India and JNTU and Btech Bachelors (.*) created successfully")]
        public void ThenTheIndiaAndJNTUAndBtechBachelorsCreatedSuccessfully(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"editedSingapore and National University and MS Masters (.*) to the education")]
        public void WhenEditedSingaporeAndNationalUniversityAndMSMastersToTheEducation(int p0)
        {

            Educationpage EducationPageObj = new Educationpage();
            EducationPageObj.EditEducation(driver);
        }

        [Then(@"theSingapore National University  MS Masters (.*)  edited successfully")]
        public void ThenTheSingaporeNationalUniversityMSMastersEditedSuccessfully(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"Deleted <country> and <University> and <Title> <Degree> <Graduation year> to the education")]
        public void WhenDeletedCountryAndUniversityAndTitleDegreeGraduationYearToTheEducation()
        {
            Educationpage EducationPageObj = new Educationpage();
            EducationPageObj.DelEducation(driver);
        }
        [Then(@"the <country> <University> <Title> <Degree> <Graduation year>  deleted successfully")]
        public void ThenTheCountryUniversityTitleDegreeGraduationYearDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"Lefted <country> and <University> and <Title> <Degree> <Graduation year> not choosen or when duplicate data exists")]
        public void WhenLeftedCountryAndUniversityAndTitleDegreeGraduationYearNotChoosenOrWhenDuplicateDataExists()
        {

            Educationpage EducationPageObj = new Educationpage();
            EducationPageObj.ErrorEducation(driver);
        }
    }
}

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
