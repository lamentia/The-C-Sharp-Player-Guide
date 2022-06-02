
// This solution is overcomplicated!


//Introduction

Console.WriteLine("What's your name, you highness?");
string kingName = Console.ReadLine();

//Checking your estates points

Console.WriteLine("King " + kingName + ", how many estates you have?");
string firstEquality = Console.ReadLine();
int totalEstates = Convert.ToInt32(firstEquality);
totalEstates*=1;

//Checking your duchy points

Console.WriteLine("King " + kingName + ", how many duchies you have?");
string secondEquality = Console.ReadLine();
int totalDuchies = Convert.ToInt32(secondEquality);
totalDuchies*=3;

//Checking your provinces points

Console.WriteLine("King " + kingName + ", how many provinces you have?");
string thirdEquality = Console.ReadLine();
int totalProvinces = Convert.ToInt32(thirdEquality);
totalProvinces*=6;

//Calculating your total

Console.WriteLine("King " + kingName + ", your total points is " + (totalEstates + totalDuchies + totalProvinces) + "!");
Console.ReadKey();

// This solution is overcomplicated!