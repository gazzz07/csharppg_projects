// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the triangle's base size:");
string triangleBaseText = Console.ReadLine();
double triangleBase = Convert.ToDouble(triangleBaseText);

Console.WriteLine("Enter the triangle's height:");
string triangleHeightText = Console.ReadLine();
double triangleHeight = Convert.ToDouble(triangleHeightText);

Console.WriteLine($"The area of this triangle is " + (triangleBase * triangleHeight) / 2);