// See https://aka.ms/new-console-template for more information
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); //an item
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); //descriptor of said iten
string c = "of Doom"; //hardcoded
string d = "3000"; //hardcoded
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
