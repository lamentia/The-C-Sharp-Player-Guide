// See https://aka.ms/new-console-template for more information
Console.WriteLine("What's the width size?");
string widthText = Console.ReadLine();
float width = Convert.ToSingle(widthText);

Console.WriteLine("What's the height size");
string heightText = Console.ReadLine();
float height = Convert.ToSingle(heightText);

float areaSize = width * height / 2;

Console.WriteLine("The area is " + areaSize);
Console.ReadKey();