# Getting Started Coding Challenge
In this challenge, there is no step-by-step guide and no hints. However, if you get really stuck, the full solution is located in the ChallengeSolution folder.

# Steps
Locate the GettingStartedChallenge.Code console application. Open the ```Program.cs``` files and add code to the ```main``` function that does the following:

-	Displays a prompt asking the user for their name and inputs their response
-	Displays a message that says "Hello, ___" (where their name is filled in)
-	Asks the user how old they are, and stores their response as an integer
-	Displays the message "You are nn years old" where nn is the user’s age
-	Asks the user for their date of birth, and stores their response in a DateTime variable
-	Displays the message "You are nnn days old" where nnn is the total number of days that the user has been alive

# To Run the Project
-  Select "Start Debugging" or "Run Without Debugging" from Visual Studio Code's "Run" menu or press F5 or Ctrl+F5
-  To interact with the console (and view the program's output) select the "Terminal" option from Visual Studio Code's View Menu (or press Ctrl+')  

# Execute Unit Tests
At any time you can invoke the unit tests that will be used to determine whether you have successfully completed the challenge by selecting the "Terminal" option from Visual Studio Code's View Menu (or pressing Ctrl+')) and running the following command:

```
dotnet test
```
If all the tests pass you will see a message (in green) that states <span style="color:green">"Passed!  - Failed:   0..."</span>. If any of the tests fail tou will see a message in red that states <span style="color:red">"Failed! - Failed:    n..."</span> where n indicates the number of tests that have failed.

__Note:__ You are NOT (yet) expected to understand how to create your own unit tests nor to interpret the results beyond knowing whether the tests have passed or failed. You will be looking at unit testing as the final topic of this digital course.

# Model Solution (__But only if you need it__)
The code for a model solution can be found in the ```ModelSolutionIfYouNeedIt.Code``` project 