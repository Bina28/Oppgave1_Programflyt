namespace Oppgave1_Programflyt;

public class UserInteraction
{

    public string UserNameInput()
    {
        string? input;
        do
        {
            Console.WriteLine("Please enter your name bellow");
            input = Console.ReadLine();
        } while (string.IsNullOrEmpty(input));
        return input;
    }

    public bool ExitInput()
    {
        Console.WriteLine("Press enter to go back to the main menu or any key to exit");

        var key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Returning to main menu...");
            return true;
        }
        else
        {
            Console.WriteLine("Goodbye!");
            return false;

        }
    }

    public int MoodInput() {
        string? mood;
        int result=0;
        do
        {
            Console.WriteLine("Choose you mood (enter a  number)");
            mood = Console.ReadLine();

        } while (string.IsNullOrEmpty(mood) || !int.TryParse(mood, out result));
        return result;
    }

}
