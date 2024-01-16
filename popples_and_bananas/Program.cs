
using System.Reflection.Metadata;
/*
We're going to start off simple.
Here we have a banana, a potato, and an apple.
The variable names are like signs on a countertop. 
The values are the physical objects.
*/

/*
Image 1:
banana with a card that says "banana"
potato with a card that says "potato"
apple with a card that says "otherFruit"
*/

/*
This is 
*/
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
Console.WriteLine(ShowMeBlue(banana));
Console.WriteLine(ShowMeBlue(potato));
Console.WriteLine(ShowMeBlue(otherFruit));
Console.WriteLine("");

Console.WriteLine("-------");
Console.WriteLine("");
Console.WriteLine("Local Scope(inside during ShowMeStripes):");
Console.WriteLine(ShowMeStripes(otherFruit));
Console.WriteLine(ShowMeStripes(ShowMeBlue(banana)));
Console.WriteLine(ShowMeBlue(ShowMeStripes(potato)));



Console.WriteLine("------");
Console.WriteLine("");
Console.WriteLine("Global Scope(outside after ShowMeBlue and ShowMeStripes)");
Console.WriteLine($"The banana is: {banana}.");
Console.WriteLine($"The potato is: {potato}.");
Console.WriteLine($"The other fruit is: {otherFruit}.");
