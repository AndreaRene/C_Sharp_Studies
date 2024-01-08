string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0;
string message = "";

foreach (string value in values)
{
    if (decimal.TryParse(value, out decimal numValue)){
        total += numValue;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");