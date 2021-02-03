Feature: ToolsQa Demo
	Validate login functionality

@loginToolsQa
Scenario Outline: Validate login functionality
	Given User Launch the DemoQA application
	When User click on login button
	And User enter <user_name> and <password>


	Examples: 
	| user_name | password |
	|      'drajesh174@gmail.com'     |     'Rajesh@123'     |

	@demo
	Scenario: Demo functionality
	Given User validate multiple tag
