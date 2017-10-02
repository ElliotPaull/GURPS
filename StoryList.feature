Scenario: Saving a name
Given a GURPS sheet helper with an entered name of "Merlin"
And all other fields are valid
When the save button is clicked
Then "Merlin" is saved to a text file for that character

Scenario: Warned when attributes exceed the total points limit
Given a GURPS sheet helper with a points limit of 40
And total attributes exceeds the limit
When the save button is clicked
Then a warning popup is displayed