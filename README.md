# TupasKAskingTwoQuestionsAPI3

//Peer Review: Elizar Garcia, code works great. i really like the layout of how the questions are asked and followed up with. The code shows up on postman with no 
problem. Good job sir!

Download Appications and Download Code: You need the following appications postman and visual studio code. All must be login or setup before proceding.
To download my code there should be a green button that says code on it. Then copy it and open up visual studio code.Open a new window and click on Clone git Repository. 
Then paste the link in the URL. Make a new folder where you want to put it.

Run the code: You run a Debug then your default browser should pop up a window. It should say localhost can't be found. On top copy the URL then. 
Go on postman and click on workspace in the URL put the URL you copy from the localhost in the URL. It should look like this https://localhost:7191/. 
Go back on visual studio code click on the contoller folder. Look at the names click on AskingTwoQuestionController.cs. By public class copy only "AskingTwoQuestion" 
ignoring Contoller.cs. Go back on postman and paste it in the URL. It should look like this https://localhost:7191/AskingTwoQuestion/. Go back on visual studio code 
on the AskingTwoQuestionController.cs. You should see [HttpGet] and under it [Route("Questions/{name}/{adj}/{number}")] . Copy the text in the quotions marks. Go back 
on postman and paste what you copy in the URL. Get rid of {name},{adj},{number} and type in any name you want. It should look like this 
https://localhost:7191/AskingTwoQuestion/questions/Mary/sleepy/2am.
