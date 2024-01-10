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
string[] palletsTwo = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");
// starting with declared index and continuing for decelared amount of values
Array.Clear(palletsTwo, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {palletsTwo.Length}");
foreach (var palletTwo in palletsTwo)
{
    Console.WriteLine($"-- {palletTwo}");
}
