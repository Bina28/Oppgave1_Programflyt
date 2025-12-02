namespace Oppgave1_Programflyt;

public class MoodGame
{
 
    private readonly UserInteraction _userInteraction;

    public MoodGame(UserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }
    public void Run()
    {
        string name = _userInteraction.UserNameInput();
        PrintMessage($"Hello {name}. Welcome to the MOOD APP!");
        while (true)
        {

            DisplayMessageBasedOnTime(DateTime.Now);
            DisplayMoodOptions();
            int resultFromUserInput = _userInteraction.MoodInput();
            DispalyMessageBasedOnMood(resultFromUserInput);
            if (!_userInteraction.IsUserContinueGame()) return;
        }
    }

    public static void DisplayMessageBasedOnTime(DateTime dato)
    {
        int hour = dato.Hour;
      

        if (hour >= 6 && hour <= 9)
        {
            PrintMessage(
                $"Rise and shine! It's {dato.DayOfWeek} {dato.Hour:D2}:{dato.Minute:D2}\n" +
                "Time to fuel up with a yummy breakfast! \n" +
                "Remember: coffee first, adulting second"
            );
        }
        else if (hour >= 10 && hour <= 17)
        {
            PrintMessage(
                $"It's {dato.DayOfWeek} {dato.Hour:D2}:{dato.Minute:D2}\n" +
                "Work mode activated!\n" +
                "Focus like a ninja, but don’t forget to stretch!\n" +
                "You got this!"
            );
        }
        else if (hour >= 18 && hour <= 22)
        {
            PrintMessage(
                $"It's {dato.DayOfWeek} {dato.Hour:D2}:{dato.Minute:D2}. Time to relax!\n" +
                "Chill vibes only, maybe watch your favorite show or have a snack\n" +
                "Time to recharge for tomorrow!"
            );
        }
        else
        {
            PrintMessage(
                $"It's {dato.DayOfWeek} {dato.Hour:D2}:{dato.Minute:D2}.Shhh… it's late.\n" +
                "Catch some Zzz and dream about amazing adventures!\n" +
                "No night owls allowed!"
            );
        }

    }

    public static void DisplayMoodOptions()
    {
        Console.Clear();
        Console.WriteLine(@"What mood will describe you:
    1 - Good
    2 - Okey
    3 - Tired
");

    }

    public static void DispalyMessageBasedOnMood(int moodNumber)
    {

        switch (moodNumber)
        {
            case 1:
                PrintMessage("Not bad... keep going, the day’s still young!");
                break;
            case 2:
                PrintMessage("Awesome! Keep riding that good vibe");
                break;
            case 3:
                PrintMessage("Take a little break... maybe a power nap");
                break;
            default:
                PrintMessage("Stay positive and keep smiling");
                break;
        }
    }

    public static void PrintMessage(string s)
    {
        Console.Clear();
        Console.WriteLine(s);
        Console.WriteLine("\nPress enter to continue");
        Console.ReadKey();

    }

}
