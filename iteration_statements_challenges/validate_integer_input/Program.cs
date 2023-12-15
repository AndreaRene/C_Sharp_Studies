
do {
    Console.WriteLine("Please provide a value between 5 and 10:");
    string input = Console.ReadLine() ?? "";

    if (int.TryParse(input, out int numValue) && numValue >= 5 && numValue <= 10) {
        Console.WriteLine($"Input {numValue} accepted.");
        break;
    } else {
        Console.WriteLine($"Invalid input.");
    }

} while (true);