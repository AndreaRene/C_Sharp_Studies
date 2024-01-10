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
// starting with given index and continuing for given count of elements
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// Clear method does not store an empty string. It removes the value completely. Complier will implicitly convert the null value to an empty string for presentation, however, calling a helper method on a cleared element will result in an exception as it is null
