// See https://aka.ms/new-console-template for more information
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // Waits for command 
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();/* Waits for command*/
string c = " of Doom 3000";/*adds adjective*/
//string d = "3000"; adds adjective// 
Console.WriteLine("The " + b + " " + a + /*" of " +*/ c + " " /*+ d */+ "!");
Console.ReadKey();