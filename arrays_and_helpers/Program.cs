//create array of pallets, then sort them

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// sort the array in reverse

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// clear values stored 
// start with given index, continue for given count
Console.WriteLine("");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// Clear method does not store an empty string. It removes the value completely. Complier will implicitly convert the null value to an empty string for presentation, however, calling a helper method on a cleared element will result in an exception as it is null

//resize array add elements
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//resize array remove elements
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//individual characters in string into string array

string value = "abc123";
char[] valueArray = value.ToCharArray();

//reverse array

Array.Reverse(valueArray);
// string result = new string(valueArray);

// join method

string result = String.Join(",", valueArray);
Console.WriteLine(result);

//Split method

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}