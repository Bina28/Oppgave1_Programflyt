### PSEUDO CODE

1. ASK user: "Please enter your name:"
2. READ userName

3. WHILE userName is empty:
       Repeat step 1       

4. DISPLAY "Welcome, " + userName

5. GET currentDateTime
6. EXTRACT currentHour from currentDateTime

7. IF currentHour >= 6 AND currentHour <= 9:
        PRINT Message
   ELSE IF currentHour >= 10 AND currentHour <= 17:
        PRINT Message
   ELSE IF currentHour >= 18 AND currentHour <= 22:
        PRINT Message
   ELSE:
        PRINT Message

8. DISPLAY:
       "Choose your mood:
        1. Good
        2. Okay
        3. Tired"

9. READ moodInput

10. IF moodInput isn't a number:
        Repeat step 8

11. SWITCH moodInput:
        CASE 1:
            PRINT Message
        BREAK

        CASE 2:
            PRINT Message
        BREAK

        CASE 3:
            PRINT Message
        BREAK

        DEFAULT:
            PRINT Message

12. ASK user to eathier continue or exit the game
13. READ userInput

14. IF userChoice continue :
        GO TO step 5
    ELSE:
        PRINT "Goodbye, " + userName + "!"

END PROGRAM
