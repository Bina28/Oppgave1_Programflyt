namespace Oppgave1_Programflyt;

public class UserInteraction
{

    public static string UserNameInput()
    {
        string? input;
        do
        {
            Console.WriteLine("Please enter your name bellow \n");
            input = Console.ReadLine();
        } while (string.IsNullOrEmpty(input));
        return input;
    }

    public static void WelcomeMessage(string name)
    {
        Console.WriteLine($"Hello {name}. Welcome to the MOOD APP!");
    }
}
