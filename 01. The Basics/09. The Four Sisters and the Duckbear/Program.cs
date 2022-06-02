// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's the number of chocolate eggs gathered?");
string gatheredEggs = Console.ReadLine();
int splitEggs = Convert.ToInt32(gatheredEggs);
int sisterEggs = splitEggs / 4;
int remainder = splitEggs % 4;
Console.WriteLine(sisterEggs + " goes to sisters");
Console.WriteLine(remainder + " goes to Duckbear");
Console.ReadKey();
