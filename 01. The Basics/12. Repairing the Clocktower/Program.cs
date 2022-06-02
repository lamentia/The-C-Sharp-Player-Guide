// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number, milord : ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number % 2 == 0)
    Console.WriteLine("The pendulum swings to right! Tick!");
else
    Console.WriteLine("The pendulum swings to left! Tock!");
Console.ReadKey();