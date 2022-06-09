//Choice Number 1 

Console.Write("What's your name, young adventurer?");
var name = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"1 - {"Rope"}");
Console.WriteLine($"2 - {"Torches"}");
Console.WriteLine($"3 - {"Climbing Equipment"}");
Console.WriteLine($"4 - {"Clean Water"}");
Console.WriteLine($"5 - {"Machete"}");
Console.WriteLine($"6 - {"Canoe"}");
Console.WriteLine($"7 - {"Food Supplies"}");

if (name == "Link")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Ahhh, {name} it's you! The following items are available for half of price for you!:");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{name}! The following items are available:");
}

Console.Write("What number do you want to see the price of?");
int choice = Convert.ToInt32(Console.ReadLine());


string item = choice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1
};
if (name == "Link")
    price /= 2;

switch (choice)
{
    case 1:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 2:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 3:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 4:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 5:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 6:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
    case 7:
        Console.WriteLine($"{item} cost {price} gold.");
        break;
}
Console.ReadKey();


/* Choice number 2

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.Write("What number do you want to see the price of?");
int itemNumber = Convert.ToInt32(Console.ReadLine());
string item = itemNumber switch

{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1
};

Console.WriteLine($"{item} cost {price} gold.");
Console.ReadKey();
*/