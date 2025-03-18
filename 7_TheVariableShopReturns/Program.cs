// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string stringVar = "This is a string";
char charVar = 'C';
bool boolVar = true;
int intVar = -1020304050;
uint uintVar = 100200300;
short shortVar = -534;
ushort ushortVar = 412;
long longVar = -1000200030004000500;
ulong ulongVar = 10002000300040005000;
byte byteVar = 17;
sbyte sbyteVar = 12;
float floatVar = 1.234f;
double doubleVar = 1.23456789;
decimal decimalVar = 1.23456789101112m;

Console.Write($"Take a look at all of the variables on offer!\nString : {stringVar}\tChar : {charVar}\tBool : {boolVar}\n" +
    $"Int : {intVar}\tLong : {longVar}\tDouble : {doubleVar}\nJust to name a few!\n");

stringVar = "New string!";
charVar = 'N';
boolVar = false;
intVar = 2000202020;
longVar = 123455432112345;
doubleVar = 9.87654321;

Console.Write($"Take a look at the variables on offer, now with updated values!\nString : {stringVar}\tChar : {charVar}\tBool : {boolVar}\n" +
    $"Int : {intVar}\tLong : {longVar}\tDouble : {doubleVar}\n");