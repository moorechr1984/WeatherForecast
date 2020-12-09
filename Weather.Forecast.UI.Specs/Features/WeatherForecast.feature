Feature: WeatherForecast	
As a user, I want to view today's forecasted temperature, so that i know what to wear today.

@mytag
Scenario: View Today's forecast
	Given the user is viewing the home page
	When he/she clicks today's forecast
	Then he should see "It Worked" 

	Given the user is viewing the home page
	When he/she clicks today's forecast
	And clicks Clear Me
	Then he should see """" 
