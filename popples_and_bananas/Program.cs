
using System.Reflection.Metadata;

string banana = "banana";
string potato = "potato";
string otherFruit = "orange";

Console.WriteLine("Global Scope(outside before ShowMeBlue and ShowMeStripes):");
Console.WriteLine($"The banana is: {banana}.");
Console.WriteLine($"The potato is: {potato}.");
Console.WriteLine($"The other fruit is: {otherFruit}.");
Console.WriteLine("");

string ShowMeBlue(string item){
    potato = "apple";
    return "blue " + item;
}

string ShowMeStripes(string item){
    return "striped " + item;
}

Console.WriteLine("-------");
Console.WriteLine("");
Console.WriteLine("Local Scope(inside during ShowMeBlue):");
Console.WriteLine(ShowMeBlue(potato));
Console.WriteLine(ShowMeBlue(banana));
Console.WriteLine(ShowMeBlue(potato));
Console.WriteLine(ShowMeBlue(otherFruit));
Console.WriteLine("");

Console.WriteLine("-------");
Console.WriteLine("");
Console.WriteLine("Local Scope(inside during ShowMeStripes):");
Console.WriteLine(ShowMeStripes(potato));
Console.WriteLine(ShowMeStripes(ShowMeBlue(otherFruit)));
Console.WriteLine(ShowMeBlue(ShowMeStripes(banana)));



Console.WriteLine("------");
Console.WriteLine("");
Console.WriteLine("Global Scope(outside after ShowMeBlue and ShowMeStripes)");
Console.WriteLine($"The banana is: {banana}.");
Console.WriteLine($"The potato is: {potato}.");
Console.WriteLine($"The other fruit is: {otherFruit}.");
