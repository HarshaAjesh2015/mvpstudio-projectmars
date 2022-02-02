Feature:Seller Add Profile Details
Priority: Major
As a Seller 
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details

@mytag
Scenario: Succefully login with valid credentials 
	Given The URL 
	And I have entered the email address and password
	When I login 
	Then I should be able to see my profile name on Home Page

	Scenario: Seller able to ADD Description
	Given Successfully logged into the Home Page 
	And I Clicked on the edit button and add Description
	Then I should be able to create/add Description
	
	
	Scenario: Seller able to Add new Langauges
	Given Successfully logged into the Home Page 
	And I clicked on add new on Language option
	When The langauge and language level are chosen
	Then the result should be "'langauge' has been added to your languages" 

	Scenario: Seller able to Add new Skills
	Given Successfully logged into the Home Page 
	And I clicked on add new on Skills option
	When The skill and skill level are chosen
	Then the result must be "'skill' has been added to your skills" 

	Scenario: Seller able to Add new Education
	Given Successfully logged into the Home Page 
	And I clicked on add new on Education option
	When The required fields/text boxes are filled
	Then the result must show " Education has been added"

	Scenario: Seller able to Add new Certifications
	Given Successfully logged into the Home Page
	And I clicked on the add new on Certificaytions option
	When The required fields/textboxes are filled
	Then The result will be "'certificate' has been added to your certifications"
