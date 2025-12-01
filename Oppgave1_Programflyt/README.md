
### START PROGRAM

1. ASK user: "Please enter your name:"
2. READ userName

3. WHILE userName is empty:
       ASK user again: "Name cannot be empty. Please enter your name:"
       READ userName

4. DISPLAY "Welcome, " + userName

5. GET currentDateTime
6. EXTRACT currentHour from currentDateTime

7. IF currentHour >= 6 AND currentHour <= 9:
        PRINT "Good morning! Time to fuel up with breakfast"
   ELSE IF currentHour >= 10 AND currentHour <= 17:
        PRINT "Work mode activated!"
   ELSE IF currentHour >= 18 AND currentHour <= 22:
        PRINT "Relax time"
   ELSE:
        PRINT "Shhh… it's late. Go catch some Zzz"

8. DISPLAY:
       "Choose your mood:
        1. Good
        2. Okay
        3. Tired"

9. READ moodInput

10. IF moodInput == 1:
        PRINT "Awesome! Keep riding that good vibe"
    ELSE IF moodInput == 2:
        PRINT "Not bad… keep going, the day’s still young!"
    ELSE IF moodInput == 3:
        PRINT "Take a little break… maybe a power nap"
    ELSE:
        PRINT "Stay positive and keep smiling"
    

12. ASK user: "Do you want to quit or start again? (type 'quit' or 'again')"
13. READ userChoice

14. IF userChoice == "again":
        GO TO step 1
    ELSE:
        PRINT "Goodbye, " + userName + "! See you next time!"

END PROGRAM

