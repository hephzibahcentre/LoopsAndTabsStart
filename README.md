# ITEC140-A07

Add a new TabControl to the form, and for each question below, create a new tab for that specific question.

For each question below where you are asked to create a user interface, create a new item in the TabPages property.

Ensure you name each control exactly as requested.

1.	Use a for loop that runs between the numbers 65 to 90.  Inside the loop convert the current number to a character using the ``` char c = (char)65; ``` variable definition and concatenate the result of each iteration into a label control (lblCharacters).  
The resulting string of letters in the label belong to a set you learn about starting in Grade 0 (Kindergarten) what is it?  [2]

Put your text answer here: ABCDEFGHIJKLMNOPQRSTUVWXYZ

2.	Create two ListBoxes, one for even numbers (lstEven) and one for odd numbers (lstOdd).  Then create a loop of your choice that will run for 100 iterations.  On each iteration a random number should be generated, then an IF statement should check to see if the number is even or odd.  If the number is even it will be added to the even list box (lstEven), else odd it will be added to the odd list box (lstOdd).

Hint: C#.NET (and every other language) has a Modulo operator, research and use this operator to determine if the number is even or odd [2]

3.	Create three TrackBar (TB) controls and a Button.  These TB controls will be used to adjust 3 parameters of a for loop: Starting Number (trkStart), Ending Number(trkEnd), and Step Amount(trkStep).  When the button(btnQ3) is clicked a For loop will run from the Starting Number to the Ending Number with a step value of the Step Amount TB and the resulting number will be added to a ListBox (lstForLoop).  The ListBox should be cleared each button click, right before the loop begins.
Note: Each TB minimum and maximum should span from -100 to 100 [2]

4.	Using a Button (btnFactorial), a Label (lblFactorial), a TextBox (txtFactorial) and any Loop of your choice, create code to calculate Factorial.  When the Button is pressed the number will be read in, processed, and the result output in the label. [2]
5.	
Here is some example input, calculation and output to help design the loop:

| Input |	Factorial Calculation	| Output |
| --- | --- | --- |
| 5 |	5 x 4 x 3 x 2 x 1	| 120 |
| 8 |	8 x 7 x 6 x 5 x 4 x 3 x 2 x 1 |	40320 |
| 3	| 3 x 2 x 1	| 6 |

5.	Create an interface that will act as a Flash Card game to practice simple mathematics. The user can choose (via Radio Button) if they want to practice addition, subtraction, multiplication or division (rdoAdd, rdoSub, rdoMult, rdoDiv).  Two buttons will exist (btnGenerate), one to generate a question (using two randomly generated numbers) these can be displayed in a Label reflecting the entire equation ( 1 + 10 ), and one to submit the answer (btnSubmit) that was typed into a TextBox (txtAnswer).  Calculate the correct answer and compare it to the users input.  Two ListBox controls should remember all questions and answers, one for correct answers, one for incorrect answers (lstCorrect, lstIncorrect).  Using a count of the number of correct and incorrect create two labels to display the current count of correct and incorrect answers (lblCorrect, lblIncorrect).  [4]


## Hand-In
Please download the finished code from Github and upload it to Blackboard before the due date.

 
## Expectations
This assignment should be completed individually, please ask your instructor for clarification where needed.  Receiving help or feedback from classmates is okay, but do not share or copy any materials that will be added to the assignment submission.  Help your classmates learn to program but, do not share code/files.  Any code that you find on the internet can be referenced in comments, where necessary.
