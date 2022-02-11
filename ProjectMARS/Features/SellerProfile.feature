Feature:Seller Add Profile Details
Priority: Major
As a Seller 
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details

@mytag
#Scenario: Succefully login with valid credentials 
#	Given The URL 
#	And I have entered the email address and password
#	When I login 
#	Then I should be able to see my profile name on Home Page

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

	Scenario: Seller able to EDIT Description
	Given Successfully logged into the Home Page 
	And I Clicked on the edit button and edited Description
	Then I should be able to edit Description
	
	
	Scenario: Seller able to EDIT Langauges
	Given Successfully logged into the Home Page 
	And I clicked on Language option and selected edit button
	When The langauge and language level to be edited are chosen
	Then the result should be "'langauge' has been updated to your languages" 

	Scenario: Seller able to EDIT Skills
	Given Successfully logged into the Home Page 
	And I clicked  on Skills option and edit skill option
	When The skill and skill level to be edited are chosen
	Then the result must be "'skill' has been updated to your skills" 

	Scenario: Seller able to EDIT Education
	Given Successfully logged into the Home Page 
	And I clicked on Education option and edit Education option
	When The required fields/text boxes to be edited  are filled
	Then the result must show " Education has been updated"

	Scenario: Seller able to EDIT Certifications
	Given Successfully logged into the Home Page
	And I clicked edit on Certificaytions option and click on the edit button
	When The required fields/textboxes to be edited  are filled
	Then The result will be "'certificate' has been updated to your certifications"

	Scenario: Seller able to DELETE Description
	Given Successfully logged into the Home Page 
	And I Clicked on the Description button and deleted Description
	Then I should be able to delete Description
	
	
	Scenario: Seller able to DELETE Langauges
	Given Successfully logged into the Home Page 
	And I clicked on Language option 
	When The langauge to be deleted are chosen
	Then the result should be "'langauge' has been deleted from your languages" 

	Scenario: Seller able to DELETE Skills
	Given Successfully logged into the Home Page 
	And I clicked  on Skills option
	When The skill to be deleted are chosen
	Then the result must be "'skill' has been deleted " 

	Scenario: Seller able to DELETE Education
	Given Successfully logged into the Home Page 
	And I clicked on Education option 
	When The Education details to be deleted are chosen
	Then the result must show " Education entry successfully removed"

	Scenario: Seller able to  DELETE Certifications
	Given Successfully logged into the Home Page
	And I clicked  on Certifications option 
	When The Certification details to be deleted are chosen
	Then The result will be "'certificate' has been deleted from your certifications"

	Scenario: Seller able to update title details
	Given Successfully logged into the Home Page
    And Update Title, Location,Availabilty,Hours and Earn target on Profile page
	Then I should be able to see the udated details.



