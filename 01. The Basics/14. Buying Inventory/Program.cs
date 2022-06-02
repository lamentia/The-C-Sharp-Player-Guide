/* Choice Number 1 
Console.WriteLine("The following items are available:");
Console.WriteLine($"1 - {"Rope"}");
Console.WriteLine($"2 - {"Torches"}");
Console.WriteLine($"3 - {"Climbing Equipment"}");
Console.WriteLine($"4 - {"Clean Water"}");
Console.WriteLine($"5 - {"Machete"}");
Console.WriteLine($"6 - {"Canoe"}");
Console.WriteLine($"7 - {"Food Supplies"}");

Console.Write("What number do you want to see the price of?");
int choice = Convert.ToInt32(Console.ReadLine());

switch(choice)
{
    case 1:
        Console.WriteLine("Rope cost 10 gold.");
        break;
    case 2:
        Console.WriteLine("Torches cost 15 gold.");
        break;
    case 3:
        Console.WriteLine("Climbing Equipment cost 25 gold.");
        break;
    case 4:
        Console.WriteLine("CLean Water cost 1 gold.");
        break;
    case 5:
        Console.WriteLine("Machete cost 20 gold.");
        break;
    case 6:
        Console.WriteLine("Canoe cost 200 gold.");
        break;
    case 7:
        Console.WriteLine("Food Supplies cost 1 gold.");
        break;
}
Console.ReadKey();
*/

// Choice number 2

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