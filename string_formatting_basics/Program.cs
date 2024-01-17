//composite formatting

/*
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
Console.WriteLine("{0} {0} {0}", first, second);
*/

//string interpolation

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

