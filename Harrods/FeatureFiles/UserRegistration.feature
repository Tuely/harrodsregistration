Feature: UserRegistration
	User Registration

Background: 
	Given I am a new user and visits the registration page

Scenario: Email address format validation
	When I enter email address 'wrongemail'
	And I continue with the registration
	Then I should see error message 'Please enter a valid email address.'

@signout
Scenario: Registration of a user with valid information
	When I enter email address 'test4.email@gmail.com'
	And I continue with the registration
	And I enter the following registration details
	| Field           | Value                                      |
	| Title           | Mr                                         |
	| FirstName       | First                                      |
	| LastName        | Last                                       |
	| ContactNumber   | 1234567890                                 |
	| BirthDay        | 20                                         |
	| BirthMonth      | January                                    |
	| Country         | United Kingdom                             |
	| AddressKey      | BR13BN                                     |
	| Address         | 13 Wanstead Close, BROMLEY, Kent, BR1  3BN |
	| Password        | testPass1                                  |
	| ConfirmPassword | testPass1                                  |
	And I complete registration 
	Then I should see the greeting 'Welcome Mr First Last'

Scenario: Duplicate Email address validation
	When I enter email address 'testvalidation.email@gmail.com'
	And I continue with the registration
	Then I should see Email Validation error message 'This email is already registered. Please sign in to continue to your account.'

Scenario Outline: Registration Form Field validations
	When I enter email address 'testvalidation3.email@gmail.com'
	And I continue with the registration
	And I enter the registration details '<Title>' '<FirstName>' '<LastName>' '<ContactNumber>' '<Birthday>' '<BirthMonth>' '<Country>' '<AddressKey>' '<Address>' '<Password>' '<ConfirmPassword>' 
	And I complete registration 
	Then I should see error message '<Message>'
	Examples: 
	| Title | FirstName | LastName | ContactNumber | Birthday | BirthMonth | Country        | AddressKey | Address | Password  | ConfirmPassword | Message                                                                                                                                                                          |
	|       | First     | Last     | 1234567890    | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 | testPass1       | Please select a title                                                                                                                                                            |
	| Mr    |           | Last     | 1234567890    | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 | testPass1       | Please enter A-Z, ' and - characters only                                                                                                                                        |
	| Mr    | 123       | Last     | 1234567890    | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 | testPass1       | Please enter a first name                                                                                                                                                        |
	| Mr    | First     |          | 1234567890    | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 | testPass1       | Please enter a last name                                                                                                                                                         |
	| Mr    | First     | 123      | 1234567890    | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 | testPass1       | Please enter A-Z, ' and - characters only                                                                                                                                        |
	| Mr    | First     | Last     |               | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 | testPass1       | Please enter a valid telephone number without any spaces and special characters                                                                                                  |
	| Mr    | First     | Last     | 123           | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 | testPass1       | Please enter a valid mobile number.                                                                                                                                              |
	| Mr    | First     | Last     | 1234567890    | 20       | January    | United Kingdom | BR13BN     | 13      | 123       | testPass1       | This is an invalid password. Your password must be at least 7 characters long, including an uppercase and a lowercase character, and a number up to a maximum of 116 characters. |
	| Mr    | First     | Last     | 1234567890    | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 | testPass12      | Your new password entries do not match. Please try again                                                                                                                         |
	| Mr    | First     | Last     | 1234567890    | 20       | January    | United Kingdom | BR13BN     | 13      | testPass1 |                 | Please confirm your password                                                                                                                                                     |
	

	



