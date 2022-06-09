Console.Title = "Guessing Game";
// Getting pilot name
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Please enter your name: ");
string pilotName = Console.ReadLine();
Console.WriteLine($"{pilotName}, you are a pilot!");
Console.Beep();

//Getting a guessing number by pilot
int pilotNumber;
do
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write($"{pilotName}, please enter a number between 0 and 100: ");
    string pilotResponse = Console.ReadLine(); 
    pilotNumber = Convert.ToInt32(pilotResponse);
}
while (pilotNumber < 0 || pilotNumber > 100);
Console.Clear();


//Getting hunter name
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Please enter your name: ");
string hunterName = Console.ReadLine();
Console.WriteLine($"{hunterName}, you are a hunter!");
Console.Beep();

//Guessing the number by hunter
while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write($"{hunterName}, please guess the number in order to eat the hunter: ");
    string hunterResponse = Console.ReadLine();
    if (hunterResponse == "quit" || hunterResponse == "exit")
        break;

    int hunterNumber = Convert.ToInt32(hunterResponse);

    if (hunterNumber > pilotNumber)
    {
        Console.WriteLine($"{hunterName}, {hunterNumber} is too high!");
        Console.Write("What is your next guess? ");
        continue;
    }
    else if (hunterNumber < pilotNumber)
    {
        Console.WriteLine($"{hunterName}, {hunterNumber} is too low!");
        Console.Write("What is your next guess? ");
        continue;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Beep();
        Console.WriteLine($"{hunterName}, you guessed it! You ate the hunter!");
        break;
    }
}
Console.ReadKey();