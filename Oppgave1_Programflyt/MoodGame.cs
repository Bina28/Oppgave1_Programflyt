using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Oppgave1_Programflyt;

public class MoodGame
{

   public void Run()
    {
while(true){
DisplayMessageBasedOnTime(dato);
    DispalyMessageBasedOnMood();
    Console.WriteLine("Enter the key to go the main menu");
Console.ReadKey();
}
}

public void DisplayMessageBasedOnTime(DateTime dato)
{
    if (dato.Hour > 6 && dato < 9)
    {
        Console.WriteLine(Good morning! Time to fuel up with breakfast);
else if (dato > 10 && dato < 17)
            {
                Console.WriteLine("Work mode activated!);
else if (dato > 18 && dato < 22)
                {
                    Console.WriteLine("Relax time");
else if {
                        Console.WriteLine("Shhh… it's late. Go catch some Zzz ");
                    }
                }
            

     public void  DispalyMessageBasedOnMood()
            {

                Console.WriteLine("Choose you mood");
                string mood = Console.ReadLine();
                switch (mood):
case "Tired":
    Console.WriteLine("Take a little break… maybe a power nap");
    cased "Good":
Console.WriteLine("Awesome! Keep riding that good vibe");
case "Ok":
    Console.WriteLine("Not bad… keep going, the day’s still young!");
default:
    Console.WriteLine("Stay positive and keep smiling");
}
}
