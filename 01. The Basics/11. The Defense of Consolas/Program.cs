Console.Title = "Defense of Shu Kingdom";

Console.WriteLine("Press any key when you're ready to defend.");
Console.ReadKey(true);
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("The war is upon us, milord! Please gather your troops and command it to avoid damage! ");

Console.Write($"Our scouts telling us they will hit Target Row! ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"And also Target Column! ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nZhuge Liang is saying we should choose where to move our army!");
string targetDeployment = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})\n");
Console.WriteLine("What will be your order, milord?");

string deploymentWin = Console.ReadLine();
Console.Beep(440, 1000);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"\n{deploymentWin} We saved our army!");
Console.ReadKey();