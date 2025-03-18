using System;

string newString = "This is a string of characters.";
char newChar = 'a';
bool newBool = false;
int newInt = -2147483648;
uint newUInt = 4294967295;
byte newByte = 255;
sbyte newSbyte = -128;
short newShort = - 32768;
ushort newUShort = 65535;
long newLong = -9223372036854775808;
ulong newULong = 18446744073709551615;
float newFloat = 1.0000001f;
double newDouble = 1.000000000000001;
decimal newDecimal = 1.0000000000000000000000000001m;

Console.WriteLine($"{newByte} and {newDecimal} and {newChar}");

newInt = 100;

Console.WriteLine(newInt);