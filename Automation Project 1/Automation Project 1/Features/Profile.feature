﻿Feature: ProfileFeature

As a Seller, I would like to  add my Profile Details in the profile page
So that
The people seeking for some skills can look into my details.


Background:I logged into Mars page successfully
When I navigated to profile page


Scenario Outline: User Create languages using valid data
When Added <language> and <level> to the languages
Then the <language> and <level> created successfully

 Examples: 
 | Languages | Level  |
 | English   | Fluent |


Scenario Outline: User edited existing language with valid details
When edited <language> and <level> to the languages
Then the <language> and <level> edited successfully

Examples: 
| Language | Level          |
| Hindi    | Conversational |

Scenario: User able to delete edited languages with valid details
When Deleted <language> and <level> in the language
Then the <language> and <level> deleted successfully

Scenario:Verify validation error for language
When Lefted <language> field blank or <level> not choosen or when duplicate data exists
Then error message should be displayed

Scenario Outline: User create skills using skills tab
When When Added <skill> and <skilllevel> to the skills
Then the <skill> and <skilllevel> created successfully

 Examples: 
 | skill               | skillLevel |
 | Selenium using Java | Beginner   |


Scenario Outline: User edited existing skill with valid details
When edited <skill> and <skilllevel> to the languages
Then the <skill> and <skilllevel> edited successfully

Examples: 
| Language | Level          |
| Selenium using C#   |Intermediate|

Scenario: User able to delete edited skill with valid details
When Deleted <skill> and <skilllevel> in the language
Then the <skill> and <skilllevel> deleted successfully

Scenario:Verify validation error for skill
When Lefted <skill> field blank or <skilllevel> not choosen or when duplicate data exists
Then error message should be displayed

Scenario Outline: User create Education using education tab
When When Added <country> and <University> and <Title> <Degree> <Graduation year> to the education
Then the <country> and <University> and <Title> <Degree> <Graduation year> created successfully

 Examples: 
 | country | University | Title | Degree    | Graduation year |
 | India   | JNTU       | Btech | Bachelors | 2013            |


Scenario Outline: User edited existing education details with valid details
When edited<country> and <University> and <Title> <Degree> <Graduation year> to the education
Then the<country> <University>  <Title> <Degree> <Graduation year>  edited successfully

Examples: 
| country   | University          | Title | Degree  | Graduation year |
| Singapore | National University | MS    | Masters | 2020            |

Scenario: User able to delete edited education  with valid details
When Deleted <country> and <University> and <Title> <Degree> <Graduation year> to the education
Then the <country> <University> <Title> <Degree> <Graduation year>  deleted successfully

Scenario:Verify validation error for education
When Lefted <country> and <University> and <Title> <Degree> <Graduation year> not choosen or when duplicate data exists
Then error message should be displayed

Scenario Outline: User create certifications using certification tab
When When Added <certificate> and <Year> and <From>  to the Certifications
Then the <certificate> and <Year> and <From>  created successfully

 Examples: 
 | certificate  | From             | Year | 
 | Manual Tester| Times Institue   | 2015 |


Scenario Outline: User edited existing certificate details with valid details
When edited<certificate> and <Year> and <From>  to the Certifications
Then the<certificate> and <Year> and <From>  to the Certifications edited successfully

 Examples: 
 | certificate  | From             | Year | 
 | Test Analyst | Industry Connect  | 2023 |
Scenario: User able to delete edited certificate details  with valid details
When Deleted<certificate> and <Year> and <From>  to the Certifications
Then the <certificate> and <Year> and <From>  to the Certifications  deleted successfully

Scenario:Verify validation error for certification
When Lefted <certificate> and <Year> and <From>  to the Certificationsnot choosen or when duplicate data exists
Then error message should be displayed

Scenario Outline: User writes  description using description tab
When When Added <description>  to the description
Then the <description>   created successfully

 Examples: 
 | Description                                                            |  
 | Iam Harshitha, I would like to say that Iam a Qa Intern at MvP studios |


Scenario Outline: User edited existing description details with valid details
When edited<description>  to the description
Then the<description>  to the description edited successfully

 Examples: 
 | Description                                                                      |
 | Iam Harshitha, I would like to say that Iam a Test analyst Intern at MvP studios |

Scenario: User able to delete edited description details
When Deleted <description>  to the description
Then the <description>  to the description deleted successfully

Scenario:Verify validation error for description
When Lefted  <description> not choosen or when duplicate data exists
Then error message should be displayed